using System;
using System.Windows.Forms;

namespace SRIMS
{
	public partial class EditForm : Form
	{
		Item item;

		public EditForm(int index, ViewDB z)
		{
			InitializeComponent();
			item = SRIMSForm.Instance.Inv[index];
		}

		public EditForm(Item itemInput, SearchControl z)
		{
			InitializeComponent();
			item = itemInput;
		}

		private void Edit_Load(object sender, EventArgs e)
		{
			NameTextBox.Text = item.Name;
			CatTextBox.Text = item.Cat;
			DescTextBox.Text = item.Desc;
			numericUpDown1.Value = item.Qt;
			LocTextBox.Text = item.Loc;
		}

		private void SaveBtn_Click(object sender, EventArgs e)
		{
			item.Name = NameTextBox.Text;
			item.Cat = CatTextBox.Text;
			item.Desc = DescTextBox.Text;
			item.Qt = (int)numericUpDown1.Value;
			item.Loc = LocTextBox.Text;

			SRIMSForm.Instance.SaveInventory();
			Close();
		}

		private void DescTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Prevent newlines because they break things
			if (e.KeyChar == '\r' || e.KeyChar == '\n')
				e.Handled = true;
		}
	}
}
