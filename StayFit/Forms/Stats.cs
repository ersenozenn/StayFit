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
    public partial class Stats : Form
    {
        public Stats()
        {
            InitializeComponent();
        }
        string mail;
        MealDetailService mealDetailService;
        UserService userService;
        UserPropertyService userPropertyService;
        MealService mealService;

        public Stats(string _mail)
        {
            InitializeComponent();
            mail = _mail;
            mealDetailService = new MealDetailService();
            userService = new UserService();
            userPropertyService = new UserPropertyService();
            mealService = new MealService();
        }
        public User GetUser()
        {
            return userService.GetUserbyMail(mail);
        }
        private void Stats_Load(object sender, EventArgs e)
        {
            try
            {
                List<Meal> meals = new List<Meal>();
                User user = GetUser();
                meals = mealService.GetMealbyUserId(user.Id,DateTime.Now.AddYears(-100),DateTime.Now);
                if (meals.Count>0)
                {
                    btnInfo.Text = "";
                    dtpMinValue.Value = DateTime.Now.AddDays(-1);
                    FillEverything();
                    
                }
                else
                {
                    btnInfo.Text= "You have not added any dishes yet.";
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void FillTotalCalories()
        {
            User user = GetUser();
            List<Meal> meals = new List<Meal>();
            if (mealService.GetMealbyUserId(user.Id) != null)
            {
                meals = mealService.GetMealbyUserId(user.Id);
                foreach (var item in meals)
                {
                    if (mealDetailService.GetProductsforOneMeal(item.Id) != null)
                    {
                        btnTotalCalories.Text = mealDetailService.GetCaloriesbyTime(user.Id, dtpMinValue.Value, dtpMaxValue.Value).ToString("0.##");
                        break;
                    }
                }
            }            

        }
        public void FillTotalProtein()
        {
            User user = GetUser();
            List<Meal> meals = new List<Meal>();
            if (mealService.GetMealbyUserId(user.Id) != null)
            {
                meals = mealService.GetMealbyUserId(user.Id);
                foreach (var item in meals)
                {
                    if (mealDetailService.GetProductsforOneMeal(item.Id) != null)
                    {
                        btnTotalProtein.Text = mealDetailService.GetProteinbyTime(user.Id, dtpMinValue.Value, dtpMaxValue.Value).ToString();
                        break;
                    }
                }
            }            

        }        
        public void FillAverageHealthIndex()
        {
            User user = GetUser();
            
            List<Meal> meals = new List<Meal>();
            if (mealService.GetMealbyUserId(user.Id)!=null)
            {
                meals = mealService.GetMealbyUserId(user.Id);
                foreach (var item in meals)
                {
                    if (mealDetailService.GetProductsforOneMeal(item.Id) != null)
                    {
                        btnAverageHIndex.Text = mealDetailService.GetHealthIndexbyTime(user.Id, dtpMinValue.Value, dtpMaxValue.Value).ToString("0.##");
                        break;
                    }
                }
            }         
                       
             
        }
        public decimal GetCaloryIntake(decimal _activityFactor, UserProperty userProperty)
        {
            if (userProperty.GenderId == 1)
            {
                return (10 * userProperty.Weight * 6.25M * userProperty.Height - 5 * (DateTime.Now.Year - userProperty.BirthDate.Year) - 161) * _activityFactor / 1000;
            }
            else
            {
                return (10 * userProperty.Weight * 6.25M * userProperty.Height - 5 * (DateTime.Now.Year - userProperty.BirthDate.Year) + 5) * _activityFactor / 1000;
            }
        }
        decimal activityFactor;
        public decimal CalculateCaloryIntake()
        {
            User user = new User();
            user = GetUser();
            UserProperty userProperty = new UserProperty();
            userProperty = userPropertyService.GetActiveUserPropertyByuserId(user.Id);
            if (userProperty != null)
            {
                if (userProperty.PhysicalActivityId == 1)
                    activityFactor = 1.2M;
                else if (userProperty.PhysicalActivityId == 2)
                    activityFactor = 1.4M;
                else if (userProperty.PhysicalActivityId == 3)
                    activityFactor = 1.55M;
                else if (userProperty.PhysicalActivityId == 4)
                    activityFactor = 1.9M;

                return GetCaloryIntake(activityFactor, userProperty);
            }
            else
            {
                return 0;
            }

        }
        public void FillTotalCalorieNeed()
        {
            btnTotalCaloriesNeed.Text = (CalculateCaloryIntake()* Convert.ToDecimal((dtpMaxValue.Value - dtpMinValue.Value).TotalDays)).ToString("0.##");
        }
        public void FillTotalProteinNeed()
        {
            User user = new User();
            user = GetUser();
            UserProperty userProperty = new UserProperty();
            userProperty = userPropertyService.GetActiveUserPropertyByuserId(user.Id);
            if (userProperty!=null)
            {
                if (userProperty.PhysicalActivityId == 1)
                {
                    btnTotalProteinNeed.Text = (userProperty.Weight * 0.8M* Convert.ToDecimal((dtpMaxValue.Value - dtpMinValue.Value).TotalDays)).ToString("0.##");
                }
                else if (userProperty.PhysicalActivityId == 2)
                {
                    btnTotalProteinNeed.Text = (userProperty.Weight * 1M * Convert.ToDecimal((dtpMaxValue.Value - dtpMinValue.Value).TotalDays)).ToString("0.##");
                }
                else if (userProperty.PhysicalActivityId == 3)
                {
                    btnTotalProteinNeed.Text = (userProperty.Weight * 1.2M * Convert.ToDecimal((dtpMaxValue.Value - dtpMinValue.Value).TotalDays)).ToString("0.##");
                }
                else if (userProperty.PhysicalActivityId == 4)
                {
                    btnTotalProteinNeed.Text = (userProperty.Weight * 1.5M * Convert.ToDecimal((dtpMaxValue.Value - dtpMinValue.Value).TotalDays)).ToString("0.##");
                }
                btnInfo.Text = "";
            }
            else
            {
                btnInfo.Text="Please input your information on 'My Profile' screen!";
            }
            
        }

        private void dtpMinValue_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dtpMinValue.MaxDate = dtpMaxValue.Value.AddDays(-1);
                FillEverything();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtpMaxValue_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dtpMaxValue.MinDate = dtpMinValue.Value;
                FillEverything();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void FillEverything()
        {
            FillAverageHealthIndex();
            FillTotalCalorieNeed();
            FillTotalCalories();
            FillTotalProtein();
            FillTotalProteinNeed();
        }
    }
}
