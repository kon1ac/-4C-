using System.Windows;

namespace MagicPartik4C_
{

    public partial class LoginForm : Window
    {
        private string adminPassword = "your_admin_password";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            if (editRadioButton.IsChecked == true)
            {
                string inputPassword = passwordTextBox.Text;
                if (inputPassword == adminPassword)
                {
                    // Открыть окно редактирования теста
                    var editForm = new EditTestForm();
                    editForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Неверное кодовое слово");
                }
            }
            else if (takeTestRadioButton.IsChecked == true)
            {
                // Открыть окно прохождения теста
                TakeTestForm takeTestForm = new TakeTestForm();
                takeTestForm.Show();
                this.Hide();
            }
        }
    }
}
