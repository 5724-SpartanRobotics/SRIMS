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
    public partial class Search : UserControl
    {
        public Search()
        {
            InitializeComponent();
        }

        List<item> inv;
        List<item> resultsList = new List<item>();
        private void Search_Load(object sender, EventArgs e)
        {

        }

        public void popdb(List<item> x)
        {
            inv = x;
            //Console.WriteLine("dbpopulated");
        }

        private List<item> search()
        {
            
            int tp = comboBox1.SelectedIndex;
            string sa = textBox1.Text;
            string gut = "";
            if (tp >= 0)
            {
                if (sa == "" || sa == "Search Argument")
                {
                    return null;
                }
                sa = sa.ToLower();
                if (tp == 0)
                {
                    foreach (item x in inv)
                    {
                        // Console.WriteLine("Test: "+ sa + " vs " + x.getName().ToLower());
                        if (x.getName().ToLower().Contains(sa))
                        {
                            //Console.WriteLine("bazzinga!");
                            resultsList.Add(x);
                        }
                    }
                }

                if (tp == 1)
                {
                    //Search by Loc
                    foreach (item x in inv)
                    {
                        // Console.WriteLine("Test: "+ sa + " vs " + x.getName().ToLower());
                        if (x.getLoc().ToLower().Contains(sa))
                        {
                            //Console.WriteLine("bazzinga!");
                            resultsList.Add(x);
                        }
                    }
                }

                if (tp == 2)
                {
                    //Search by Cat

                    //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Add Dropdown For Category <<<<<<<<<<<<<<<<<<<<<<<<<<<<\\

                    foreach (item x in inv)
                    {
                        // Console.WriteLine("Test: "+ sa + " vs " + x.getName().ToLower());
                        if (x.getCat().ToLower().Contains(sa))
                        {
                            //Console.WriteLine("bazzinga!");
                            resultsList.Add(x);
                        }
                    }
                }

                return resultsList;
            }

            return null;
        }

        public void reset()
        {
            try { resultsList.Clear(); } catch { }
            comboBox1.Text = "Type";
            textBox1.Text = "Search Argument";
            //results.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //reset();
            results.Items.Clear();
            resultsList.Clear();
            foreach (item x in search())
            {
                results.Items.Add(x);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            results.Items.Clear();
        }
    }
}
