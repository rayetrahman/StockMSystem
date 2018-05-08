using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using ShockManagementProject.BLL;
using ShockManagementProject.Model;


namespace ShockManagementProject
{
    public partial class login : Form
    {      

        public login()
        {
            InitializeComponent();
        }

        LoginManager aLoginManager=new LoginManager();
      

        private void loginButton_Click_1(object sender, EventArgs e)
        {
            Login aLogin = new Login();
            aLogin.UserName = userNameTextBox.Text;
            aLogin.Password = passwordTextBox.Text;

            aLoginManager.login(aLogin);
            this.Hide();          
        }
    }
}
