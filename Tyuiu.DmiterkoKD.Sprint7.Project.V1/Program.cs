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

            // ��������� ������ �����
            Application.Run(new FormMain());
        }
    }
}