using System.Reflection.Emit;
using System.Windows.Forms;
using Tyuiu.DmiterkoKD.Sprint7.Project.V1.Lib;
using static System.Windows.Forms.DataFormats;
namespace Tyuiu.DmiterkoKD.Sprint7.Project.V1
{
    public partial class FormMain : Form
    {
        private FormMain2 form2;
        public FormMain()
        {
            InitializeComponent();
            form2 = new FormMain2();
        }
        private void buttonOpenForm1_Click(object sender, EventArgs e)
        {
            // Переменная для хранения значения
            string m = "8"; // Значение по умолчанию

            // Определяем значение в зависимости от нажатой кнопки
            if (sender == buttonPlan_DKD)
            {
                m = "1";
            }
            else if (sender == buttonOil_DKD)
            {
                m = "2";
            }
            else if (sender == buttonFridge_DKD)
            {
                m = "3";
            }
            else if (sender == buttonSO_DKD)
            {
                m = "4";
            }
            else if (sender == buttonEnergy_DKD)
            {
                m = "5";
            }
            else if (sender == buttonStop_DKD)
            {
                m = "6";
            }
            else if (sender == buttonMove_DKD)
            {
                m = "7";
            }

            // Передаем значение во вторую форму
            form2.SetText(m);

            // Открываем вторую форму
            form2.Show();
            this.Hide(); // Скрываем текущую форму
        }
    }
}
