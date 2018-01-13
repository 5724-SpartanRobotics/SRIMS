using SRIMS.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SRIMS
{
	public partial class ViewDB : UserControl
	{
		public ViewDB()
		{
			InitializeComponent();

			if (Settings.Default.ViewDBColumnSizes == null || Settings.Default.ViewDBColumnSizes.Length != 7)
				Settings.Default.ViewDBColumnSizes = new int[] { 23, 53, 73, 112, 239, 51, 51 };

			for (int i = 0; i < 7; i++)
				_ListViewBox.Columns[i].Width = Settings.Default.ViewDBColumnSizes[i];

			_ListViewBox.Sorting = SortOrder.Ascending;
		}

		public void Ext()
		{
			Clear();
			foreach (Item item in SRIMSForm.Instance.Inv.Items.Values)
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
				DialogResult res = MessageBox.Show("Are you sure you want to delete " +
					$"{((Item.ItemListViewItem)_ListViewBox.SelectedItems[0]).ItemValue.Name}? This cannot be undone.",
					"Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

			if (res == DialogResult.Yes)
			{
				SRIMSForm.Instance.Inv.RemoveItem(((Item.ItemListViewItem)_ListViewBox.SelectedItems[0]).ItemValue);
				Ext();
				SRIMSForm.Instance.SaveInventory();
			}
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
		Settings.Default.Save();
	}

	private void _ListViewBox_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		if (_ListViewBox.SelectedIndices.Count == 1)
		{
			Rectangle rect = _ListViewBox.GetItemRect(_ListViewBox.SelectedIndices[0]);
			if (rect.Contains(e.Location))
				EditItem(((Item.ItemListViewItem)_ListViewBox.SelectedItems[0]).ItemValue);
		}
	}
}
}
