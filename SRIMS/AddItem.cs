using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SRIMS
{
	public partial class AddItem : UserControl
	{
		List<Item> inv;

		public AddItem()
		{
			InitializeComponent();
		}

		public void SetDB(List<Item> x)
		{
			inv = x;
		}

		private void Submit_Click(object sender, EventArgs e)
		{
			int id = 0;
			if (inv.Count > 0)
				id = inv.Last().Id + 1;

			int qt = (int)Quantity.Value;

			string[] cat = { "Mech", "Elec", "Code", "Bump", "Misc" };

			int scat = Category.SelectedIndex;

			inv.Add(new Item(id, ItemLocation.Text, cat[scat], ItemName.Text, Description.Text, qt));

			label1.Visible = true;
			SRIMSForm.Instance.SaveInventory();
			Reload();
		}

		private void Reload()
		{
			Quantity.Value = 0;
			Category.SelectedIndex = 0;
		}

		public void Reload(bool x)
		{
			Reload();
			label1.Visible = false;
		}

		private void ItemLocation_TextChanged(object sender, EventArgs e)
		{

		}

		private void Category_SelectedIndexChanged(object sender, EventArgs e)
		{
			Console.WriteLine(Category.SelectedIndex);
		}

		private void Description_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Prevent newlines because they break things
			if (e.KeyChar == '\r' || e.KeyChar == '\n')
				e.Handled = true;
		}
	}
}
