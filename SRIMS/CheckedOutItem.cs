namespace SRIMS
{
	class CheckedOutItem
    {

        public string Name { get; set;} = "";
        public Item item { get; set; } = new Item();
        public int qt { get; set; } = 0;

        public CheckedOutItem(string Name, Item x, int qt)
        {
            this.Name = Name;
            this.item = x;
            this.qt = qt;
        }

        public override string ToString()
        {
            return Name + ": " + item.Name + "-" + item.Loc + "-Qt[" + qt + "]";
        }

    }
}
