using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRIMS
{
    public class item
    {
        int id = 0;
        string loc = "Location";
        string cat = "Category";
        string name = "Item";
        string desc = "Item Description";
        int qt = 0;

        public item()
        {
         
        }

        public item(int id, string loc, string cat, string name, string desc, int qt)
        {
            this.id = id;
            this.loc = loc;
            this.cat = cat;
            this.name = name;
            this.desc = desc;
            this.qt = qt;

        }

        public override string ToString()
        {
            //return null;
            return this.id + "," + this.loc + "," + this.cat + "," + this.name + "," + this.desc + "," + this.qt;
        }
        public int getid()
        {
            return id;
        }
        public string getName()
        {
            return name;
        }
        public string getLoc()
        {
            return loc;
        }
        public string getCat()
        {
            return cat;
        }
    }

}
