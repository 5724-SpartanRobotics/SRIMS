using System;
using System.Windows.Forms;

namespace SRIMS
{
	public partial class edit : Form
	{
		Item item;
		ViewDB viewDB;
		Search search;
		bool tp;
		Form1 parentForm;

		public edit(Form1 parent, int index, ViewDB z)
		{
			InitializeComponent();
			item = parent.Inv[index];
		}

		public edit(Form1 parent, Item itemInput, Search z)
		{
			InitializeComponent();
			parentForm = parent;
			item = itemInput;
			search = z;
			tp = true;
		}

		private void edit_Load(object sender, EventArgs e)
		{
			textBox1.Text = item.Name;
			textBox3.Text = item.Cat;
			textBox2.Text = item.Desc;
			numericUpDown1.Value = item.Qt;
			textBox4.Text = item.Loc;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			item.Name = textBox1.Text;
			item.Cat = textBox3.Text;
			item.Desc = textBox2.Text;
			item.Qt = (int)numericUpDown1.Value;
			item.Loc = textBox4.Text;
			if (tp)
				;
			else
				;

			Close();
		}
	}
}
