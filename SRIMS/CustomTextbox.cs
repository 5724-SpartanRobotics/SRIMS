using System.Drawing;
using System.Windows.Forms;

namespace SRIMS
{
	// Based off of https://stackoverflow.com/a/15232752/5515842
	public partial class SRIMSTextBox : TextBox
	{
		/// <summary>
		/// The text that will be presented as the watermak hint.
		/// </summary>
		private string _watermarkText = "Someone forgot the watermark";

		/// <summary>
		/// Gets or Sets the text that will be presented as the watermak hint.
		/// </summary>
		public string WatermarkText
		{
			get => _watermarkText;
			set
			{
				_watermarkText = value;
				if (_watermarkActive)
					Text = value;
			}
		}

		/// <summary>
		/// Gets or sets the color of the Watermark text.
		/// </summary>
		public Color WatermarkColor
		{
			get
			{
				return _watermarkColor;
			}
			set
			{
				_watermarkColor = value;
				if (_watermarkActive)
					base.ForeColor = _watermarkColor;
			}
		}

		private Color _originalColor = Color.Black;
		private Color _watermarkColor = Color.Gray;

		public override Color ForeColor
		{
			get
			{
				return base.ForeColor;
			}
			set
			{
				_originalColor = value;
				if (!_watermarkActive)
					base.ForeColor = value;
			}
		}

		/// <summary>
		/// Whether watermark effect is enabled or not.
		/// </summary>
		private bool _watermarkActive = true;

		/// <summary>
		/// Gets or Sets whether watermark effect is enabled or not.
		/// </summary>
		public bool WatermarkActive
		{
			get => _watermarkActive;
			set => _watermarkActive = value;
		}

		/// <summary>
		/// Create a new TextBox that supports watermak hint.
		/// </summary>
		public SRIMSTextBox()
		{
			_watermarkActive = true;
			Text = _watermarkText;
			base.ForeColor = WatermarkColor;

			GotFocus += (source, e) =>
			{
				RemoveWatermak();
			};

			LostFocus += (source, e) =>
			{
				ApplyWatermark();
			};
		}

		/// <summary>
		/// Remove watermark from the textbox
		/// </summary>
		public void RemoveWatermak()
		{
			if (_watermarkActive)
			{
				_watermarkActive = false;
				Text = "";
				base.ForeColor = _originalColor;
			}
		}

		/// <summary>
		/// Applywatermark immediately
		/// </summary>
		public void ApplyWatermark()
		{
			if (!_watermarkActive && string.IsNullOrEmpty(Text) || ForeColor == WatermarkColor)
			{
				_watermarkActive = true;
				Text = _watermarkText;
				base.ForeColor = WatermarkColor;
			}
		}

		/// <summary>
		/// Apply watermak to the textbox. 
		/// </summary>
		/// <param name="newText">Text to apply</param>
		public void ApplyWatermark(string newText)
		{
			WatermarkText = newText;
			ApplyWatermark();
		}

		// Source: https://stackoverflow.com/a/1125081/5515842
		protected override void OnKeyDown(KeyEventArgs e)
		{
			base.OnKeyDown(e);
			if (e.KeyData == (Keys.Control | Keys.Back))
			{
				e.SuppressKeyPress = true;
				int selStart = SelectionStart;
				while (selStart > 0 && Text.Substring(selStart - 1, 1) == " ")
					selStart--;

				int prevSpacePos = -1;
				if (selStart != 0)
					prevSpacePos = Text.LastIndexOf(' ', selStart - 1);

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
