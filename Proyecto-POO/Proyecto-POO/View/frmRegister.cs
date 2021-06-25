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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void frmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ciudadano registrado con éxito, ahora debe continuar al módulo Prechequeo.", "Operación éxitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmMenu frm = new frmMenu(null);
            frm.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu(null);
            frm.Show();
            this.Hide();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            dtpBirthdate.MaxDate = DateTime.Today;
        }
    }
}
