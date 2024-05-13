using System.Windows;
using System.Windows.Controls;

namespace MagicPartik4C_
{
    public partial class TakeTestForm : Window
    {
        private int currentQuestionIndex = 0;
        private int correctAnswersCount = 0;
        private Test[] tests;

        public TakeTestForm(Test[] tests)
        {
            InitializeComponent();
            this.tests = tests;
            DisplayQuestion();
        }

        private void DisplayQuestion()
        {
            if (currentQuestionIndex < tests.Length)
            {
                Test currentTest = tests[currentQuestionIndex];
                titleLabel.Text = currentTest.Title;
                descriptionLabel.Text = currentTest.Description;
                option1Button.Content = currentTest.Option1;
                option2Button.Content = currentTest.Option2;
                option3Button.Content = currentTest.Option3;
            }
            else
            {
                MessageBox.Show($"Тест завершен. Правильных ответов: {correctAnswersCount}/{tests.Length}");
                this.Close();
            }
        }

        private void OptionButton_Click(object sender, RoutedEventArgs e)
        {
            Button selectedButton = sender as Button;
            Test currentTest = tests[currentQuestionIndex];

            object correctAnswer = currentTest.CorrectAnswer;

            if (selectedButton == option1Button && correctAnswer.Equals(currentTest.Option1))
            {
                correctAnswersCount++;
            }
            else if (selectedButton == option2Button && correctAnswer.Equals(currentTest.Option2))
            {
                correctAnswersCount++;
            }
            else if (selectedButton == option3Button && correctAnswer.Equals(currentTest.Option3))
            {
                correctAnswersCount++;
            }

            currentQuestionIndex++;
            DisplayQuestion();
        }
    }

    internal class Test
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public object CorrectAnswer { get; set; }
    }
}
