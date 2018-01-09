using System;
using System.Windows.Forms;
using static SRIMS.Category;

namespace SRIMS
{
	public partial class CategoryPage : UserControl
	{
		public CategoryPage()
		{
			InitializeComponent();
			ResetItems();
		}

		private void _BtnAddCategory_Click(object sender, EventArgs e)
		{
			if (SRIMSForm.Instance.Inv.TryAddCategory(_TextBoxCategoryName.Text))
			{
				_LabelSuccess.Visible = true;
			}
			else
			{
				_LabelSuccess.Visible = false;
				MessageBox.Show("Category " + _TextBoxCategoryName.Text + " already exists!", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			ResetItems();
		}

		private void ResetItems()
		{
			_ListBoxCategories.Items.Clear();
			SRIMSForm.Instance.Inv.Categories.ForEach(x => _ListBoxCategories.Items.Add(x));
		}

		public void Reload()
		{
			ResetItems();
			_LabelSuccess.Visible = false;
		}

		private void _BtnDeleteCategory_Click(object sender, EventArgs e)
		{
			if (_ListBoxCategories.SelectedItems.Count >= 1)
			{
				string msg;
				if (_ListBoxCategories.SelectedItems.Count == 1)
				{
					msg = string.Format("Are you sure you want to permanently delete the category '{0}'? This cannot be undone.",
						 _ListBoxCategories.SelectedItems[0]);
				}
				else
				{
					string items = "";
					foreach (ListViewItem item in _ListBoxCategories.SelectedItems)
					{
						items += item.Text + ", ";
					}
					items = items.Substring(0, items.Length - 2);
					msg = "You are about to permanently delete the following categories: " + _ListBoxCategories.SelectedItems +
						". This cannot be undone. Are you sure you wish to continue?";
				}

				DialogResult result = MessageBox.Show(msg, "Delete Category", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

				if (result.HasFlag(DialogResult.Yes))
				{
					foreach (object item in _ListBoxCategories.SelectedItems)
						SRIMSForm.Instance.Inv.RemoveCategory((Category)item);
					SRIMSForm.Instance.SaveInventory();
				}
			}
			else
			{
				MessageBox.Show("You must have at least one category selected!", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void _BtnRenameCategory_Click(object sender, EventArgs e)
		{
			if (_ListBoxCategories.SelectedItems.Count != 1)
			{
				string msg;
				if (_ListBoxCategories.SelectedItems.Count > 1)
					msg = "You may only edit one item at a time!";
				else
					msg = "Whoa, I ate my shoe! You must select an item to edit!";
				MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				using (EditCategory editCat = new EditCategory((Category)_ListBoxCategories.SelectedItems[0]))
					editCat.ShowDialog();
				ResetItems();
				SRIMSForm.Instance.SaveInventory();
			}
		}
	}
}
