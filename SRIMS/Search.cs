using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SRIMS
{
	public partial class Search : UserControl
	{

		List<Item> inv;
		List<Item> resultsList = new List<Item>();

		public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        public void PopDB(List<Item> x)
        {
            inv = x;
            //Console.WriteLine("dbpopulated");
        }

        private List<Item> search()
        {
            
            int tp = comboBox1.SelectedIndex;
            string sa = textBox1.Text;
            if (tp >= 0)
            {
                if (sa == "" || sa == "Search Argument")
                {
                    return new List<Item>();
                }
                sa = sa.ToLower();
                if (tp == 0)
                {
                    foreach (Item x in inv)
                    {
                        // Console.WriteLine("Test: "+ sa + " vs " + x.getName().ToLower());
                        if (x.Name.ToLower().Contains(sa))
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
                        if (x.Loc.ToLower().Contains(sa))
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
                        if (x.Cat.ToLower().Contains(sa))
                        {
                            //Console.WriteLine("bazzinga!");
                            resultsList.Add(x);
                        }
                    }
                }

                return resultsList;
            }

            return new List<Item>();
        }

        public void Reset()
        {
            try { resultsList.Clear(); } catch { }
            comboBox1.Text = "Type";
            textBox1.Text = "Search Argument";
            //results.Items.Clear();
        }

        public void but1click()
        {
            foreach (Item x in search())
                results.Items.Add(x);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //reset();
            results.Items.Clear();
            resultsList.Clear();
            but1click();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            results.Items.Clear();
        }

        private void editItem(int index)
        {
            edit ed = new edit(resultsList, index, this);
            ed.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (results.SelectedIndex != -1)
            {
                editItem(results.SelectedIndex);
                PopDB(inv);
            }
        }
    }
}
