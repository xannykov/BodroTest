using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BodroTest
{
    public static class FormManager
    {
        private static List<Form> openForms = new List<Form>();

        public static void AddForm(Form form)
        {
            openForms.Add(form);
        }

        public static void CloseAllForms()
        {
            foreach (var form in openForms)
            {
                form.Close();
            }
            openForms.Clear();
        }
    }
}
