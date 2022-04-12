
namespace StayFit.Forms
{
    partial class MyProfile
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnChosePhoto = new System.Windows.Forms.Button();
            this.pbProfilePhoto = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAdvice = new System.Windows.Forms.Button();
            this.btnBMI = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.btnTotalCaloryIntake = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbBig = new System.Windows.Forms.RadioButton();
            this.rbAverage = new System.Windows.Forms.RadioButton();
            this.rbLight = new System.Windows.Forms.RadioButton();
            this.rbLow = new System.Windows.Forms.RadioButton();
            this.btnAddInfo = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpMeasurementDate = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePhoto)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1131, 685);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnChosePhoto);
            this.panel3.Controls.Add(this.pbProfilePhoto);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(655, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(476, 685);
            this.panel3.TabIndex = 29;
            // 
            // btnChosePhoto
            // 
            this.btnChosePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChosePhoto.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChosePhoto.Location = new System.Drawing.Point(39, 50);
            this.btnChosePhoto.Name = "btnChosePhoto";
            this.btnChosePhoto.Size = new System.Drawing.Size(190, 59);
            this.btnChosePhoto.TabIndex = 51;
            this.btnChosePhoto.Text = "CHOOSE PROFILE PICTURE";
            this.btnChosePhoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnChosePhoto.UseVisualStyleBackColor = true;
            this.btnChosePhoto.Click += new System.EventHandler(this.btnChosePhoto_Click);
            // 
            // pbProfilePhoto
            // 
            this.pbProfilePhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbProfilePhoto.Location = new System.Drawing.Point(274, 50);
            this.pbProfilePhoto.Name = "pbProfilePhoto";
            this.pbProfilePhoto.Size = new System.Drawing.Size(132, 131);
            this.pbProfilePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfilePhoto.TabIndex = 50;
            this.pbProfilePhoto.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnAdvice);
            this.panel4.Controls.Add(this.btnBMI);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.button15);
            this.panel4.Controls.Add(this.btnTotalCaloryIntake);
            this.panel4.Location = new System.Drawing.Point(39, 197);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(367, 444);
            this.panel4.TabIndex = 28;
            // 
            // btnAdvice
            // 
            this.btnAdvice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdvice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdvice.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvice.Location = new System.Drawing.Point(0, 147);
            this.btnAdvice.Name = "btnAdvice";
            this.btnAdvice.Size = new System.Drawing.Size(367, 124);
            this.btnAdvice.TabIndex = 25;
            this.btnAdvice.Text = "Advice";
            this.btnAdvice.UseVisualStyleBackColor = true;
            // 
            // btnBMI
            // 
            this.btnBMI.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBMI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBMI.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBMI.Image = global::StayFit.Properties.Resources.bmi;
            this.btnBMI.Location = new System.Drawing.Point(0, 61);
            this.btnBMI.Name = "btnBMI";
            this.btnBMI.Size = new System.Drawing.Size(367, 86);
            this.btnBMI.TabIndex = 24;
            this.btnBMI.Text = "1502";
            this.btnBMI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBMI.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBMI.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(367, 61);
            this.button1.TabIndex = 23;
            this.button1.Text = "Body Mass Index";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(0, 271);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(367, 87);
            this.button15.TabIndex = 21;
            this.button15.Text = "Your Daily Calorie Intake";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // btnTotalCaloryIntake
            // 
            this.btnTotalCaloryIntake.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTotalCaloryIntake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotalCaloryIntake.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalCaloryIntake.Image = global::StayFit.Properties.Resources.kcal;
            this.btnTotalCaloryIntake.Location = new System.Drawing.Point(0, 358);
            this.btnTotalCaloryIntake.Name = "btnTotalCaloryIntake";
            this.btnTotalCaloryIntake.Size = new System.Drawing.Size(367, 86);
            this.btnTotalCaloryIntake.TabIndex = 20;
            this.btnTotalCaloryIntake.Text = "1502";
            this.btnTotalCaloryIntake.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTotalCaloryIntake.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTotalCaloryIntake.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(655, 685);
            this.panel2.TabIndex = 28;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.dtpBirthDate);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btnAddInfo);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.dtpMeasurementDate);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.rbFemale);
            this.groupBox2.Controls.Add(this.rbMale);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtWeight);
            this.groupBox2.Controls.Add(this.txtHeight);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(655, 685);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dtpBirthDate.CalendarTrailingForeColor = System.Drawing.SystemColors.Window;
            this.dtpBirthDate.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthDate.Location = new System.Drawing.Point(250, 60);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(333, 27);
            this.dtpBirthDate.TabIndex = 21;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbBig);
            this.groupBox3.Controls.Add(this.rbAverage);
            this.groupBox3.Controls.Add(this.rbLight);
            this.groupBox3.Controls.Add(this.rbLow);
            this.groupBox3.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(44, 451);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(539, 199);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "(*)Excercise Frequency";
            // 
            // rbBig
            // 
            this.rbBig.AutoSize = true;
            this.rbBig.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBig.Location = new System.Drawing.Point(73, 142);
            this.rbBig.Name = "rbBig";
            this.rbBig.Size = new System.Drawing.Size(240, 27);
            this.rbBig.TabIndex = 1;
            this.rbBig.Text = "Big (6 Times A Week)";
            this.rbBig.UseVisualStyleBackColor = true;
            // 
            // rbAverage
            // 
            this.rbAverage.AutoSize = true;
            this.rbAverage.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAverage.Location = new System.Drawing.Point(73, 107);
            this.rbAverage.Name = "rbAverage";
            this.rbAverage.Size = new System.Drawing.Size(292, 27);
            this.rbAverage.TabIndex = 2;
            this.rbAverage.Text = "Average (4 Times A Week)";
            this.rbAverage.UseVisualStyleBackColor = true;
            // 
            // rbLight
            // 
            this.rbLight.AutoSize = true;
            this.rbLight.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLight.Location = new System.Drawing.Point(73, 73);
            this.rbLight.Name = "rbLight";
            this.rbLight.Size = new System.Drawing.Size(259, 27);
            this.rbLight.TabIndex = 3;
            this.rbLight.Text = "Light (2 Times A Week)";
            this.rbLight.UseVisualStyleBackColor = true;
            // 
            // rbLow
            // 
            this.rbLow.AutoSize = true;
            this.rbLow.Checked = true;
            this.rbLow.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLow.Location = new System.Drawing.Point(73, 36);
            this.rbLow.Name = "rbLow";
            this.rbLow.Size = new System.Drawing.Size(353, 27);
            this.rbLow.TabIndex = 4;
            this.rbLow.TabStop = true;
            this.rbLow.Text = "Low (Almost No Pysical Activity)";
            this.rbLow.UseVisualStyleBackColor = true;
            // 
            // btnAddInfo
            // 
            this.btnAddInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddInfo.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInfo.Location = new System.Drawing.Point(250, 381);
            this.btnAddInfo.Name = "btnAddInfo";
            this.btnAddInfo.Size = new System.Drawing.Size(334, 46);
            this.btnAddInfo.TabIndex = 19;
            this.btnAddInfo.Text = "ADD INFORMATION";
            this.btnAddInfo.UseVisualStyleBackColor = true;
            this.btnAddInfo.Click += new System.EventHandler(this.btnAddInfo_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(121, 132);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(124, 23);
            this.label17.TabIndex = 1;
            this.label17.Text = "(*)Gender :";
            // 
            // dtpMeasurementDate
            // 
            this.dtpMeasurementDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dtpMeasurementDate.CalendarTrailingForeColor = System.Drawing.SystemColors.Window;
            this.dtpMeasurementDate.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMeasurementDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMeasurementDate.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.dtpMeasurementDate.Location = new System.Drawing.Point(249, 338);
            this.dtpMeasurementDate.Name = "dtpMeasurementDate";
            this.dtpMeasurementDate.Size = new System.Drawing.Size(334, 27);
            this.dtpMeasurementDate.TabIndex = 18;
            this.dtpMeasurementDate.ValueChanged += new System.EventHandler(this.dtpMeasurementDate_ValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(126, 201);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 23);
            this.label16.TabIndex = 1;
            this.label16.Text = "(*)Height :";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.Location = new System.Drawing.Point(374, 128);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(97, 27);
            this.rbFemale.TabIndex = 0;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.Location = new System.Drawing.Point(249, 128);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(73, 27);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 338);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(208, 23);
            this.label18.TabIndex = 17;
            this.label18.Text = "Measurement Date :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(90, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(155, 23);
            this.label15.TabIndex = 1;
            this.label15.Text = "(*)Birth Date :";
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(249, 270);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(335, 27);
            this.txtWeight.TabIndex = 3;
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.Location = new System.Drawing.Point(250, 197);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(335, 27);
            this.txtHeight.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(122, 270);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 23);
            this.label14.TabIndex = 9;
            this.label14.Text = "(*)Weight :";
            // 
            // MyProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1140, 685);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MyProfile";
            this.Text = "MyProfile";
            this.Load += new System.EventHandler(this.MyProfile_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePhoto)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button btnTotalCaloryIntake;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtpMeasurementDate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnAddInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbBig;
        private System.Windows.Forms.RadioButton rbAverage;
        private System.Windows.Forms.RadioButton rbLight;
        private System.Windows.Forms.RadioButton rbLow;
        private System.Windows.Forms.Button btnAdvice;
        private System.Windows.Forms.Button btnBMI;
        private System.Windows.Forms.Button btnChosePhoto;
        private System.Windows.Forms.PictureBox pbProfilePhoto;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
    }
}