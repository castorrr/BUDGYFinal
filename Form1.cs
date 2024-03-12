namespace BUDGY_2._0
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //so that the user can see the password
            if (cbxShow.Checked)
                tbxPassword.PasswordChar = '\0';//null
            else
                tbxPassword.PasswordChar = '●';
        }
    }
}
