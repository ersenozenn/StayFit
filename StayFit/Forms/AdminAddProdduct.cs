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
    public partial class AdminAddProdduct : Form
    {
        ProductService productService;
        CategoryService categoryService;
        SubCategoryService subCategoryService;
        public AdminAddProdduct()
        {
            InitializeComponent();
            productService = new ProductService();
            categoryService = new CategoryService();
            subCategoryService = new SubCategoryService();
        }
        List<Category> categories;

        public void GetAllProducts()
        {

            dataProductInfo.Rows.Clear();
            List<Product> products = productService.GetActiveProducts();

            foreach (Product product in products)
            {
                int row=dataProductInfo.Rows.Add(product.Name, product.PortionWeight, product.Calories, product.Protein, product.HealthIndex,product.IsActive);
                dataProductInfo.Rows[row].Tag = product.Id;
            }
        }
        
        private void AdminAddProdduct_Load(object sender, EventArgs e)
        {
            try
            {                
                FillCategoryComboBox();
                GetAllProducts();
                dataProductInfo_DoubleClick(sender, e);
                                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
       public void ShowTotal()
        {           
            decimal totalCalories = 0;
            decimal totalProtein = 0;
            for (int i = 0; i < dataProductInfo.Rows.Count; i++)
            {                
                totalCalories += Convert.ToDecimal(dataProductInfo.Rows[i].Cells[2]);
                totalProtein += Convert.ToDecimal(dataProductInfo.Rows[i].Cells[3]);
            }
            lblTotalCalorie.Text = totalCalories.ToString();
            lblTotalProtein.Text = totalProtein.ToString();
        }
        private void FillCategoryComboBox()
        {
            categories = new List<Category>();
            categories = categoryService.GetCategoriesforUser();
            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            bool active;
            if (rdbActive.Checked)
            {
                active = true;
            }
            else
                active = false;
            try
            {
                if (GetPhoto()!=null)
                {
                    Product product = new Product();
                    product.Name = txtProductName.Text;
                    product.PortionWeight = nudPortionWeight.Value;
                    product.Protein = nudProtein.Value;
                    product.Calories = nudCalories.Value;
                    product.HealthIndex = cmbHealthIndex.SelectedIndex;
                    product.SubCategoryId = (int)(cmbSubCategory.SelectedValue);
                    product.Photo = GetPhoto();
                    product.IsActive = active;
                    productService.AddProduct(product);
                }
                else if (GetPhoto() == null)
                {
                    Product product1 = new Product();
                    product1.Name = txtProductName.Text;
                    product1.PortionWeight = nudPortionWeight.Value;
                    product1.Protein = nudProtein.Value;
                    product1.Calories = nudCalories.Value;
                    product1.HealthIndex = cmbHealthIndex.SelectedIndex;
                    product1.SubCategoryId = (int)(cmbSubCategory.SelectedValue);
                    product1.IsActive = active;
                    productService.AddProduct(product1);
                }
                
                ClearEverything();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
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
                Image img = pbProduct.Image;
                byte[] arr;
                if (img != null)
                {
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    arr = ms.ToArray();
                    return arr;
                }
                else
                {
                    return null;
                }
            }

        }
        private void cmbCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                FillSubCategoryComboBox();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
                       
        }
        public void FillSubCategoryComboBox()
        {
            List<SubCategory> subCategories = new List<SubCategory>();
            int value = (int)cmbCategory.SelectedValue;
            subCategories = subCategoryService.GetSubCategorybyCategoryId(value);

            cmbSubCategory.DataSource = subCategories;
            cmbSubCategory.DisplayMember = "Name";
            cmbSubCategory.ValueMember = "Id";
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                productService.DeleteforAdmin((int)(dataProductInfo.SelectedRows[0].Tag));
                ClearEverything();
                GetAllProducts();
                MessageBox.Show("Deleted Successfully");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
        public void ClearEverything()
        {
            txtProductName.Text = "";
            nudCalories.Value = 0;
            nudProtein.Value = 0;
            cmbHealthIndex.SelectedIndex = 1;
            cmbCategory.SelectedIndex = -1;
            cmbSubCategory.SelectedIndex = -1;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool active;
            if (rdbActive.Checked)
            {
                active = true;
            }
            else
                active = false;
            try
            {
                Product product = new Product();
                product.Id = (int)(dataProductInfo.SelectedRows[0].Tag);
                product.Name = txtProductName.Text;
                product.PortionWeight = nudPortionWeight.Value;
                product.Protein = nudProtein.Value;
                product.Calories = nudCalories.Value;
                product.HealthIndex = cmbHealthIndex.SelectedIndex;
                product.SubCategoryId = (int)(cmbSubCategory.SelectedValue);
                product.IsActive = active;
                if (GetPhoto()!=null)
                {
                    product.Photo = GetPhoto();
                }

                if (productService.UpdateforAdmin(product))
                {
                    MessageBox.Show("Update succesfull");
                    ClearEverything();
                    GetAllProducts();
                }
                else
                    MessageBox.Show("Something went wrong!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }         
        }

        private void dataProductInfo_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product();
                product = productService.GetById(Convert.ToInt32(dataProductInfo.SelectedRows[0].Tag));
                txtProductName.Text = product.Name;
                nudPortionWeight.Value = product.PortionWeight;
                nudCalories.Value = product.Calories;
                nudProtein.Value = product.Protein;
                cmbHealthIndex.SelectedIndex = (int)product.HealthIndex - 1;

                int categoryId = categoryService.GetCategoryIdbyProductId(product.Id);

                Category category = new Category();
                category = categoryService.GetbyCategoryId(categoryId);

                cmbCategory.SelectedValue = category.Id;
                cmbCategory_SelectionChangeCommitted(sender, e);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
               
            
            
        }
        
        private void btnChosePhoto_Click(object sender, EventArgs e)
        {
            try
            {
                AddingPhototoPictureBox();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
