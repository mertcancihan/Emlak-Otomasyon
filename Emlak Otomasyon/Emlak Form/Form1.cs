using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emlak_Form
{
    public partial class Form1 : Form
    {
        Database db = new Database();
        Update update = new Update();
        int active;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            make();
            db.HouseRead("satilik");
            db.HouseRead("kiralik");
        }
        private void make()
        {
            db.Dolduril(comboBox_il);
            db.Dolduril(comboBox2_il);
            enumTurDoldur();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(((RadioButton)sender) == radioButton1)
            {
                groupBox3.Visible = true;
                groupBox4.Visible = false;
            }
            if (((RadioButton)sender) == radioButton2)
            {
                groupBox3.Visible = true;
                groupBox4.Visible = false;
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox4.Visible = true;
            groupBox3.Visible = false;
        }
        public void enumTurDoldur()
        {
            string[] days = Enum.GetNames(typeof(ClassLibrary.Home.KindOf));
            foreach (string day in days)
            {
                comboBox_tur.Items.Add(day);
            }
        }
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        void columnsSet(RadioButton radio, DataGridView dataGridView)
        {
            if (dataGridView.Columns.Count == 12)
            {
                dataGridView.Columns.Remove("KiraFiyati");
                dataGridView.Columns.Remove("Depozito");
            }
            else if (dataGridView.Columns.Count == 11)
                dataGridView.Columns.Remove("Fiyati");
        }


        private void button_Click(object sender, EventArgs e)
        {
            if (((Button)sender) == btn_sil) 
            {
                silmeIslemi();
            }
            if(((Button)sender) == btn_list)
            {
                listelemeIslemi();
            }
            if(((Button)sender) == btn_kayit)
            {
                if (radioButton1.Checked == true)//sale
                {
                    if (textBox_alan.Text != " " && comboBox_ilce.SelectedItem != null && textBox_kat.Text != " " &&
                textBox_oda.Text != " " && comboBox_tur.SelectedItem != null && ((textBox_kira.Text != " " &&
                textBox_deposit.Text != " ") || textBox_fiyat.Text != " "))
                    {
                        ClassLibrary.Sale sale = new ClassLibrary.Sale();
                        sale.ActiveStatus = true;
                        sale.AreaOfHome = Convert.ToInt32(textBox_alan.Text);
                        sale.DateOfConstruct = dateTimePicker1.Value;
                        sale.CalculateDate = 0;
                        sale.NumberOfEstate = 1;
                        sale.NumberOfFloors = Convert.ToInt32(textBox_kat.Text);
                        sale.NumberOfRooms = Convert.ToInt32(textBox_oda.Text);
                        sale.SalePrice = Convert.ToInt32(textBox_fiyat.Text);
                        sale.ProbableRent = Convert.ToInt32(textBox_oda.Text);
                        sale.HomeKindOf(comboBox_tur.SelectedItem);
                        sale.Province = comboBox_il.SelectedItem.ToString();
                        sale.District = comboBox_ilce.SelectedItem.ToString();
                        db.HouseRegister(sale.homeInformation(), "satilik");
                        MessageBox.Show("Kayıt Başarılı", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Kayıt Başarısız", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (radioButton2.Checked == true)//rent
                {
                    if (textBox_alan.Text != " " && comboBox_ilce.SelectedItem != null && textBox_kat.Text != " " &&
                    textBox_oda.Text != " " && comboBox_tur.SelectedItem != null && ((textBox_kira.Text != " " &&
                    textBox_deposit.Text != " ") || textBox_fiyat.Text != " "))
                    {
                        ClassLibrary.Rent rent = new ClassLibrary.Rent();
                        rent.ActiveStatus = true;
                        rent.AreaOfHome = Convert.ToInt32(textBox_alan.Text);
                        rent.DateOfConstruct = dateTimePicker1.Value;
                        rent.CalculateDate = 0;
                        rent.NumberOfEstate = 1;
                        rent.NumberOfFloors = Convert.ToInt32(textBox_kat.Text);
                        rent.NumberOfRooms = Convert.ToInt32(textBox_oda.Text);
                        rent.RentPrice = Convert.ToInt32(textBox_kira.Text);
                        rent.Deposit = Convert.ToInt32(textBox_deposit.Text);
                        rent.ProbableRent = Convert.ToInt32(textBox_oda.Text);
                        rent.HomeKindOf(comboBox_tur.SelectedItem);
                        rent.Province = comboBox_il.SelectedItem.ToString();
                        rent.District = comboBox_ilce.SelectedItem.ToString();
                        db.HouseRegister(rent.homeInformation(), "kiralik");
                        MessageBox.Show("Kayıt Başarılı", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Kayıt Başarısız", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Kayıt Başarısız", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(((Button)sender) == btn_guncelle)
            {
                update.Show();
                if (rBtn_sale.Checked == true)
                    update.DoDataGrid(dataGridView1,true);
                else if (rBtn_rent.Checked == true)
                    update.DoDataGrid(dataGridView1, false);               
                silmeIslemi();
            }
        }
        public void silmeIslemi()
        {
            if (rBtn_rent.Checked == true)
            {
                db.DataHouseDelete(dataGridView1, "kiralik");
                db.DataHouseRead(dataGridView1, "kiralik", comboBox2_il, comboBox2_ilce, active);
            }
            else if (rBtn_sale.Checked == true)
            {
                db.DataHouseDelete(dataGridView1, "satilik");
                db.DataHouseRead(dataGridView1, "satilik", comboBox2_il, comboBox2_ilce, active);
            }
        }
        public void listelemeIslemi()
        {
            if (rBtn_active.Checked == true)
                active = 0;// ev aktif
            else if (rBtn_deactive.Checked == true)
                active = 1;// ev pasif
            else if (rBtn_all.Checked == true)
                active = 2;// aktif pasif tüm evler

            if (rBtn_rent.Checked == true)
            {
                columnsSet(rBtn_rent, dataGridView1);
                dataGridView1.Columns.Add("KiraFiyati", "Kira Fiyatı");
                dataGridView1.Columns.Add("Depozito", "Depozito");
                db.DataHouseRead(dataGridView1, "kiralik", comboBox2_il, comboBox2_ilce, active);

            }
            else if (rBtn_sale.Checked == true)
            {
                columnsSet(rBtn_sale, dataGridView1);
                dataGridView1.Columns.Add("Fiyati", "Fiyatı");
                db.DataHouseRead(dataGridView1, "satilik", comboBox2_il, comboBox2_ilce, active);
            }
        }
        private void comboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender) == comboBox_il)
            {
                if (comboBox_il.SelectedItem != null)
                    comboBox_ilce.SelectedItem = null;
                comboBox_ilce.Items.Clear();
                db.Doldurilce(comboBox_ilce, comboBox_il.SelectedItem.ToString());
            }
            if (((ComboBox)sender) == comboBox2_il)
            {
                if (comboBox2_il.SelectedItem != null)
                    comboBox2_ilce.SelectedItem = null;
                comboBox2_ilce.Items.Clear();
                db.Doldurilce(comboBox2_ilce, comboBox2_il.SelectedItem.ToString());
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender) == radioButton1)
            {
                groupBox3.Visible = true;
                groupBox4.Visible = false;
            }
            if (((RadioButton)sender) == radioButton2)
            {
                groupBox3.Visible = true;
                groupBox4.Visible = false;
            }
        }
    }
}
