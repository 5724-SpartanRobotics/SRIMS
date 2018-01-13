using SRIMS.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SRIMS
{
	public partial class SearchControl : UserControl
	{
		List<Item> _ResultsList = new List<Item>();

		public SearchControl()
		{
			InitializeComponent();

			if (Settings.Default.SearchColumnSizes == null || Settings.Default.SearchColumnSizes.Length != 7)
				Settings.Default.SearchColumnSizes = new int[] { 23, 53, 73, 112, 239, 51, 51 };

			for (int i = 0; i < 7; i++)
				_ListViewResults.Columns[i].Width = Settings.Default.SearchColumnSizes[i];
		}

		private void Search()
		{
			_ResultsList.Clear();
			string arg = SearchBox.Text.ToLower();

			if (arg != string.Empty && !SearchBox.WatermarkOn)
			{
				foreach (Item x in SRIMSForm.Instance.Inv.Items.Values)
				{
					if (x.Name.ToLower().Contains(arg) || x.Desc.ToLower().Contains(arg) ||
						x.Cat.Name.ToLower().Contains(arg) || x.Loc.ToLower().Contains(arg) ||
						x.Id.ToString().Contains(arg))
					{
						_ResultsList.Add(x);
					}
				}
			}
			else
			{
				foreach (Item item in SRIMSForm.Instance.Inv.Items.Values)
					_ResultsList.Add(item);
			}

			_ListViewResults.Items.Clear();
			foreach (Item item in _ResultsList)
				_ListViewResults.Items.Add(new Item.ItemListViewItem(item));
		}

		public void Reset()
		{
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
			{
				using (CheckOut c = new CheckOut(((Item.ItemListViewItem)_ListViewResults.SelectedItems[0]).ItemValue))
					c.ShowDialog();

				Search();
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

		private void _ListViewResults_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
		{
			Settings.Default.ViewDBColumnSizes[e.ColumnIndex] = _ListViewResults.Columns[e.ColumnIndex].Width;
			Settings.Default.Save();
		}

		private void _ListViewResults_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (_ListViewResults.SelectedIndices.Count == 1)
			{
				Rectangle rect = _ListViewResults.GetItemRect(_ListViewResults.SelectedIndices[0]);
				if (rect.Contains(e.Location))
					EditItem(((Item.ItemListViewItem)_ListViewResults.SelectedItems[0]).ItemValue);
			}
		}
	}
}
