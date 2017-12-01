using System;
using System.Windows.Forms;

namespace SRIMS
{
	public partial class ViewDB : UserControl
	{
		public ViewDB()
		{
			InitializeComponent();

			ViewListBox.Columns[0].Width = 23;
			ViewListBox.Columns[1].Width = 53;
			ViewListBox.Columns[2].Width = 70;
			ViewListBox.Columns[3].Width = 112;
			ViewListBox.Columns[4].Width = 293;
			ViewListBox.Columns[5].Width = 51;

			ViewListBox.Sorting = SortOrder.Ascending;
		}

		public void Ext()
		{
			Clear();
			foreach (Item item in SRIMSForm.Instance.Inv)
				ViewListBox.Items.Add(new Item.ItemListViewItem(item));
			ViewListBox.Sort();
		}

		public void Clear()
		{
			ViewListBox.Items.Clear();
		}

		private void _BtnDelItem_Click(object sender, EventArgs e)
		{
			if (ViewListBox.SelectedItems.Count == 1)
			{
				SRIMSForm.Instance.Inv.Remove(((Item.ItemListViewItem)ViewListBox.SelectedItems[0]).ItemValue);
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
			if (ViewListBox.SelectedItems.Count == 1)
				EditItem(((Item.ItemListViewItem)ViewListBox.SelectedItems[0]).ItemValue);
		}

	}
}
