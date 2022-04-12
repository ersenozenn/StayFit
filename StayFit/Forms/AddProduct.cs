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
    public partial class AddProduct : Form
    {
        ProductService productService;
        CategoryService categoryService;
        SubCategoryService subCategoryService;
        public AddProduct()
        {
            InitializeComponent();
            productService = new ProductService();
            categoryService = new CategoryService();
            subCategoryService = new SubCategoryService();
        }
        private void FillCategoryComboBox()
        {
            List<Category> categories = new List<Category>();
            categories = categoryService.GetCategoriesforUser();
            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtProductName.Text) && nudPortionWeight.Value != 0 && nudCalories.Value != 0 && cmbHealthIndex.SelectedIndex != -1 && cmbSubCategory.SelectedIndex != -1 && cmbCategory.SelectedIndex != -1)
                {
                    if (GetPhoto()==null)
                    {
                        Product product1 = new Product();
                        product1.Name = txtProductName.Text;
                        product1.PortionWeight = nudPortionWeight.Value;
                        product1.Protein = nudProtein.Value;
                        product1.Calories = nudCalories.Value;
                        product1.HealthIndex = cmbHealthIndex.SelectedIndex;
                        product1.SubCategoryId = (int)(cmbSubCategory.SelectedValue);
                        if (productService.AddProduct(product1))
                        {
                            MessageBox.Show("Product Added");
                        }
                        else MessageBox.Show("Something went wrong!");
                    }
                    else if (GetPhoto() != null)
                    {
                        Product product = new Product();
                        product.Name = txtProductName.Text;
                        product.PortionWeight = nudPortionWeight.Value;
                        product.Protein = nudProtein.Value;
                        product.Calories = nudCalories.Value;
                        product.HealthIndex = cmbHealthIndex.SelectedIndex;
                        product.SubCategoryId = (int)(cmbSubCategory.SelectedValue);
                        product.Photo = GetPhoto();
                        if (productService.AddProduct(product))
                        {
                            MessageBox.Show("Product Added");
                        }
                        else MessageBox.Show("Something went wrong!");
                    }




                    
                }
                else
                    MessageBox.Show("Please do not leave the fields blank");
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

            try
            {
                FillCategoryComboBox();
                cmbCategory.SelectedIndex = -1;
                cmbSubCategory.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        
        private void GetSubCategoriesByCategoryId()
        {
            List<SubCategory> subCategories = new List<SubCategory>();
            int value = (int)cmbCategory.SelectedValue;
            subCategories = subCategoryService.GetSubCategorybyCategoryId(value);

            cmbSubCategory.DataSource = subCategories;
            cmbSubCategory.DisplayMember = "Name";
            cmbSubCategory.ValueMember = "Id";
        }
        public void AddingPhototoPictureBox()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pbProduct.Image = new Bitmap(open.FileName);
            }
        }
        public byte[] GetPhoto()
        {           
                
                using (MemoryStream ms = new MemoryStream())
                {
                if (pbProduct.Image != null)
                {
                    Image img = pbProduct.Image;
                    byte[] arr;
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    arr = ms.ToArray();
                    return arr;
                }
                else
                    return null;
            }              
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddingPhototoPictureBox();
        }

        private void cmbCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                List<SubCategory> subCategories = new List<SubCategory>();
                int value = (int)cmbCategory.SelectedValue;
                subCategories = subCategoryService.GetSubCategorybyCategoryId(value);

                cmbSubCategory.DataSource = subCategories;
                cmbSubCategory.DisplayMember = "Name";
                cmbSubCategory.ValueMember = "Id";
                cmbSubCategory.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
