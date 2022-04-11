using StayFitNTier.BLL.Services;
using StayFitNTier.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StayFit.Forms
{
    public partial class AdminUserControl : Form
    {
        UserService userService;
        public AdminUserControl()
        {
            InitializeComponent();
            userService = new UserService();
        }

       
        private void GetListBox()
        {
            lstUsers.SelectionMode = SelectionMode.MultiExtended;
            lstUsers.DataSource = userService.GetActiveUsers();
            lstUsers.DisplayMember = "FullName";
            lstUsers.ValueMember = "Id";
        }
        public void ShowOneUserOnGridView()
        {
            dataUserInfo.Rows.Clear();
            User user = userService.GetById((int)(lstUsers.SelectedValue));
            dataUserInfo.Rows.Add(user.FirstName, user.Surname, user.PhoneNumber, user.Mail, user.Password);

        }
        public void GetAllActiveUsers()
        {
            dataUserInfo.Rows.Clear();
            List<User> users = userService.GetActiveUsers();

            foreach (User user in users)
            {
                dataUserInfo.Rows.Add(user.FirstName, user.Surname, user.PhoneNumber, user.Mail, user.Password);
            }
        }

        private void AdminUserControl_Load(object sender, EventArgs e)
        {
            try
            {
                GetListBox();
                GetAllActiveUsers();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {

            this.Hide();
            using (SignUp signUp = new SignUp())
            {
                signUp.Text = "Add User";
                signUp.btnSignUp.Text = "Add";

                if (signUp.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                {
                    this.Show();
                    GetListBox();
                }
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            int id = (int)(lstUsers.SelectedValue);
            this.Hide();
            using (SignUp signUp = new SignUp(id))
            {
                signUp.Text = "Update User";
                signUp.btnSignUp.Text = "Update";
                User user = new User();
                if (signUp.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                {
                    this.Show();
                    GetListBox();
                }
            }
        }

        private void lstUsers_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                ShowOneUserOnGridView();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnShowActiveUsers_Click(object sender, EventArgs e)
        {
            try
            {
                GetListBox();
                GetAllActiveUsers();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        
        public List<User> GetAllUsers()
        {
            return userService.GetAllUsers();
        }

        private void btnShowUserHistory_Click(object sender, EventArgs e)
        {
            List<User> allUsers = new List<User>();
            allUsers = GetAllUsers();

            lstUsers.SelectionMode = SelectionMode.MultiExtended;
            lstUsers.DataSource = GetAllUsers();
            lstUsers.DisplayMember = "FullName";
            lstUsers.ValueMember = "Id";         
            
        }

        private void pbPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;
            printDialog.UseEXDialog = true;

            DialogResult dialogResult = printDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                printDocument1.DocumentName = "New File";
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap printDataGridView = new Bitmap(this.dataUserInfo.Width, this.dataUserInfo.Height);
            dataUserInfo.DrawToBitmap(printDataGridView, new Rectangle(0, 0, this.dataUserInfo.Width, this.dataUserInfo.Height));
            e.Graphics.DrawImage(printDataGridView, 0, 0);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstUsers.SelectedIndex != -1)
                userService.DeleteforAdmin((int)(lstUsers.SelectedValue));
            GetListBox();
        }
    }
}
