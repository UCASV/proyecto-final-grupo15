using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_POO.MySQLContext;

namespace Proyecto_POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // usuario: txtUser, contraseña: txtPassword, olvidar contraseña: lblForgotPassword

            var db = new ProyectoContext();
            string user = txtUser.Text;

            string password = txtPassword.Text;

            List<Manager> managers = db.Managers
                .ToList();

            List<Manager> result = managers
                .Where(u => u.Username == user && u.ManagerPassword == password)
                .ToList();

            if (result.Count() > 0)
            {
                MessageBox.Show("Bienvenido!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMenu frm = new frmMenu(result[0]);
                frm.Show();
                this.Hide();
            }
            // sino, mostrar un mensaje de error
            else
                MessageBox.Show("ERROR!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void lblForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword();
            frm.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
