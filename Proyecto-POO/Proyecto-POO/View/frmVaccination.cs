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
        private Manager IdManager { get; set; }

        Queue<CitizenVm> vaccination;

        Queue<CitizenVm1> monitoreo;
        public frmVaccination(Queue<CitizenVm> models, Queue<CitizenVm1> vacqueue, Manager IdManager)
        {
            InitializeComponent();
            vaccination = models;
            monitoreo = vacqueue;          
            dgvQueue.DataSource = vacqueue.ToList();
            this.IdManager = IdManager;
        }

        private void frmVaccination_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                prbProgress.Visible = true;
                label3.Visible = true;
                timer1.Enabled = true;
                conteo++;
                if (conteo == 10)
                {
                    timer1.Enabled = false;
                    MessageBox.Show("El tiempo de observacion ha terminado");
                    frmSideEffects frm = new frmSideEffects(vaccination, monitoreo, IdManager);
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
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu(vaccination, IdManager);
            frm.Show();
            this.Hide();
        }

        private void frmVaccination_Load(object sender, EventArgs e)
        {
            label2.Text = "" + IdManager.IdManager;
        }

        private void prbProgress_Click(object sender, EventArgs e)
        {

        }
    }
}
