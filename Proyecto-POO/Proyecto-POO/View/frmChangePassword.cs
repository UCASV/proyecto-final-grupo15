using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_POO
{
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La contraseña fue restablecida correctamente.", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void frmChangePassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {

        }
    }
}
