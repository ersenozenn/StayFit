
namespace StayFit.Forms
{
    partial class MainMenu
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
            this.label4 = new System.Windows.Forms.Label();
            this.flpSnack = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.flpDinner = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.flpLunch = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flpBreakfast = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMessages = new System.Windows.Forms.Button();
            this.btnInformation = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pbPrint = new System.Windows.Forms.PictureBox();
            this.pbProfilePicture = new System.Windows.Forms.PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 551);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Snack";
            // 
            // flpSnack
            // 
            this.flpSnack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpSnack.Location = new System.Drawing.Point(12, 573);
            this.flpSnack.Name = "flpSnack";
            this.flpSnack.Size = new System.Drawing.Size(468, 140);
            this.flpSnack.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Dinner";
            // 
            // flpDinner
            // 
            this.flpDinner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpDinner.Location = new System.Drawing.Point(12, 408);
            this.flpDinner.Name = "flpDinner";
            this.flpDinner.Size = new System.Drawing.Size(468, 140);
            this.flpDinner.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Lunch";
            // 
            // flpLunch
            // 
            this.flpLunch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpLunch.Location = new System.Drawing.Point(13, 243);
            this.flpLunch.Name = "flpLunch";
            this.flpLunch.Size = new System.Drawing.Size(468, 140);
            this.flpLunch.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Breakfast";
            // 
            // flpBreakfast
            // 
            this.flpBreakfast.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpBreakfast.Location = new System.Drawing.Point(12, 78);
            this.flpBreakfast.Name = "flpBreakfast";
            this.flpBreakfast.Size = new System.Drawing.Size(468, 140);
            this.flpBreakfast.TabIndex = 10;
            // 
            // btnMessages
            // 
            this.btnMessages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMessages.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessages.Location = new System.Drawing.Point(12, 3);
            this.btnMessages.Name = "btnMessages";
            this.btnMessages.Size = new System.Drawing.Size(1188, 50);
            this.btnMessages.TabIndex = 6;
            this.btnMessages.UseVisualStyleBackColor = true;
            // 
            // btnInformation
            // 
            this.btnInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformation.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformation.Location = new System.Drawing.Point(20, 181);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.Size = new System.Drawing.Size(678, 448);
            this.btnInformation.TabIndex = 5;
            this.btnInformation.Text = "You need to input your physical properties to see the our unique results .";
            this.btnInformation.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMessages);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.flpBreakfast);
            this.panel1.Controls.Add(this.flpSnack);
            this.panel1.Controls.Add(this.flpLunch);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.flpDinner);
            this.panel1.Location = new System.Drawing.Point(90, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1212, 723);
            this.panel1.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.pbProfilePicture);
            this.groupBox1.Controls.Add(this.btnInformation);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(496, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 635);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pbPrint);
            this.panel6.Location = new System.Drawing.Point(653, 130);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(45, 45);
            this.panel6.TabIndex = 16;
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
            // pbProfilePicture
            // 
            this.pbProfilePicture.Location = new System.Drawing.Point(290, 22);
            this.pbProfilePicture.Name = "pbProfilePicture";
            this.pbProfilePicture.Size = new System.Drawing.Size(137, 140);
            this.pbProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfilePicture.TabIndex = 15;
            this.pbProfilePicture.TabStop = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1393, 770);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1409, 809);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flpSnack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flpDinner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flpLunch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpBreakfast;
        private System.Windows.Forms.Button btnMessages;
        private System.Windows.Forms.Button btnInformation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbProfilePicture;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pbPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}