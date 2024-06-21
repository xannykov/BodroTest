using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace BodroTest
{
    public partial class Form1 : Form
    {
        private List<Question> questions;
        private int currentQuestionIndex = 0;
        private int correctAnswers = 0;
        private Stopwatch timerTestTime;
        private Timer timerTest;
        private int originalFormWidth = 786;
        private SoundPlayer soundPlayer;
        private PictureBox pictureBoxQuestions = new PictureBox
        {
            SizeMode = PictureBoxSizeMode.Zoom,
            Location = new Point(788, 58),
            Size = new Size(490, 556),
        };

        public Form1()
        {
            InitializeComponent();
            SetLabelFonts();
            InitializeQuestions();
            ShowQuestion();
            InitializeTimer();
            buttonNextQuestion.Enabled = false;
            buttonNextQuestion.Visible = false;
        }

        private void SetLabelFonts()
        {
            buttonReady.Font = FontLoader.GetFont(12);
            buttonNextQuestion.Font = FontLoader.GetFont(12);
            DuraksButton.Font = FontLoader.GetFont(11);
            CloseButtonX.Font = FontLoader.GetFont(11);
        }

        private void InitializeQuestions()
        {
            questions = QuestionInitializer.InitializeQuestions();
        }

        private void ShowQuestion()
        {
            if (currentQuestionIndex < questions.Count)
            {
                Question currentQuestion = questions[currentQuestionIndex];
                textBoxQuestion.Text = currentQuestion.QuestionText;

                // Очищаем старые контролы
                tableLayoutPanelAnswers.Controls.Clear();
                //-------------------------------------------------------------------------------
                if (currentQuestion.QuestionAudio != null)
                {
                    StopBox.Visible = true;

                    // Создаем SoundPlayer и воспроизводим аудиофайл
                    soundPlayer = new SoundPlayer(currentQuestion.QuestionAudio);
                    soundPlayer.Play();
                }
                //-------------------------------------------------------------------------------
                if (currentQuestion.QuestionImage != null)
                {
                    this.Width = originalFormWidth;
                    pictureBoxQuestions.Image = currentQuestion.QuestionImage;

                    this.Controls.Add(pictureBoxQuestions);

                    originalFormWidth = this.Width;

                    this.Width = originalFormWidth + 520;

                    this.CenterToScreen();
                }
                else
                {
                    this.Width = originalFormWidth;
                    CloseButtonX.Location = new Point(744, 12);
                    DuraksButton.Location = new Point(696, 12);

                    pictureBoxQuestions.Image = null;
                    this.CenterToScreen();
                }
                //-------------------------------------------------------------------------------
                if (currentQuestionIndex == questions.Count - 1)
                {
                    buttonNextQuestion.Text = "ЗАВЕРШИТЬ ТЕСТ";
                }
                else
                {
                    buttonNextQuestion.Text = "СЛЕДУЮЩИЙ ВОПРОС";
                }
                //-------------------------------------------------------------------------------
                // Устанавливаем количество строк и столбцов в TableLayoutPanel
                tableLayoutPanelAnswers.RowCount = currentQuestion.AnswerOptions.Count;
                tableLayoutPanelAnswers.ColumnCount = 1;

                for (int i = 0; i < currentQuestion.AnswerOptions.Count; i++)
                {
                    // Создаем новый RadioButton
                    RadioButton radioButton = new RadioButton();
                    radioButton.Text = currentQuestion.AnswerOptions[i];
                    radioButton.Dock = DockStyle.Fill; // Заполняем все доступное пространство в ячейке таблицы

                    // Добавляем RadioButton в TableLayoutPanel
                    tableLayoutPanelAnswers.Controls.Add(radioButton, 0, i);
                }
            }
            else
            {
                timerTest.Stop();
                ShowResultsInForm3();
                this.Hide();
            }
        }

        private void ShowResultsInForm3()
        {
            Form2 form2 = (Form2)Application.OpenForms["Form2"];

            if (form2 != null)
            {
                string userName = form2.UserName;
                string userSurname = form2.UserSurname;
                string userPogon = form2.UserPogon;
                string userGender = form2.UserGender;
                string userWeight = form2.UserWeight;

                Form3 form3 = new Form3();
                form3.SetResults(timerTestTime.Elapsed, questions.Count, correctAnswers, userName, userSurname, userPogon, userGender, userWeight);
                form3.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonReady.MouseEnter += new EventHandler(buttonReady_MouseEnter);
            buttonReady.MouseLeave += new EventHandler(buttonReady_MouseLeave);
            buttonNextQuestion.MouseEnter += new EventHandler(buttonNextQuestion_MouseEnter);
            buttonNextQuestion.MouseLeave += new EventHandler(buttonNextQuestion_MouseLeave);
            CloseButtonX.MouseEnter += new EventHandler(CloseButtonX_MouseEnter);
            CloseButtonX.MouseLeave += new EventHandler(CloseButtonX_MouseLeave);
            DuraksButton.MouseEnter += new EventHandler(DuraksButton_MouseEnter);
            DuraksButton.MouseLeave += new EventHandler(DuraksButton_MouseLeave);
            PlayerBox.MouseEnter += new EventHandler(PlayerBox_MouseEnter);
            PlayerBox.MouseLeave += new EventHandler(PlayerBox_MouseLeave);
            StopBox.MouseEnter += new EventHandler(StopBox_MouseEnter);
            StopBox.MouseLeave += new EventHandler(StopBox_MouseLeave);
            FormManager.AddForm(this);
            Form2 form2 = new Form2();
            form2.Close();

        }

        private void buttonNextQuestion_Click(object sender, EventArgs e)
        {
            if (soundPlayer != null)
            {
                soundPlayer.Stop();
                soundPlayer.Dispose();
                soundPlayer = null;
            }

            pictureBoxQuestions.Image?.Dispose();
            pictureBoxQuestions.Image = null;

            LightBox.BackColor = Color.Transparent;
            buttonNextQuestion.Enabled = false;
            buttonNextQuestion.Visible = false;

            buttonReady.Enabled = true;
            buttonReady.Visible = true;

            PlayerBox.Visible = false;
            StopBox.Visible = false;

            CheckAnswer();
            currentQuestionIndex++;
            ShowQuestion();
        }

        private void CheckAnswer()
        {
            Question currentQuestion = questions[currentQuestionIndex];
            int selectedAnswer = GetSelectedAnswer();

            if (selectedAnswer == currentQuestion.CorrectAnswer)
            {
                correctAnswers++;
            }
        }

        private int GetSelectedAnswer()
        {
            for (int i = 0; i < tableLayoutPanelAnswers.Controls.Count; i++)
            {
                if (tableLayoutPanelAnswers.Controls[i] is RadioButton radioButton && radioButton.Checked)
                {
                    return i;
                }
            }

            return -1;
        }

        private void TimerTest_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelElapsedTime.Text = $"Время: {timerTestTime.Elapsed:mm\\:ss}";

            toolStripStatusLabelCount.Text = $"Вопрос: {currentQuestionIndex+1}/{questions.Count}";

            toolStripStatusLabelTestStatus.Text = "Тест идёт";
        }

        private void InitializeTimer()
        {
            timerTest = new Timer();
            timerTest.Interval = 1000;
            timerTest.Tick += TimerTest_Tick;

            timerTestTime = new Stopwatch();

            timerTest.Start();
            timerTestTime.Start();
        }

        private bool IsAnswerCorrect(Question currentQuestion, int selectedAnswerIndex)
        {
            return selectedAnswerIndex == currentQuestion.CorrectAnswer;
        }

        private void buttonReady_Click(object sender, EventArgs e)
        {
            Question currentQuestion = questions[currentQuestionIndex];
            int selectedAnswerIndex = GetSelectedAnswer();

            if (selectedAnswerIndex == -1) // Проверка, был ли выбран ответ
            {
                MessageBox.Show("Пожалуйста, выберите ответ!");
                return;
            }

            if (IsAnswerCorrect(currentQuestion, selectedAnswerIndex))
            {
                LightBox.BackColor = Color.Chartreuse;
            }
            else
            {
                LightBox.BackColor = Color.Red;
            }

            buttonNextQuestion.Enabled = true;
            buttonNextQuestion.Visible = true;

            PlayerBox.Visible = false;
            StopBox.Visible = false;

            buttonReady.Enabled = false;
            buttonReady.Visible = false;

            foreach (Control control in tableLayoutPanelAnswers.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.Enabled = false;
                }
            }
        }

        #region Event And Func
        private void buttonNextQuestion_MouseEnter(object sender, EventArgs e)
        {
            buttonNextQuestion.BackColor = Color.DimGray;
        }
        private void buttonNextQuestion_MouseLeave(object sender, EventArgs e)
        {
            buttonNextQuestion.BackColor = Color.Black;
        }

        private void buttonReady_MouseEnter(object sender, EventArgs e)
        {
            buttonReady.BackColor = Color.DimGray;
        }
        private void buttonReady_MouseLeave(object sender, EventArgs e)
        {
            buttonReady.BackColor = Color.Black;
        }

        private void CloseButtonX_Click(object sender, EventArgs e)
        {
            FormManager.CloseAllForms();
        }
        private void DuraksButton_Click(object sender, EventArgs e)
        {
            Text = "Тест предназначен для ровных пацанов, без всяких приколов." + Environment.NewLine +
                "Просьба вводить все данные при регистрации, не тупить на тесте и кайфовать!" + Environment.NewLine +
                "( ͡° ͜ʖ ͡°) ";
            MessageBox.Show(Text);
        }

        private void CloseButtonX_MouseEnter(object sender, EventArgs e)
        {
            CloseButtonX.BackColor = Color.Red;
        }
        private void CloseButtonX_MouseLeave(object sender, EventArgs e)
        {
            CloseButtonX.BackColor = Color.Black;
        }

        private void DuraksButton_MouseEnter(object sender, EventArgs e)
        {
            DuraksButton.BackColor = Color.Red;
        }
        private void DuraksButton_MouseLeave(object sender, EventArgs e)
        {
            DuraksButton.BackColor = Color.Black;
        }

        private void PlayerBox_MouseEnter(object sender, EventArgs e)
        {
            PlayerBox.Size = new Size(52,52);
            PlayerBox.Location = new Point(194, 556);
        }
        private void PlayerBox_MouseLeave(object sender, EventArgs e)
        {
            PlayerBox.Size = new Size(64, 64);
            PlayerBox.Location = new Point(188, 550);
        }

        private void StopBox_MouseEnter(object sender, EventArgs e)
        {
            StopBox.Size = new Size(52, 52);
            StopBox.Location = new Point(194, 556);
        }
        private void StopBox_MouseLeave(object sender, EventArgs e)
        {
            StopBox.Size = new Size(64, 64);
            StopBox.Location = new Point(188, 550);
        }

        private void PlayerBox_Click(object sender, EventArgs e)
        {
            if (soundPlayer != null)
            {
                soundPlayer.Play();
            }
            StopBox.Visible = true;
            PlayerBox.Visible = false;
        }
        private void StopBox_Click(object sender, EventArgs e)
        {
            if (soundPlayer != null)
            {
                soundPlayer.Stop();
            }
            StopBox.Visible = false;
            PlayerBox.Visible = true;
        }
        #endregion Event And Func
    }
}
