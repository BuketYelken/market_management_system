namespace StoreApp
{
    partial class Form4
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
            this.btnSorting4 = new System.Windows.Forms.ComboBox();
            this.btnSearch4 = new System.Windows.Forms.Button();
            this.dataGridView1_product = new System.Windows.Forms.DataGridView();
            this.btnAdd4 = new System.Windows.Forms.Button();
            this.btnDelete4 = new System.Windows.Forms.Button();
            this.btnUpdate4 = new System.Windows.Forms.Button();
            this.btnBack4 = new System.Windows.Forms.Button();
            this.btnExit4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxNumber4 = new System.Windows.Forms.TextBox();
            this.textBoxCompany4 = new System.Windows.Forms.TextBox();
            this.textBoxBuy4 = new System.Windows.Forms.TextBox();
            this.textBoxCategory4 = new System.Windows.Forms.TextBox();
            this.textBoxBarcode4 = new System.Windows.Forms.TextBox();
            this.textBoxId4 = new System.Windows.Forms.TextBox();
            this.textBoxProduct4 = new System.Windows.Forms.TextBox();
            this.textBoxSale4 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_product)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSorting4
            // 
            this.btnSorting4.FormattingEnabled = true;
            this.btnSorting4.Location = new System.Drawing.Point(820, 25);
            this.btnSorting4.Name = "btnSorting4";
            this.btnSorting4.Size = new System.Drawing.Size(198, 24);
            this.btnSorting4.TabIndex = 0;
            // 
            // btnSearch4
            // 
            this.btnSearch4.Location = new System.Drawing.Point(204, 673);
            this.btnSearch4.Name = "btnSearch4";
            this.btnSearch4.Size = new System.Drawing.Size(133, 57);
            this.btnSearch4.TabIndex = 2;
            this.btnSearch4.Text = "Search ";
            this.btnSearch4.UseVisualStyleBackColor = true;
            this.btnSearch4.Click += new System.EventHandler(this.btnSearchit4_Click);
            // 
            // dataGridView1_product
            // 
            this.dataGridView1_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_product.Location = new System.Drawing.Point(398, 65);
            this.dataGridView1_product.Name = "dataGridView1_product";
            this.dataGridView1_product.RowHeadersWidth = 51;
            this.dataGridView1_product.RowTemplate.Height = 24;
            this.dataGridView1_product.Size = new System.Drawing.Size(620, 617);
            this.dataGridView1_product.TabIndex = 3;
            this.dataGridView1_product.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1_product.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_product_MouseClick);
            // 
            // btnAdd4
            // 
            this.btnAdd4.Location = new System.Drawing.Point(59, 593);
            this.btnAdd4.Name = "btnAdd4";
            this.btnAdd4.Size = new System.Drawing.Size(121, 50);
            this.btnAdd4.TabIndex = 4;
            this.btnAdd4.Text = "Insert";
            this.btnAdd4.UseVisualStyleBackColor = true;
            this.btnAdd4.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDelete4
            // 
            this.btnDelete4.Location = new System.Drawing.Point(204, 593);
            this.btnDelete4.Name = "btnDelete4";
            this.btnDelete4.Size = new System.Drawing.Size(133, 50);
            this.btnDelete4.TabIndex = 5;
            this.btnDelete4.Text = "Delete";
            this.btnDelete4.UseVisualStyleBackColor = true;
            this.btnDelete4.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnUpdate4
            // 
            this.btnUpdate4.Location = new System.Drawing.Point(59, 673);
            this.btnUpdate4.Name = "btnUpdate4";
            this.btnUpdate4.Size = new System.Drawing.Size(121, 54);
            this.btnUpdate4.TabIndex = 6;
            this.btnUpdate4.Text = "Update";
            this.btnUpdate4.UseVisualStyleBackColor = true;
            this.btnUpdate4.Click += new System.EventHandler(this.btnUpdate4_Click);
            // 
            // btnBack4
            // 
            this.btnBack4.Location = new System.Drawing.Point(786, 692);
            this.btnBack4.Name = "btnBack4";
            this.btnBack4.Size = new System.Drawing.Size(97, 55);
            this.btnBack4.TabIndex = 7;
            this.btnBack4.Text = "Back";
            this.btnBack4.UseVisualStyleBackColor = true;
            this.btnBack4.Click += new System.EventHandler(this.btnBack4_Click);
            // 
            // btnExit4
            // 
            this.btnExit4.Location = new System.Drawing.Point(920, 692);
            this.btnExit4.Name = "btnExit4";
            this.btnExit4.Size = new System.Drawing.Size(98, 55);
            this.btnExit4.TabIndex = 8;
            this.btnExit4.Text = "Exit";
            this.btnExit4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Barcode Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Product Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Company Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 454);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Buying Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 523);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Sale Price";
            // 
            // textBoxNumber4
            // 
            this.textBoxNumber4.Location = new System.Drawing.Point(170, 235);
            this.textBoxNumber4.Name = "textBoxNumber4";
            this.textBoxNumber4.Size = new System.Drawing.Size(204, 22);
            this.textBoxNumber4.TabIndex = 17;
            // 
            // textBoxCompany4
            // 
            this.textBoxCompany4.Location = new System.Drawing.Point(170, 369);
            this.textBoxCompany4.Name = "textBoxCompany4";
            this.textBoxCompany4.Size = new System.Drawing.Size(204, 22);
            this.textBoxCompany4.TabIndex = 18;
            // 
            // textBoxBuy4
            // 
            this.textBoxBuy4.Location = new System.Drawing.Point(170, 451);
            this.textBoxBuy4.Name = "textBoxBuy4";
            this.textBoxBuy4.Size = new System.Drawing.Size(204, 22);
            this.textBoxBuy4.TabIndex = 20;
            // 
            // textBoxCategory4
            // 
            this.textBoxCategory4.Location = new System.Drawing.Point(170, 300);
            this.textBoxCategory4.Multiline = true;
            this.textBoxCategory4.Name = "textBoxCategory4";
            this.textBoxCategory4.Size = new System.Drawing.Size(204, 22);
            this.textBoxCategory4.TabIndex = 21;
            // 
            // textBoxBarcode4
            // 
            this.textBoxBarcode4.Location = new System.Drawing.Point(170, 89);
            this.textBoxBarcode4.Name = "textBoxBarcode4";
            this.textBoxBarcode4.Size = new System.Drawing.Size(204, 22);
            this.textBoxBarcode4.TabIndex = 22;
            // 
            // textBoxId4
            // 
            this.textBoxId4.Location = new System.Drawing.Point(170, 22);
            this.textBoxId4.Name = "textBoxId4";
            this.textBoxId4.Size = new System.Drawing.Size(204, 22);
            this.textBoxId4.TabIndex = 23;
            // 
            // textBoxProduct4
            // 
            this.textBoxProduct4.Location = new System.Drawing.Point(170, 162);
            this.textBoxProduct4.Name = "textBoxProduct4";
            this.textBoxProduct4.Size = new System.Drawing.Size(204, 22);
            this.textBoxProduct4.TabIndex = 24;
            // 
            // textBoxSale4
            // 
            this.textBoxSale4.Location = new System.Drawing.Point(170, 520);
            this.textBoxSale4.Name = "textBoxSale4";
            this.textBoxSale4.Size = new System.Drawing.Size(204, 22);
            this.textBoxSale4.TabIndex = 26;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 774);
            this.Controls.Add(this.textBoxSale4);
            this.Controls.Add(this.textBoxProduct4);
            this.Controls.Add(this.textBoxId4);
            this.Controls.Add(this.textBoxBarcode4);
            this.Controls.Add(this.textBoxCategory4);
            this.Controls.Add(this.textBoxBuy4);
            this.Controls.Add(this.textBoxCompany4);
            this.Controls.Add(this.textBoxNumber4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit4);
            this.Controls.Add(this.btnBack4);
            this.Controls.Add(this.btnUpdate4);
            this.Controls.Add(this.btnDelete4);
            this.Controls.Add(this.btnAdd4);
            this.Controls.Add(this.dataGridView1_product);
            this.Controls.Add(this.btnSearch4);
            this.Controls.Add(this.btnSorting4);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox btnSorting4;
        private System.Windows.Forms.Button btnSearch4;
        private System.Windows.Forms.DataGridView dataGridView1_product;
        private System.Windows.Forms.Button btnAdd4;
        private System.Windows.Forms.Button btnDelete4;
        private System.Windows.Forms.Button btnUpdate4;
        private System.Windows.Forms.Button btnBack4;
        private System.Windows.Forms.Button btnExit4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxNumber4;
        private System.Windows.Forms.TextBox textBoxCompany4;
        private System.Windows.Forms.TextBox textBoxBuy4;
        private System.Windows.Forms.TextBox textBoxCategory4;
        private System.Windows.Forms.TextBox textBoxBarcode4;
        private System.Windows.Forms.TextBox textBoxId4;
        private System.Windows.Forms.TextBox textBoxProduct4;
        private System.Windows.Forms.TextBox textBoxSale4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}