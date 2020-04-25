namespace StoreApp
{
    partial class Form3
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
            this.txtName3 = new System.Windows.Forms.TextBox();
            this.txtSurname3 = new System.Windows.Forms.TextBox();
            this.name3 = new System.Windows.Forms.Label();
            this.surname3 = new System.Windows.Forms.Label();
            this.id3 = new System.Windows.Forms.Label();
            this.phone3 = new System.Windows.Forms.Label();
            this.adress3 = new System.Windows.Forms.Label();
            this.txtId3 = new System.Windows.Forms.TextBox();
            this.txtPhone3 = new System.Windows.Forms.TextBox();
            this.txtAdress3 = new System.Windows.Forms.TextBox();
            this.btnSave3 = new System.Windows.Forms.Button();
            this.btnBack3 = new System.Windows.Forms.Button();
            this.btnExit3 = new System.Windows.Forms.Button();
            this.mail3 = new System.Windows.Forms.Label();
            this.txtMail3 = new System.Windows.Forms.TextBox();
            this.dataGridView_customers = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxId1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_customers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // txtName3
            // 
            this.txtName3.Location = new System.Drawing.Point(172, 84);
            this.txtName3.Name = "txtName3";
            this.txtName3.Size = new System.Drawing.Size(221, 22);
            this.txtName3.TabIndex = 1;
            this.txtName3.TextChanged += new System.EventHandler(this.txtName3_TextChanged);
            // 
            // txtSurname3
            // 
            this.txtSurname3.AcceptsReturn = true;
            this.txtSurname3.Location = new System.Drawing.Point(173, 137);
            this.txtSurname3.Name = "txtSurname3";
            this.txtSurname3.Size = new System.Drawing.Size(221, 22);
            this.txtSurname3.TabIndex = 2;
            // 
            // name3
            // 
            this.name3.AutoSize = true;
            this.name3.Location = new System.Drawing.Point(40, 87);
            this.name3.Name = "name3";
            this.name3.Size = new System.Drawing.Size(45, 17);
            this.name3.TabIndex = 3;
            this.name3.Text = "Name";
            this.name3.Click += new System.EventHandler(this.label2_Click);
            // 
            // surname3
            // 
            this.surname3.AutoSize = true;
            this.surname3.Location = new System.Drawing.Point(41, 140);
            this.surname3.Name = "surname3";
            this.surname3.Size = new System.Drawing.Size(65, 17);
            this.surname3.TabIndex = 4;
            this.surname3.Text = "Surname";
            // 
            // id3
            // 
            this.id3.AutoSize = true;
            this.id3.Location = new System.Drawing.Point(41, 207);
            this.id3.Name = "id3";
            this.id3.Size = new System.Drawing.Size(115, 17);
            this.id3.TabIndex = 5;
            this.id3.Text = " \tIdentity Number ";
            // 
            // phone3
            // 
            this.phone3.AutoSize = true;
            this.phone3.Location = new System.Drawing.Point(41, 276);
            this.phone3.Name = "phone3";
            this.phone3.Size = new System.Drawing.Size(103, 17);
            this.phone3.TabIndex = 6;
            this.phone3.Text = "Phone Number";
            // 
            // adress3
            // 
            this.adress3.AutoSize = true;
            this.adress3.Location = new System.Drawing.Point(41, 346);
            this.adress3.Name = "adress3";
            this.adress3.Size = new System.Drawing.Size(52, 17);
            this.adress3.TabIndex = 7;
            this.adress3.Text = "Adress";
            // 
            // txtId3
            // 
            this.txtId3.Location = new System.Drawing.Point(173, 204);
            this.txtId3.Name = "txtId3";
            this.txtId3.Size = new System.Drawing.Size(221, 22);
            this.txtId3.TabIndex = 8;
            // 
            // txtPhone3
            // 
            this.txtPhone3.Location = new System.Drawing.Point(173, 273);
            this.txtPhone3.Name = "txtPhone3";
            this.txtPhone3.Size = new System.Drawing.Size(221, 22);
            this.txtPhone3.TabIndex = 9;
            // 
            // txtAdress3
            // 
            this.txtAdress3.Location = new System.Drawing.Point(173, 343);
            this.txtAdress3.Name = "txtAdress3";
            this.txtAdress3.Size = new System.Drawing.Size(221, 22);
            this.txtAdress3.TabIndex = 10;
            // 
            // btnSave3
            // 
            this.btnSave3.Location = new System.Drawing.Point(44, 510);
            this.btnSave3.Name = "btnSave3";
            this.btnSave3.Size = new System.Drawing.Size(100, 59);
            this.btnSave3.TabIndex = 11;
            this.btnSave3.Text = "Insert";
            this.btnSave3.UseVisualStyleBackColor = true;
            this.btnSave3.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBack3
            // 
            this.btnBack3.Location = new System.Drawing.Point(164, 594);
            this.btnBack3.Name = "btnBack3";
            this.btnBack3.Size = new System.Drawing.Size(97, 59);
            this.btnBack3.TabIndex = 12;
            this.btnBack3.Text = "Back";
            this.btnBack3.UseVisualStyleBackColor = true;
            this.btnBack3.Click += new System.EventHandler(this.btnBack3_Click);
            // 
            // btnExit3
            // 
            this.btnExit3.Location = new System.Drawing.Point(284, 594);
            this.btnExit3.Name = "btnExit3";
            this.btnExit3.Size = new System.Drawing.Size(95, 59);
            this.btnExit3.TabIndex = 13;
            this.btnExit3.Text = "Exit";
            this.btnExit3.UseVisualStyleBackColor = true;
            // 
            // mail3
            // 
            this.mail3.AutoSize = true;
            this.mail3.Location = new System.Drawing.Point(41, 414);
            this.mail3.Name = "mail3";
            this.mail3.Size = new System.Drawing.Size(33, 17);
            this.mail3.TabIndex = 14;
            this.mail3.Text = "Mail";
            // 
            // txtMail3
            // 
            this.txtMail3.Location = new System.Drawing.Point(177, 411);
            this.txtMail3.Name = "txtMail3";
            this.txtMail3.Size = new System.Drawing.Size(214, 22);
            this.txtMail3.TabIndex = 15;
            // 
            // dataGridView_customers
            // 
            this.dataGridView_customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_customers.Location = new System.Drawing.Point(460, 36);
            this.dataGridView_customers.Name = "dataGridView_customers";
            this.dataGridView_customers.RowHeadersWidth = 51;
            this.dataGridView_customers.RowTemplate.Height = 24;
            this.dataGridView_customers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_customers.Size = new System.Drawing.Size(694, 693);
            this.dataGridView_customers.TabIndex = 16;
            this.dataGridView_customers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_customers_CellContentClick);
            this.dataGridView_customers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_customers_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Id";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // textBoxId1
            // 
            this.textBoxId1.Location = new System.Drawing.Point(173, 33);
            this.textBoxId1.Name = "textBoxId1";
            this.textBoxId1.Size = new System.Drawing.Size(221, 22);
            this.textBoxId1.TabIndex = 18;
            this.textBoxId1.TextChanged += new System.EventHandler(this.textBoxId1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 510);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 59);
            this.button1.TabIndex = 19;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(284, 510);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 59);
            this.button2.TabIndex = 20;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(44, 594);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 59);
            this.button3.TabIndex = 21;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 753);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxId1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView_customers);
            this.Controls.Add(this.txtMail3);
            this.Controls.Add(this.mail3);
            this.Controls.Add(this.btnExit3);
            this.Controls.Add(this.btnBack3);
            this.Controls.Add(this.btnSave3);
            this.Controls.Add(this.txtAdress3);
            this.Controls.Add(this.txtPhone3);
            this.Controls.Add(this.txtId3);
            this.Controls.Add(this.adress3);
            this.Controls.Add(this.phone3);
            this.Controls.Add(this.id3);
            this.Controls.Add(this.surname3);
            this.Controls.Add(this.name3);
            this.Controls.Add(this.txtSurname3);
            this.Controls.Add(this.txtName3);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_customers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName3;
        private System.Windows.Forms.TextBox txtSurname3;
        private System.Windows.Forms.Label name3;
        private System.Windows.Forms.Label surname3;
        private System.Windows.Forms.Label id3;
        private System.Windows.Forms.Label phone3;
        private System.Windows.Forms.Label adress3;
        private System.Windows.Forms.TextBox txtId3;
        private System.Windows.Forms.TextBox txtPhone3;
        private System.Windows.Forms.TextBox txtAdress3;
        private System.Windows.Forms.Button btnSave3;
        private System.Windows.Forms.Button btnBack3;
        private System.Windows.Forms.Button btnExit3;
        private System.Windows.Forms.Label mail3;
        private System.Windows.Forms.TextBox txtMail3;
        private System.Windows.Forms.DataGridView dataGridView_customers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxId1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}