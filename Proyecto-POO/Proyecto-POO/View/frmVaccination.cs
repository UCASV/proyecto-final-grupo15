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
    public partial class frmVaccination : Form
    {
        public frmVaccination()
        {
            InitializeComponent();
        }

        private void frmVaccination_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El paciente ya ha sido vacunado, pasará al módulo de Observación.", "Vacunación realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmSideEffects frm = new frmSideEffects();
            frm.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            frm.Show();
            this.Hide();
        }
    }
}
