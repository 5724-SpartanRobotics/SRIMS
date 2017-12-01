using System;
using System.Drawing;

namespace SRIMS
{
	class WatermarkTextbox : SRIMSTextBox
	{
		public bool WatermarkOn { get; private set; }
		private string _WatermarkText = "Someone forgot the watermark";

		/// <summary>
		/// Gets or sets the text that will be presented as the watermak hint.
		/// </summary>
		public string WatermarkText
		{
			get { return _WatermarkText; }
			set
			{
				_WatermarkText = value;
				RemoveWatermark();
				ApplyWatermark();
			}
		}

		public override string Text
		{
			get
			{
				return base.Text;
			}
			set
			{
				base.Text = value;
				if (value == string.Empty && !Focused)
				{
					WatermarkOn = false;
					ApplyWatermark();
				}
			}
		}

		/// <summary>
		/// Gets or sets the color of the watermark text.
		/// </summary>
		public Color WatermarkColor { get; set; } = Color.Gray;

		/// <summary>
		/// Gets or sets the color of the non-watermark text.
		/// </summary>
		public Color OriginalColor { get; set; } = Color.Black;

		private void GotFocusListener(object sender, EventArgs e)
		{
			RemoveWatermark();
		}

		private void LostFocusListener(object sender, EventArgs e)
		{
			ApplyWatermark();
		}

		/// <summary>
		/// Remove watermark from the textbox
		/// </summary>
		public void RemoveWatermark()
		{
			if (WatermarkOn)
			{
				WatermarkOn = false;
				Text = string.Empty;
			}
			ForeColor = OriginalColor;
		}

		/// <summary>
		/// Applywatermark immediately
		/// </summary>
		public void ApplyWatermark()
		{
			if (!WatermarkOn && string.IsNullOrEmpty(Text) || ForeColor == WatermarkColor)
			{
				WatermarkOn = true;
				Text = WatermarkText;
				ForeColor = WatermarkColor;
			}
		}

		public WatermarkTextbox()
		{
			WatermarkOn = false;
			ApplyWatermark();
			GotFocus += GotFocusListener;
			LostFocus += LostFocusListener;
		}
	}
}
