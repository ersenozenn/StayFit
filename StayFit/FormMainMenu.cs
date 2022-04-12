using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using StayFit.Forms;
using StayFitNTier.Model.Entities;
using StayFitNTier.BLL.Services;

namespace StayFit
{

    public partial class FormMainMenu : Form
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
        string mail;
        bool drag = false;
        Point start_point = new Point(0, 0);
        public FormMainMenu()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 100, 100));

        }
        public FormMainMenu(string _mail)
        {
            mail = _mail;
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 100, 100));
            userService = new UserService();
        }
        public User GetUser()
        {
            return userService.GetUserbyMail(mail);
        }
        UserService userService;
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
        public void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();

            }
            
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.PanelContainer.Controls.Add(childForm);
            this.PanelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }


        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.MainMenu(mail));
        }

        private void btnShowStats_Click_1(object sender, EventArgs e)
        {
            
            OpenChildForm(new Forms.Stats(mail), sender);

        }

        private void btnMyProfile_Click_1(object sender, EventArgs e)
        {
            
            OpenChildForm(new Forms.MyProfile(mail), sender);
        }

        private void btnComparisons_Click_1(object sender, EventArgs e)
        {
            
            OpenChildForm(new Forms.Comparisons(mail), sender);
        }

        private void btnAddProduct_Click_2(object sender, EventArgs e)
        {
            
            OpenChildForm(new Forms.AddProduct(), sender);
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            
            OpenChildForm(new Forms.DeleteProduct(), sender);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnMyMeals_Click(object sender, EventArgs e)
        {
            
            OpenChildForm(new Forms.MyMeals(mail),sender);
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.MainMenu(mail));


        }
               

        private void btnMostEatenProduct_Click(object sender, EventArgs e)
        {            
            OpenChildForm(new Forms.MostEatenProducts(mail), sender);
        }
        private void btnExit_Click_1(object sender, EventArgs e)
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

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbInfo_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            using (HelpCenter helpCenter = new HelpCenter())
            {
                if (helpCenter.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                {
                    this.Show();
                }
            }
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbChangeUserInfo_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            using (SignUp signUp = new SignUp(mail))
            {
                signUp.Text = "Change User Info";
                signUp.btnSignUp.Text = "Update Information";                
                if (signUp.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                {
                    this.Show();
                    
                }
            }
        }
        
        public void OpenMyProfile(object sender, EventArgs e)
        {           

            btnMyProfile_Click_1(sender,e);
        }
        private void pbDeleteUser_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("Are you sure you want to delete your account?", "Delete Account", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                User user = new User();
                user = GetUser();
                userService.DeleteforUser(user.Id);
                this.Close();
            }
        }
    }
}
