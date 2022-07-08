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
    public partial class Dashboard : Form
    {
        /// <summary>
        /// URUCHAMIA SIĘ PODCZAS OTWIERANIA OKNA
        /// </summary>
        public Dashboard()
        {
            InitializeComponent();


            using DataBaseContext context = new DataBaseContext();

            IFunctions functions = new MockFunctions(context);

            var wydatkiList = functions.GetAll();

            var userModel = frmLogin.userModel;

            var money = 0;

            //Pętla do ładowania listy z bazy danych i aktualizowania stanu konta

            foreach (var item in wydatkiList)
            {
                if (item.UserId.Equals(userModel.Id))
                {
                    money += item.Amount;
                    ListViewItem list = new ListViewItem(item.Id.ToString());

                    list.SubItems.Add(item.Description.ToString());
                    list.SubItems.Add(item.Amount.ToString());

                    listView.Items.Add(list);
                }
                
            }
            functions.UpdateMoney(money, userModel.Id);
            labelMoney.Text = money.ToString()+ " zł";
        }
        /// <summary>
        /// Dodawanie elementów do listy
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            

            using DataBaseContext context = new DataBaseContext();
            IFunctions functions = new MockFunctions(context);

            var userModel = frmLogin.userModel;
            var updatedUser = functions.GetUpdatedUser(userModel);

            if (string.IsNullOrEmpty(txtAmount.Text) || string.IsNullOrEmpty(txtDescription.Text))
            {
                return;
            }
            try
            {
                WydatkiModel wydatkiModel = new() { Amount = int.Parse(txtAmount.Text), Description = txtDescription.Text, UserId = userModel.Id };
                int money = int.Parse(wydatkiModel.Amount.ToString()) + updatedUser.Money;

                functions.AddData(wydatkiModel);
                functions.UpdateMoney(wydatkiModel.Amount, userModel.Id);
            }
            catch
            {
                MessageBox.Show("Spróbuj ponownie");
            }
            

            txtDescription.Clear();
            txtAmount.Clear();

            RefreshForm();
        }
        /// <summary>
        /// Usuwanie zaznaczonego elementu z listy
        /// </summary>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            using DataBaseContext context = new DataBaseContext();
            IFunctions functions = new MockFunctions(context);

            var userModel = frmLogin.userModel;
            var updatedUser = functions.GetUpdatedUser(userModel);

            if (listView.Items.Count > 0)
            {
                ListViewItem item = listView.SelectedItems[0];
                WydatkiModel model = new()
                {
                    Id = int.Parse(listView.SelectedItems[0].Text),
                    Description = listView.SelectedItems[0].SubItems[1].Text,
                    Amount = int.Parse(listView.SelectedItems[0].SubItems[2].Text)
                };
                functions.RemoveData(model);

                RefreshForm();
            }
        }
        /// <summary>
        /// Edytowanie zaznaczonego elementu w liście
        /// </summary>
        private void listView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView.Items.Count > 0)
            {
                this.txtDescription.Text = listView.SelectedItems[0].SubItems[1].Text.ToString();
                this.txtAmount.Text = listView.SelectedItems[0].SubItems[2].Text.ToString();
            }
        }
        /// <summary>
        /// Zatwierdzenie edycji zaznaczonego elementu, wysłanie do bazy danych
        /// </summary>
        private void btnChange_Click(object sender, EventArgs e)
        {
            var userModel = frmLogin.userModel;

            using DataBaseContext context = new DataBaseContext();
            IFunctions functions = new MockFunctions(context);

            var updatedUser = functions.GetUpdatedUser(userModel);


            if (listView.Items.Count > 0)
            {
                try
                {
                    WydatkiModel model = new()
                    {
                        Id = int.Parse(listView.SelectedItems[0].Text),
                        Description = txtDescription.Text,
                        Amount = int.Parse(txtAmount.Text)
                    };

                    functions.UpdateData(model);
                }
                catch
                {
                    MessageBox.Show("Spróbuj ponownie");
                }


                RefreshForm();
            }

            
        }
        /// <summary>
        /// Odświeżenie okna
        /// </summary>
        private void RefreshForm()
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Close();
        }

    }
}
