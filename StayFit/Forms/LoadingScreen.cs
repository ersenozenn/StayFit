using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Runtime.InteropServices;
using StayFitNTier.BLL.Services;

namespace StayFit.Forms
{
    public partial class LoadingScreen : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse

        );


        public LoadingScreen()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
            userService = new UserService();
            

        }
        UserService userService;
        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            
            panel2.Height += 5;
            if (panel2.Height >= panel1.Height)
            {
                timer1.Stop();
                Login login = new Login();
                login.Show();
                this.Hide();

            }
            if (userService.GetActiveUsers() == null)
            {

            }
        }

       
        
    }
}
