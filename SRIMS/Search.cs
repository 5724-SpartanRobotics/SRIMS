using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SRIMS
{
	public partial class Search : UserControl
	{
		List<Item> resultsList = new List<Item>();

		public Search()
		{
			InitializeComponent();
		}

		private void Search_Load(object sender, EventArgs e)
		{

		}

		private List<Item> search()
		{
			int tp = comboBox1.SelectedIndex;
			string sa = textBox1.Text;
			if (tp >= 0)
			{
				if (sa == "" || sa == "Search Argument")
				{
					return new List<Item>();
				}
				sa = sa.ToLower();
				if (tp == 0)
				{
					foreach (Item x in ((Form1)ParentForm).Inv)
					{
						// Console.WriteLine("Test: "+ sa + " vs " + x.getName().ToLower());
						if (x.Name.ToLower().Contains(sa))
						{
							//Console.WriteLine("bazzinga!");
							resultsList.Add(x);
						}
					}
				}

				if (tp == 1)
				{
					//Search by Loc
					foreach (Item x in ((Form1)ParentForm).Inv)
					{
						// Console.WriteLine("Test: "+ sa + " vs " + x.getName().ToLower());
						if (x.Loc.ToLower().Contains(sa))
						{
							//Console.WriteLine("bazzinga!");
							resultsList.Add(x);
						}
					}
				}

				if (tp == 2)
				{
					//Search by Cat

					//>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Add Dropdown For Category <<<<<<<<<<<<<<<<<<<<<<<<<<<<\\

					foreach (Item x in ((Form1)ParentForm).Inv)
					{
						// Console.WriteLine("Test: "+ sa + " vs " + x.getName().ToLower());
						if (x.Cat.ToLower().Contains(sa))
						{
							//Console.WriteLine("bazzinga!");
							resultsList.Add(x);
						}
					}
				}

				return resultsList;
			}

			return new List<Item>();
		}

		public void Reset()
		{
			try { resultsList.Clear(); } catch { }
			comboBox1.Text = "Type";
			textBox1.Text = "Search Argument";
			//results.Items.Clear();
		}

		public void but1click()
		{
			foreach (Item x in search())
				results.Items.Add(x);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//reset();
			results.Items.Clear();
			resultsList.Clear();
			but1click();
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			results.Items.Clear();
		}

		private void EditItem(Item item)
		{
			edit ed = new edit(((Form1)ParentForm), item, this);
			ed.FormClosed += button1_Click;
			ed.Show();
		}

		private void Modify_Click(object sender, EventArgs e)
		{
			if (results.SelectedIndex != -1)
			{
				EditItem(resultsList[results.SelectedIndex]);
			}
		}


        // CHECK OUT!!!!!!!!!!!!!!!

        private void button4_Click(object sender, EventArgs e)
        {
            if (results.SelectedIndex != -1)
            {
                CheckOut c = new CheckOut(resultsList[results.SelectedIndex]);
                c.Show();
            }
            
        }
    }
}
