namespace SRIMS
{
	public class Item
	{
		public int Id { get; private set; } = 0;
		public string Name { get; set; } = "Item";
		public string Cat { get; set; } = "Category";
		public string Loc { get; set; } = "Location";
		public string Desc { get; set; } = "Item Description";
		public int Qt { get; set; } = 0;

		public Item()
		{

		}

		public Item(int id, string loc, string cat, string name, string desc, int qt)
		{
			Id = id;
			Loc = loc;
			Cat = cat;
			Name = name;
			Desc = desc;
			Qt = qt;

		}

		public override string ToString()
		{
			return CSVHelper.SerializeItem(this);
		}
	}

}
