using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SRIMS
{
	public partial class Search : UserControl
    {
        public Search()
        {
            InitializeComponent();
        }

        List<Item> inv;
        List<Item> resultsList = new List<Item>();
        private void Search_Load(object sender, EventArgs e)
        {

        }

        public void popdb(List<Item> x)
        {
            inv = x;
            //Console.WriteLine("dbpopulated");
        }

        private List<Item> search()
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
                    foreach (Item x in inv)
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
                    foreach (Item x in inv)
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

                    foreach (Item x in inv)
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

        public void Reset()
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
            foreach (Item x in search())
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
