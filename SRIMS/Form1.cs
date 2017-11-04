using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

		item x = new item();

		public List<item> inv = new List<item>();

		private void init()
		{
			dbloc = Properties.Settings.Default.dbloc;
			if (dbloc == null || dbloc == "")
			{
				Settings settings = new Settings();
				settings.Show();
			}
			try
			{
				StreamReader sr = new StreamReader(dbloc);
				string head = sr.ReadLine();

				//Console.WriteLine(head);

				string headId = head.Split(',')[0];
				//Console.WriteLine(headId);
				headId = headId.Remove(0, 2);
				//Console.WriteLine(headId);
				int itemcount = Int32.Parse(headId);
				//Console.WriteLine(itemcount);

				for (int i = 0; i < itemcount; i++)
				{
					string currentitem = sr.ReadLine();

					string[] parts = currentitem.Split(',');

					//Console.WriteLine(parts[0] + "," + parts[1] + "," + parts[2] + "," + parts[3] + "," + parts[4] + "," + parts[5]);

					inv.Add(new item((Int32.Parse(parts[0])), parts[1], parts[2], parts[3], parts[4], Int32.Parse(parts[5])));

				}

				foreach (item x in inv)
				{
					// Console.WriteLine(x);
				}


				sr.Close();
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
			init();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			init();
			dehighlightSelectors();
		}

		private void dehighlightSelectors()
		{
			CheckOutSelected.Visible = false;
			CheckInSelected.Visible = false;
			ViewDatabaseSelected.Visible = false;
			AddItemSelected.Visible = false;
			SearchSelected.Visible = false;
			CheckOutLogSelected.Visible = false;

			checkout1.Visible = false;
			checkin1.Visible = false;
			viewDB1.Visible = false;
			addItem1.Visible = false;
			search1.Visible = false;
			checkoutLog1.Visible = false;


		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}
		// CheckOut
		private void button1_Click(object sender, EventArgs e)
		{
			dehighlightSelectors();
			CheckOutSelected.Visible = true;
			checkout1.Visible = true;

		}
		// CheckIn
		private void button2_Click(object sender, EventArgs e)
		{
			dehighlightSelectors();
			CheckInSelected.Visible = true;
			checkin1.Visible = true;

		}
		// ViewDB
		private void button3_Click(object sender, EventArgs e)
		{
			dehighlightSelectors();
			ViewDatabaseSelected.Visible = true;
			viewDB1.Visible = true;

			viewDB1.ext(inv);

		}
		// Search
		private void button4_Click(object sender, EventArgs e)
		{
			dehighlightSelectors();
			SearchSelected.Visible = true;
			search1.Visible = true;

			search1.popdb(inv);
			search1.reset();

		}
		// AddItem
		private void button5_Click(object sender, EventArgs e)
		{
			dehighlightSelectors();
			AddItemSelected.Visible = true;
			addItem1.Visible = true;

			addItem1.reload(true);

			addItem1.setDB(inv);



		}
		// CheckOutLog
		private void button6_Click(object sender, EventArgs e)
		{
			dehighlightSelectors();
			CheckOutLogSelected.Visible = true;
			checkoutLog1.Visible = true;

		}
		// Settings
		private void button7_Click(object sender, EventArgs e)
		{
			Settings settings = new Settings();
			settings.Show();
		}
	}
}
