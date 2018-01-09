using System.Windows.Forms;

namespace SRIMS
{
	public partial class EditCategory : Form
	{
		private Category _Category;

		public EditCategory(Category category)
		{
			InitializeComponent();
			_Category = category;
			_TextBoxCategoryName.Text = _Category.Name;
		}

		private void _BtnSave_Click(object sender, System.EventArgs e)
		{
			if (SRIMSForm.Instance.Inv.TryRenameCategory(_Category, _TextBoxCategoryName.Text))
			{
				Close();
			}
			else
			{
				DialogResult result = MessageBox.Show("Category " + _TextBoxCategoryName.Text +
					" already exists! Would you like to combine the two?",
					"Error", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

				if (result.HasFlag(DialogResult.Yes))
				{
					SRIMSForm.Instance.Inv.TryRenameCategory(_Category, _TextBoxCategoryName.Text, true);
					Close();
				}
			}
		}

		private void _BtnCancel_Click(object sender, System.EventArgs e)
		{
			Close();
		}
	}
}
