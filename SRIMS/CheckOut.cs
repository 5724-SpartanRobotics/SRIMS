using System;
using System.Windows.Forms;

namespace SRIMS
{
	public partial class CheckOut : Form
	{
		private Item _Item;

		public CheckOut(Item item)
		{
			InitializeComponent();
			_Item = item;
		}

		private void CheckOut_Load(object sender, EventArgs e)
		{
			textBox2.Text = _Item.Name;
			ActiveControl = textBox1;
			AcceptButton = _BtnCheckout;
			label4.Visible = false;
			_NumericUpDown1.Maximum = _Item.Qt - SRIMSForm.Instance.CheckoutManager.QuantityCheckedOut(_Item);
		}

		private void _BtnCheckout_Click(object sender, EventArgs e)
		{
			if (_NumericUpDown1.Value != 0 && textBox1.Text != "")
			{
				SRIMSForm.Instance.CheckoutManager
					.CheckOutItem(new CheckedOutItem(textBox1.Text, _Item, (int)_NumericUpDown1.Value));
				label4.Text = "Item Checked Out";
				label4.Visible = true;
				MessageBox.Show("Item Checkout out!", "Checked out", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Close();
			}
			else if (_NumericUpDown1.Value == 0)
			{
				label4.Text = "Error QT = 0!";
				label4.Visible = true;
			}
			else if (textBox1.Text == "")
			{
				label4.Text = "Error Name Null";
				label4.Visible = true;
			}
			else
			{
				label4.Text = "Error Unkown";
				label4.Visible = true;
			}
		}
	}
}
