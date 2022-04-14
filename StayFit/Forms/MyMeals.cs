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
    public partial class MyMeals : Form
    {
        string mail;
        MealService mealService;
        UserService userService;
        RepastService repastService;
        CategoryService categoryService;
        SubCategoryService subCategoryService;
        ProductService productService;
        MealDetailService mealDetailService;
        public MyMeals()
        {
            InitializeComponent();
        }
        public MyMeals(string _mail)
        {
            InitializeComponent();
            mail = _mail;
            mealService = new MealService();
            userService = new UserService();
            repastService = new RepastService();
            categoryService = new CategoryService();
            subCategoryService = new SubCategoryService();
            productService = new ProductService();
            mealDetailService = new MealDetailService();
            mealDetails = new List<MealDetail>();
        }
        public User GetUser()
        {
            return userService.GetUserbyMail(mail);
        }
        ListViewItem lw;
        List<MealDetail> mealDetails;
        public void FillMealList()
        {
            lvMeals.Items.Clear();
            User user = new User();
            user = GetUser();
            List<Meal> mealsbyUser = new List<Meal>();
            mealsbyUser = mealService.GetMealbyUserId(user.Id, dtpMin.Value, dtpMax.Value.AddHours(+4));


            if (mealsbyUser.Count > 0)
            {
                foreach (Meal item in mealsbyUser)
                {
                    
                    lw = new ListViewItem();
                    lw.Text = item.Name;
                    lw.Tag = item.Id;
                    lw.SubItems.Add(item.Date.ToString());
                    Repast repast = new Repast();
                    repast = repastService.GetById(item.RepastId);
                    lw.SubItems.Add(repast.Name);
                    lvMeals.Items.Add(lw);

                }

            }

        }
        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbRepast.SelectedIndex!=-1 && !string.IsNullOrWhiteSpace(txtMealName.Text))
                {
                    User user = new User();
                    user = GetUser();
                    Meal meal = new Meal();
                    meal.Name = txtMealName.Text;
                    meal.RepastId = (int)cmbRepast.SelectedValue;
                    meal.UserId = user.Id;
                    meal.Date = dtpDate.Value;
                    mealService.AddMeal(meal);
                    FillMealList();
                }
                else if (string.IsNullOrWhiteSpace(txtMealName.Text))
                {
                    MessageBox.Show("Please add a name to meal");
                }
                else
                {
                    MessageBox.Show("Please pick a repast");
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        List<Category> categories;
        private void MyMeals_Load(object sender, EventArgs e)
        {
            dtpMin.Value = DateTime.Today.AddDays(-1);
            FillMealList();
            List<Repast> repasts = new List<Repast>();
            repasts = repastService.GetRepasts();

            cmbRepast.DataSource = repasts;
            cmbRepast.DisplayMember = "Name";
            cmbRepast.ValueMember = "Id";

            categories = new List<Category>();
            categories = categoryService.GetCategoriesforUser();
            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";


            cmbCategory.SelectedIndex = -1;
        }

        private void cmbCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {

            List<SubCategory> subCategories = new List<SubCategory>();
            int value = (int)cmbCategory.SelectedValue;
            subCategories = subCategoryService.GetSubCategorybyCategoryId(value);

            cmbSubcategory.DataSource = subCategories;
            cmbSubcategory.DisplayMember = "Name";
            cmbSubcategory.ValueMember = "Id";
            cmbSubcategory.SelectedIndex = -1;
        }

        private void cmbSubcategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            List<Product> products = new List<Product>();
            products = productService.GetProductbySubCategoryId(Convert.ToInt32(cmbSubcategory.SelectedValue));

            cmbProduct.DataSource = products;
            cmbProduct.DisplayMember = "Name";
            cmbProduct.ValueMember = "Id";
            cmbProduct.SelectedIndex = -1;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

            try
            {
                if (lvMeals.SelectedItems.Count >= 1)
                {                    
                    if (true)
                    {

                    }
                    if (cmbCategory.SelectedIndex != -1 && cmbSubcategory.SelectedIndex != -1 && cmbProduct.SelectedIndex != -1 && nudPortion.Value != 0 && nudPortionWeight.Value != 0)
                    {
                        Product product = productService.GetById((int)cmbProduct.SelectedValue);
                        MealDetail mealDetail = new MealDetail();
                        mealDetail.MealId = (int)lvMeals.SelectedItems[0].Tag;
                        mealDetail.ProductId = (int)cmbProduct.SelectedValue;
                        mealDetail.CaloriesforMeal = (nudPortionWeight.Value * nudPortion.Value / 100) * product.Calories;
                        mealDetail.HealthIndexforMeal = product.HealthIndex;
                        mealDetail.PortionforMeal = Convert.ToInt32(nudPortion.Value);
                        mealDetail.PortionWeightforMeal = Convert.ToInt32(nudPortionWeight.Value);
                        mealDetail.ProteinforMeal = (nudPortionWeight.Value * nudPortion.Value / 100) * product.Protein;
                        if (mealDetailService.GetbyId(mealDetail.MealId,mealDetail.ProductId)==null)
                        {
                            if (mealDetailService.AddMealDetail(mealDetail))
                            {
                                MessageBox.Show("Product added to meal Succesfully");
                            }
                            else
                            {
                                MessageBox.Show("Please do not leave the fields blank!");

                            }
                            FillMealDetailsList();
                        }
                        else
                        {
                            MessageBox.Show("Hata");
                        }
                        
                    }

                }
                else
                {
                    MessageBox.Show("Please do not leave the fields blank!");
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cmbCategory.SelectedIndex = -1;
                cmbSubcategory.SelectedIndex = -1;
                cmbProduct.SelectedIndex = -1;
                MyMeals_Load(sender, e);

                return;
            }           

        }
        public void FillMealDetailsList()
        {
            lvMealDetails.Items.Clear();
            List<MealDetail> mealDetails = new List<MealDetail>();
            mealDetails = mealDetailService.GetMealDetailsforOneMeal(Convert.ToInt32(lvMeals.SelectedItems[0].Tag));
            if (mealDetails.Count > 0)
            {
                Product product = new Product();
                foreach (MealDetail item in mealDetails)
                {
                    lw = new ListViewItem();
                    product = productService.GetById(item.ProductId);
                    lw.Text = product.Name;
                    lw.Tag = item.ProductId;
                    lw.SubItems.Add(item.PortionforMeal.ToString());
                    lw.SubItems.Add(item.PortionWeightforMeal.ToString());
                    lw.SubItems.Add(item.CaloriesforMeal.ToString());
                    lw.SubItems.Add(item.ProteinforMeal.ToString());
                    lw.SubItems.Add(item.HealthIndexforMeal.ToString());
                    lvMealDetails.Items.Add(lw);
                }
            }
        }


        private void lvMeals_MouseDoubleClick(object sender, MouseEventArgs e)
        {           
            txtMealName.Text = lvMeals.SelectedItems[0].Text;
            dtpDate.Value = Convert.ToDateTime(lvMeals.SelectedItems[0].SubItems[1].Text);
            Meal meal = new Meal();
            meal = mealService.GetById((int)lvMeals.SelectedItems[0].Tag);
            cmbRepast.SelectedValue = meal.RepastId;
            FillMealList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                User user = GetUser();
                Meal meal = new Meal();
                if (lvMeals.SelectedItems.Count > 0 && !string.IsNullOrWhiteSpace(txtMealName.Text))
                {
                    meal.Id = Convert.ToInt32(lvMeals.SelectedItems[0].Tag);
                    meal.Name = txtMealName.Text;
                    meal.RepastId = (int)cmbRepast.SelectedValue;
                    meal.UserId = user.Id;
                    meal.Date = dtpDate.Value;
                    mealService.UpdateMeal(meal);
                    FillMealList();
                }                
                else if(lvMeals.SelectedItems.Count<=0)
                {
                    MessageBox.Show("Please pick a meal to update");
                }
                else if (string.IsNullOrWhiteSpace(txtMealName.Text)&& lvMeals.SelectedItems.Count > 0)
                    MessageBox.Show("Meal name can not be empty");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (mealService.DeleteforAdmin((int)lvMeals.SelectedItems[0].Tag))
                {
                    MessageBox.Show("Meal delete is successfull!");
                }
                FillMealList();
                lvMealDetails.Items.Clear();
                clearMealBoxes();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void clearMealBoxes()
        {
            txtMealName.Text = "";
            dtpDate.Value = DateTime.Now;
            cmbRepast.SelectedIndex = -1;
            btnAddMeal.Enabled = true;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearMealBoxes();
        }

        private void lvMeals_MouseClick(object sender, MouseEventArgs e)
        {
            FillMealDetailsList();
        }

        private void dtpMin_ValueChanged(object sender, EventArgs e)
        {
            FillMealList();
            dtpMin.MaxDate = dtpMax.Value.AddDays(-1);
        }

        private void dtpMax_ValueChanged(object sender, EventArgs e)
        {
            FillMealList();
            dtpMax.MinDate = dtpMin.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                mealDetailService.DeleteforAdmin((int)lvMeals.SelectedItems[0].Tag, (int)lvMealDetails.SelectedItems[0].Tag);
                FillMealDetailsList();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
