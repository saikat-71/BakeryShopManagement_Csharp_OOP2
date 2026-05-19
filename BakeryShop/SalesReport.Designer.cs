namespace BakeryShop
{
    partial class SalesReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesReport));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewSalesReport = new System.Windows.Forms.DataGridView();
            this.btnView = new System.Windows.Forms.Button();
            this.textInvoiceno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textOrderdate = new System.Windows.Forms.TextBox();
            this.textCustomername = new System.Windows.Forms.TextBox();
            this.textCustomerphone = new System.Windows.Forms.TextBox();
            this.textTotalamount = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.labe = new System.Windows.Forms.Label();
            this.textCashiername = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalesReport)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MistyRose;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(901, 536);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SeaShell;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label1.Location = new System.Drawing.Point(371, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sales Report";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridViewSalesReport
            // 
            this.dataGridViewSalesReport.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridViewSalesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSalesReport.GridColor = System.Drawing.Color.Black;
            this.dataGridViewSalesReport.Location = new System.Drawing.Point(63, 93);
            this.dataGridViewSalesReport.Name = "dataGridViewSalesReport";
            this.dataGridViewSalesReport.RowHeadersWidth = 51;
            this.dataGridViewSalesReport.RowTemplate.Height = 24;
            this.dataGridViewSalesReport.Size = new System.Drawing.Size(844, 201);
            this.dataGridViewSalesReport.TabIndex = 2;
            this.dataGridViewSalesReport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSalesReport_CellClick);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnView.Location = new System.Drawing.Point(439, 300);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(95, 50);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // textInvoiceno
            // 
            this.textInvoiceno.ForeColor = System.Drawing.Color.Black;
            this.textInvoiceno.Location = new System.Drawing.Point(265, 361);
            this.textInvoiceno.Name = "textInvoiceno";
            this.textInvoiceno.Size = new System.Drawing.Size(206, 22);
            this.textInvoiceno.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MistyRose;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(91, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Invoice No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MistyRose;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(91, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Order Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MistyRose;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(91, 449);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Customer Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MistyRose;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(508, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Customer Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.MistyRose;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Brown;
            this.label6.Location = new System.Drawing.Point(508, 405);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Total Ammount";
            // 
            // textOrderdate
            // 
            this.textOrderdate.ForeColor = System.Drawing.Color.Black;
            this.textOrderdate.Location = new System.Drawing.Point(265, 405);
            this.textOrderdate.Name = "textOrderdate";
            this.textOrderdate.Size = new System.Drawing.Size(206, 22);
            this.textOrderdate.TabIndex = 10;
            // 
            // textCustomername
            // 
            this.textCustomername.ForeColor = System.Drawing.Color.Black;
            this.textCustomername.Location = new System.Drawing.Point(265, 447);
            this.textCustomername.Name = "textCustomername";
            this.textCustomername.Size = new System.Drawing.Size(206, 22);
            this.textCustomername.TabIndex = 11;
            // 
            // textCustomerphone
            // 
            this.textCustomerphone.ForeColor = System.Drawing.Color.Black;
            this.textCustomerphone.Location = new System.Drawing.Point(664, 363);
            this.textCustomerphone.Name = "textCustomerphone";
            this.textCustomerphone.Size = new System.Drawing.Size(206, 22);
            this.textCustomerphone.TabIndex = 12;
            // 
            // textTotalamount
            // 
            this.textTotalamount.ForeColor = System.Drawing.Color.Black;
            this.textTotalamount.Location = new System.Drawing.Point(664, 405);
            this.textTotalamount.Name = "textTotalamount";
            this.textTotalamount.Size = new System.Drawing.Size(206, 22);
            this.textTotalamount.TabIndex = 13;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(762, 479);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 50);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labe
            // 
            this.labe.AutoSize = true;
            this.labe.BackColor = System.Drawing.Color.MistyRose;
            this.labe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labe.ForeColor = System.Drawing.Color.Brown;
            this.labe.Location = new System.Drawing.Point(511, 449);
            this.labe.Name = "labe";
            this.labe.Size = new System.Drawing.Size(116, 20);
            this.labe.TabIndex = 15;
            this.labe.Text = "Cashier Name";
            // 
            // textCashiername
            // 
            this.textCashiername.ForeColor = System.Drawing.Color.Black;
            this.textCashiername.Location = new System.Drawing.Point(664, 447);
            this.textCashiername.Name = "textCashiername";
            this.textCashiername.Size = new System.Drawing.Size(206, 22);
            this.textCashiername.TabIndex = 16;
            // 
            // SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(970, 610);
            this.Controls.Add(this.textCashiername);
            this.Controls.Add(this.labe);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.textTotalamount);
            this.Controls.Add(this.textCustomerphone);
            this.Controls.Add(this.textCustomername);
            this.Controls.Add(this.textOrderdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textInvoiceno);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.dataGridViewSalesReport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "SalesReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesReport";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalesReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewSalesReport;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.TextBox textInvoiceno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textOrderdate;
        private System.Windows.Forms.TextBox textCustomername;
        private System.Windows.Forms.TextBox textCustomerphone;
        private System.Windows.Forms.TextBox textTotalamount;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labe;
        private System.Windows.Forms.TextBox textCashiername;
    }
}