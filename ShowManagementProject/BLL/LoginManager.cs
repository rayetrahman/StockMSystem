using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShockManagementProject.DAL;
using ShockManagementProject.Model;

namespace ShockManagementProject.BLL
{
    class LoginManager
    {
  
        LogInGateway aLogInGateway=new LogInGateway();

        public void login(Login aLogin)

        {

            string count = aLogInGateway.login(aLogin);
            if (count == "1")
            {
               // MessageBox.Show("Username and Password . . . is Correct", "Confirmation Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);               
                Main obMain = new Main();
                obMain.Show();
            }
            else
            {
                MessageBox.Show("Username and Password is Not Correct . . . Please try again", "Error Message!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                login alogin = new login();
                alogin.Show();
            }
               
        }
    }
}
