using System;
using Proyecto_POO.MySqlContext;
using Proyecto_POO.ViewModels;
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
        Queue<CitizenVm1> addWaiting = new Queue<CitizenVm1>()
         {

         };
         
        Queue<CitizenVm> appointment;        
        private Manager IdManager { get; set; }
        public frmAppoinmentMonitoring(Queue<CitizenVm>? models, Manager IdManager)
        {
            InitializeComponent(); 
            this.IdManager = IdManager;
            try
            {
                
                appointment = models;
                dgvMonitoring.DataSource = models.ToList();
            }
            catch(Exception)
            {

            }
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            try
            {
                var hourNow = DateTime.Now.ToString("HH:mm:ss");
                var dateNow = DateTime.Now.ToString("dd-MM-yyyy");
                CitizenVm1 model = new();
                model.Dui = Convert.ToInt32(dgvMonitoring.CurrentRow.Cells[0].Value);
                model.CitizenName = dgvMonitoring.CurrentRow.Cells[1].Value.ToString();
                model.Address = dgvMonitoring.CurrentRow.Cells[2].Value.ToString();
                model.Birthdate = Convert.ToDateTime(dgvMonitoring.CurrentRow.Cells[3].Value);
                model.Email = dgvMonitoring.CurrentRow.Cells[4].Value.ToString();
                model.Phone = Convert.ToInt32(dgvMonitoring.CurrentRow.Cells[5].Value);
                model.IdInstitution = Convert.ToInt32(dgvMonitoring.CurrentRow.Cells[6].Value);
                model.dateNow = dateNow;
                model.hourNow = hourNow;

                if (dgvMonitoring.Rows[0].Selected == true )
                {                   
                    addWaiting.Enqueue(model);
                    MessageBox.Show("Se agrego en la fecha " + dateNow + " a hora " + hourNow);
                    frmVaccination frm = new frmVaccination(appointment, addWaiting, IdManager);
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Se encuentra un paciente en cola");
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("No selecciono ningun usuario");
            }
        }

        private void frmAppoinmentMonitoring_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu(appointment, IdManager);
            frm.Show();
            this.Hide();
        }

        private void frmAppoinmentMonitoring_Load(object sender, EventArgs e)
        {
            
            label2.Text = "" + IdManager.IdManager;
        }
      
    }
}
