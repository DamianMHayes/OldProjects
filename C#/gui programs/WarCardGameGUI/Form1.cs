namespace WarCardGameGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}