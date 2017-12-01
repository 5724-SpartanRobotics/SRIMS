using System.Windows.Forms;

namespace SRIMS
{
	public partial class SortableListView : ListView
	{
		private int _ColumnNum = 0;

		public SortableListView()
		{
			ColumnClick += ColumnClickSortHandler;
		}

		private void ColumnClickSortHandler(object sender, ColumnClickEventArgs e)
		{
			if (e.Column == _ColumnNum)
			{
				if (Sorting == SortOrder.Ascending)
					Sorting = SortOrder.Descending;
				else
					Sorting = SortOrder.Ascending;
			}
			else
			{
				_ColumnNum = e.Column;
				Sorting = SortOrder.Ascending;
			}

			ListViewItemSorter = new Item.ItemListViewComparer(e.Column, Sorting);
		}

		protected override void OnPaint(PaintEventArgs pe)
		{
			base.OnPaint(pe);
		}
	}
}
