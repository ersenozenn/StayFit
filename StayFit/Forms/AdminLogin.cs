using StayFitNTier.BLL.Services;
using StayFitNTier.Model.Entities;
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
    public partial class AdminLogin : Form
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
        public AdminLogin()
        {
            InitializeComponent();
            userService = new UserService();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 100, 100));
        }
        UserService userService;
        bool drag = false;
        Point start_point = new Point(0, 0);
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User();
                user = userService.GetById(1); 
                if (txtAdmin.Text==user.Mail&&txtPassword.Text==user.Password)
                {
                    MessageBox.Show("Welcome");
                    this.Hide();
                    using (AdminPanel adminPanel = new AdminPanel())
                    {
                        if (adminPanel.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please use user login screen");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
