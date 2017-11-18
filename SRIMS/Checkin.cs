using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

		private Item finditem(int id)
		{
			foreach (Item y in ((SRIMSForm)ParentForm).Inv)
			{
				//Console.WriteLine(y);
				//Console.WriteLine(y.Id + "vs (srch) " + id);
				if (y.Id == id)
					return y;
				else
				{
					continue;
				}

			}
			Item o = new Item
			{
				Name = "Unknown Item"
			};
			return o;
		}

		private void population()
		{
			foreach (CheckedOutItem x in checkout_list)
			{
				listBox1.Items.Add(x);
			}
			listBox1.Refresh();
		}

		private void depop()
		{
			listBox1.Items.Clear();
		}

		public void settingsReader()
		{
			//Clear List<>
			checkout_list.Clear();
			depop();
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
						Item XD = finditem(id);
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
			population();
		}

		public void modified()
		{
			string newset = "";
			Properties.Settings.Default.checkout_list = "";
			foreach (CheckedOutItem x in checkout_list)
			{
				//Console.WriteLine(LogIt(x));
				newset += LogIt(x);
			}
			//Console.WriteLine(newset);
			Properties.Settings.Default.checkout_list = newset;
			//Console.WriteLine(Properties.Settings.Default.checkout_list);
			Properties.Settings.Default.Save();

		}

		private string LogIt(CheckedOutItem lol)
		{

			return lol.Name + "," + lol.item.Id + "," + lol.qt + ";";

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (listBox1.SelectedIndex != -1)
			{
				checkout_list.Remove(checkout_list[listBox1.SelectedIndex]);
			}
			depop();
			population();
		}
	}
}
