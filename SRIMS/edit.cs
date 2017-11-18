using System;
using System.Windows.Forms;

namespace SRIMS
{
	public partial class EditForm : Form
	{
		Item item;
		SRIMSForm parentForm;

		public EditForm(SRIMSForm parent, int index, ViewDB z)
		{
			InitializeComponent();
			item = parent.Inv[index];
		}

		public EditForm(SRIMSForm parent, Item itemInput, SearchControl z)
		{
			InitializeComponent();
			parentForm = parent;
			item = itemInput;
		}

		private void Edit_Load(object sender, EventArgs e)
		{
			textBox1.Text = item.Name;
			textBox3.Text = item.Cat;
			textBox2.Text = item.Desc;
			numericUpDown1.Value = item.Qt;
			textBox4.Text = item.Loc;
		}

		private void SaveBtn_Click(object sender, EventArgs e)
		{
			item.Name = textBox1.Text;
			item.Cat = textBox3.Text;
			item.Desc = textBox2.Text;
			item.Qt = (int)numericUpDown1.Value;
			item.Loc = textBox4.Text;

			parentForm.SaveInventory();
			Close();
		}
	}
}
