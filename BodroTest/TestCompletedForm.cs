using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BodroTest
{
    public partial class TestCompletedForm : Form
    {

        public TestCompletedForm()
        {
            InitializeComponent();
            SetLabelFonts();
        }

        private void SetLabelFonts()
        {
            label1.Font = FontLoader.GetFont(11);
            label2.Font = FontLoader.GetFont(11);
            label3.Font = FontLoader.GetFont(36);
            label4.Font = FontLoader.GetFont(36);
            CloseButtonX.Font = FontLoader.GetFont(11);
        }

        private void CloseButtonX_MouseEnter(object sender, EventArgs e)
        {
            CloseButtonX.BackColor = Color.Red;
        }

        private void CloseButtonX_MouseLeave(object sender, EventArgs e)
        {
            CloseButtonX.BackColor = Color.Black;
        }

        private void TestCompletedForm_Load(object sender, EventArgs e)
        {
            CloseButtonX.MouseEnter += new EventHandler(CloseButtonX_MouseEnter);
            CloseButtonX.MouseLeave += new EventHandler(CloseButtonX_MouseLeave);
            FormManager.AddForm(this);
        }

        private void CloseButtonX_Click(object sender, EventArgs e)
        {
            FormManager.CloseAllForms();
        }
    }
}
