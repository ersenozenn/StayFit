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
    public partial class AdminAddCategory : Form
    {
        CategoryService categoryService;
        
        public AdminAddCategory()
        {
            InitializeComponent();
            categoryService = new CategoryService();
            
        }


        List<Category> categories;

        private void GetCategories()
        {
            categories = new List<Category>();
            categories = categoryService.GetCategoriesforUser();
            lstCategories.DataSource = categories;
            lstCategories.DisplayMember = "Name";
            lstCategories.ValueMember = "Id";
        }
        private void AdminAddCategory_Load(object sender, EventArgs e)
        {
            GetCategories();
        }
        public void AddingPhototoPictureBox()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg;*.jpeg)|*.jpg;*.jpeg;";
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


        private void btnAdd_Click(object sender, EventArgs e)
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
                    Category category1 = new Category();
                    category1.Name = txtCategory.Text;
                    category1.Photo = GetPhoto();
                    category1.IsActive = active;
                    if (categoryService.Insert(category1))
                    {
                        MessageBox.Show("Category Added");
                    }
                    else MessageBox.Show("Something went Wrong!");
                }
                else if (GetPhoto() == null)
                {
                    Category category = new Category();
                    category.Name = txtCategory.Text;
                    category.IsActive = active;
                    if (categoryService.Insert(category))
                    {
                        MessageBox.Show("Category Added");
                    }
                    else MessageBox.Show("Something went Wrong!");
                }

                GetCategories();
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
                if (categoryService.DeleteforAdmin((int)(lstCategories.SelectedValue)))
                {
                    MessageBox.Show("Category Deleted");
                }
                else
                    MessageBox.Show("Something went wrong!");
                GetCategories();
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
                else
                    active = false;
                Category category = new Category();
                category.Id = (int)(lstCategories.SelectedValue);
                category.Name = txtCategory.Text;
                category.IsActive = active;
                if (GetPhoto() != null)
                {
                    category.Photo = GetPhoto();
                }

                if (categoryService.UpdateforAdmin(category))
                {
                    MessageBox.Show("Category Updated");
                }
                else
                    MessageBox.Show("Something went wrong!");

                GetCategories();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void lstCategories_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                Category category = new Category();
                category = categoryService.GetbyCategoryId((int)lstCategories.SelectedValue);
                txtCategory.Text = category.Name;
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
