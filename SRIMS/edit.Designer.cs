namespace SRIMS
{
    partial class EditForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.SaveBtn = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.NameTextBox = new SRIMS.SRIMSTextBox();
			this.LocTextBox = new SRIMS.SRIMSTextBox();
			this.DescTextBox = new SRIMS.SRIMSTextBox();
			this._ComboBoxCat = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(36, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(36, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Category";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(36, 130);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 16);
			this.label3.TabIndex = 1;
			this.label3.Text = "Description";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(36, 242);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 16);
			this.label4.TabIndex = 1;
			this.label4.Text = "Quantity";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericUpDown1.Location = new System.Drawing.Point(39, 261);
			this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(121, 21);
			this.numericUpDown1.TabIndex = 4;
			// 
			// SaveBtn
			// 
			this.SaveBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SaveBtn.Location = new System.Drawing.Point(39, 288);
			this.SaveBtn.Name = "SaveBtn";
			this.SaveBtn.Size = new System.Drawing.Size(121, 23);
			this.SaveBtn.TabIndex = 5;
			this.SaveBtn.Text = "Save Changes";
			this.SaveBtn.UseVisualStyleBackColor = true;
			this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(36, 87);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 16);
			this.label5.TabIndex = 1;
			this.label5.Text = "Location";
			// 
			// NameTextBox
			// 
			this.NameTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F);
			this.NameTextBox.ForeColor = System.Drawing.Color.Black;
			this.NameTextBox.Location = new System.Drawing.Point(39, 23);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(121, 21);
			this.NameTextBox.TabIndex = 6;
			// 
			// LocTextBox
			// 
			this.LocTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F);
			this.LocTextBox.ForeColor = System.Drawing.Color.Black;
			this.LocTextBox.Location = new System.Drawing.Point(39, 106);
			this.LocTextBox.Name = "LocTextBox";
			this.LocTextBox.Size = new System.Drawing.Size(121, 21);
			this.LocTextBox.TabIndex = 8;
			// 
			// DescTextBox
			// 
			this.DescTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F);
			this.DescTextBox.ForeColor = System.Drawing.Color.Black;
			this.DescTextBox.Location = new System.Drawing.Point(39, 149);
			this.DescTextBox.Multiline = true;
			this.DescTextBox.Name = "DescTextBox";
			this.DescTextBox.Size = new System.Drawing.Size(121, 90);
			this.DescTextBox.TabIndex = 9;
			this.DescTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DescTextBox_KeyPress);
			// 
			// _ComboBoxCat
			// 
			this._ComboBoxCat.FormattingEnabled = true;
			this._ComboBoxCat.Location = new System.Drawing.Point(39, 63);
			this._ComboBoxCat.Name = "_ComboBoxCat";
			this._ComboBoxCat.Size = new System.Drawing.Size(121, 21);
			this._ComboBoxCat.TabIndex = 10;
			// 
			// EditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(208, 319);
			this.Controls.Add(this._ComboBoxCat);
			this.Controls.Add(this.DescTextBox);
			this.Controls.Add(this.LocTextBox);
			this.Controls.Add(this.NameTextBox);
			this.Controls.Add(this.SaveBtn);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EditForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Edit";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.Edit_Load);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label5;
		private SRIMSTextBox NameTextBox;
		private SRIMSTextBox LocTextBox;
		private SRIMSTextBox DescTextBox;
		private System.Windows.Forms.ComboBox _ComboBoxCat;
	}
}