using System;
using System.IO;
using System.Windows.Forms;

namespace BodroTest
{
    public partial class SplashScreenForm : Form
    {
        private const string testCompletionFileName = "TestCompleted.txt";
        private string testCompletionFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, testCompletionFileName);


        private Timer startTimer;
        private Timer fadeTimer;
        private int fadeSteps = 100;

        private void CheckTestCompletion()
        {
            if (File.Exists(testCompletionFilePath))
            {
                string fileContent = File.ReadAllText(testCompletionFilePath);
                if (fileContent.Contains("ТЕСТ ЗАВЕРШЁН"))
                {
                    TestCompletedForm testCompletedForm = new TestCompletedForm();
                    testCompletedForm.Closed += (s, args) => Close(); //Закрыть SplashScreenForm после закрытия TestCompletedForm
                    testCompletedForm.Show();
                    return;
                }
            }

            Form2 form2 = new Form2();
            form2.Closed += (s, args) => Close();
            form2.Show();
            return;
        }

        public SplashScreenForm()
        {
            InitializeComponent();

            startTimer = new Timer();
            startTimer.Interval = 5000;
            startTimer.Tick += StartTimer_Tick;
            startTimer.Start();
        }

        private void StartTimer_Tick(object sender, EventArgs e)
        {
            startTimer.Stop();

            fadeTimer = new Timer();
            fadeTimer.Interval = 10;
            fadeTimer.Tick += FadeTimer_Tick;
            fadeTimer.Start();
        }

        private void FadeTimer_Tick(object sender, EventArgs e)
        {
            Opacity -= 1.0 / fadeSteps;

            if (Opacity <= 0)
            {
                fadeTimer.Stop();
                Hide();
                CheckTestCompletion();
            }
        }

        private void SplashScreenForm_Load(object sender, EventArgs e)
        {
            FormManager.AddForm(this);
        }
    }
}
