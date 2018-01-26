namespace SRIMS
{
    partial class Checkin
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this._ListBoxCheckout = new System.Windows.Forms.ListBox();
			this._BtnCheckin = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// _ListBoxCheckout
			// 
			this._ListBoxCheckout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._ListBoxCheckout.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._ListBoxCheckout.FormattingEnabled = true;
			this._ListBoxCheckout.ItemHeight = 17;
			this._ListBoxCheckout.Location = new System.Drawing.Point(3, 37);
			this._ListBoxCheckout.Name = "_ListBoxCheckout";
			this._ListBoxCheckout.Size = new System.Drawing.Size(624, 480);
			this._ListBoxCheckout.TabIndex = 0;
			this._ListBoxCheckout.KeyDown += new System.Windows.Forms.KeyEventHandler(this._ListBoxCheckout_KeyDown);
			// 
			// _BtnCheckin
			// 
			this._BtnCheckin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._BtnCheckin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this._BtnCheckin.FlatAppearance.BorderSize = 0;
			this._BtnCheckin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._BtnCheckin.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._BtnCheckin.ForeColor = System.Drawing.Color.White;
			this._BtnCheckin.Location = new System.Drawing.Point(535, 3);
			this._BtnCheckin.Name = "_BtnCheckin";
			this._BtnCheckin.Size = new System.Drawing.Size(92, 28);
			this._BtnCheckin.TabIndex = 1;
			this._BtnCheckin.Text = "Check In";
			this._BtnCheckin.UseVisualStyleBackColor = false;
			this._BtnCheckin.Click += new System.EventHandler(this._BtnCheckin_Click);
			// 
			// Checkin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this._BtnCheckin);
			this.Controls.Add(this._ListBoxCheckout);
			this.Name = "Checkin";
			this.Size = new System.Drawing.Size(630, 526);
			this.Load += new System.EventHandler(this.Checkin_Load);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox _ListBoxCheckout;
        private System.Windows.Forms.Button _BtnCheckin;
	}
}
