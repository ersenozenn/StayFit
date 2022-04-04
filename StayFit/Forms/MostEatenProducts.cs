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
    public partial class MostEatenProducts : Form
    {
        public MostEatenProducts()
        {
            InitializeComponent();
        }
        public MostEatenProducts(string _mail)
        {
            InitializeComponent();
            mail = _mail;
            mealDetailService = new MealDetailService();
            userService = new UserService();
            productService = new ProductService();
        }
        string mail;
        MealDetailService mealDetailService;
        ProductService productService;
        UserService userService;
        Dictionary<int, int> productsforUser;
        Dictionary<int, int> productsforGeneral;
        Dictionary<int, int> productsforBreakFast;
        Dictionary<int, int> productsforLunch;
        Dictionary<int, int> productsforDinner;
        Dictionary<int, int> productsforSnack;

        private void MostEatenProducts_Load(object sender, EventArgs e)
        {
            try
            {
                
                FillListViewforUser(mail);
                FillListViewforGeneral();

                productsforBreakFast = new Dictionary<int, int>();
                productsforBreakFast = GetMostEatenProductbyRepast(1);
                if (productsforBreakFast.Count>0)
                {
                    if (productsforBreakFast.Values.First()>0)
                    {
                        Product product = new Product();
                        product = productService.GetById(productsforBreakFast.Keys.First());
                        lblBreakfastProductName.Text = product.Name;
                        lblBreakfastProductCount.Text = productsforBreakFast.Values.First().ToString();

                        Byte[] byteBLOBData = new Byte[0];
                        byteBLOBData = (Byte[])product.Photo;
                        MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);

                        if (pbBreakfast.Image != null)
                        {
                            pbBreakfast.Image.Dispose();
                        }

                        pbBreakfast.Image = Image.FromStream(stmBLOBData);
                    }
                    
                    
                }
                

                productsforLunch = new Dictionary<int, int>();
                productsforLunch = GetMostEatenProductbyRepast(2);
                if (productsforLunch.Count>0)
                {
                    if (productsforLunch.Values.First()>0)
                    {
                        Product product1 = new Product();
                        product1 = productService.GetById(productsforLunch.Keys.First());
                        lblLunchProductName.Text = product1.Name;
                        lblLunchProductCount.Text = productsforLunch.Values.First().ToString();

                        Byte[] byteBLOBData1 = new Byte[0];
                        byteBLOBData1 = (Byte[])product1.Photo;
                        MemoryStream stmBLOBData = new MemoryStream(byteBLOBData1);
                        if (pbLunch.Image != null)
                        {
                            pbLunch.Image.Dispose();
                        }
                        pbLunch.Image = Image.FromStream(stmBLOBData);
                    }
                    
                }
                

                productsforDinner = new Dictionary<int, int>();
                productsforDinner = GetMostEatenProductbyRepast(3);
                if (productsforDinner.Count>0)
                {
                    if (productsforDinner.Values.First()>0)
                    {
                        Product product2 = new Product();
                        product2 = productService.GetById(productsforDinner.Keys.First());
                        lblDinnerProductName.Text = product2.Name;
                        lblDinnerProductCount.Text = productsforDinner.Values.First().ToString();

                        Byte[] byteBLOBData2 = new Byte[0];
                        byteBLOBData2 = (Byte[])product2.Photo;
                        MemoryStream stmBLOBData = new MemoryStream(byteBLOBData2);
                        if (pbDinner.Image != null)
                        {
                            pbDinner.Image.Dispose();
                        }
                        pbDinner.Image = Image.FromStream(stmBLOBData);
                    }
                   
                }
                
                productsforSnack = new Dictionary<int, int>();
                productsforSnack = GetMostEatenProductbyRepast(4);
                if (productsforSnack.Count>0)
                {
                    if (productsforSnack.Values.First()>0)
                    {
                        Product product3 = new Product();
                        product3 = productService.GetById(productsforSnack.Keys.First());
                        lblSnackProductName.Text = product3.Name;
                        lblSnackProductCount.Text = productsforSnack.Values.First().ToString();

                        Byte[] byteBLOBData3 = new Byte[0];
                        byteBLOBData3 = (Byte[])product3.Photo;
                        MemoryStream stmBLOBData = new MemoryStream(byteBLOBData3);
                        if (pbSnack.Image != null)
                        {
                            pbSnack.Image.Dispose();
                        }
                        pbSnack.Image = Image.FromStream(stmBLOBData);
                    }
                    
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public User GetUser()
        {
            return userService.GetUserbyMail(mail);
        }
        public void FillListViewforUser(string userMail)
        {
            lvMyFavorites.Items.Clear();
            User user = GetUser();

            productsforUser = new Dictionary<int, int>();
            productsforUser = mealDetailService.GetMostPreferredProductsbyUser(user.Id);
            foreach (var item in productsforUser)
            {
                ListViewItem lw = new ListViewItem();
                Product product = new Product();
                product = productService.GetById(item.Key);
                lw.Text = product.Name;
                lw.SubItems.Add(item.Value.ToString());
                lvMyFavorites.Items.Add(lw);
            }
        }
        public void FillListViewforGeneral()
        {
            lvGeneralFavorites.Items.Clear();
            productsforGeneral = new Dictionary<int, int>();
            productsforGeneral = mealDetailService.GetMostPreferredProducts();
            foreach (var item in productsforGeneral)
            {
                ListViewItem lw = new ListViewItem();
                Product product = new Product();
                product = productService.GetById(item.Key);
                lw.Text = product.Name;
                lw.SubItems.Add(item.Value.ToString());
                lvGeneralFavorites.Items.Add(lw);
            }
        }
        public Dictionary<int, int> GetMostEatenProductbyRepast(int repastId)
        {

            return mealDetailService.GetMostPreferredProductsbyRepast(repastId);
        }
    }
}
