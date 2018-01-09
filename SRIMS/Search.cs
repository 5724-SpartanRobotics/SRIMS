using SRIMS.Properties;
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

			if (Settings.Default.SearchColumnSizes == null)
				Settings.Default.SearchColumnSizes = new int[] { 23, 53, 73, 112, 290, 51 };

			for (int i = 0; i < 6; i++)
				_ListViewResults.Columns[i].Width = Settings.Default.SearchColumnSizes[i];
		}

		private void Search()
		{
			_ResultsList.Clear();
			_ListViewResults.Items.Clear();
			int tp = SearchTypeDropdown.SelectedIndex;
			string sa = SearchBox.Text;

			if (sa != string.Empty && !SearchBox.WatermarkOn && tp >= 0)
			{
				sa = sa.ToLower();
				if (tp == 0)
				{
					foreach (Item x in SRIMSForm.Instance.Inv.Items)
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
					foreach (Item x in SRIMSForm.Instance.Inv.Items)
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

					foreach (Item x in SRIMSForm.Instance.Inv.Items)
					{
						// Console.WriteLine("Test: "+ sa + " vs " + x.getName().ToLower());
						if (x.Cat.Name.ToLower().Contains(sa))
						{
							//Console.WriteLine("bazzinga!");
							_ResultsList.Add(x);
						}
					}
				}

			}
			else
			{
				_ResultsList.AddRange(SRIMSForm.Instance.Inv.Items);
			}


			foreach (Item item in _ResultsList)
				_ListViewResults.Items.Add(new Item.ItemListViewItem(item));
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
			if (_ListViewResults.SelectedItems.Count == 1)
				EditItem(((Item.ItemListViewItem)_ListViewResults.SelectedItems[0]).ItemValue);
		}

		private void _Btn_Checkout_Click(object sender, EventArgs e)
		{
			if (_ListViewResults.SelectedItems.Count == 1)
				using (CheckOut c = new CheckOut(((Item.ItemListViewItem)_ListViewResults.SelectedItems[0]).ItemValue))
					c.ShowDialog();


		}

		private void SearchBox_TextChanged(object sender, EventArgs e)
		{
			Search();
		}

		private void SearchTypeDropdown_SelectedValueChanged(object sender, EventArgs e)
		{
			Search();
		}

		private void _ListViewResults_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
		{
			Settings.Default.ViewDBColumnSizes[e.ColumnIndex] = _ListViewResults.Columns[e.ColumnIndex].Width;
		}
	}
}
