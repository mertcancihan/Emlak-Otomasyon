using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Emlak_Form
{
    public partial class Login : Form
    {
        bool userCont;
        Thread th;
        public Login()
        {
            InitializeComponent();
        }
        private void btn_giris_Click(object sender, EventArgs e)
        {
            Operations operations = new Operations();
            userCont = operations.UserControl(txt_userName.Text + " " + txt_userPassword.Text);
            if (userCont == true)
            {                
                this.Close();
                th = new Thread(OpenNewForm);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
                MessageBox.Show("Kullanıcı Adı ve Şifre Yanlış Tekrar Deneyiniz!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void OpenNewForm(object obj)
        {
            Application.Run(new Form1());
        }
    }
}
