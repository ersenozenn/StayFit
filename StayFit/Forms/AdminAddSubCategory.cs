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
    public partial class AdminAddSubCategory : Form
    {
        CategoryService categoryService;
        SubCategoryService subCategoryService;
        public AdminAddSubCategory()
        {
            InitializeComponent();
            categoryService = new CategoryService();
            subCategoryService = new SubCategoryService();
        }
        List<Category> categories;
        List<SubCategory> subCategories;

        private void GetCategories()
        {
            categories = new List<Category>();
            categories = categoryService.GetCategories();
            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";
        }

        private void GetSubCategories()
        {
            subCategories = new List<SubCategory>();
            subCategories = subCategoryService.GetSubCategorybyCategoryId((int)(cmbCategory.SelectedValue));
        }

        private void AdminAddSubCategory_Load(object sender, EventArgs e)
        {
            try
            {
                GetCategories();
                GetSubCategoryList();
                lstSubCategories.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void GetSubCategoryList()
        {
            subCategories = new List<SubCategory>();
            subCategories = subCategoryService.GetSubCategories();
            lstSubCategories.DataSource = subCategories;
            lstSubCategories.DisplayMember = "Name";
            lstSubCategories.ValueMember = "Id";
        }

        private void btnAddSubCategory_Click(object sender, EventArgs e)
        {
            try
            {
                bool active;
                if (rdbActive.Checked)
                {
                    active = true;
                }
                else
                    active = false;
                if (GetPhoto() != null)
                {
                    SubCategory subCategory = new SubCategory();
                    subCategory.Name = txtSubCategory.Text;
                    subCategory.CategoryId = (int)(cmbCategory.SelectedValue);
                    subCategory.Photo = GetPhoto();
                    subCategory.IsActive = active;

                    if (subCategoryService.AddSubCategory(subCategory))
                    {
                        MessageBox.Show("SubCategory added");
                    }
                    else MessageBox.Show("Something went Wrong!");
                }
                else if (GetPhoto() == null)
                {
                    SubCategory subCategory1 = new SubCategory();
                    subCategory1.Name = txtSubCategory.Text;
                    subCategory1.CategoryId = (int)(cmbCategory.SelectedValue);
                    subCategory1.IsActive = active;

                    if (subCategoryService.AddSubCategory(subCategory1))
                    {
                        MessageBox.Show("SubCategory added");
                    }
                    else MessageBox.Show("Something went Wrong!");
                }
                GetSubCategories();
                GetSubCategoryList();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                subCategoryService.DeleteforAdmin((int)(lstSubCategories.SelectedValue));
                GetSubCategories();
                GetSubCategoryList();
                MessageBox.Show("Deleted successfully");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void cmbCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                GetSubCategories();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                bool active;
                if (rdbActive.Checked)
                {
                    active = true;
                }

                if (lstSubCategories.SelectedIndex != -1)
                {
                    active = false;
                    SubCategory subCategory = new SubCategory();
                    subCategory.Id = (int)(lstSubCategories.SelectedValue);
                    subCategory.Name = txtSubCategory.Text;
                    subCategory.CategoryId = (int)(cmbCategory.SelectedValue);
                    subCategory.IsActive = active;
                    if (GetPhoto() != null)
                    {
                        subCategory.Photo = GetPhoto();
                    }

                    if (subCategoryService.UpdateforAdmin(subCategory))
                    {
                        MessageBox.Show("SubCategory Updated");
                    }
                    else MessageBox.Show("Something went wrong!");
                    GetSubCategories();
                    GetSubCategoryList();
                }


                
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void lstSubCategories_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int categoryId = categoryService.GetCategoryIdbySubCategoryId((int)lstSubCategories.SelectedValue);
                cmbCategory.SelectedValue = categoryId;
                cmbCategory_SelectionChangeCommitted(sender, e);
                txtSubCategory.Text = lstSubCategories.Text;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        public void AddingPhototoPictureBox()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg;*.jpeg;)*.png;|*.jpg;*.jpeg;*.png;";
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
