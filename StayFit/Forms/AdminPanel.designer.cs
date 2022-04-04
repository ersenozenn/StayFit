
namespace StayFit.Forms
{
    partial class AdminPanel
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pbInfo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnControlUsers = new System.Windows.Forms.Button();
            this.btnUserProperties = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnSubCategory = new System.Windows.Forms.Button();
            this.PanelContainer = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.panelHeader.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInfo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelHeader.Controls.Add(this.panel10);
            this.panelHeader.Controls.Add(this.panel9);
            this.panelHeader.Controls.Add(this.panel1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1773, 50);
            this.panelHeader.TabIndex = 2;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseMove);
            this.panelHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseUp);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.pbInfo);
            this.panel9.Location = new System.Drawing.Point(1581, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(43, 44);
            this.panel9.TabIndex = 6;
            // 
            // pbInfo
            // 
            this.pbInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbInfo.Image = global::StayFit.Properties.Resources.information__1_1;
            this.pbInfo.Location = new System.Drawing.Point(0, 0);
            this.pbInfo.Name = "pbInfo";
            this.pbInfo.Size = new System.Drawing.Size(43, 44);
            this.pbInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInfo.TabIndex = 0;
            this.pbInfo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbClose);
            this.panel1.Location = new System.Drawing.Point(1679, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(43, 44);
            this.panel1.TabIndex = 5;
            // 
            // pbClose
            // 
            this.pbClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbClose.Image = global::StayFit.Properties.Resources.close__1_;
            this.pbClose.Location = new System.Drawing.Point(0, 0);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(43, 44);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 0;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 717);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1773, 50);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(50, 667);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1723, 50);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(50, 667);
            this.panel5.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.AutoScroll = true;
            this.panel6.Controls.Add(this.button1);
            this.panel6.Controls.Add(this.btnControlUsers);
            this.panel6.Controls.Add(this.btnUserProperties);
            this.panel6.Controls.Add(this.btnProduct);
            this.panel6.Controls.Add(this.btnCategory);
            this.panel6.Controls.Add(this.btnSubCategory);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(50, 50);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(341, 667);
            this.panel6.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::StayFit.Properties.Resources.logout__1_;
            this.button1.Location = new System.Drawing.Point(0, 555);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(341, 111);
            this.button1.TabIndex = 5;
            this.button1.Text = "LOG OUT";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnControlUsers
            // 
            this.btnControlUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnControlUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControlUsers.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControlUsers.Image = global::StayFit.Properties.Resources.network;
            this.btnControlUsers.Location = new System.Drawing.Point(0, 444);
            this.btnControlUsers.Name = "btnControlUsers";
            this.btnControlUsers.Size = new System.Drawing.Size(341, 111);
            this.btnControlUsers.TabIndex = 0;
            this.btnControlUsers.Text = "CONTROL USERS";
            this.btnControlUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnControlUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnControlUsers.UseVisualStyleBackColor = true;
            this.btnControlUsers.Click += new System.EventHandler(this.btnControlUsers_Click);
            // 
            // btnUserProperties
            // 
            this.btnUserProperties.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserProperties.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserProperties.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserProperties.Image = global::StayFit.Properties.Resources.intellectual_property;
            this.btnUserProperties.Location = new System.Drawing.Point(0, 333);
            this.btnUserProperties.Name = "btnUserProperties";
            this.btnUserProperties.Size = new System.Drawing.Size(341, 111);
            this.btnUserProperties.TabIndex = 4;
            this.btnUserProperties.Text = "USER PROPERTIES";
            this.btnUserProperties.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserProperties.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUserProperties.UseVisualStyleBackColor = true;
            this.btnUserProperties.Click += new System.EventHandler(this.btnUserProperties_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.Image = global::StayFit.Properties.Resources.online_shopping;
            this.btnProduct.Location = new System.Drawing.Point(0, 222);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(341, 111);
            this.btnProduct.TabIndex = 1;
            this.btnProduct.Text = "PRODUCT SETTINGS";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.Image = global::StayFit.Properties.Resources.categories;
            this.btnCategory.Location = new System.Drawing.Point(0, 111);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(341, 111);
            this.btnCategory.TabIndex = 3;
            this.btnCategory.Text = "CATEGORY SETTINGS";
            this.btnCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnSubCategory
            // 
            this.btnSubCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubCategory.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubCategory.Image = global::StayFit.Properties.Resources.standings;
            this.btnSubCategory.Location = new System.Drawing.Point(0, 0);
            this.btnSubCategory.Name = "btnSubCategory";
            this.btnSubCategory.Size = new System.Drawing.Size(341, 111);
            this.btnSubCategory.TabIndex = 2;
            this.btnSubCategory.Text = "SUBCATEGORY SETTINGS";
            this.btnSubCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSubCategory.UseVisualStyleBackColor = true;
            this.btnSubCategory.Click += new System.EventHandler(this.btnSubCategory_Click);
            // 
            // PanelContainer
            // 
            this.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContainer.Location = new System.Drawing.Point(391, 50);
            this.PanelContainer.MaximumSize = new System.Drawing.Size(1332, 667);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(1332, 667);
            this.PanelContainer.TabIndex = 7;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.pbMinimize);
            this.panel10.Location = new System.Drawing.Point(1630, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(43, 44);
            this.panel10.TabIndex = 7;
            // 
            // pbMinimize
            // 
            this.pbMinimize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbMinimize.Image = global::StayFit.Properties.Resources.minimize;
            this.pbMinimize.Location = new System.Drawing.Point(0, 0);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(43, 44);
            this.pbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinimize.TabIndex = 0;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1773, 767);
            this.Controls.Add(this.PanelContainer);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximumSize = new System.Drawing.Size(1773, 767);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.panelHeader.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnControlUsers;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnSubCategory;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnUserProperties;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel PanelContainer;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.PictureBox pbInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.PictureBox pbMinimize;
    }
}