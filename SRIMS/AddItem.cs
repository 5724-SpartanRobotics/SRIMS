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
    public partial class AddItem : UserControl
    {

        List<Item> inv;

        public AddItem()
        {
            InitializeComponent();
        }

        public void setDB(List<Item> x)
        {
            inv = x;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            int id = inv[inv.Count()-1].getid() + 1;

            int qt = (int) Quantity.Value;

            string[] cat = { "Mech", "Elec", "Code", "Misc" };

            int scat = Category.SelectedIndex;


            inv.Add(new Item(id, ItemLocation.Text, cat[scat] , ItemName.Text, Description.Text,qt));

            label1.Visible = true;

            reload();
        }

        private void reload()
        {
            ItemName.Text = "Item Name";
            ItemLocation.Text = "Location";
            Description.Text = "Item Description";
            Quantity.Value = 0;
            Category.Text = "Choose Category";
        }

        public void reload(bool x)
        {
            reload();
            label1.Visible = false;
        }

        private void ItemLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(Category.SelectedIndex);
        }
    }
}
