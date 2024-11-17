namespace Inventory
{
    partial class frmAddProduct
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnAddProduct = new Button();
            txtProductName = new TextBox();
            txtQuantity = new TextBox();
            txtSellPrice = new TextBox();
            cbCategory = new ComboBox();
            dtPickerMfgDate = new DateTimePicker();
            dtPickerExpDate = new DateTimePicker();
            richTxtDescription = new RichTextBox();
            gridViewProductList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 9);
            label1.Name = "label1";
            label1.Size = new Size(133, 26);
            label1.TabIndex = 0;
            label1.Text = "Add Product";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(58, 57);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 1;
            label2.Text = "Product";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(58, 95);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 2;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(53, 137);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 3;
            label4.Text = "Mfg. Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(53, 174);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 4;
            label5.Text = "Exp. Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(58, 213);
            label6.Name = "label6";
            label6.Size = new Size(40, 20);
            label6.TabIndex = 5;
            label6.Text = "Qty.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(53, 252);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 6;
            label7.Text = "Sell Price";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(437, 78);
            label8.Name = "label8";
            label8.Size = new Size(92, 20);
            label8.TabIndex = 7;
            label8.Text = "Description";
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = SystemColors.ButtonFace;
            btnAddProduct.Location = new Point(608, 252);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(132, 35);
            btnAddProduct.TabIndex = 8;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // txtProductName
            // 
            txtProductName.BackColor = SystemColors.ButtonHighlight;
            txtProductName.Location = new Point(173, 57);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(200, 23);
            txtProductName.TabIndex = 9;
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = SystemColors.ButtonHighlight;
            txtQuantity.Location = new Point(173, 214);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(200, 23);
            txtQuantity.TabIndex = 10;
            // 
            // txtSellPrice
            // 
            txtSellPrice.BackColor = SystemColors.ButtonHighlight;
            txtSellPrice.Location = new Point(173, 253);
            txtSellPrice.Name = "txtSellPrice";
            txtSellPrice.Size = new Size(200, 23);
            txtSellPrice.TabIndex = 11;
            // 
            // cbCategory
            // 
            cbCategory.BackColor = SystemColors.ButtonHighlight;
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(173, 96);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(200, 23);
            cbCategory.TabIndex = 12;
            // 
            // dtPickerMfgDate
            // 
            dtPickerMfgDate.CalendarForeColor = SystemColors.Menu;
            dtPickerMfgDate.CalendarMonthBackground = SystemColors.Menu;
            dtPickerMfgDate.CalendarTitleBackColor = SystemColors.Menu;
            dtPickerMfgDate.CalendarTitleForeColor = SystemColors.Menu;
            dtPickerMfgDate.CalendarTrailingForeColor = SystemColors.Menu;
            dtPickerMfgDate.Location = new Point(173, 137);
            dtPickerMfgDate.Name = "dtPickerMfgDate";
            dtPickerMfgDate.Size = new Size(200, 23);
            dtPickerMfgDate.TabIndex = 13;
            dtPickerMfgDate.Value = new DateTime(2024, 11, 17, 13, 29, 26, 0);
            // 
            // dtPickerExpDate
            // 
            dtPickerExpDate.CalendarForeColor = SystemColors.Menu;
            dtPickerExpDate.CalendarMonthBackground = SystemColors.Menu;
            dtPickerExpDate.CalendarTitleBackColor = SystemColors.Menu;
            dtPickerExpDate.CalendarTitleForeColor = SystemColors.Menu;
            dtPickerExpDate.CalendarTrailingForeColor = SystemColors.Menu;
            dtPickerExpDate.Location = new Point(173, 174);
            dtPickerExpDate.Name = "dtPickerExpDate";
            dtPickerExpDate.Size = new Size(200, 23);
            dtPickerExpDate.TabIndex = 14;
            dtPickerExpDate.Value = new DateTime(2024, 11, 17, 13, 29, 41, 0);
            // 
            // richTxtDescription
            // 
            richTxtDescription.BackColor = SystemColors.Info;
            richTxtDescription.Location = new Point(437, 111);
            richTxtDescription.Name = "richTxtDescription";
            richTxtDescription.Size = new Size(303, 126);
            richTxtDescription.TabIndex = 15;
            richTxtDescription.Text = "";
            // 
            // gridViewProductList
            // 
            gridViewProductList.BackgroundColor = SystemColors.Info;
            gridViewProductList.BorderStyle = BorderStyle.Fixed3D;
            gridViewProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewProductList.Location = new Point(58, 293);
            gridViewProductList.Name = "gridViewProductList";
            gridViewProductList.Size = new Size(682, 145);
            gridViewProductList.TabIndex = 16;
            // 
            // frmAddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(gridViewProductList);
            Controls.Add(richTxtDescription);
            Controls.Add(dtPickerExpDate);
            Controls.Add(dtPickerMfgDate);
            Controls.Add(cbCategory);
            Controls.Add(txtSellPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtProductName);
            Controls.Add(btnAddProduct);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAddProduct";
            Text = "Inventory";
            Load += frmAddProduct_Load;
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnAddProduct;
        private TextBox txtProductName;
        private TextBox txtQuantity;
        private TextBox txtSellPrice;
        private ComboBox cbCategory;
        private DateTimePicker dtPickerMfgDate;
        private DateTimePicker dtPickerExpDate;
        private RichTextBox richTxtDescription;
        private DataGridView gridViewProductList;
    }
}
