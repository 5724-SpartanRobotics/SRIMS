using System;
using System.Drawing;

namespace SRIMS
{
	class WatermarkTextbox : SRIMSTextBox
	{
		private string _watermarkText = "Someone forgot the watermark";

		/// <summary>
		/// Gets or sets the text that will be presented as the watermak hint.
		/// </summary>
		public string WatermarkText
		{
			get { return _watermarkText; }
			set
			{
				_watermarkText = value;
				RemoveWatermark();
				ApplyWatermark();
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
			if (_watermarkOn)
			{
				_watermarkOn = false;
				Text = string.Empty;
			}
			ForeColor = OriginalColor;
		}

		/// <summary>
		/// Applywatermark immediately
		/// </summary>
		public void ApplyWatermark()
		{
			if (!_watermarkOn && string.IsNullOrEmpty(Text) || ForeColor == WatermarkColor)
			{
				_watermarkOn = true;
				Text = WatermarkText;
				ForeColor = WatermarkColor;
			}
		}

		private bool _watermarkOn;

		public WatermarkTextbox()
		{
			_watermarkOn = false;
			ApplyWatermark();
			GotFocus += GotFocusListener;
			LostFocus += LostFocusListener;
		}
	}
}
