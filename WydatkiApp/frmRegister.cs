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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
            txtPassword.PasswordChar='*';
            txtConfirmPassword.PasswordChar = '*';
        }
        /// <summary>
        /// Rejestracja użytkownika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            using DataBaseContext context = new DataBaseContext();

            IFunctions wydatki = new MockFunctions(context);

            User newUser = new()
            {
                Email = txtEmail.Text,
                Password = txtPassword.Text
            };

            if (txtEmail.Text == "" || txtPassword.Text == "" || txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Login i hasło są puste", "Rejestracja nieudana", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == txtConfirmPassword.Text && !wydatki.isUserExits(newUser))
            {
                wydatki.SignUser(newUser);
                MessageBox.Show("Przejdz do logowania", "Zarejestrowano", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(txtPassword.Text == txtConfirmPassword.Text && wydatki.isUserExits(newUser))
            {
                MessageBox.Show("Konto o takim loginie jest juz zarejestrowane.", "Konto z tym loginem istnieje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Hasła nie są takie same", "Rejestracja nieudana", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Przejście do logowania
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelGoToLogin_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }
    }
}
