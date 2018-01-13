using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Json;
using SRIMS.Properties;

//TODO comment everything
namespace SRIMS
{
	public partial class SRIMSForm : Form
	{
		public string DBLoc { get { return Settings.Default.dbloc; } private set { Settings.Default.dbloc = value; } }
		public static SRIMSForm Instance { get; private set; } = null;

		public SRIMSForm()
		{
			if (Instance != null)
				throw new ApplicationException("Can't have more than one instance of SRIMSForm in a single application!");
			Instance = this;
			Init();
			InitializeComponent();
		}

		//Real Code Begins Here:

		public Inventory Inv { get; private set; } = new Inventory();
		public CheckoutManager CheckoutManager { get; private set; } = new CheckoutManager();

		public void Init()
		{
			ClearInventory();
			//Console.WriteLine("The CheckOut Line as of Open: " + Properties.Settings.Default.checkout_list);

			bool flag = false;
			while (!flag)
			{
				string chout = Settings.Default.CheckoutList;

				try
				{
					LoadInventory();
					flag = true;
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex);
					using (SettingsForm settings = new SettingsForm())
						settings.ShowDialog();
				}
			}
		}

		private void SRIMSForm_Load(object sender, EventArgs e)
		{
			DehighlightSelectors();
		}

		private void DehighlightSelectors()
		{
			CheckInSelected.Visible = false;
			ViewDatabaseSelected.Visible = false;
			AddItemSelected.Visible = false;
			SearchSelected.Visible = false;
			CheckOutLogSelected.Visible = false;
			_PanelCategoriesSelected.Visible = false;

			checkin1.Visible = false;
			_ViewDB.Visible = false;
			addItem1.Visible = false;
			search1.Visible = false;
			checkoutLog1.Visible = false;
			_CategoryPage.Visible = false;
		}

		private void CheckOutLogPanel_Paint(object sender, PaintEventArgs e)
		{

		}

		// CheckIn
		private void _BtnCheckInPage_Click(object sender, EventArgs e)
		{
			DehighlightSelectors();
			CheckInSelected.Visible = true;
			checkin1.Visible = true;
			checkin1.Repopulate();

		}

		// ViewDB
		private void _BtnViewDBPage_Click(object sender, EventArgs e)
		{
			DehighlightSelectors();
			ViewDatabaseSelected.Visible = true;
			_ViewDB.Visible = true;

			_ViewDB.Ext();

		}

		// Search
		private void _BtnSearchPage_Click(object sender, EventArgs e)
		{
			DehighlightSelectors();
			SearchSelected.Visible = true;
			search1.Visible = true;

			search1.Reset();
		}

		// AddItem
		private void _BtnAddItemPage_Click(object sender, EventArgs e)
		{
			DehighlightSelectors();
			AddItemSelected.Visible = true;
			addItem1.Visible = true;

			addItem1.Reload();
		}

		// CheckOutLog
		private void _BtnCheckOutLog_Click(object sender, EventArgs e)
		{
			DehighlightSelectors();
			CheckOutLogSelected.Visible = true;
			checkoutLog1.Visible = true;

		}

		// Settings
		private void _BtnSettings_Click(object sender, EventArgs e)
		{
			SettingsForm settings = new SettingsForm();
			settings.Show();
		}

		private void _BtnCategories_Click(object sender, EventArgs e)
		{
			DehighlightSelectors();
			_PanelCategoriesSelected.Visible = true;
			_CategoryPage.Visible = true;

			_CategoryPage.Reload();
		}

		// Erases the inventory
		public void ClearInventory()
		{
			Inv?.Items?.Clear();
		}

		private void LoadInventory()
		{
			// Decided to switch to just using JSON to store the inventory
			try
			{
				using (Stream stream = File.OpenRead(DBLoc))
				{
					DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Inventory));
					Inv = (Inventory)serializer.ReadObject(stream);
					Inv.CorrectItemErrors(); // No idea why I need this
				}
			}
			catch
			{
				// using statements automatically close IDisposible objects
				using (StreamReader sr = new StreamReader(DBLoc))
				{
					string head = sr.ReadLine();

					string headId = head.Split(',')[0];
					headId = headId.Remove(0, 2);
					int itemcount = int.Parse(headId);
					Inv = new Inventory();

					for (int i = 0; i < itemcount; i++)
					{
						string currentitem = sr.ReadLine();

						// Created this CSVHelper in case some idiot decides to put a
						// comma in a name or something and corrupt the inventory file.
						Item item = CSVHelper.DeserializeItem(currentitem);
						Inv.Items.Add(item.Id, item);
					}
				}
				int j = 0;
				string filename = Path.Combine(Path.GetDirectoryName(DBLoc), Path.GetFileNameWithoutExtension(DBLoc)
					+ ".old" + Path.GetExtension(DBLoc));

				while (File.Exists(filename))
					filename = Path.Combine(Path.GetDirectoryName(DBLoc), Path.GetFileNameWithoutExtension(DBLoc)
					+ ".old" + j++.ToString() + Path.GetExtension(DBLoc));

				File.Move(DBLoc, filename);
				DBLoc = Path.Combine(Path.GetDirectoryName(DBLoc), Path.GetFileNameWithoutExtension(DBLoc) + ".json");
				SaveInventory();
			}
		}

		public void SaveInventory()
		{
			try
			{
				string backupFile0 = Path.Combine(Path.GetDirectoryName(DBLoc), Path.GetFileName(DBLoc) + ".0.bak");
				string backupFile1 = Path.Combine(Path.GetDirectoryName(DBLoc), Path.GetFileName(DBLoc) + ".1.bak");
				string backupFile2 = Path.Combine(Path.GetDirectoryName(DBLoc), Path.GetFileName(DBLoc) + ".2.bak");
				if (File.Exists(backupFile2))
					File.Delete(backupFile2);
				if (File.Exists(backupFile1))
					File.Move(backupFile1, backupFile2);
				if (File.Exists(backupFile0))
					File.Move(backupFile0, backupFile1);
				if (File.Exists(DBLoc))
					File.Move(DBLoc, backupFile0);

				using (FileStream fs = File.Open(DBLoc, FileMode.Create))
				{
					DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Inventory));
					serializer.WriteObject(fs, Inv);
				}

				//checkin1.Modified();
			}
			catch (Exception e)
			{
				Console.WriteLine("There was an error right here in the Form1_FormClosing function: " +
					e.Message + "\n" + e.StackTrace);
			}
		}

		private void SRIMSForm_FormClosing(object sender, FormClosingEventArgs a)
		{
			SaveInventory();
		}
	}
}
