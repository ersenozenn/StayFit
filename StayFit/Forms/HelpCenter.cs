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
    public partial class HelpCenter : Form
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
        public HelpCenter()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }

        bool drag = false;
        Point start_point = new Point(0, 0);


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

        private void btnMain_Click(object sender, EventArgs e)
        {
            btnText.Text =  "On this screen; New motivational messages are waiting for you every time!\n" +
                            "You can track your daily meals from this screen.\n" +
                            "The content and calorie amounts of your breakfast, lunch, dinner and snack meals are presented to you" +
                            " on this screen. So you can create your daily plan and try to stick to that plan. At the same time, if" +
                            " there is a change in your plan and you update your meal, the program automatically updates this screen.";
        }

        private void btnCreateMeal_Click(object sender, EventArgs e)
        {
            btnText.Text = "You can easily add your meals from the upper left part.\n" +
                "This screen is designed to meet all your needs for your current and future meal additions. In " +
                "addition, you can easily update and delete dishes from the relevant buttons.\n" +
                "You can create meals on the date you want from this screen.\n" +
                "You can see your meals between those dates by selecting the date range from the date selection screens at the top of the screen.";
        }

        private void btnAddProductToMeal_Click(object sender, EventArgs e)
        {
            btnText.Text = "You can access this screen by clicking the 'My Meals' button from the main screen.\n" +
                "With the 'Add Product to Meal' button at the bottom left of the screen, the product you want is added to the selected dish at the top.\n" +
                "If you want to delete products from your meal; You can delete your meal by selecting the meal from the list and pressing the 'Delete Product Meal' button.\n" +
                "The 'Clear' button makes all the fields in the 'Add Meal' field default.";
        }

        private void btnShowStats_Click(object sender, EventArgs e)
        {
            btnText.Text = "You can reach this screen by clicking the 'Stats' button from the main menu.\n" +
                "On this screen, the total calories and proteins you take will meet you according to your choices " +
                "between the dates under the 'GET YOUR STATS' heading. In addition, in the 'Average Health' section, the health rates of the foods you eat will meet you. ";
        }

        private void btnCreateProfile_Click(object sender, EventArgs e)
        {
            btnText.Text = "You can click on the 'My Profile' button in the main menu to reach this screen.\n" +
                "As a result of entering the information on this screen, your BMI Index will be calculated and also " +
                "your analysis will be shared with you according to your daily calorie needs and BMI index result.\n" +
                "You can also add your profile photo on this screen.";
        }

        private void btnComparisons_Click(object sender, EventArgs e)
        {
            btnText.Text = "To access this screen, simply press the 'Comparisons' button from the main screen.\n" +
                "With the buttons on the left, you can list your favorite food categories according to meals.\n" +
                "You can also select the date ranges and compare how many meals you and all users add to your meals from which category.\n" +
                "In the fields next to the buttons, the categories preferred by all our users, including you, are displayed.";
        }

        private void btnAddingProduct_Click(object sender, EventArgs e)
        {
            btnText.Text = "You can access this screen by clicking the 'ADD PRODUCT' button from the main menu.\n" +
                "Here, you can select the fields to add the product according to the category and sub-categories you " +
                "have chosen and add them. Of course, we think you won't forget to press the 'ADD PRODUCT' button.\n" +
                "You can also add the photo of the product you selected to this screen.\n\n" +
                "WARNING!\n" +
                "Users who add meaningless and rude products will be blocked by the Admin!\n";
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            btnText.Text = "You can access this screen by pressing the 'DELETE PRODUCT' button from the main menu.\n" +
                "You can easily delete the product whose category and sub-categories you have selected from this screen.\n" +
                "The product can be added again upon request from other users.";
        }

        private void btnHelpForExit_Click(object sender, EventArgs e)
        {
            btnText.Text = "You can exit by pressing the 'LOG OUT' button in the lower left corner of the main menu.\n" +
                "When you exit from this screen, you will be directed to the login screen.";
        }
    }
}
