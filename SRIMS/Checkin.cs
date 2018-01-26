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
				SRIMSForm.Instance.CheckoutManager.CheckoutList.Sort();
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
				using (CheckinDialog dialog = new CheckinDialog(((CheckedOutItem)_ListBoxCheckout.SelectedItem)))
					dialog.ShowDialog();

			Repopulate();
		}

		private void _ListBoxCheckout_KeyDown(object sender, KeyEventArgs e)
		{
			if (_ListBoxCheckout.SelectedItems.Count == 1 && e.Control && e.KeyCode == Keys.I)
				_BtnCheckin_Click(null, null);
		}
	}
}
