namespace group_project
{
    
    public partial class SplashScreenForm : Form
    {
        
        public SplashScreenForm()
        {
            InitializeComponent();
           

        }

        private void SplashScreenForm_Load(object sender, EventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            LoginForm f = new LoginForm();

            timer1.Stop();
            f.Show();
            this.Hide();

        }
      
    }
}
