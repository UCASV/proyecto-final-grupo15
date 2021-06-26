using System;
using Proyecto_POO.MySQLContext;
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
        Queue<CitizenVm1> addWaitingList = new Queue<CitizenVm1>()
        {

        };
        private void showWaitingList()
        {
            using (var context = new ProyectoContext())
            {
                var showCitizens = context.Citizens
                    .ToList();

                var mappedDs = new List<CitizenVm>();

                showCitizens.ForEach(e => mappedDs.Add(CitizenMapper.MapCitizenToCitizenVm(e)));
                dgvMonitoring.DataSource = mappedDs;
            }
        }

        public frmAppoinmentMonitoring()
        {
            InitializeComponent();
        }

        private void btnAddToList_Click(object sender, EventArgs e)
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
            addWaitingList.Enqueue(model);
            MessageBox.Show("Se agrego el " + dateNow + "a las " + hourNow);
            frmVaccination frm = new frmVaccination(addWaitingList);
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
            showWaitingList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new ProyectoContext())
                {
                    var showCitizens = context.Citizens
                    .ToList();
                    var institutions = context.Institutions
                        .ToList();

                    var innerjoin =
                        from institution in institutions
                        join citizen in showCitizens on institution.IdInstitution equals citizen.Dui
                        select new { IdI = institution.IdInstitution };

                    var filter = showCitizens
                        .Where(c => c.Dui == (Convert.ToInt32(txtSearch.Text)));
                    var mappedDs = new List<CitizenVm>();

                    if (filter.Count() > 0)
                    {
                        var citizenss = filter.SingleOrDefault();
                        List<CitizenVm> citizenSearch = new List<CitizenVm>();
                        citizenSearch.Add(CitizenMapper.MapCitizenToCitizenVm(citizenss));
                        showCitizens.ForEach(e => mappedDs.Add(CitizenMapper.MapCitizenToCitizenVm(e)));
                        dgvMonitoring.DataSource = null;
                        dgvMonitoring.DataSource = citizenSearch;
                        MessageBox.Show("Ciudadano encontrado");

                    }
                    else
                    {
                        dgvMonitoring.DataSource = null;
                        MessageBox.Show("El ciudadano no se encuentra en la lista de espera", "Peligro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese los numeros de su DUI", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
