namespace SRIMS
{
    partial class AddItem
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
			this._ComboBoxCategory = new System.Windows.Forms.ComboBox();
			this.Quantity = new System.Windows.Forms.NumericUpDown();
			this.Submit = new System.Windows.Forms.Button();
			this._LabelSuccess = new System.Windows.Forms.Label();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.Description = new SRIMS.WatermarkTextbox();
			this.ItemLocation = new SRIMS.WatermarkTextbox();
			this.ItemName = new SRIMS.WatermarkTextbox();
			((System.ComponentModel.ISupportInitialize)(this.Quantity)).BeginInit();
			this.SuspendLayout();
			// 
			// _ComboBoxCategory
			// 
			this._ComboBoxCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
			this._ComboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._ComboBoxCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._ComboBoxCategory.FormattingEnabled = true;
			this._ComboBoxCategory.Location = new System.Drawing.Point(199, 94);
			this._ComboBoxCategory.Name = "_ComboBoxCategory";
			this._ComboBoxCategory.Size = new System.Drawing.Size(223, 29);
			this._ComboBoxCategory.TabIndex = 8;
			// 
			// Quantity
			// 
			this.Quantity.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Quantity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Quantity.Location = new System.Drawing.Point(199, 345);
			this.Quantity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.Quantity.Name = "Quantity";
			this.Quantity.Size = new System.Drawing.Size(223, 27);
			this.Quantity.TabIndex = 11;
			// 
			// Submit
			// 
			this.Submit.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.Submit.FlatAppearance.BorderSize = 0;
			this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Submit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Submit.ForeColor = System.Drawing.Color.White;
			this.Submit.Location = new System.Drawing.Point(199, 380);
			this.Submit.Name = "Submit";
			this.Submit.Size = new System.Drawing.Size(223, 55);
			this.Submit.TabIndex = 12;
			this.Submit.Text = "Add Item";
			this.Submit.UseVisualStyleBackColor = false;
			this.Submit.Click += new System.EventHandler(this.Submit_Click);
			// 
			// _LabelSuccess
			// 
			this._LabelSuccess.Anchor = System.Windows.Forms.AnchorStyles.None;
			this._LabelSuccess.AutoSize = true;
			this._LabelSuccess.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._LabelSuccess.Location = new System.Drawing.Point(215, 443);
			this._LabelSuccess.Name = "_LabelSuccess";
			this._LabelSuccess.Size = new System.Drawing.Size(200, 21);
			this._LabelSuccess.TabIndex = 4;
			this._LabelSuccess.Text = "Item Added Successfully";
			this._LabelSuccess.Visible = false;
			// 
			// Description
			// 
			this.Description.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Description.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.Description.ForeColor = System.Drawing.Color.Black;
			this.Description.Location = new System.Drawing.Point(199, 166);
			this.Description.Multiline = true;
			this.Description.Name = "Description";
			this.Description.OriginalColor = System.Drawing.Color.Black;
			this.Description.Size = new System.Drawing.Size(223, 173);
			this.Description.TabIndex = 10;
			this.Description.Text = "Item Description";
			this.Description.WatermarkColor = System.Drawing.Color.Gray;
			this.Description.WatermarkText = "Item Description";
			this.Description.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Description_KeyPress);
			// 
			// ItemLocation
			// 
			this.ItemLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ItemLocation.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.ItemLocation.ForeColor = System.Drawing.Color.Black;
			this.ItemLocation.Location = new System.Drawing.Point(199, 131);
			this.ItemLocation.Name = "ItemLocation";
			this.ItemLocation.OriginalColor = System.Drawing.Color.Black;
			this.ItemLocation.Size = new System.Drawing.Size(223, 27);
			this.ItemLocation.TabIndex = 9;
			this.ItemLocation.Text = "Location";
			this.ItemLocation.WatermarkColor = System.Drawing.Color.Gray;
			this.ItemLocation.WatermarkText = "Location";
			// 
			// ItemName
			// 
			this.ItemName.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ItemName.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.ItemName.ForeColor = System.Drawing.Color.Black;
			this.ItemName.Location = new System.Drawing.Point(199, 59);
			this.ItemName.Name = "ItemName";
			this.ItemName.OriginalColor = System.Drawing.Color.Black;
			this.ItemName.Size = new System.Drawing.Size(223, 27);
			this.ItemName.TabIndex = 7;
			this.ItemName.Text = "Item Name";
			this.ItemName.WatermarkColor = System.Drawing.Color.Gray;
			this.ItemName.WatermarkText = "Item Name";
			// 
			// AddItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.Description);
			this.Controls.Add(this.ItemLocation);
			this.Controls.Add(this.ItemName);
			this.Controls.Add(this._LabelSuccess);
			this.Controls.Add(this.Submit);
			this.Controls.Add(this.Quantity);
			this.Controls.Add(this._ComboBoxCategory);
			this.Name = "AddItem";
			this.Size = new System.Drawing.Size(630, 526);
			((System.ComponentModel.ISupportInitialize)(this.Quantity)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox _ComboBoxCategory;
        private System.Windows.Forms.NumericUpDown Quantity;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label _LabelSuccess;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private WatermarkTextbox ItemName;
		private WatermarkTextbox ItemLocation;
		private WatermarkTextbox Description;
	}
}
