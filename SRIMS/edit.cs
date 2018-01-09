using System;
using System.Windows.Forms;

namespace SRIMS
{
	public partial class EditForm : Form
	{
		Item _Item;

		public EditForm(Item itemInput)
		{
			InitializeComponent();
			_Item = itemInput;
			foreach (Category cat in SRIMSForm.Instance.Inv.Categories)
				_ComboBoxCat.Items.Add(cat);
		}

		private void Edit_Load(object sender, EventArgs e)
		{
			NameTextBox.Text = _Item.Name;
			_ComboBoxCat.SelectedIndex = _ComboBoxCat.Items.IndexOf(_Item.Cat);
			DescTextBox.Text = _Item.Desc;
			numericUpDown1.Value = _Item.Qt;
			LocTextBox.Text = _Item.Loc;
		}

		private void SaveBtn_Click(object sender, EventArgs e)
		{
			if (NameTextBox.Text == string.Empty)
			{
				MessageBox.Show("Name is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			_Item.Name = NameTextBox.Text;
			_Item.Cat = (Category)_ComboBoxCat.SelectedItem;
			_Item.Desc = DescTextBox.Text;
			_Item.Qt = (int)numericUpDown1.Value;
			_Item.Loc = LocTextBox.Text;

			if (_Item.Cat == null)
				_Item.Cat = Category.NONE;

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
