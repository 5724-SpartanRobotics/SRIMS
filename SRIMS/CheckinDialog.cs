using System;
using System.Windows.Forms;

namespace SRIMS
{
	public partial class CheckinDialog : Form
	{
		private CheckedOutItem _Item;

		public CheckinDialog(CheckedOutItem item)
		{
			InitializeComponent();
			_Item = item;
			_NumericUpDownQt.Maximum = _Item.Qt;
			_NumericUpDownQt.Value = _Item.Qt;
		}

		private void _BtnCheckin_Click(object sender, EventArgs e)
		{
			SRIMSForm.Instance.CheckoutManager.CheckInItem(_Item, (int)_NumericUpDownQt.Value);
			Close();
		}
	}
}
