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
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        item x = new item();

        private void init()
        {

            Console.WriteLine(x);

        }




        private void Form1_Load(object sender, EventArgs e)
        {
            init();
            dehighlightSelectors();
        }

        private void dehighlightSelectors()
        {
            CheckOutSelected.Visible = false;
            CheckInSelected.Visible = false;
            ViewDatabaseSelected.Visible = false;
            AddItemSelected.Visible = false;
            SearchSelected.Visible = false;
            CheckOutLogSelected.Visible = false;

            checkout1.Visible = false;
            checkin1.Visible = false;
            viewDB1.Visible = false;
            addItem1.Visible = false;
            search1.Visible = false;
            checkoutLog1.Visible = false;


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }
        // CheckOut
        private void button1_Click(object sender, EventArgs e)
        {
            dehighlightSelectors();
            CheckOutSelected.Visible = true;
            checkout1.Visible = true;

        }
        // CheckIn
        private void button2_Click(object sender, EventArgs e)
        {
            dehighlightSelectors();
            CheckInSelected.Visible = true;
            checkin1.Visible = true;

        }
        // ViewDB
        private void button3_Click(object sender, EventArgs e)
        {
            dehighlightSelectors();
            ViewDatabaseSelected.Visible = true;
            viewDB1.Visible = true;

        }
        // Search
        private void button4_Click(object sender, EventArgs e)
        {
            dehighlightSelectors();
            SearchSelected.Visible = true;
            search1.Visible = true;

        }
        // AddItem
        private void button5_Click(object sender, EventArgs e)
        {
            dehighlightSelectors();
            AddItemSelected.Visible = true;
            addItem1.Visible = true;


        }
        // CheckOutLog
        private void button6_Click(object sender, EventArgs e)
        {
            dehighlightSelectors();
            CheckOutLogSelected.Visible = true;
            checkoutLog1.Visible = true;

        }

    }
}
