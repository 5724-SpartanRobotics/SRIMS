using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SRIMS
{
	public partial class SearchControl : UserControl
	{
		List<Item> resultsList = new List<Item>();

		public SearchControl()
		{
			InitializeComponent();

			results.Columns[0].Width = 23;
			results.Columns[1].Width = 53;
			results.Columns[2].Width = 70;
			results.Columns[3].Width = 112;
			results.Columns[4].Width = 171;
			results.Columns[5].Width = 51;
		}

		private void Search_Load(object sender, EventArgs e)
		{

		}

		private List<Item> Search()
		{
			int tp = SearchTypeDropdown.SelectedIndex;
			string sa = SearchBox.Text;
			if (tp >= 0)
			{
				if (sa == "")
				{
					return new List<Item>();
				}
				sa = sa.ToLower();
				if (tp == 0)
				{
					foreach (Item x in ((SRIMSForm)ParentForm).Inv)
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
					foreach (Item x in ((SRIMSForm)ParentForm).Inv)
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

					foreach (Item x in ((SRIMSForm)ParentForm).Inv)
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
			SearchTypeDropdown.SelectedIndex = 0;
			//results.Items.Clear();
		}

		private void SearchFunctionThing()
		{
			resultsList.Clear();
			results.Items.Clear();
			List<Item> items = Search();

			foreach (Item item in items)
			{
				results.Items.Add(item.Id.ToString()).SubItems.AddRange(new string[]
					{ item.Loc, item.Cat, item.Name, item.Desc, item.Qt.ToString() });
			}
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			results.Items.Clear();
		}

		private void EditItem(Item item)
		{
			EditForm ed = new EditForm(((SRIMSForm)ParentForm), item, this);
			ed.FormClosed += (sender, args) => SearchFunctionThing();
			ed.Show();
		}

		private void Modify_Click(object sender, EventArgs e)
		{
			if (results.SelectedIndices.Count == 1 && results.SelectedIndices[0] != -1)
			{
				EditItem(resultsList[results.SelectedIndices[0]]);
			}
		}


		// CHECK OUT!!!!!!!!!!!!!!!

		private void button4_Click(object sender, EventArgs e)
		{
			if (results.SelectedIndices.Count == 1 && results.SelectedIndices[0] != -1)
			{
				CheckOut c = new CheckOut(resultsList[results.SelectedIndices[0]]);
				c.Show();
			}

		}

		private void SearchBox_TextChanged(object sender, EventArgs e)
		{
			SearchFunctionThing();
		}
	}
}
