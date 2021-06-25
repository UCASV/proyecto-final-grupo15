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
    public partial class frmWaitingList : Form
    {
        public frmWaitingList()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El paciente fue procesado con éxito, ahora pasará al módulo de Vacunación.", "Operación éxitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmMenu frm = new frmMenu();
            frm.Show();
            this.Hide();
        }

        private void frmWaitingList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmAppoinmentMonitoring frm = new frmAppoinmentMonitoring();
            frm.Show();
            this.Hide();
        }

        private void frmWaitingList_Load(object sender, EventArgs e)
        {
            dtpAppoinmentDate.MinDate = DateTime.Today;
            dtpAppoinmentTime.MinDate = DateTime.Now;
        }
    }
}
