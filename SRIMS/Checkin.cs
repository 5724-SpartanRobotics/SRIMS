using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SRIMS
{
	public partial class Checkin : UserControl
	{

		private List<Item> inv = new List<Item>();
		private List<CheckedOutItem> checkout_list = new List<CheckedOutItem>();

		public Checkin()
		{
			InitializeComponent();
		}

		private void Checkin_Load(object sender, EventArgs e)
		{
			settingsReader();
		}

		private Item Finditem(int id)
		{
			foreach (Item y in SRIMSForm.Instance.Inv.Items)
			{
				if (y.Id == id)
					return y;
				else
					continue;
			}
			Item o = new Item(-1, "", Category.NONE, "Unknown Item", "unknown", 0);
			return o;
		}

		private void Population()
		{
			foreach (CheckedOutItem x in checkout_list)
				listBox1.Items.Add(x);
			listBox1.Refresh();
		}

		private void Depop()
		{
			listBox1.Items.Clear();
		}

		public void settingsReader()
		{
			//Clear List<>
			checkout_list.Clear();
			Depop();
			//Read Settings for CheckOutItems
			string checkout_list_string = Properties.Settings.Default.checkout_list;

			if (checkout_list_string != "")
			{

				string[] individual = checkout_list_string.Split(';').Where(s => s.Length > 0).ToArray();
				foreach (string lol in individual)
				{
					try
					{
						string[] pieces = lol.Split(',');
						string nom = pieces[0];
						int id = Int32.Parse(pieces[1]);
						Item XD = Finditem(id);
						int qt = Int32.Parse(pieces[2]);
						CheckedOutItem wtf = new CheckedOutItem(nom, XD, qt);
						// Console.WriteLine(nom + " {" + XD + " : [" + pieces[1] + "] " + qt);
						checkout_list.Add(wtf);
					}
					catch (Exception ex)
					{
						Console.WriteLine("There Was An Error When Parsing Settings For CheckOutItems"); Console.WriteLine(ex);
					}
				}
			}
			// Populate ListBox
			Population();
		}

		public void modified()
		{
			string newset = "";
			Properties.Settings.Default.checkout_list = "";
			foreach (CheckedOutItem x in checkout_list)
				newset += LogIt(x);

			Properties.Settings.Default.checkout_list = newset;
			Properties.Settings.Default.Save();
		}

		private string LogIt(CheckedOutItem lol)
		{
			return lol.Name + "," + lol.Item.Id + "," + lol.Qt + ";";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (listBox1.SelectedIndex != -1)
				checkout_list.Remove(checkout_list[listBox1.SelectedIndex]);

			Depop();
			Population();
		}
	}
}
