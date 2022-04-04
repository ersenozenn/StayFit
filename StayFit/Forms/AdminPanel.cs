using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StayFit.Forms
{
    public partial class AdminPanel : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse

    );
        public AdminPanel()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 100, 100));
        }
        bool drag = false;
        Point start_point = new Point(0, 0);
        private Button currentButton;
        private Form activeForm;
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    currentButton = (Button)btnSender;

                }
            }
        }
        public void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();

            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.PanelContainer.Controls.Add(childForm);
            this.PanelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.AdminAddProdduct(), sender);
        }

        private void btnSubCategory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.AdminAddSubCategory(), sender);
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.AdminAddCategory(), sender);
        }

        private void btnControlUsers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.AdminUserControl(), sender);
        }

        private void btnUserProperties_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.AdminUserSettings(), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void panelHeader_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
