using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SRIMS
{
	public partial class edit : Form
	{
		List<Item> lol;
		Item x;
		ViewDB z;
        Search z1;
        bool tp;

		public edit(List<Item> x, int index, ViewDB z)
		{
			InitializeComponent();
			this.x = x[index];
			this.lol = x;
			this.z = z;
		}

        public edit(List<Item> x, int index, Search z)
        {
            InitializeComponent();
            this.x = x[index];
            this.lol = x;
            this.z1 = z;
            this.tp = true;
        }

        private void edit_Load(object sender, EventArgs e)
		{
			textBox1.Text = x.Name;
			textBox3.Text = x.Cat;
			textBox2.Text = x.Desc;
			numericUpDown1.Value = x.Qt;
			textBox4.Text = x.Loc;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			x.Name = textBox1.Text;
			x.Cat = textBox3.Text;
			x.Desc = textBox2.Text;
			x.Qt = (int)numericUpDown1.Value;
			x.Loc = textBox4.Text;
            if (!tp)
            { z.ext(lol); }
            else
            { z1.PopDB(lol);}

			Close();
		}
	}
}
