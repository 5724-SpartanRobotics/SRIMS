using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;


namespace SRIMS
{
	public partial class SRIMSForm : Form
	{
		string DBloc { get { return Properties.Settings.Default.dbloc; } }
		public static SRIMSForm Instance { get; private set; } = null;

		public SRIMSForm()
		{
			InitializeComponent();
			if (Instance != null)
				throw new ApplicationException("Can't have more than one instance of SRIMSForm in a single application!");
			Instance = this;
		}

		//Real Code Begins Here:

		Item x = new Item();

		public List<Item> Inv = new List<Item>();

		public List<Item> CheckOutInv = new List<Item>();

		public void Init()
		{
			ClearInventory();
			//Console.WriteLine("The CheckOut Line as of Open: " + Properties.Settings.Default.checkout_list);

			string chout = Properties.Settings.Default.checkout_list;
			// TODO use ShowDialog instead of Show for all forms and fix bug that happened when trying to open database while it was opened in excel

			try
			{
				// using statements automatically close disposible objects
				using (StreamReader sr = new StreamReader(DBloc))
				{
					string head = sr.ReadLine();

					string headId = head.Split(',')[0];
					headId = headId.Remove(0, 2);
					int itemcount = int.Parse(headId);

					for (int i = 0; i < itemcount; i++)
					{
						string currentitem = sr.ReadLine();

						// Created this CSVHelper in case some idiot decides to put a
						// comma in a name or something and corrupt the inventory file.
						Inv.Add(CSVHelper.DeserializeItem(currentitem));

					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
				using (Settings settings = new Settings())
					settings.ShowDialog();
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Init();
			DehighlightSelectors();
		}

		private void DehighlightSelectors()
		{
			CheckInSelected.Visible = false;
			ViewDatabaseSelected.Visible = false;
			AddItemSelected.Visible = false;
			SearchSelected.Visible = false;
			CheckOutLogSelected.Visible = false;

			checkin1.Visible = false;
			viewDB1.Visible = false;
			addItem1.Visible = false;
			search1.Visible = false;
			checkoutLog1.Visible = false;


		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		// CheckIn
		private void button2_Click(object sender, EventArgs e)
		{
			DehighlightSelectors();
			CheckInSelected.Visible = true;
			checkin1.Visible = true;
			checkin1.settingsReader();

		}

		// ViewDB
		private void button3_Click(object sender, EventArgs e)
		{
			DehighlightSelectors();
			ViewDatabaseSelected.Visible = true;
			viewDB1.Visible = true;

			viewDB1.Ext();

		}

		// Search
		private void button4_Click(object sender, EventArgs e)
		{
			DehighlightSelectors();
			SearchSelected.Visible = true;
			search1.Visible = true;

			search1.Reset();
		}

		// AddItem
		private void button5_Click(object sender, EventArgs e)
		{
			DehighlightSelectors();
			AddItemSelected.Visible = true;
			addItem1.Visible = true;

			addItem1.Reload(true);

			addItem1.SetDB(Inv);



		}

		// CheckOutLog
		private void button6_Click(object sender, EventArgs e)
		{
			DehighlightSelectors();
			CheckOutLogSelected.Visible = true;
			checkoutLog1.Visible = true;

		}

		// Settings
		private void button7_Click(object sender, EventArgs e)
		{
			Settings settings = new Settings();
			settings.Show();
		}

		// Erases the inventory
		public void ClearInventory()
		{
			Inv.Clear();
		}

		public void SaveInventory()
		{
			try
			{
				using (StreamWriter writer = new StreamWriter(DBloc))
				{
					writer.WriteLine("Id" + Inv.Count + ",Location,Category,Item,Item Description,Quantity");
					foreach (Item item in Inv)
						writer.WriteLine(CSVHelper.SerializeItem(item));
				}

				checkin1.modified();
			}
			catch (Exception e)
			{
				Console.WriteLine("There was an error right here in the Form1_FormClosing function: " +
					e.Message + "\n" + e.StackTrace);
			}
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs a)
		{
			SaveInventory();
		}


	}
}
