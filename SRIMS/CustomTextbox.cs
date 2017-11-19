using System.Windows.Forms;

namespace SRIMS
{
	// Based off of https://stackoverflow.com/a/15232752/5515842
	public partial class SRIMSTextBox : TextBox
	{
		// Source: https://stackoverflow.com/a/1125081/5515842
		protected override void OnKeyDown(KeyEventArgs e)
		{
			base.OnKeyDown(e);
			if (e.KeyData == (Keys.Control | Keys.Back))
			{
				e.SuppressKeyPress = true;
				int selStart = SelectionStart;
				while (selStart > 0 && base.Text.Substring(selStart - 1, 1) == " ")
					selStart--;

				int prevSpacePos = -1;
				if (selStart != 0)
					prevSpacePos = base.Text.LastIndexOf(' ', selStart - 1);

				Select(prevSpacePos + 1, SelectionStart - prevSpacePos - 1);
				SelectedText = "";
			}
			else if (e.KeyData == (Keys.Control | Keys.A))
			{
				SelectAll();
			}
		}
	}
}
