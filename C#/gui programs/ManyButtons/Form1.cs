namespace ManyButtons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }
    }
}