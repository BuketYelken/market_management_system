namespace StoreApp
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnExit1 = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.sellinglist1 = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.SlateBlue;
            this.btnCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomer.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCustomer.Location = new System.Drawing.Point(26, 40);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(142, 73);
            this.btnCustomer.TabIndex = 0;
            this.btnCustomer.Text = "Customer Transactions ";
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.SlateBlue;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProduct.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProduct.Location = new System.Drawing.Point(188, 41);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(142, 71);
            this.btnProduct.TabIndex = 1;
            this.btnProduct.Text = "Product Transactions ";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnSale
            // 
            this.btnSale.BackColor = System.Drawing.SystemColors.Control;
            this.btnSale.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSale.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSale.Location = new System.Drawing.Point(369, 39);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(142, 73);
            this.btnSale.TabIndex = 4;
            this.btnSale.Text = "Sale Transactions ";
            this.btnSale.UseVisualStyleBackColor = false;
            this.btnSale.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnExit1
            // 
            this.btnExit1.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit1.Location = new System.Drawing.Point(563, 42);
            this.btnExit1.Name = "btnExit1";
            this.btnExit1.Size = new System.Drawing.Size(144, 71);
            this.btnExit1.TabIndex = 6;
            this.btnExit1.Text = "Exit";
            this.btnExit1.UseVisualStyleBackColor = false;
            this.btnExit1.Click += new System.EventHandler(this.button7_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.Color.PeachPuff;
            this.dataGridView.Location = new System.Drawing.Point(12, 200);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1072, 525);
            this.dataGridView.TabIndex = 7;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // sellinglist1
            // 
            this.sellinglist1.AutoSize = true;
            this.sellinglist1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sellinglist1.Location = new System.Drawing.Point(7, 145);
            this.sellinglist1.Name = "sellinglist1";
            this.sellinglist1.Size = new System.Drawing.Size(106, 25);
            this.sellinglist1.TabIndex = 8;
            this.sellinglist1.Text = "Selling List";
            // 
            // date1
            // 
            this.date1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.date1.Location = new System.Drawing.Point(126, 144);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(266, 26);
            this.date1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1096, 737);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.sellinglist1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnExit1);
            this.Controls.Add(this.btnSale);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btnCustomer);
            this.Name = "Form1";
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnExit1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label sellinglist1;
        private System.Windows.Forms.DateTimePicker date1;
    }
}

