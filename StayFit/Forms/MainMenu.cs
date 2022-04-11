using StayFitNTier.BLL.Services;
using StayFitNTier.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StayFit.Forms
{
    public partial class MainMenu : Form
    {
        MealDetailService mealDetailService;
        MealService mealService;
        UserService userService;
        UserPropertyService userPropertyService;
        string mail;
        public MainMenu()
        {
            InitializeComponent();            
        }
        public MainMenu(string _mail)
        {
            InitializeComponent();
            mail = _mail;
            mealDetailService = new MealDetailService();
            mealService = new MealService();
            userService = new UserService();
            userPropertyService = new UserPropertyService();
        }
        List<Meal> todaysMeals;

        public User GetUser()
        {
            return userService.GetUserbyMail(mail);
        }
        public void FillPictureBoxes()
        {
            User user = new User();
            user = GetUser();
            UserProperty userProperty = new UserProperty();
            userProperty=userPropertyService.GetActiveUserPropertyByuserId(user.Id);
            if (userProperty != null)
            {
                if (pbProfilePicture.Image != null)
                {
                    pbProfilePicture.Image.Dispose();
                }
                if (userProperty.Photo!=null)
                {
                    Byte[] byteBLOBData2 = new Byte[0];
                    byteBLOBData2 = (Byte[])userProperty.Photo;
                    MemoryStream stmBLOBData = new MemoryStream(byteBLOBData2);
                    if (pbProfilePicture.Image != null)
                    {
                        pbProfilePicture.Image.Dispose();
                    }
                    pbProfilePicture.Image = Image.FromStream(stmBLOBData);
                }
                
            }

        }
        void Generate()
        {
            List<string> words = new List<string>();
            Random rnd = new Random();

            string path = Path.GetFullPath(@"..\..\..\Words.txt");
            StreamReader wordReader = new StreamReader(path);

            string line = "";
            while (!wordReader.EndOfStream)
            {
                line = wordReader.ReadLine();
                words.Add(line);
            }

            btnMessages.Text = words[rnd.Next(1, words.Count)];

            GetUserInformation();
        }

        void GetUserInformation()
        {            
            User user = GetUser();
            
            if (userPropertyService.GetUserPropertiesbyuserId(user.Id) != null)
            {
                string advice = "";

                UserProperty userProperty = new UserProperty();
                userProperty = userPropertyService.GetUserPropertiesbyuserId(user.Id).First();

                string firstName = user.FirstName;
                string lastName = user.Surname;
                int age = DateTime.Now.Year - userProperty.BirthDate.Year;
                decimal BMI = CalculateBMIForOneUser(user);
                if (BMI < 18.5M)
                {                    
                    advice = "A BMI of less than 18.5 indicates that you are underweight,\n" +
                             "so you may need to put on some weight. You are recommended \n" +
                             "to ask your doctor or a dietitian for advice.";

                }
                else if (BMI > 18.5M && BMI < 24.9M)
                {                    
                    advice = "A BMI of 18.5-24.9 indicates that you are at a healthy weight\n" +
                             "for your height. By maintaining a healthy weight, you lower your\n" +
                             "risk of developing serious health problems.";
                }
                else if (BMI > 25M && BMI < 29.9M)
                {                    
                    advice = "A BMI of 25-29.9 indicates that you are slightly overweight. \n" +
                             "You may be advised to lose some weight for health reasons. \n" +
                             "You are recommended to talk to your doctor or a dietitian for advice.";

                }
                else if (BMI > 29.9M)
                {                    
                    advice = "A BMI of over 30 indicates that you are heavily overweight. \n" +
                             "Your health may be at risk if you do not lose weight. \n" +
                             "You are recommended to talk to your doctor or a dietitian for advice.";

                }
                this.btnInformation.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnInformation.Text = $"First Name: {firstName}\n\nLast Name: {lastName}\n\nAge: {age}\n\nBMI: {BMI.ToString("0.##")}\n\nAdvice\n---------\n\n{advice}";
            }
            


        }

        decimal CalculateBMIForOneUser(User _user)
        {
            User user1 = _user;
            UserProperty userProperty = new UserProperty();
            userProperty = userPropertyService.GetActiveUserPropertyByuserId(user1.Id);
            if (userProperty != null)
            {
                decimal HeightbyMeter = (userProperty.Height / 100M);
                decimal calculation = Convert.ToDecimal(Math.Pow(Convert.ToDouble(HeightbyMeter), 2));
                decimal bMI = userProperty.Weight / calculation;
                return bMI;
            }
            else
            {
                return 0;
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            Generate();
            User user = new User();
            user = GetUser();
            todaysMeals = mealService.GetTodaysMealbyUserId(user.Id);
            
            if (todaysMeals.Count>0)
            {
                foreach (Meal meal in todaysMeals)
                {

                    if ((DateTime.Now - meal.Date).TotalDays > 0 || (DateTime.Now - meal.Date).TotalDays <= 1)
                    {

                        if (meal.RepastId == 1)
                        {

                            Button button = new Button();
                            button.Name = "button1";
                            button.Size = new System.Drawing.Size(135, 135);
                            
                            button.TabIndex = 0;
                            if (mealDetailService.GetMealsbyMealId(meal.Id) == null)
                            {
                                button.Text = $" Meal Name: {meal.Name}\n----------------\nTotal Calories: 0";
                                button.FlatStyle = FlatStyle.Flat;

                                flpBreakfast.Controls.Add(button);

                            }
                            else if (mealDetailService.GetMealsbyMealId(meal.Id) != null)
                            {
                                button.Text = $" Meal Name: {meal.Name}\n----------------\nTotal Calories: {mealDetailService.GetCaloriesforOneMeal(meal.Id)}";
                                button.FlatStyle = FlatStyle.Flat;
                                flpBreakfast.Controls.Add(button);

                            }

                        }

                        else if (meal.RepastId == 2)
                        {

                            Button button = new Button();
                            button.Name = "button1";
                            button.Size = new System.Drawing.Size(135, 135);
                            
                            button.TabIndex = 0;
                            if (mealDetailService.GetMealsbyMealId(meal.Id) == null)
                            {
                                button.Text = $" Meal Name: {meal.Name}\n----------------\nTotal Calories: 0";
                                button.FlatStyle = FlatStyle.Flat;

                                flpLunch.Controls.Add(button);


                            }
                            else if (mealDetailService.GetMealsbyMealId(meal.Id) != null)
                            {
                                button.Text = $" Meal Name: {meal.Name}\n----------------\nTotal Calories: {mealDetailService.GetCaloriesforOneMeal(meal.Id)}";
                                button.FlatStyle = FlatStyle.Flat;
                                flpLunch.Controls.Add(button);

                            }

                        }
                        else if (meal.RepastId == 3)
                        {
                            Button button = new Button();
                            button.Name = "button1";
                            button.Size = new System.Drawing.Size(135, 135);
                            
                            button.TabIndex = 0;
                            if (mealDetailService.GetMealsbyMealId(meal.Id) == null)
                            {
                                button.Text = $" Meal Name: {meal.Name}\n----------------\nTotal Calories: 0";
                                button.FlatStyle = FlatStyle.Flat;

                                flpDinner.Controls.Add(button);
                            }
                            else if (mealDetailService.GetMealsbyMealId(meal.Id) != null)
                            {
                                button.Text = $" Meal Name: {meal.Name}\n----------------\nTotal Calories: {mealDetailService.GetCaloriesforOneMeal(meal.Id)}";
                                button.FlatStyle = FlatStyle.Flat;
                                flpDinner.Controls.Add(button);
                            }
                        }
                        else if (meal.RepastId == 4)
                        {
                            Button button = new Button();
                            button.Name = "button1";
                            button.Size = new System.Drawing.Size(135, 135);
                            this.btnInformation.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            button.TabIndex = 0;
                            if (mealDetailService.GetMealsbyMealId(meal.Id) == null)
                            {
                                button.Text = $" Meal Name: {meal.Name}\n----------------\nTotal Calories: 0";
                                button.FlatStyle = FlatStyle.Flat;

                                flpSnack.Controls.Add(button);
                            }
                            else if (mealDetailService.GetMealsbyMealId(meal.Id) != null)
                            {
                                button.Text = $" Meal Name: {meal.Name}\n----------------\nTotal Calories: {mealDetailService.GetCaloriesforOneMeal(meal.Id)}";
                                button.FlatStyle = FlatStyle.Flat;
                                flpSnack.Controls.Add(button);
                            }
                        }
                    }


                    
                }
            }
            

            
            FillPictureBoxes();
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

            e.Graphics.DrawString(btnInformation.Text, new Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular), Brushes.Black, 20, 20);
        }
    }
}
