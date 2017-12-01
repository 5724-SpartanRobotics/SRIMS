using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SRIMS
{
	public partial class SearchControl : UserControl
	{
		List<Item> _ResultsList = new List<Item>();

		public SearchControl()
		{
			InitializeComponent();

			results.Columns[0].Width = 23;
			results.Columns[1].Width = 53;
			results.Columns[2].Width = 55;
			results.Columns[3].Width = 110;
			results.Columns[4].Width = 171;
			results.Columns[5].Width = 51;
		}

		private void Search()
		{
			_ResultsList.Clear();
			results.Items.Clear();
			int tp = SearchTypeDropdown.SelectedIndex;
			string sa = SearchBox.Text;

			if (sa != string.Empty && !SearchBox.WatermarkOn && tp >= 0)
			{
				sa = sa.ToLower();
				if (tp == 0)
				{
					foreach (Item x in SRIMSForm.Instance.Inv)
					{
						// Console.WriteLine("Test: "+ sa + " vs " + x.getName().ToLower());
						if (x.Name.ToLower().Contains(sa))
						{
							//Console.WriteLine("bazzinga!");
							_ResultsList.Add(x);
						}
					}
				}
				else if (tp == 1)
				{
					//Search by Loc
					foreach (Item x in SRIMSForm.Instance.Inv)
					{
						// Console.WriteLine("Test: "+ sa + " vs " + x.getName().ToLower());
						if (x.Loc.ToLower().Contains(sa))
						{
							//Console.WriteLine("bazzinga!");
							_ResultsList.Add(x);
						}
					}
				}
				else if (tp == 2)
				{
					//Search by Cat

					//>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Add Dropdown For Category <<<<<<<<<<<<<<<<<<<<<<<<<<<<\\

					foreach (Item x in SRIMSForm.Instance.Inv)
					{
						// Console.WriteLine("Test: "+ sa + " vs " + x.getName().ToLower());
						if (x.Cat.ToLower().Contains(sa))
						{
							//Console.WriteLine("bazzinga!");
							_ResultsList.Add(x);
						}
					}
				}

			}
			else
			{
				_ResultsList.AddRange(SRIMSForm.Instance.Inv);
			}


			foreach (Item item in _ResultsList)
				results.Items.Add(new Item.ItemListViewItem(item));
		}

		public void Reset()
		{
			SearchTypeDropdown.SelectedIndex = 0;
			SearchBox.Text = string.Empty;
			Search();
		}

		private void ClearSearch_Click(object sender, EventArgs e)
		{
			Reset();
		}

		private void EditItem(Item item)
		{
			using (EditForm ed = new EditForm(item))
				ed.ShowDialog();
			Search();
		}

		private void Modify_Click(object sender, EventArgs e)
		{
			if (results.SelectedIndices.Count == 1 && results.SelectedIndices[0] != -1)
				EditItem(_ResultsList[results.SelectedIndices[0]]);
		}


		// CHECK OUT!!!!!!!!!!!!!!!

		private void button4_Click(object sender, EventArgs e)
		{
			if (results.SelectedIndices.Count == 1 && results.SelectedIndices[0] != -1)
			{
				using (CheckOut c = new CheckOut(_ResultsList[results.SelectedIndices[0]]))
					c.ShowDialog();
			}

		}

		private void SearchBox_TextChanged(object sender, EventArgs e)
		{
			Search();
		}

		private void SearchTypeDropdown_SelectedValueChanged(object sender, EventArgs e)
		{
			Search();
		}
	}
}
