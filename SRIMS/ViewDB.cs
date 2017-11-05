using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRIMS
{
    public partial class ViewDB : UserControl
    {

        List<Item> inv;

        public ViewDB()
        {
            InitializeComponent();
        }

        private void ViewDB_Load(object sender, EventArgs e)
        {

        }

        public void ext(List<Item> x)
        {
            clear();
            inv = x;
            foreach (Item y in inv)
            {

                listBox1.Items.Add(y);

            }

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
                inv.Remove(inv[listBox1.SelectedIndex]);
                ext(inv);
            }
               
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.dbloc);
            
        }


        private void editItem(int index)
        {
            edit ed = new edit(inv, index, this);
            ed.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                editItem(listBox1.SelectedIndex);
                ext(inv);
            }
        }
    }
}
