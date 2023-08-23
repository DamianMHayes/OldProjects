using System.Globalization;
namespace GreenvilleRevenueGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // declare variables
            const double FEE = 25;
            bool bigger;

            double lastYear = Convert.ToDouble(textBoxLast.Text);
            double thisYear = Convert.ToDouble(textBoxCurrent.Text);

            double revenue = thisYear * FEE;


            if (thisYear > lastYear)
            {
                bigger = true;
            }
            else
            {
                bigger = false;
            };



            labelCount.Text = "Last year's competition had "+ lastYear + " contestants, and this year's has "+ thisYear + " contestants.";
            labelRevenue.Text = "Revenue expected this year is "+ revenue.ToString("C", CultureInfo.GetCultureInfo("en-US"));
            labelComparison.Text = "It is "+ bigger +" that this year's competition is bigger than last year's.";

            labelCount.Visible = true;
            labelRevenue.Visible = true;
            labelComparison.Visible = true;
        }
    }
}