namespace SRIMS
{
	class CheckedOutItem
    {

        public string Name { get; set;} = "";
		public Item Item { get; set; } = null;
        public int Qt { get; set; } = 0;

        public CheckedOutItem(string name, Item x, int qt)
        {
			Name = name;
			Item = x;
			Qt = qt;
        }

        public override string ToString()
        {
            return Name + ": " + Item.Name + "-" + Item.Loc + "-Qt[" + Qt + "]";
        }

    }
}
