namespace SRIMS
{
	public class Item
	{
		int id = 0;
		string loc = "Location";
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
