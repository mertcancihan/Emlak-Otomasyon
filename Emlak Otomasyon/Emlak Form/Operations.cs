using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using System.Windows.Forms;

namespace Emlak_Form
{
    class Operations
    {
        public static Operations obj = new Operations();
        bool userCont;
        Home[] homes = new Home[1000];

        public bool UserControl(string user)
        {
            Database db = new Database();
            if (user == db.userControl())
                userCont = true;
            else
                userCont = false;

            return userCont;
        }
        
    }
}
