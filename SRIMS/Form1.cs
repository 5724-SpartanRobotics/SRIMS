using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace SRIMS
{
	public partial class Form1 : Form
	{
		string dbloc = Properties.Settings.Default.dbloc;

		public Form1()
		{
			InitializeComponent();
		}

		//Real Code Begins Here:

		Item x = new Item();

		public List<Item> Inv = new List<Item>();

		private void Init()
		{
			dbloc = Properties.Settings.Default.dbloc;
			/*if (dbloc == null || dbloc == "")
			{
				Settings settings = new Settings();
				settings.Show();
			}*/
			try
			{
				// using statements automatically close disposible objects
				using (StreamReader sr = new StreamReader(dbloc))
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

					foreach (Item x in Inv)
					{
						// Console.WriteLine(x);
					}

				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
				Settings settings = new Settings();
				settings.Show();
				settings.FormClosed += Settings_FormClosed;

			}

			//StreamReader sr = new StreamReader(dbloc);

		}

		private void Settings_FormClosed(object sender, FormClosedEventArgs e)
		{
			Init();
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

		}

		// ViewDB
		private void button3_Click(object sender, EventArgs e)
		{
			DehighlightSelectors();
			ViewDatabaseSelected.Visible = true;
			viewDB1.Visible = true;

			viewDB1.ext();

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

			addItem1.reload(true);

			addItem1.setDB(Inv);



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

		private void Form1_FormClosing(object sender, FormClosingEventArgs a)
		{
			try
			{
				using (StreamWriter writer = new StreamWriter(dbloc))
				{
					writer.WriteLine("Id" + Inv.Count + ",Location,Category,Item,Item Description,Quantity");
					foreach (Item item in Inv)
						writer.WriteLine(CSVHelper.SerializeItem(item));
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("There was an error right here in the Form1_FormClosing function: " +
					e.Message + "\n" + e.StackTrace);
			}
		}
	}
}
