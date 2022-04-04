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

    public partial class SignUp : Form
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
        UserService userService;
        int id;
        public SignUp()
        {
            InitializeComponent();
            userService = new UserService();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }
        public SignUp(int _id)
        {
            InitializeComponent();
            userService = new UserService();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
            id = _id;
        }
        public SignUp(string _mail)
        {
            InitializeComponent();
            userService = new UserService();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
            this.label3.Location = new System.Drawing.Point(42, 204);
            label3.Text = "Old password :";
            email = _mail;
        }
        string email;
        bool drag = false;
        Point start_point = new Point(0, 0);

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e) //yeni
        {

            string firstName = txtName.Text;
            string surname = txtSurname.Text;
            string phoneNumber = mtbPhoneNumber.Text;
            string mail = txtMail.Text;
            string password = txtPassword.Text;
            string rePassword = txtRePassword.Text;
            if (mail.Length >= 6 && password.Any(Char.IsDigit) && password.Any(Char.IsLower) && password.Any(char.IsUpper) && rePassword == password && !string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(surname) && password.Length >= 6 && mail.Contains("@") && mail.EndsWith(".com") && btnSignUp.Text == "Sign Up" || btnSignUp.Text == "Add" || btnSignUp.Text == "Update")
            {
                if (userService.GetUserbyMail(mail) != null)
                {
                    MessageBox.Show("This e_mail already registered!");
                }
                else
                {
                    txtName.Text = txtName.Text[0].ToString().ToUpper() + txtName.Text.Substring(1);
                    txtSurname.Text = txtSurname.Text[0].ToString().ToUpper() + txtSurname.Text.Substring(1);
                    SignInAddorUpdate();
                }

            }
            else if (password.Any(Char.IsDigit) && password.Any(Char.IsLower) && password.Any(char.IsUpper) && rePassword == password && !string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(surname) && password.Length >= 6 && btnSignUp.Text == "Update Information")
            {
                txtName.Text = txtName.Text[0].ToString().ToUpper() + txtName.Text.Substring(1);
                txtSurname.Text = txtSurname.Text[0].ToString().ToUpper() + txtSurname.Text.Substring(1);
                SignInAddorUpdate();
            }
            else if (mail.Length >= 10 && password.Any(Char.IsDigit) && password.Any(Char.IsLower) && password.Any(char.IsUpper) && rePassword == password && !string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(surname) && password.Length >= 6 && !mail.Contains("@") || !mail.EndsWith(".com"))
            {
                MessageBox.Show("Please enter a valid email address!");
            }
            else if (mail.Length >= 10 && password.Any(Char.IsDigit) && password.Any(Char.IsLower) && password.Any(char.IsUpper) && rePassword == password && string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(surname) && password.Length >= 6 && mail.Contains("@") && mail.EndsWith(".com"))
            {
                MessageBox.Show("Please do not leave the name and surname fields blank!");
            }
            else if (mail.Length < 10 && password.Any(Char.IsDigit) && password.Any(Char.IsLower) && password.Any(char.IsUpper) && rePassword == password && !string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(surname) && password.Length >= 6 && mail.Contains("@") && mail.EndsWith(".com"))
            {
                MessageBox.Show("Email address must be longer than 10 characters!");
            }
            else if (mail.Length > 10 || password.Any(Char.IsDigit) || password.Any(Char.IsLower) || password.Any(char.IsUpper) && rePassword == password && !string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(surname) || password.Length >= 6 && mail.Contains("@") && mail.EndsWith(".com"))
            {
                MessageBox.Show("Your password must contain uppercase and lowercase letters and numbers and length should be more than 6 characters!");
            }
            else if (mail.Length >= 10 && password.Any(Char.IsDigit) && password.Any(Char.IsLower) && password.Any(char.IsUpper) && rePassword != password && !string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(surname) && password.Length >= 6 && !mail.Contains("@") || !mail.EndsWith(".com"))
            {
                MessageBox.Show("Passwords do not match!");
            }

            else
            {
                MessageBox.Show("Something went wrong. Please check your entries.");
            }
        }
        public void SignInAddorUpdate()
        {
            if (btnSignUp.Text == "Sign Up")
            {
                User user = new User();
                user.FirstName = txtName.Text;
                user.Surname = txtSurname.Text;
                user.PhoneNumber = mtbPhoneNumber.Text;
                user.CreateDate = DateTime.Now;
                user.Mail = txtMail.Text;
                user.Password = txtPassword.Text;

                if (userService.AddUser(user))
                {
                    MessageBox.Show("Sign up succesfull");
                    this.Close();
                }
            }
            else if (btnSignUp.Text == "Add")
            {
                User user = new User();
                user.FirstName = txtName.Text;
                user.Surname = txtSurname.Text;
                user.PhoneNumber = mtbPhoneNumber.Text;
                user.CreateDate = DateTime.Now;
                user.Mail = txtMail.Text;
                user.Password = txtPassword.Text;

                if (userService.AddUser(user))
                {
                    MessageBox.Show("Adding succesfull");
                    this.Close();
                }
            }
            else if (btnSignUp.Text == "Update")
            {
                User user = new User();
                user.Id = id;
                user.FirstName = txtName.Text;
                user.Surname = txtSurname.Text;
                user.PhoneNumber = mtbPhoneNumber.Text;
                user.CreateDate = DateTime.Now;
                user.Mail = txtMail.Text;
                user.Password = txtPassword.Text;
                if (userService.UpdateforAdmin(user))
                {
                    MessageBox.Show("Update succesfull");
                    this.Close();
                }
            }
            else if (btnSignUp.Text == "Update Information")
            {
                User user = new User();
                user = userService.GetUserbyMail(email);
                user.Mail = email;
                user.FirstName = txtName.Text;
                user.Surname = txtSurname.Text;
                user.PhoneNumber = mtbPhoneNumber.Text;
                user.CreateDate = DateTime.Now;

                if (user.Password == txtMail.Text)
                {
                    user.Password = txtPassword.Text;
                    if (userService.UpdateforUser(user))
                    {
                        MessageBox.Show("Update succesfull");
                        this.Close();
                    }
                }

            }
        }
        private void SignUp_Load(object sender, EventArgs e)
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
