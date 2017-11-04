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
            this.ItemName = new System.Windows.Forms.TextBox();
            this.Category = new System.Windows.Forms.ComboBox();
            this.Description = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.NumericUpDown();
            this.Submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ItemLocation = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemName
            // 
            this.ItemName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemName.Location = new System.Drawing.Point(199, 59);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(223, 27);
            this.ItemName.TabIndex = 0;
            this.ItemName.Text = "Item Name";
            // 
            // Category
            // 
            this.Category.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category.FormattingEnabled = true;
            this.Category.Items.AddRange(new object[] {
            "Mechanical",
            "Electrical",
            "Programming",
            "Misc"});
            this.Category.Location = new System.Drawing.Point(199, 94);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(223, 29);
            this.Category.TabIndex = 1;
            this.Category.Text = "Choose Category";
            this.Category.SelectedIndexChanged += new System.EventHandler(this.Category_SelectedIndexChanged);
            // 
            // Description
            // 
            this.Description.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(199, 166);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(223, 171);
            this.Description.TabIndex = 0;
            this.Description.Text = "Item Description";
            // 
            // Quantity
            // 
            this.Quantity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.Location = new System.Drawing.Point(199, 345);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(223, 27);
            this.Quantity.TabIndex = 2;
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Submit.FlatAppearance.BorderSize = 0;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.ForeColor = System.Drawing.Color.White;
            this.Submit.Location = new System.Drawing.Point(199, 380);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(223, 55);
            this.Submit.TabIndex = 3;
            this.Submit.Text = "Add Item";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 443);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Item Added Sucessfully";
            this.label1.Visible = false;
            // 
            // ItemLocation
            // 
            this.ItemLocation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemLocation.Location = new System.Drawing.Point(199, 131);
            this.ItemLocation.Name = "ItemLocation";
            this.ItemLocation.Size = new System.Drawing.Size(223, 27);
            this.ItemLocation.TabIndex = 5;
            this.ItemLocation.Text = "Location";
            this.ItemLocation.TextChanged += new System.EventHandler(this.ItemLocation_TextChanged);
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ItemLocation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.ItemName);
            this.Name = "AddItem";
            this.Size = new System.Drawing.Size(630, 526);
            ((System.ComponentModel.ISupportInitialize)(this.Quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ItemName;
        private System.Windows.Forms.ComboBox Category;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.NumericUpDown Quantity;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox ItemLocation;
    }
}
