using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using InventoryCB.Business.Service.Abstract;
using InventoryCB.Business.Service.Concret;
using InventoryCB.models;
using InventoryCB.View;


namespace InventoryCB
{
    public partial class LoginForm : Form
    {
        IAuthentificationService _authentificationService ;
        public LoginForm()
        {
            this._authentificationService = new AuthentificationService();
            InitializeComponent();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Cursor.Show();
            authentification();
            Cursor.Current = Cursors.Default;
            Cursor.Show();
            
        }

        private void authentification()
        {
            String login = tx_login.Text;
            String password = tx_password.Text;

            if (login == "" || password == "")
            {
                MessageBox.Show("Vous devez remplir tous les champs !");
            }
            else
            {
               // AuthentificationService authentificationService = new AuthentificationService() ;
                User user = _authentificationService.findUser(login, password);
                if (user == null)
                {
                    MessageBox.Show("Login ou mot de passe incorrect !");
                    tx_login.Text = "";
                    tx_password.Text = "";
                    tx_login.Focus();

                }
                else
                {                   
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                }
            }


        }
    }
}