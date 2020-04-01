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
    public partial class Update : Form
    {
        Database db = new Database();

        public Update()
        {
            InitializeComponent();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            make();
        }

        private void make()
        {
            db.Dolduril(comboBox_il);
            enumTurDoldur();
        }       
        public void enumTurDoldur()
        {
            string[] days = Enum.GetNames(typeof(ClassLibrary.Home.KindOf));
            foreach (string day in days)
            {
                comboBox_tur.Items.Add(day);
            }
        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            if (rBtn_sale.Checked == true)//sale
            {
                if (textBox_alan.Text != " " && comboBox_ilce.SelectedItem != null && textBox_kat.Text != " " &&
            textBox_oda.Text != " " && comboBox_tur.SelectedItem != null && ((textBox_kira.Text != " " &&
            textBox_deposit.Text != " ") || textBox_fiyat.Text != " "))
                {
                    ClassLibrary.Sale sale = new ClassLibrary.Sale();
                    if (rBtn_aktif.Checked == true)
                        sale.ActiveStatus = true;
                    else if (rBtn_pasif.Checked == true)
                        sale.ActiveStatus = false;
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
                    MessageBox.Show("Güncelleme Başarılı", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1 form1 = new Form1();
                    form1.listelemeIslemi();
                    this.Hide();
                }
                else
                    MessageBox.Show("Güncelleme Başarısız", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (rBtn_rent.Checked == true)//rent
            {          
                if (textBox_alan.Text != " " && comboBox_ilce.SelectedItem != null && textBox_kat.Text != " " &&
                textBox_oda.Text != " " && comboBox_tur.SelectedItem != null && ((textBox_kira.Text != " " &&
                textBox_deposit.Text != " ") || textBox_fiyat.Text != " "))
                {
                    ClassLibrary.Rent rent = new ClassLibrary.Rent();
                    if(rBtn_aktif.Checked == true)
                        rent.ActiveStatus = true;
                    else if(rBtn_pasif.Checked == true)
                        rent.ActiveStatus = false;
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
                    MessageBox.Show("Güncelleme Başarılı", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1 form1 = new Form1();
                    //form1.silmeIslemi();
                    this.Hide();
                }
                else
                    MessageBox.Show("Güncelleme Başarısız", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Güncelleme Başarısız", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Error);            

        }
        public void DoDataGrid(DataGridView dataGridView, bool sale)
        {
            if (sale == true)
            {
                if (dataGridView.CurrentRow.Cells["EvinDurumu"].Value.ToString() == "True")
                    rBtn_aktif.Checked = true;
                else if (dataGridView.CurrentRow.Cells["EvinDurumu"].Value.ToString() == "False")
                    rBtn_pasif.Checked = true;
                rBtn_sale.Checked = true;
                groupBox3.Visible = true;
                textBox_oda.Text = dataGridView.CurrentRow.Cells["OdaSayisi"].Value.ToString();
                textBox_kat.Text = dataGridView.CurrentRow.Cells["KatSayisi"].Value.ToString();
                textBox_alan.Text = dataGridView.CurrentRow.Cells["EvinAlani"].Value.ToString();
                textBox_fiyat.Text = dataGridView.CurrentRow.Cells["Fiyati"].Value.ToString();

                aaa(dataGridView);
               
            }
            if (sale == false)
            {
                if (dataGridView.CurrentRow.Cells["EvinDurumu"].Value.ToString() == "False")
                    rBtn_pasif.Checked = true;
                else if (dataGridView.CurrentRow.Cells["EvinDurumu"].Value.ToString() == "True")
                    rBtn_aktif.Checked = true;
                rBtn_rent.Checked = true;
                groupBox4.Visible = true;
                textBox_oda.Text = dataGridView.CurrentRow.Cells["OdaSayisi"].Value.ToString();
                textBox_kat.Text = dataGridView.CurrentRow.Cells["KatSayisi"].Value.ToString();
                textBox_alan.Text = dataGridView.CurrentRow.Cells["EvinAlani"].Value.ToString();
                textBox_kira.Text = dataGridView.CurrentRow.Cells["KiraFiyati"].Value.ToString();
                textBox_deposit.Text = dataGridView.CurrentRow.Cells["Depozito"].Value.ToString();
                aaa(dataGridView);
            }
        }
        void aaa (DataGridView dataGridView)
        {
            foreach (var item in comboBox_il.Items)
            {
                if (item.ToString() == dataGridView.CurrentRow.Cells["il"].Value.ToString())
                {
                    comboBox_il.SelectedItem = item;
                }
            }
            if (comboBox_il.SelectedItem != null)
                comboBox_ilce.SelectedItem = null;
            comboBox_ilce.Items.Clear();
            db.Doldurilce(comboBox_ilce, comboBox_il.SelectedItem.ToString());
            foreach (var item in comboBox_ilce.Items)
            {
                if (item.ToString() == dataGridView.CurrentRow.Cells["ilce"].Value.ToString())
                {
                    comboBox_ilce.SelectedItem = item;
                }
            }
            foreach (var item in comboBox_tur.Items)
            {
                if (item.ToString() == dataGridView.CurrentRow.Cells["Turu"].Value.ToString())
                {
                    comboBox_tur.SelectedItem = item;
                }
            }
        }

        private void comboBox_il_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox_il.SelectedItem != null)
                comboBox_ilce.SelectedItem = null;
            comboBox_ilce.Items.Clear();
            db.Doldurilce(comboBox_ilce, comboBox_il.SelectedItem.ToString());
        }

        private void rBtn_sale_CheckedChanged(object sender, EventArgs e)
        {          
                groupBox3.Visible = true;
                groupBox4.Visible = false;
        }

        private void rBtn_rent_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox4.Visible = true;
        }
    }
}
