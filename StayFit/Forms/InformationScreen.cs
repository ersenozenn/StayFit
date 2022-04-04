using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StayFit.Forms
{
    public partial class InformationScreen : Form
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
        public InformationScreen()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }
        bool drag = false;
        Point start_point = new Point(0, 0);

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

    

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }

        }

        private void panelHeader_MouseUp(object sender, MouseEventArgs e)
        {
                drag = false;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InformationScreen_Load(object sender, EventArgs e)
        {
            btnText.Text = "# This program created for diet plan to jumpstart weight loss and control their food intake.\n" +
                "# Calculate your exact calorie needs to optimize your weight loss journey.\n" +
                "# The number of calories you need depends on many factors, including physical activity, gender, age and weight loss goals\n" +
                "# It’s important to estimate how many calories your body requires to both maintain and lose weight when determining your needs.\n" +
                "# To calculate your overall calories needs, it’s necessary to calculate the total number of calories you typically burn in a day, which is known as your total daily energy expenditure";
        }
    }
}
