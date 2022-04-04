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
    public partial class DeleteProduct : Form
    {
        public DeleteProduct()
        {
            InitializeComponent();
            categoryService = new CategoryService();
            subCategoryService = new SubCategoryService();
            productService = new ProductService();
        }
                       
        CategoryService categoryService;
        SubCategoryService subCategoryService;
        ProductService productService;        
        List<Category> categories;

        private void DeleteProduct_Load(object sender, EventArgs e)
        {
            categories = new List<Category>();
            categories = categoryService.GetCategoriesforUser();
            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";


            cmbCategory.SelectedIndex = -1;

        }

        private void cmbSubcategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            List<Product> products = new List<Product>();
            products = productService.GetProductbySubCategoryId(Convert.ToInt32(cmbSubcategory.SelectedValue));

            cmbProduct.DataSource = products;
            cmbProduct.DisplayMember = "Name";
            cmbProduct.ValueMember = "Id";
        }

        private void cmbCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            List<SubCategory> subCategories = new List<SubCategory>();
            int value = (int)cmbCategory.SelectedValue;
            subCategories = subCategoryService.GetSubCategorybyCategoryId(value);

            cmbSubcategory.DataSource = subCategories;
            cmbSubcategory.DisplayMember = "Name";
            cmbSubcategory.ValueMember = "Id";
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategory.SelectedIndex!=-1&&cmbSubcategory.SelectedIndex!=-1&&cmbProduct.SelectedIndex!=-1)
                {
                    if (productService.DeleteforUser((int)cmbProduct.SelectedValue))
                        MessageBox.Show("Deleted successfully");

                    else
                        MessageBox.Show("Something went wrong");
                }
                else
                {
                    MessageBox.Show("Please do not leave the fields blank.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
