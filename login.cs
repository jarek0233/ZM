using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZM
{
    public partial class login : Form
    {

        private const string User = "admin";
        private const string Haslo = "admin";
        public login()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBoxUser.Text;
            string password = textBoxPassword.Text;

            if (User == user && Haslo == password)
            {
                menu menu = new menu();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nieprawidlowa nazwa uzytkownika lub haslo.");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
