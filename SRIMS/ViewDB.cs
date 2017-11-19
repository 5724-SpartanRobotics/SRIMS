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
		}

		private void ViewDB_Load(object sender, EventArgs e)
		{

		}

		public void Ext()
		{
			Clear();
			foreach (Item item in SRIMSForm.Instance.Inv)
				ViewListBox.Items.Add(item.Id.ToString()).SubItems.AddRange(new string[]
					{ item.Loc, item.Cat, item.Name, item.Desc, item.Qt.ToString() });
		}

		public void Clear()
		{
			ViewListBox.Items.Clear();
		}

		private void DelItem_Click(object sender, EventArgs e)
		{
			if (ViewListBox.SelectedIndices.Count == 1 && ViewListBox.SelectedIndices[0] != -1)
			{
				SRIMSForm.Instance.Inv.Remove(SRIMSForm.Instance.Inv[ViewListBox.SelectedIndices[0]]);
				Ext();
			}

		}

		private void button2_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(Properties.Settings.Default.dbloc);

		}


		private void EditItem(int index)
		{
			using (EditForm ed = new EditForm(index, this))
				ed.ShowDialog();
			Ext();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (ViewListBox.SelectedIndices.Count == 1 && ViewListBox.SelectedIndices[0] != -1)
			{
				EditItem(ViewListBox.SelectedIndices[0]);
			}
		}
	}
}
