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
    public partial class AdminUserSettings : Form
    {
        UserService userService;
        UserPropertyService userPropertyService;
        GenderService genderService;
        public AdminUserSettings()
        {
            InitializeComponent();
            userService = new UserService();
            userPropertyService = new UserPropertyService();
            genderService = new GenderService();
        }
        private void GetListBox()
        {
            lstUsers.Items.Clear();
            lstUsers.SelectionMode = SelectionMode.MultiExtended;
            lstUsers.DataSource = userService.GetActiveUsers();
            lstUsers.DisplayMember = "FullName";
            lstUsers.ValueMember = "Id";
        }
        public void GetAllUserProperties()
        {
            dataUserProperties.Rows.Clear();
            List<UserProperty> userProperties = new List<UserProperty>();
            userProperties= userPropertyService.GetUserProperties();
            

            foreach (UserProperty userProperty in userProperties)
            {
                dataUserProperties.Rows.Add(userProperty.Height, userProperty.Weight, (int)(DateTime.Now.Year- userProperty.BirthDate.Year), userProperty.PhysicalActivityId==1 ? "Low": userProperty.PhysicalActivityId == 2 ? "Light": userProperty.PhysicalActivityId == 3 ? " Average": userProperty.PhysicalActivityId == 4 ? "Big" : "Wrong Info", userProperty.GenderId==1 ? "Female" : "Male", userProperty.IsActive);
                
            }

        }
        public void GetUserPropertiesforOneUser()
        {
            dataUserProperties.Rows.Clear();
            List<UserProperty> userProperties = new List<UserProperty>();
            if (userPropertyService.GetUserPropertiesbyuserId((int)lstUsers.SelectedValue)!=null)
            {
                userProperties = userPropertyService.GetUserPropertiesbyuserId((int)lstUsers.SelectedValue);


                foreach (UserProperty userProperty in userProperties)
                {
                    dataUserProperties.Rows.Add(userProperty.Height, userProperty.Weight, (int)(DateTime.Now.Year - userProperty.BirthDate.Year), userProperty.PhysicalActivityId == 1 ? "Low" : userProperty.PhysicalActivityId == 2 ? "Light" : userProperty.PhysicalActivityId == 3 ? " Average" : userProperty.PhysicalActivityId == 4 ? "Big" : "Wrong Info", userProperty.GenderId == 1 ? "Female" : "Male", userProperty.IsActive);

                }
            }
            

        }
        private void AdminUserSettings_Load(object sender, EventArgs e)
        {
            try
            {
                GetListBox();
                GetAllUserProperties();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void lstUsers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                GetUserPropertiesforOneUser();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
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
            Bitmap printDataGridView = new Bitmap(this.dataUserProperties.Width, this.dataUserProperties.Height);
            dataUserProperties.DrawToBitmap(printDataGridView, new Rectangle(0, 0, this.dataUserProperties.Width, this.dataUserProperties.Height));
            e.Graphics.DrawImage(printDataGridView, 0, 0);
        }
    }
}
