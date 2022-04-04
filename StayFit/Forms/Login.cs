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
    public partial class Login : Form
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
        public Login()
        {
            InitializeComponent();
            userService = new UserService();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }
        UserService userService;
        bool drag = false;
        Point start_point = new Point(0, 0);
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (SignUp signUp = new SignUp())
            {
                if (signUp.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                {
                    this.Show();
                }
            }
            
        }

        private void btnLogin_Click(object sender, EventArgs e)//yeni
        {
            try
            {
                User user = userService.GetUserbyMail(txtMail.Text);
                userService = new UserService();
                user = userService.GetUserbyMail(txtMail.Text);
                if (user!=null)
                {
                    if (txtMail.Text == user.Mail && txtPassword.Text == user.Password)
                    {
                        
                        this.Hide();
                        using (FormMainMenu formMainMenu = new FormMainMenu(txtMail.Text))
                        {
                            
                            if (formMainMenu.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                            {
                                this.Show();

                                Login login = new Login();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong Email or password!");
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Email or password!");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        
                
        private void Login_Load(object sender, EventArgs e)
        {

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
            Application.Exit();
        }

        private void pbAdminLogin_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            using (AdminLogin adminLogin = new AdminLogin())
            {
                if (adminLogin.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                {
                    this.Show();
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (InformationScreen ınformationScreen = new InformationScreen())
            {
                if (ınformationScreen.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                {
                    this.Show();
                }
            }
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
