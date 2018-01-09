using System.Collections;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace SRIMS
{
	[DataContract]
	public class Item
	{
		[DataMember]
		public int Id { get; private set; } = 0;
		[DataMember]
		public string Name { get; set; } = "Item";

		public Category Cat { get; set; } = Category.NONE;

		[DataMember]
		private int _CatID
		{
			get
			{
				return Cat.Id;
			}
			set
			{
				Cat = SRIMSForm.Instance.Inv.FindCategoryById(value);
			}
		}

		[DataMember]
		public string Loc { get; set; } = "Location";
		[DataMember]
		public string Desc { get; set; } = "Item Description";
		[DataMember]
		public int Qt { get; set; } = 0;

		public Item(int id, string loc, Category cat, string name, string desc, int qt)
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
				SubItems.AddRange(new string[] { item.Loc, item.Cat.Name, item.Name, item.Desc, item.Qt.ToString() });
			}
		}

		public class ItemListViewComparer : IComparer
		{
			private bool _IsNumber;
			private int _Column;
			private SortOrder _SortOrder;

			public ItemListViewComparer(int col, SortOrder order)
			{
				_Column = col;
				_IsNumber = _Column == 0 || _Column == 5;
				_SortOrder = order;
			}

			public int Compare(object rowX, object rowY)
			{
				string x = ((ListViewItem)rowX).SubItems[_Column].Text;
				string y = ((ListViewItem)rowY).SubItems[_Column].Text;

				if (_SortOrder == SortOrder.Descending)
				{
					string temp = x;
					x = y;
					y = temp;
				}

				if (_IsNumber)
					if (int.TryParse(x.ToString(), out int a) && int.TryParse(y.ToString(), out int b))
						return a.CompareTo(b);

				return x.ToString().CompareTo(y.ToString());
			}
		}
	}

}
