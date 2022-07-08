using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WydatkiApp.Interface;
using WydatkiApp.Models;

namespace WydatkiApp
{
    public partial class frmLogin : Form
    {
        public static User userModel;
        
        public frmLogin()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }
        /// <summary>
        /// Logowanie do dashboardu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            using DataBaseContext context = new DataBaseContext();

            IFunctions functions = new MockFunctions(context);

            User user = new()
            {
                Email = txtEmail.Text,
                Password = txtPassword.Text
            };

            

            var loginUser = functions.LoginUser(user);

            if(loginUser != null)
            {
                userModel = loginUser;
                new Dashboard().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Niepoprawne dane", "Logwanie nieudane", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Przejście do rejestracji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelGoToLogin_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }
    }
}
