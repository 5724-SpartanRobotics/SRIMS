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

			reload();
		}

		private void reload()
		{
			ItemName.Text = "Item Name";
			ItemLocation.Text = "Location";
			Description.Text = "Item Description";
			Quantity.Value = 0;
			Category.SelectedIndex = 0;
		}

		public void reload(bool x)
		{
			reload();
			label1.Visible = false;
		}

		private void ItemLocation_TextChanged(object sender, EventArgs e)
		{

		}

		private void Category_SelectedIndexChanged(object sender, EventArgs e)
		{
			Console.WriteLine(Category.SelectedIndex);
		}

		// Source: https://stackoverflow.com/a/1125081/5515842
		private void TextBoxes_KeyDown(object sender, KeyEventArgs e)
		{
			throw new NotImplementedException();
			if (e.KeyData == (Keys.Control | Keys.Back))
			{
				TextBox textBox1 = (TextBox)sender;
				e.SuppressKeyPress = true;
				int selStart = textBox1.SelectionStart;
				while (selStart > 0 && textBox1.Text.Substring(selStart - 1, 1) == " ")
					selStart--;

				int prevSpacePos = -1;
				if (selStart != 0)
					prevSpacePos = textBox1.Text.LastIndexOf(' ', selStart - 1);

				textBox1.Select(prevSpacePos + 1, textBox1.SelectionStart - prevSpacePos - 1);
				textBox1.SelectedText = "";
			}

		}
	}
}
