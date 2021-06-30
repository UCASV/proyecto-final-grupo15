using System;
using System.Collections.Generic;
using Proyecto_POO.ViewModels;
using Proyecto_POO.MySqlContext;
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
            var db = new ProyectoContext();
            try
            {
                             
                var hourNow = DateTime.Now.ToString("HH:mm:ss");
                var dateNow = DateTime.Now.ToString("dd-MM-yyyy");               
                var A = db.Appointments
                        .ToList();
                var C = db.Citizens
                        .ToList();
                var innerjoin =
                from citizens in C
                join appointments in A on citizens.Dui equals appointments.IdCitizen
                select new { idA = appointments.IdAppointment };
                string StatisticDate = DateTime.Now.ToString("HH:mm:ss");
                Statistic s = new();
                s.StatisticDate = DateTime.Parse(StatisticDate);
                s.StatisticHour = TimeSpan.Parse(hourNow);
                s.IdAppointment = innerjoin.FirstOrDefault().idA;
                db.Add(s);
                db.SaveChanges();
                countDown();
            }

            catch(Exception)
            {
                
            }            
        }
        private void countDown()
        {       prbProgress.Visible = true;
                label3.Visible = true;

                for(int progreso = 1; progreso <= 10; progreso++)
                {                    
                    prbProgress.Value++;                   
                    if (progreso == 10)
                    {                    
                        MessageBox.Show("El tiempo de observacion ha terminado");
                        frmSideEffects frm = new frmSideEffects(vaccination, monitoreo, IdManager);
                        frm.Show();
                        this.Hide();
                    }
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
