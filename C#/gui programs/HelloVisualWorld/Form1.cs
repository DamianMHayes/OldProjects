namespace HelloVisualWorld
{
    public partial class HelloForm : Form
    {
        public HelloForm()
        {
            InitializeComponent();
        }

        private void DisplayOutputButton_Click(object sender, EventArgs e)
        {
            helloLabel.Visible = true;
            changeOutputButton.Enabled = true;
        }

        private void changeOutputButton_Click(object sender, EventArgs e)
        {
            helloLabel.Text = "Goodbye";
        }
    }
}