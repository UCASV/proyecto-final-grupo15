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
    public partial class frmAppoinmentMonitoring : Form
    {
        public frmAppoinmentMonitoring()
        {
            InitializeComponent();
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ciudadano a lista de espera con éxito.", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmWaitingList frm = new frmWaitingList();
            frm.Show();
            this.Hide();
        }

        private void frmAppoinmentMonitoring_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmPreCheck frm = new frmPreCheck();
            frm.Show();
            this.Hide();
        }

        private void frmAppoinmentMonitoring_Load(object sender, EventArgs e)
        {

        }
    }
}
