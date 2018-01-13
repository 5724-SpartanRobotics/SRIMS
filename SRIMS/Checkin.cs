using System;
using System.Windows.Forms;

namespace SRIMS
{
	public partial class Checkin : UserControl
	{
		public Checkin()
		{
			InitializeComponent();
		}

		private void Checkin_Load(object sender, EventArgs e)
		{
			Repopulate();
		}

		public void Repopulate()
		{
			Depop();
			if (SRIMSForm.Instance?.CheckoutManager?.CheckoutList != null)
			{
				foreach (CheckedOutItem item in SRIMSForm.Instance.CheckoutManager.CheckoutList)
					_ListBoxCheckout.Items.Add(item);
				_ListBoxCheckout.Refresh();
			}
		}

		private void Depop()
		{
			_ListBoxCheckout.Items.Clear();
		}

		private void _BtnCheckin_Click(object sender, EventArgs e)
		{
			if (_ListBoxCheckout.SelectedIndex != -1)
				SRIMSForm.Instance.CheckoutManager.CheckInItem((CheckedOutItem)_ListBoxCheckout.SelectedItem);
			
			Repopulate();
		}
	}
}
