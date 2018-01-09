using SRIMS.Properties;
using System;
using System.Windows.Forms;

namespace SRIMS
{
	public partial class ViewDB : UserControl
	{
		public ViewDB()
		{
			InitializeComponent();

			if (Settings.Default.ViewDBColumnSizes == null)
				Settings.Default.ViewDBColumnSizes = new int[] { 23, 53, 73, 112, 290, 51 };

			for (int i = 0; i < 6; i++)
				_ListViewBox.Columns[i].Width = Settings.Default.ViewDBColumnSizes[i];

			_ListViewBox.Sorting = SortOrder.Ascending;
		}

		public void Ext()
		{
			Clear();
			foreach (Item item in SRIMSForm.Instance.Inv.Items)
				_ListViewBox.Items.Add(new Item.ItemListViewItem(item));
			_ListViewBox.Sort();
		}

		public void Clear()
		{
			_ListViewBox.Items.Clear();
		}

		private void _BtnDelItem_Click(object sender, EventArgs e)
		{
			if (_ListViewBox.SelectedItems.Count == 1)
			{
				SRIMSForm.Instance.Inv.Items.Remove(((Item.ItemListViewItem)_ListViewBox.SelectedItems[0]).ItemValue);
				Ext();
				SRIMSForm.Instance.SaveInventory();
			}

		}

		private void _BtnOpenDatabase_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(Properties.Settings.Default.dbloc);
		}


		private void EditItem(Item item)
		{
			using (EditForm ed = new EditForm(item))
				ed.ShowDialog();
			Ext();
		}

		private void _BtnEdit_Click(object sender, EventArgs e)
		{
			if (_ListViewBox.SelectedItems.Count == 1)
				EditItem(((Item.ItemListViewItem)_ListViewBox.SelectedItems[0]).ItemValue);
		}

		private void _ListViewBox_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
		{
			Settings.Default.ViewDBColumnSizes[e.ColumnIndex] = _ListViewBox.Columns[e.ColumnIndex].Width;
		}
	}
}
