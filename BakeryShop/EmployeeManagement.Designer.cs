namespace BakeryShop
{
    partial class EmployeeManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeManagement));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.textRole = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textContact = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textGender = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnViewInfo = new System.Windows.Forms.Button();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(884, 537);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(333, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 40);
            this.label1.TabIndex = 13;
            this.label1.Text = "Employee Information";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(67, 102);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.RowHeadersWidth = 51;
            this.dataGridViewEmployee.RowTemplate.Height = 24;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(836, 153);
            this.dataGridViewEmployee.TabIndex = 12;
            this.dataGridViewEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployee_CellClick);
            // 
            // textRole
            // 
            this.textRole.BackColor = System.Drawing.Color.AliceBlue;
            this.textRole.Location = new System.Drawing.Point(650, 344);
            this.textRole.Name = "textRole";
            this.textRole.Size = new System.Drawing.Size(253, 22);
            this.textRole.TabIndex = 44;
            // 
            // textAddress
            // 
            this.textAddress.BackColor = System.Drawing.Color.AliceBlue;
            this.textAddress.Location = new System.Drawing.Point(650, 377);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(253, 22);
            this.textAddress.TabIndex = 43;
            // 
            // textEmail
            // 
            this.textEmail.BackColor = System.Drawing.Color.AliceBlue;
            this.textEmail.Location = new System.Drawing.Point(650, 273);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(253, 22);
            this.textEmail.TabIndex = 41;
            // 
            // textContact
            // 
            this.textContact.BackColor = System.Drawing.Color.AliceBlue;
            this.textContact.Location = new System.Drawing.Point(159, 377);
            this.textContact.Name = "textContact";
            this.textContact.Size = new System.Drawing.Size(253, 22);
            this.textContact.TabIndex = 40;
            // 
            // textPassword
            // 
            this.textPassword.BackColor = System.Drawing.Color.AliceBlue;
            this.textPassword.Location = new System.Drawing.Point(159, 344);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(253, 22);
            this.textPassword.TabIndex = 39;
            // 
            // textGender
            // 
            this.textGender.BackColor = System.Drawing.Color.AliceBlue;
            this.textGender.Location = new System.Drawing.Point(159, 313);
            this.textGender.Name = "textGender";
            this.textGender.Size = new System.Drawing.Size(253, 22);
            this.textGender.TabIndex = 38;
            // 
            // textName
            // 
            this.textName.BackColor = System.Drawing.Color.AliceBlue;
            this.textName.Location = new System.Drawing.Point(159, 281);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(253, 22);
            this.textName.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FloralWhite;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(64, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 36;
            this.label2.Text = "Contact   ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FloralWhite;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(64, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 35;
            this.label3.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FloralWhite;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(568, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 22);
            this.label6.TabIndex = 34;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FloralWhite;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(568, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 22);
            this.label5.TabIndex = 33;
            this.label5.Text = "DOB     ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FloralWhite;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(568, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 22);
            this.label4.TabIndex = 32;
            this.label4.Text = "Email    ";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.BackColor = System.Drawing.Color.FloralWhite;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.ForeColor = System.Drawing.Color.DarkRed;
            this.lblContact.Location = new System.Drawing.Point(568, 344);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(72, 22);
            this.lblContact.TabIndex = 31;
            this.lblContact.Text = "Role     ";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.FloralWhite;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.DarkRed;
            this.lblGender.Location = new System.Drawing.Point(64, 310);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(85, 22);
            this.lblGender.TabIndex = 30;
            this.lblGender.Text = "Gender   ";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.FloralWhite;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.DarkRed;
            this.lblName.Location = new System.Drawing.Point(64, 279);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(87, 22);
            this.lblName.TabIndex = 29;
            this.lblName.Text = "Name      ";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.SteelBlue;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(68, 446);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(125, 49);
            this.btnInsert.TabIndex = 45;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Olive;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(208, 448);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 47);
            this.btnUpdate.TabIndex = 46;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkRed;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(340, 448);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 47);
            this.btnDelete.TabIndex = 47;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(764, 446);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(124, 49);
            this.btnSearch.TabIndex = 48;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(754, 513);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 49);
            this.btnExit.TabIndex = 49;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnViewInfo
            // 
            this.btnViewInfo.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnViewInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewInfo.ForeColor = System.Drawing.Color.White;
            this.btnViewInfo.Location = new System.Drawing.Point(592, 446);
            this.btnViewInfo.Name = "btnViewInfo";
            this.btnViewInfo.Size = new System.Drawing.Size(134, 49);
            this.btnViewInfo.TabIndex = 50;
            this.btnViewInfo.Text = "View Info";
            this.btnViewInfo.UseVisualStyleBackColor = false;
            this.btnViewInfo.Click += new System.EventHandler(this.btnViewInfo_Click);
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(650, 313);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(253, 22);
            this.dtpDOB.TabIndex = 51;
            // 
            // EmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(970, 610);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.btnViewInfo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.textRole);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textContact);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textGender);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewEmployee);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "EmployeeManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Management";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private System.Windows.Forms.TextBox textRole;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textContact;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textGender;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnViewInfo;
        private System.Windows.Forms.DateTimePicker dtpDOB;
    }
}