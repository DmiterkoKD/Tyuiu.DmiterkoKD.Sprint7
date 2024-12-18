using System;
using System.Windows.Forms;
namespace Tyuiu.DmiterkoKD.Sprint7.Project.V1
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Запускаем первую форму
            Application.Run(new FormMain());
        }
    }
}