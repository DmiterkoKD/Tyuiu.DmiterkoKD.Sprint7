namespace Tyuiu.DmiterkoKD.Sprint7.Project.V1.Lib
{
    public class DataService
    {
        public string Number(string fio)
        {
            if (fio == "Иванов Иван Иванович")
            {
                return "89568956";
            }
            else
            {
                return "0";
            }
        }
    }
}
