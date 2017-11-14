using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SRIMS
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            FormClosing += Settings_FormClosing;
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            dbpath.Text = Properties.Settings.Default.dbloc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stream mystream = null;

            OpenFileDialog op = new OpenFileDialog();

            //op.InitialDirectory = "c:\\";
            op.Filter = "CSV Files|*.csv";
            op.FilterIndex = 1;
            //op.RestoreDirectory = true;

            if (op.ShowDialog() == DialogResult.OK)
            {
               if ((mystream = op.OpenFile()) != null)
                {
                    // instert code here to change db location on app settings
                    dbpath.Text = op.InitialDirectory + op.FileName;
                    Properties.Settings.Default.dbloc = op.InitialDirectory + op.FileName;
                }
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.checkout_list = "";
        }
    }
}
