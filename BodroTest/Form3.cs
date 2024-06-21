using System;
using System.Drawing;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using System.IO;

namespace BodroTest
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            SetLabelFonts();
            buttonOk.Enabled = false;
            buttonOk.Visible = false;
        }
        
        private void SetLabelFonts()
        {
            labelTime.Font = FontLoader.GetFont(12);
            labelTotalQuestions.Font = FontLoader.GetFont(12);
            labelCorrectQuestions.Font = FontLoader.GetFont(12);
            labelResultPercentage.Font = FontLoader.GetFont(12);
            buttonOk.Font = FontLoader.GetFont(8);
            buttonSendEmail.Font = FontLoader.GetFont(8);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            buttonSendEmail.MouseEnter += new EventHandler(buttonSendEmail_MouseEnter);
            buttonSendEmail.MouseLeave += new EventHandler(buttonSendEmail_MouseLeave);
            buttonOk.MouseEnter += new EventHandler(buttonOk_MouseEnter);
            buttonOk.MouseLeave += new EventHandler(buttonOk_MouseLeave);
            Form1 form1 = new Form1();
            form1.Close();
            FormManager.AddForm(this);
        }

        public void SetResults(TimeSpan timeTaken, int totalQuestions, int correctAnswers, string name, string surname, string pogon, string gender, string weight)
        {
            string userName = name;
            string userSurname = surname;
            string userPogon = pogon;
            string userGender = gender;
            string userWeight = weight;

            labelTime.Text = $"ВРЕМЯ ПРОХОЖДЕНИЯ : {timeTaken:mm\\:ss}";
            labelTotalQuestions.Text = $"КОЛИЧЕСТВО ВОПРОСОВ : {totalQuestions}";
            labelCorrectQuestions.Text = $"КОЛИЧЕСТВО ПРАВИЛЬНЫХ ОТВЕТОВ : {correctAnswers}";
            double percentage = (double)correctAnswers / totalQuestions * 100;
            labelResultPercentage.Text = $"РЕЗУЛЬТАТИВНОСТЬ : {percentage:F2}%";

            double correctPercentage = ((double)correctAnswers / totalQuestions) * 100;
            double incorrectPercentage = 100 - correctPercentage;

            chartPie.Series["Series1"].Points.AddXY(correctPercentage.ToString("F2") + "%", correctAnswers);
            chartPie.Series["Series1"].Points.AddXY(incorrectPercentage.ToString("F2") + "%", totalQuestions - correctAnswers);


            string rating = "";
            if (percentage >= 90)
            {
                rating = "Твоя оценка: Great.";
            }
            else if (percentage >= 70)
            {
                rating = "Твоя оценка: Good.";
            }
            else if (percentage >= 60)
            {
                rating = "Твоя оценка: Normal.";
            }
            else if (percentage >= 50)
            {
                rating = "Твоя оценка: Could be better";
            }
            else if (percentage >= 40)
            {
                rating = "Твоя оценка: Dumb";
            }
            else if (percentage == 0)
            {
                rating = "Твоя оценка: ...";
            }

            string emailBody = 
                       $"Имя: {name}\n" +
                       $"Фамилия: {surname}\n" +
                       $"Погоняло: {pogon}\n" +
                       $"Гендер: {gender}\n" +
                       $"Вес на районе:  {weight}\n" +
                       $"Время прохождения: {timeTaken:mm\\:ss}\n" +
                       $"Количество вопросов: {totalQuestions}\n" +
                       $"Количество правильных ответов: {correctAnswers}\n" +
                       $"Результативность: {percentage:F2}%\n" +
                       $"{rating}\n";
                      
            buttonSendEmail.Tag = emailBody;

            textBoxRating.Text = rating.ToString();
            this.Controls.Add(textBoxRating);
        }

        private void SendEmail(string recipient, string subject, string body)
        {
            try
            {
                // Настройки SMTP-сервера
                string smtpAddress = "smtp.email.com";
                int portNumber = 2525;
                bool enableSSL = true;
                string emailFrom = "example@email.com"; // Введите свою почту
                string password = "password";

                //Создаем новый клиент Smtp и настраиваем его
                using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                {
                    smtp.Credentials = new NetworkCredential(emailFrom, password);
                    smtp.EnableSsl = enableSSL;

                    //Создаем сообщение
                    using (MailMessage mail = new MailMessage())
                    {
                        mail.From = new MailAddress(emailFrom);
                        mail.To.Add(recipient);
                        mail.Subject = subject;
                        mail.Body = body;

                        //Отправляем сообщение
                        smtp.Send(mail);
                        MessageBox.Show("Отправилось!");
                        buttonSendEmail.Visible = false;
                        buttonSendEmail.Enabled = false;
                        buttonOk.Visible = true;
                        buttonOk.Enabled = true;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message  + ".Попробуй ещё раз");
            }
        }

        private void buttonSendEmail_Click(object sender, EventArgs e)
        {
            if (buttonSendEmail.Tag != null)
            {
                string emailBody = buttonSendEmail.Tag.ToString();
                //Получатель
                SendEmail("example@email.com", "Результаты теста", emailBody); // Введите свою почту, чтобы получать сообщения

                string testCompletionFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestCompleted.txt");
                File.WriteAllText(testCompletionFilePath, "ТЕСТ ЗАВЕРШЁН");
                File.SetAttributes(testCompletionFilePath, File.GetAttributes(testCompletionFilePath) | FileAttributes.Hidden);
            }
            else
            {
                MessageBox.Show("Данные для отправки пусты!");
            }
        }

        #region Event And Func
        private void buttonSendEmail_MouseEnter(object sender, EventArgs e)
        {
            buttonSendEmail.BackColor = Color.DimGray;
        }
        private void buttonSendEmail_MouseLeave(object sender, EventArgs e)
        {
            buttonSendEmail.BackColor = Color.Black;
        }

        private void buttonOk_MouseEnter(object sender, EventArgs e)
        {
            buttonOk.BackColor = Color.RosyBrown;
        }
        private void buttonOk_MouseLeave(object sender, EventArgs e)
        {
            buttonOk.BackColor = Color.Black;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            FormManager.CloseAllForms();
        }
        #endregion Event And Func
    }
}
