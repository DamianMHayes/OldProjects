namespace InchesToCentimentersGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void button1_Click(object sender, EventArgs e)
        {
            double inches;
            double centimeters;

            inches = Convert.ToDouble(textBox1.Text);
            centimeters = inches * 2.54;

            label5.Text = centimeters.ToString();
        }
    }
}