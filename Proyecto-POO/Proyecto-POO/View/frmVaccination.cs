using System;
using System.Collections.Generic;
using Proyecto_POO.ViewModels;
using Proyecto_POO.MySQLContext;
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
        int conteo = 0;
        public frmVaccination(Queue<CitizenVm1> models)
        {
            InitializeComponent();
            dgvQueue.DataSource = models.ToList();
        }

        private void frmVaccination_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("El paciente ya ha sido vacunado, pasará al módulo de Observación.", "Vacunación realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //DateTime nuevaDate = Convert.ToDateTime("yyyy-MM-dd");
            //nuevaDate = nuevaDate.AddDays(42);

            //Creo un timer con un intervalo de 2000 milisegundos.
            try
            {
                conteo++;
                timer1.Enabled = true;
                if (conteo == 10)
                {
                    timer1.Enabled = false;
                    MessageBox.Show("El tiempo de observacion ha terminado");
                    frmSideEffects frm = new frmSideEffects();
                    frm.Show();
                    this.Hide();
                }

                if (prbProgress.Minimum < prbProgress.Maximum)
                {
                    prbProgress.Value++;
                }
            }
            catch(Exception)
            {
                
            }


          /*  frmSideEffects frm = new frmSideEffects();
            frm.Show();
            this.Hide();*/
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu(null);
            frm.Show();
            this.Hide();
        }

        private void frmVaccination_Load(object sender, EventArgs e)
        {

        }

        private void prbProgress_Click(object sender, EventArgs e)
        {

        }
    }
}
