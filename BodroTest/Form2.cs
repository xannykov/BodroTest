using System;
using System.Drawing;
using System.Windows.Forms;

namespace BodroTest
{
    public partial class Form2 : Form
    {
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string UserPogon { get; set; }
        public string UserGender { get; set; }
        public string UserWeight { get; set; }

        public Form2()
        {
            InitializeComponent();
            SetLabelFonts();
            InitializeWeightComboBox();
            buttonStartTest.Enabled = false;
            buttonStartTest.Visible = false;
        }

        private void SetLabelFonts()
        {
            label1.Font = FontLoader.GetFont(12);
            label2.Font = FontLoader.GetFont(12);
            label3.Font = FontLoader.GetFont(12);
            label4.Font = FontLoader.GetFont(12);
            label5.Font = FontLoader.GetFont(12);
            label6.Font = FontLoader.GetFont(10);
            label7.Font = FontLoader.GetFont(36);
            SubmitButton.Font = FontLoader.GetFont(18);
            DuraksButton.Font = FontLoader.GetFont(11);
            CloseButtonX.Font = FontLoader.GetFont(11);
        }

        private void InitializeWeightComboBox()
        {
            WeightComboBox.Items.Add("Weight 1");
            WeightComboBox.Items.Add("Weight 2");
            WeightComboBox.Items.Add("Weight 3");
            WeightComboBox.Items.Add("Weight 4");

            WeightComboBox.SelectedIndex = 0;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NameBox.Text) && !string.IsNullOrWhiteSpace(GenderBox.Text) 
                && !string.IsNullOrWhiteSpace(WeightComboBox.Text))
            {
                UserName = NameBox.Text;
                UserSurname = SurnameBox.Text;
                UserPogon = PogonBox.Text;
                UserGender = GenderBox.Text;
                UserWeight = WeightComboBox.SelectedItem.ToString();

                buttonStartTest.Enabled = true;
                buttonStartTest.Visible = true;
                SubmitButton.Enabled = false;
                SubmitButton.Visible = false;
            }
            else
            {
                MessageBox.Show("Пожалуйста, заполни все поля.");
            }

        }

        private void buttonStartTest_Click(object sender, EventArgs e)
        {
            Text = "В тесте N вопросов. Одна попытка на прохождение!";
            MessageBox.Show(Text);
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        #region Event and Func
        private void buttonStartTest_MouseEnter(object sender, EventArgs e)
        {
            buttonStartTest.BackColor = Color.DimGray;
        }

        private void buttonStartTest_MouseLeave(object sender, EventArgs e)
        {
            buttonStartTest.BackColor = Color.Black;
        }

        private void SubmitButton_MouseEnter(object sender, EventArgs e)
        {
            SubmitButton.BackColor = Color.DimGray;
        }

        private void SubmitButton_MouseLeave(object sender, EventArgs e)
        {
            SubmitButton.BackColor = Color.Black;
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

        private void WeightComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // Отмена ввода символов
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            buttonStartTest.MouseEnter += new EventHandler(buttonStartTest_MouseEnter);
            buttonStartTest.MouseLeave += new EventHandler(buttonStartTest_MouseLeave);
            SubmitButton.MouseEnter += new EventHandler(SubmitButton_MouseEnter);
            SubmitButton.MouseLeave += new EventHandler(SubmitButton_MouseLeave);
            CloseButtonX.MouseEnter += new EventHandler(CloseButtonX_MouseEnter);
            CloseButtonX.MouseLeave += new EventHandler(CloseButtonX_MouseLeave);
            DuraksButton.MouseEnter += new EventHandler(DuraksButton_MouseEnter);
            DuraksButton.MouseLeave += new EventHandler(DuraksButton_MouseLeave);
            WeightComboBox.KeyPress += new KeyPressEventHandler(WeightComboBox_KeyPress);
            FormManager.AddForm(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        #endregion Event and Func
    }

}
