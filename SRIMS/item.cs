namespace SRIMS
{
	public class Item
	{
		int id = 0;
		private string loc = "Location";
        string cat = "Category";
		string name = "Item";
		string desc = "Item Description";
		int qt = 0;

		public Item()
		{

		}

		public Item(int id, string loc, string cat, string name, string desc, int qt)
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

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                //this.id = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public string Cat
        {
            get
            {
                return this.cat;
            }
            set
            {
                this.cat = value;
            }
        }
        public string Loc
        {
            get
            {
                return this.loc;
            }
            set
            {
                this.loc = value;
            }
        }
        public string Desc
        {
            get
            {
                return this.desc;
            }
            set
            {
                this.desc = value;
            }
        }
        public int Qt
        {
            get
            {
                return this.qt;
            }
            set
            {
                this.qt = value;
            }
        }
    }

}
