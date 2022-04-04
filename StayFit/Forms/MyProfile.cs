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
    public partial class MyProfile : Form
    {
        public MyProfile()
        {
            InitializeComponent();
        }
        UserService userService;
        UserPropertyService userPropertyService;
        GenderService genderService;
        PhysicalActivityService physicalActivityService;
        string mail;
        int genderId;
        int activityId;

        public MyProfile(string _mail)
        {
            InitializeComponent();
            mail = _mail;
            userService = new UserService();
            userPropertyService = new UserPropertyService();
            genderService = new GenderService();
            physicalActivityService = new PhysicalActivityService();
        }
        public User GetUser()
        {
            return userService.GetUserbyMail(mail);
        }
        
        private void btnAddInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtHeight.Text)<320 && Convert.ToInt32(txtHeight.Text) > 0 && Convert.ToDecimal(txtWeight.Text)>0 && Convert.ToDecimal(txtWeight.Text)<450)
                {
                    UserProperty userProperty = new UserProperty();
                    User user = new User();
                    user = GetUser();
                    Gender gender = new Gender();
                    PhysicalActivity physicalActivity = new PhysicalActivity();
                    if (rbMale.Checked == true)
                    {
                        genderId = 2;
                    }
                    else
                    {
                        genderId = 1;
                    }
                    gender = genderService.GetbyGenderId(genderId);
                    userProperty.UserId = user.Id;
                    userProperty.GenderId = genderId;
                    userProperty.BirthDate = dtpBirthDate.Value;
                    userProperty.MeasarumentDate = dtpMeasurementDate.Value;
                    userProperty.Height = Convert.ToInt32(txtHeight.Text);
                    userProperty.Weight = Convert.ToDecimal(txtWeight.Text);
                    if (GetPhoto() != null)
                    {

                        userProperty.Photo = GetPhoto();
                    }

                    if (rbLow.Checked)
                        activityId = 1;
                    else if (rbLight.Checked)
                        activityId = 2;
                    else if (rbAverage.Checked)
                        activityId = 3;
                    else
                        activityId = 4;
                    userProperty.PhysicalActivityId = activityId;

                    userProperty.IsActive = true;
                    userPropertyService.AddUserProperty(userProperty);

                    List<UserProperty> userProperties = new List<UserProperty>();
                    userProperties = userPropertyService.GetUserPropertiesbyuserId(user.Id);
                    if (userProperties != null)
                    {
                        int counter = 0;
                        foreach (UserProperty item in userProperties)
                        {
                            counter++;
                            if (counter == userProperties.Count)
                            {
                                break;
                            }
                            UserProperty userProperty1 = new UserProperty();
                            userProperty1 = userPropertyService.GetById(item.Id);
                            //userProperty1.IsActive = false;
                            userPropertyService.DeleteforUser(userProperty1.Id);
                        }
                    }


                    btnTotalCaloryIntake.Text = CalculateCaloryIntake().ToString("0.##");
                    btnBMI.Text = CalculateBMI().ToString("0.##");
                    MessageBox.Show("User property added");
                    GetUserInformation();
                }
                else
                {
                    MessageBox.Show("Height and weight values must be numeric!");
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong");
            }


        }
        decimal activityFactor;

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
        public decimal CalculateBMI()
        {
            User user = new User();
            user = GetUser();
            UserProperty userProperty = new UserProperty();
            userProperty = userPropertyService.GetActiveUserPropertyByuserId(user.Id);
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
        private void MyProfile_Load(object sender, EventArgs e)
        {
            btnTotalCaloryIntake.Text = CalculateCaloryIntake().ToString("0.##");
            btnBMI.Text = CalculateBMI().ToString("0.##");
            GetUserInformation();
        }

        void GetUserInformation()
        {
            User user = new User();
            user = GetUser();
            string advice = "";

            decimal BMI = CalculateBMIForOneUser(user);
            if (BMI < 18.5M)
            {
                advice = "UNDERWEIGHT";
                btnAdvice.ForeColor = System.Drawing.Color.Yellow;

            }
            else if (BMI > 18.5M && BMI < 24.9M)
            {
                advice = "NORMAL";
                btnAdvice.ForeColor = System.Drawing.Color.Green;

            }
            else if (BMI > 25M && BMI < 29.9M)
            {
                advice = "OVERWEIGHT";
                btnAdvice.ForeColor = System.Drawing.Color.Orange;

            }
            else if (BMI > 29.9M)
            {
                advice = "OBESE";
                btnAdvice.ForeColor = System.Drawing.Color.Red;

            }
            btnAdvice.Text = advice;
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

        private void btnChosePhoto_Click(object sender, EventArgs e)
        {
            AddingPhototoPictureBox();
        }
        public void AddingPhototoPictureBox()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pbProfilePhoto.Image = new Bitmap(open.FileName);
            }
        }
        public byte[] GetPhoto()
        {

            using (MemoryStream ms = new MemoryStream())
            {
                if (pbProfilePhoto.Image != null)
                {
                    Image img = pbProfilePhoto.Image;
                    byte[] arr;
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    arr = ms.ToArray();
                    return arr;
                }
                else
                    return null;
            }

        }

        private void dtpBirthDate_ValueChanged(object sender, EventArgs e)
        {
            dtpBirthDate.MaxDate = DateTime.Now;
        }

        private void dtpMeasurementDate_ValueChanged(object sender, EventArgs e)
        {
            dtpMeasurementDate.MaxDate = DateTime.Now;
        }
    }
}
