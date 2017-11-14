using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRIMS
{
    public partial class CheckOut : Form
    {

        private Item x;
        private string lel;

        public CheckOut(Item x)
        {
            InitializeComponent();
            this.x = x;
            this.lel = Properties.Settings.Default.checkout_list;
        }

        private void CheckOut_Load(object sender, EventArgs e)
        {
            textBox2.Text = x.Name;
            this.ActiveControl = textBox1;
            this.AcceptButton = button1;
            label4.Visible = false;
        }

        private string LogIt(string Name, int quantity)
        {

            return Name + "," + x.Id + "," + quantity + ";";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value != 0 && textBox1.Text != "")
            {
                Properties.Settings.Default.checkout_list = lel + LogIt(textBox1.Text, (int)numericUpDown1.Value);
                label4.Text = "Item Checked Out";
                label4.Visible = true;
            }
            else if (numericUpDown1.Value == 0)
            {
                label4.Text = "Error QT = 0!";
                label4.Visible = true;
            }
            else if (textBox1.Text == "")
            {
                label4.Text = "Error Name Null";
                label4.Visible = true;
            }
            else
            {
                label4.Text = "Error Unkown";
                label4.Visible = true;
            }
        }
    }
}
