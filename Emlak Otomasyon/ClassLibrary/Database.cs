using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class Database
    {
        public static Database obj = new Database();
        FileStream fs;
        string roomCost;
        int roomCostInt;
        bool logControl;
        ArrayList log = new ArrayList();

        public int RoomCostDataBase(int odaSayisi)
        {
            string dosya_dizini = AppDomain.CurrentDomain.BaseDirectory.ToString() + "txt\room_cost.txt";
            
            if (File.Exists(dosya_dizini) == true)
            {
                fs = new FileStream(@dosya_dizini, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
                StreamReader sr = new StreamReader(fs, Encoding.GetEncoding("windows-1254"));
                roomCost = sr.ReadLine();
                sr.Close();
                fs.Close();
                roomCostInt = odaSayisi * Convert.ToInt32(roomCost);
            }
            else
            {
                roomCostInt = odaSayisi * 200;
            }
            return roomCostInt;
        }
        public void keepLog(string valueName, int value)
        {            
            fs = new FileStream(@"txt\keepLog.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding("windows-1254"));
            LogRead();
            log.Add(DateTime.Now + " " + valueName + " : " + value.ToString());
            foreach (var _log in log)
            {
                sw.WriteLine(_log);
            }       
            sw.Close();
            fs.Close();
        }
        public void LogRead()
        {
            if (logControl == false)
            {
                fs = new FileStream(@"txt\keepLog.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                StreamReader sr = new StreamReader(fs, Encoding.GetEncoding("windows-1254"));
                string word = sr.ReadLine();
                while (word != null)
                {
                    log.Add(word);
                    word = sr.ReadLine();
                }
                sr.Close();
                fs.Close();
                logControl = true;
            }
        }
    }
}
