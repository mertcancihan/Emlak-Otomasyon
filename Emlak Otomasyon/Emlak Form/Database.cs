using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emlak_Form
{
    class Database
    {
        public static Database obj = new Database();
        public FileStream fs;
        ArrayList satilik = new ArrayList();
        ArrayList kiralik = new ArrayList();

        public string userControl()
        {
            fs = new FileStream(@"txt\users.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamReader sr = new StreamReader(fs, Encoding.GetEncoding("windows-1254"));
            string user = sr.ReadLine();
            sr.Close();
            fs.Close();
            return user;
        }
        public void Dolduril(ComboBox combobox)
        {
            string[] iller = System.IO.File.ReadAllLines(@"txt\iller.txt", Encoding.GetEncoding("windows-1254"));

            foreach (var il in iller)
            {
                string[] tokens = il.Split('\r');
                combobox.Items.Add(tokens[0]);
            }
        }
        public void Doldurilce(ComboBox combobox, string ilce)
        {
            string[] ilceler = System.IO.File.ReadAllLines(@"txt\iller\" + ilce + ".txt");

            foreach (var semt in ilceler)
            {
                string[] tokens = semt.Split('\r');
                combobox.Items.Add(tokens[0]);
            }
        }
        public void HouseRegister(string info, string evDurumu)
        {
            fs = new FileStream(@"txt\" + evDurumu + ".txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamWriter SaveFile = new StreamWriter(fs, Encoding.GetEncoding("windows-1254"));
            if (evDurumu == "satilik")
            {
                satilik.Add(info);

                foreach (var sale in satilik)
                {
                    SaveFile.WriteLine(sale);
                }
            }
            else if (evDurumu == "kiralik")
            {
                kiralik.Add(info);

                foreach (var sale in kiralik)
                {
                    SaveFile.WriteLine(sale);
                }
            }
            SaveFile.Close();
            fs.Close();
        }
        public void HouseRead(string evDurumu)
        {
            fs = new FileStream(@"txt\" + evDurumu + ".txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamReader sr = new StreamReader(fs, Encoding.GetEncoding("windows-1254"));
            if (evDurumu == "satilik")
            {
                string word = sr.ReadLine();
                while (word != null)
                {
                    satilik.Add(word);
                    word = sr.ReadLine();
                }
            }
            else if (evDurumu == "kiralik")
            {
                string word = sr.ReadLine();
                while (word != null)
                {
                    kiralik.Add(word);
                    word = sr.ReadLine();
                }
            }
            sr.Close();
            fs.Close();
        }
        public void DataHouseSave(DataGridView dataGridView, string evDurumu)
        {
            File.Delete(@"txt\" + evDurumu + ".txt");
            fs = new FileStream(@"txt\" + evDurumu + ".txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamWriter writer = new StreamWriter(fs, Encoding.GetEncoding("windows-1254"));
            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                    writer.Write(dataGridView.Rows[i].Cells[j].Value.ToString() + "*");
                writer.WriteLine("");
            }
            writer.Close();
        }
        public void DataHouseDelete(DataGridView dataGridView, string evDurumu)
        {
            int no = 0;
            if (dataGridView.SelectedRows.Count > 0)
            {
                no = Convert.ToInt32(dataGridView.CurrentRow.Cells["EmlakNo"].Value.ToString());
                
                dataGridView.Rows.RemoveAt(dataGridView.SelectedRows[0].Index);
                
            }
            RemoveItemDGV(dataGridView);

            aaa(dataGridView, no, evDurumu);
        }
        void aaa(DataGridView dataGridView, int no, string evDurumu)
        {
            dataGridView.Rows.Clear();
            string[] lines = File.ReadAllLines(@"txt\" + evDurumu + ".txt", Encoding.GetEncoding("windows-1254"));
            string[] values;
            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split('*');
                string[] row = new string[values.Length];
                int emlakNo = Convert.ToInt32(values[3].Trim());

                if (emlakNo != no)                
                    for (int j = 0; j < values.Length; j++)
                        row[j] = values[j].Trim();
                
                dataGridView.Rows.Add(row);
            }
            RemoveItemDGV(dataGridView);
            DataHouseSave(dataGridView, evDurumu);
        }
        
        public void DataHouseRead(DataGridView dataGridView, string evDurumu, ComboBox comboBox_il, ComboBox comboBox_ilce, int trueOrFalse)
        {         

            dataGridView.Rows.Clear();
            string[] lines = File.ReadAllLines(@"txt\" + evDurumu + ".txt", Encoding.GetEncoding("windows-1254"));
            string[] values;
            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split('*');
                string[] row = new string[values.Length];
                string aktifPasif = values[0].Trim();
                string il = values[1].Trim();
                string ilce = values[2].Trim();              

                
                if (aktifPasif == "True")
                {
                    if (trueOrFalse == 0)                    
                        ilIlceKontrol(comboBox_il, comboBox_ilce, il, ilce, values, row);                    
                }
                if (aktifPasif == "False")
                {
                    if (trueOrFalse == 1)                    
                        ilIlceKontrol(comboBox_il, comboBox_ilce, il,ilce, values, row);                    
                }
                if (aktifPasif == "False" || aktifPasif == "True")
                {
                    if (trueOrFalse == 2)                    
                        ilIlceKontrol(comboBox_il, comboBox_ilce, il, ilce, values, row);                    
                }

                dataGridView.Rows.Add(row);
            }
            RemoveItemDGV(dataGridView);
        }
        public void ilIlceKontrol(ComboBox comboBox_il, ComboBox comboBox_ilce, string il, string ilce, string[] values, string[] row)
        {
            if (comboBox_ilce.SelectedItem != null)
            {
                if (ilce == comboBox_ilce.SelectedItem.ToString())
                    for (int j = 0; j < values.Length; j++)
                        row[j] = values[j].Trim();
            }
            else if (comboBox_il.SelectedItem != null)
            {
                if (il == comboBox_il.SelectedItem.ToString())
                    for (int j = 0; j < values.Length; j++)
                        row[j] = values[j].Trim();
            }
            else
            {
                for (int j = 0; j < values.Length; j++)                
                    row[j] = values[j].Trim();                
            }
        }        
        private void RemoveItemDGV(DataGridView dataGridView)
        {
            for (int i = dataGridView.Rows.Count - 1; i > -1; i--)
            {
                DataGridViewRow row = dataGridView.Rows[i];
                if (!row.IsNewRow && row.Cells[0].Value == null)                
                    dataGridView.Rows.RemoveAt(i);                
            }
        }

    }
}
