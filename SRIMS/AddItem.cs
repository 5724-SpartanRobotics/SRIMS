using System;
using System.Linq;
using System.Windows.Forms;

namespace SRIMS
{
	public partial class AddItem : UserControl
	{
		public AddItem()
		{
			InitializeComponent();
			SRIMSForm.Instance?.Inv?.Categories?.ForEach(x => _ComboBoxCategory.Items.Add(x));
		}

		private void Submit_Click(object sender, EventArgs e)
		{
			int id = 0;
			if (SRIMSForm.Instance.Inv.Items.Count > 0)
				id = SRIMSForm.Instance.Inv.Items.Last().Id + 1;

			int qt = (int)Quantity.Value;

			Category cat = (Category)_ComboBoxCategory.SelectedItem;

			SRIMSForm.Instance.Inv.Items.Add(new Item(id, ItemLocation.Text, cat, ItemName.Text, Description.Text, qt));

			_LabelSuccess.Visible = true;
			SRIMSForm.Instance.SaveInventory();
			ResetItems();
		}

		private void ResetItems()
		{
			ItemName.Text = string.Empty;
			_ComboBoxCategory.SelectedIndex = 0;
			ItemLocation.Text = string.Empty;
			Description.Text = string.Empty;
			Quantity.Value = 0;
		}

		public void Reload()
		{
			ResetItems();
			_LabelSuccess.Visible = false;
		}

		private void Description_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Prevent newlines because they break things
			if (e.KeyChar == '\r' || e.KeyChar == '\n')
				e.Handled = true;
		}
	}
}
