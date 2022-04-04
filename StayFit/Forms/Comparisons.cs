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
    public partial class Comparisons : Form
    {
        public Comparisons()
        {
            InitializeComponent();
        }
        string mail;
        CategoryService categoryService;
        MealDetailService mealDetailService;
        ProductService productService;
        SubCategoryService subCategoryService;
        Dictionary<int, int> countofCategories;
        Dictionary<int, int> countofCategoriesforUser;
        UserService userService;

        public Comparisons(string _mail)
        {
            InitializeComponent();
            mail = _mail;
            categoryService = new CategoryService();
            mealDetailService = new MealDetailService();
            productService = new ProductService();
            subCategoryService = new SubCategoryService();
            userService = new UserService();


        }
        int userId;
        

        private void btnFavBreakfastCategory_Click(object sender, EventArgs e)
        {
            btnTitle.Text = btnFavBreakfastCategory.Text;
            FilllvforUserbyRepastId(1);
            FilllvGeneralbyRepastId(1);
        }

        private void btnFavLunchCategory_Click(object sender, EventArgs e)
        {
            btnTitle.Text = btnFavLunchCategory.Text;
            FilllvforUserbyRepastId(2);
            FilllvGeneralbyRepastId(2);
        }

        private void btnFavDinnerCategory_Click(object sender, EventArgs e)
        {
            btnTitle.Text = btnFavDinnerCategory.Text;
            FilllvforUserbyRepastId(3);
            FilllvGeneralbyRepastId(3);
        }

        private void btnFavSnackCategory_Click(object sender, EventArgs e)
        {
            btnTitle.Text = btnFavSnackCategory.Text;
            FilllvforUserbyRepastId(4);
            FilllvGeneralbyRepastId(4);
        }

        private void Comparisons_Load(object sender, EventArgs e)
        {           
            dtpMinDate.Value = DateTime.Now.AddDays(-10);
            btnTitle.Text = btnFavBreakfastCategory.Text;
            FilllvforUserbyRepastId(1);
            FilllvGeneralbyRepastId(1);
            FillPictureBoxes(1, pbBreakfast);
            FillPictureBoxes(2, pbLunch);
            FillPictureBoxes(3, pbDinner);
            FillPictureBoxes(4, pbSnack);
        }
        public User GetUser()
        {
            return userService.GetUserbyMail(mail);
        }
        public void FillLvforUser()
        {
            lvUserFavorites.Items.Clear();
            User user = new User();
            user = GetUser();
            int Id = user.Id;
            countofCategoriesforUser = new Dictionary<int, int>();
            countofCategoriesforUser = mealDetailService.GetMostPreferredCategoriesbyUserandDateService(Id, dtpMinDate.Value, dtpMaxDate.Value);
            foreach (var item in countofCategoriesforUser)
            {
                ListViewItem lw = new ListViewItem();
                Category category = new Category();
                category = categoryService.GetbyCategoryId(item.Key);
                lw.Text = category.Name;
                lw.SubItems.Add(item.Value.ToString());
                lvUserFavorites.Items.Add(lw);
            }
        }
        public void FillPictureBoxes(int repastId, PictureBox pictureBox)
        {
            User user = new User();
            user = GetUser();
            userId = user.Id;
            Dictionary<int, int> getCategory = new Dictionary<int, int>();

            getCategory = mealDetailService.GetMostPreferredCategoriesbyUserandDateandRepast(userId, dtpMinDate.Value, dtpMaxDate.Value, repastId);
            Category category = new Category();
            if (getCategory.Count > 0)
            {
                foreach (var item in getCategory)
                {
                    category = categoryService.GetbyCategoryId(item.Key);
                    break;
                }
                Byte[] byteBLOBData2 = new Byte[0];
                byteBLOBData2 = (Byte[])category.Photo;
                MemoryStream stmBLOBData = new MemoryStream(byteBLOBData2);
                if (pictureBox.Image != null)
                {
                    pictureBox.Image.Dispose();
                }
                pictureBox.Image = Image.FromStream(stmBLOBData);
            }

        }
        public void FilllvforUserbyRepastId(int repastId)
        {
            lvUserFavorites.Items.Clear();
            User user = new User();
            user = GetUser();
            userId = user.Id;
            countofCategoriesforUser = new Dictionary<int, int>();
            countofCategoriesforUser = mealDetailService.GetMostPreferredCategoriesbyUserandDateandRepast(userId, dtpMinDate.Value, dtpMaxDate.Value, repastId);
            foreach (var item in countofCategoriesforUser)
            {
                ListViewItem lw = new ListViewItem();
                Category category = new Category();
                category = categoryService.GetbyCategoryId(item.Key);
                lw.Text = category.Name;
                lw.SubItems.Add(item.Value.ToString());
                lvUserFavorites.Items.Add(lw);
            }
        }
        public void FilllvGeneralbyRepastId(int repastId)
        {
            lvGeneralFavorites.Items.Clear();

            countofCategories = new Dictionary<int, int>();
            countofCategories = mealDetailService.GetMostPreferredCategoriesforGeneralbyRepast(dtpMinDate.Value, dtpMaxDate.Value, repastId);
            foreach (var item in countofCategories)
            {
                ListViewItem lw = new ListViewItem();
                Category category = new Category();
                category = categoryService.GetbyCategoryId(item.Key);
                lw.Text = category.Name;
                lw.SubItems.Add(item.Value.ToString());
                lvGeneralFavorites.Items.Add(lw);
            }
        }
        public void FillLvforGeneral()
        {
            lvGeneralFavorites.Items.Clear();
            lvUserFavorites.Items.Clear();

            countofCategories = mealDetailService.GetMostPrefferredCategoriesbyDate(dtpMinDate.Value, dtpMaxDate.Value);
            foreach (var item in countofCategories)
            {
                ListViewItem lw = new ListViewItem();
                Category category = new Category();
                category = categoryService.GetbyCategoryId(item.Key);
                lw.Text = category.Name;
                lw.SubItems.Add(item.Value.ToString());
                lvGeneralFavorites.Items.Add(lw);
            }
        }

        private void dtpMinDate_ValueChanged(object sender, EventArgs e)
        {
            dtpMinDate.MaxDate = dtpMaxDate.Value.AddDays(-1);
            FillPictureBoxes(1, pbBreakfast);
            FillPictureBoxes(2, pbLunch);
            FillPictureBoxes(3, pbDinner);
            FillPictureBoxes(4, pbSnack);
        }

        private void dtpMaxDate_ValueChanged(object sender, EventArgs e)
        {
            dtpMaxDate.MinDate = dtpMinDate.Value;
            FillPictureBoxes(1, pbBreakfast);
            FillPictureBoxes(2, pbLunch);
            FillPictureBoxes(3, pbDinner);
            FillPictureBoxes(4, pbSnack);
        }
    }
}
