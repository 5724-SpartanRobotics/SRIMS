using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SRIMS
{
	public partial class ViewDB : UserControl
	{

		public ViewDB()
		{
			InitializeComponent();
		}

		private void ViewDB_Load(object sender, EventArgs e)
		{

		}

		public void ext()
		{
			clear();
			foreach (Item y in ((Form1)ParentForm).Inv)
				listBox1.Items.Add(y);
		}

		public void clear()
		{

			listBox1.Items.Clear();

		}

		private void delitem_Click(object sender, EventArgs e)
		{
			//listBox1.SelectedIndex = 0;

			if (listBox1.SelectedIndex != -1)
			{
				((Form1)ParentForm).Inv.Remove(((Form1)ParentForm).Inv[listBox1.SelectedIndex]);
				ext();
			}

		}

		private void button2_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(Properties.Settings.Default.dbloc);

		}


		private void EditItem(int index)
		{
			edit ed = new edit((Form1)ParentForm, index, this);
			ed.FormClosed += Ed_FormClosed;
			ed.Show();
		}

		private void Ed_FormClosed(object sender, FormClosedEventArgs e)
		{
			ext();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (listBox1.SelectedIndex != -1)
			{
				EditItem(listBox1.SelectedIndex);
			}
		}
	}
}
