
namespace StayFit.Forms
{
    partial class AdminUserControl
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnShowUserHistory = new System.Windows.Forms.Button();
            this.btnShowActiveUsers = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataUserInfo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pbPrint = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataUserInfo)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lstUsers);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 661);
            this.panel2.TabIndex = 1;
            // 
            // lstUsers
            // 
            this.lstUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.ItemHeight = 19;
            this.lstUsers.Items.AddRange(new object[] {
            "Name Surname"});
            this.lstUsers.Location = new System.Drawing.Point(0, 55);
            this.lstUsers.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(333, 606);
            this.lstUsers.TabIndex = 1;
            this.lstUsers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstUsers_MouseClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(333, 55);
            this.panel3.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(333, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "USERS";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.dataUserInfo);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(333, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 661);
            this.panel1.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnShowUserHistory);
            this.panel5.Controls.Add(this.btnShowActiveUsers);
            this.panel5.Controls.Add(this.btnDelete);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(696, 55);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(306, 606);
            this.panel5.TabIndex = 5;
            // 
            // btnShowUserHistory
            // 
            this.btnShowUserHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShowUserHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowUserHistory.Location = new System.Drawing.Point(0, 405);
            this.btnShowUserHistory.Name = "btnShowUserHistory";
            this.btnShowUserHistory.Size = new System.Drawing.Size(306, 201);
            this.btnShowUserHistory.TabIndex = 4;
            this.btnShowUserHistory.Text = "SHOW USER HISTORY";
            this.btnShowUserHistory.UseVisualStyleBackColor = true;
            this.btnShowUserHistory.Click += new System.EventHandler(this.btnShowUserHistory_Click);
            // 
            // btnShowActiveUsers
            // 
            this.btnShowActiveUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowActiveUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowActiveUsers.Location = new System.Drawing.Point(0, 203);
            this.btnShowActiveUsers.Name = "btnShowActiveUsers";
            this.btnShowActiveUsers.Size = new System.Drawing.Size(306, 202);
            this.btnShowActiveUsers.TabIndex = 3;
            this.btnShowActiveUsers.Text = "SHOW ACTIVE USERS";
            this.btnShowActiveUsers.UseVisualStyleBackColor = true;
            this.btnShowActiveUsers.Click += new System.EventHandler(this.btnShowActiveUsers_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(0, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(306, 203);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "DELETE USER";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataUserInfo
            // 
            this.dataUserInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataUserInfo.BackgroundColor = System.Drawing.Color.White;
            this.dataUserInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataUserInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataUserInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUserInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataUserInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataUserInfo.Location = new System.Drawing.Point(0, 55);
            this.dataUserInfo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataUserInfo.Name = "dataUserInfo";
            this.dataUserInfo.ReadOnly = true;
            this.dataUserInfo.Size = new System.Drawing.Size(696, 606);
            this.dataUserInfo.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "First Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Last Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Phone Number";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Mail";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1002, 55);
            this.panel4.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pbPrint);
            this.panel6.Location = new System.Drawing.Point(651, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(45, 45);
            this.panel6.TabIndex = 3;
            // 
            // pbPrint
            // 
            this.pbPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPrint.Image = global::StayFit.Properties.Resources.printer;
            this.pbPrint.Location = new System.Drawing.Point(0, 0);
            this.pbPrint.Name = "pbPrint";
            this.pbPrint.Size = new System.Drawing.Size(45, 45);
            this.pbPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPrint.TabIndex = 0;
            this.pbPrint.TabStop = false;
            this.pbPrint.Click += new System.EventHandler(this.pbPrint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(720, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(818, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 24);
            this.textBox1.TabIndex = 0;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // AdminUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1335, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximumSize = new System.Drawing.Size(1351, 700);
            this.Name = "AdminUserControl";
            this.Text = "AdminUserControl";
            this.Load += new System.EventHandler(this.AdminUserControl_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataUserInfo)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataUserInfo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnShowUserHistory;
        private System.Windows.Forms.Button btnShowActiveUsers;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pbPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}