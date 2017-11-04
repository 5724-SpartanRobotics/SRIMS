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

        List<item> inv;

        public ViewDB()
        {
            InitializeComponent();
        }

        private void ViewDB_Load(object sender, EventArgs e)
        {

        }

        public void ext(List<item> x)
        {
            clear();
            inv = x;
            foreach (item y in inv)
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
    }
}
