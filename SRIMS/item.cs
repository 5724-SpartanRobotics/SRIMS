using System.Collections;
using System.Windows.Forms;

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

		public class ItemListViewItem : ListViewItem
		{
			public readonly Item ItemValue;

			public ItemListViewItem(Item item) : base(item.Id.ToString())
			{
				ItemValue = item;
				SubItems.AddRange(new string[] { item.Loc, item.Cat, item.Name, item.Desc, item.Qt.ToString() });
			}
		}

		public class ItemListViewComparer : IComparer
		{
			private bool _isNumber;
			private int _column;
			private SortOrder _sortOrder;

			public ItemListViewComparer(int col, SortOrder order)
			{
				_column = col;
				_isNumber = _column == 0 || _column == 5;
				_sortOrder = order;
			}

			public int Compare(object rowX, object rowY)
			{
				string x = ((ListViewItem)rowX).SubItems[_column].Text;
				string y = ((ListViewItem)rowY).SubItems[_column].Text;

				if (_sortOrder == SortOrder.Descending)
				{
					string temp = x;
					x = y;
					y = temp;
				}

				if (_isNumber)
					if (int.TryParse(x.ToString(), out int a) && int.TryParse(y.ToString(), out int b))
						return a.CompareTo(b);

				return x.ToString().CompareTo(y.ToString());
			}
		}
	}

}
