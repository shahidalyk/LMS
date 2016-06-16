namespace Add_New_Books
{
    partial class Add_book
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelIsbn = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.txtAvailableQty = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtEdition = new System.Windows.Forms.TextBox();
            this.labelAvailableQty = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelEdition = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Add_New_Books.Properties.Resources.images;
            this.button1.Location = new System.Drawing.Point(250, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Add_New_Books.Properties.Resources.images;
            this.button2.Location = new System.Drawing.Point(142, 462);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(182, 115);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(143, 20);
            this.txtAuthor.TabIndex = 16;
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(182, 52);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(143, 20);
            this.txtIsbn.TabIndex = 15;
            this.txtIsbn.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(182, 85);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(143, 20);
            this.txtTitle.TabIndex = 14;
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(45, 118);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(44, 13);
            this.labelAuthor.TabIndex = 13;
            this.labelAuthor.Text = "Author :";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(45, 85);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(69, 13);
            this.labelTitle.TabIndex = 12;
            this.labelTitle.Text = "Book Name :";
            this.labelTitle.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelIsbn
            // 
            this.labelIsbn.AutoSize = true;
            this.labelIsbn.Location = new System.Drawing.Point(45, 52);
            this.labelIsbn.Name = "labelIsbn";
            this.labelIsbn.Size = new System.Drawing.Size(61, 13);
            this.labelIsbn.TabIndex = 11;
            this.labelIsbn.Text = "Book Isbn :";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(182, 247);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(143, 20);
            this.txtPrice.TabIndex = 27;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(45, 250);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(37, 13);
            this.labelPrice.TabIndex = 26;
            this.labelPrice.Text = "Price :";
            // 
            // txtAvailableQty
            // 
            this.txtAvailableQty.Location = new System.Drawing.Point(182, 214);
            this.txtAvailableQty.Name = "txtAvailableQty";
            this.txtAvailableQty.Size = new System.Drawing.Size(143, 20);
            this.txtAvailableQty.TabIndex = 25;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(182, 181);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(143, 20);
            this.txtCategory.TabIndex = 24;
            // 
            // txtEdition
            // 
            this.txtEdition.Location = new System.Drawing.Point(182, 148);
            this.txtEdition.Name = "txtEdition";
            this.txtEdition.Size = new System.Drawing.Size(143, 20);
            this.txtEdition.TabIndex = 23;
            // 
            // labelAvailableQty
            // 
            this.labelAvailableQty.AutoSize = true;
            this.labelAvailableQty.Location = new System.Drawing.Point(45, 217);
            this.labelAvailableQty.Name = "labelAvailableQty";
            this.labelAvailableQty.Size = new System.Drawing.Size(98, 13);
            this.labelAvailableQty.TabIndex = 22;
            this.labelAvailableQty.Text = "Available Quantity :";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(45, 184);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(55, 13);
            this.labelCategory.TabIndex = 21;
            this.labelCategory.Text = "Category :";
            // 
            // labelEdition
            // 
            this.labelEdition.AutoSize = true;
            this.labelEdition.Location = new System.Drawing.Point(45, 151);
            this.labelEdition.Name = "labelEdition";
            this.labelEdition.Size = new System.Drawing.Size(45, 13);
            this.labelEdition.TabIndex = 20;
            this.labelEdition.Text = "Edition :";
            // 
            // Add_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Add_New_Books.Properties.Resources.tumblr_m7qwndHc9v1qit6m5o1_400;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(358, 536);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.txtAvailableQty);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtEdition);
            this.Controls.Add(this.labelAvailableQty);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelEdition);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtIsbn);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelIsbn);
            this.Controls.Add(this.button1);
            this.Name = "Add_book";
            this.Text = "Add_book";
            this.Load += new System.EventHandler(this.Add_book_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelIsbn;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox txtAvailableQty;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtEdition;
        private System.Windows.Forms.Label labelAvailableQty;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelEdition;
    }
}