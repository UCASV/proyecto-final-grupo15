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
using Proyecto_POO.ViewModel;

namespace Proyecto_POO
{
    public partial class frmShowEmployee : Form
    {
        Queue<CitizenVm> appointment;
        private Manager IdManager { get; set; }
        public frmShowEmployee(Queue<CitizenVm> models,Manager IdManager)
        {
            InitializeComponent();
            this.IdManager = IdManager;
            appointment = models;

        }
        private void showWaiting()
        {
            using (var context = new ProyectoContext())
            {
                var showEmployees = context.Employees
                    .ToList();
                var mappedDS = new List<EmployeeVm>();

                showEmployees.ForEach(em => mappedDS.Add(CitizenMapper.MapEmployeeToEmployeeVm(em)));
                dgvShowEmployees.DataSource = mappedDS;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void btnSearchEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new ProyectoContext())
                {
                    var showEmployees = context.Employees
                    .ToList();

                    var filter = showEmployees
                        .Where(c => c.IdEmployee == (Convert.ToInt32(txtSearch.Text)));
                    var mappedDs = new List<EmployeeVm>();

                    if (filter.Count() > 0)
                    {
                        var employees = filter.SingleOrDefault();
                        List<EmployeeVm> employeeSearch = new List<EmployeeVm>();
                        employeeSearch.Add(CitizenMapper.MapEmployeeToEmployeeVm(employees));
                        showEmployees.ForEach(e => mappedDs.Add(CitizenMapper.MapEmployeeToEmployeeVm(e)));
                        dgvShowEmployees.DataSource = null;
                        dgvShowEmployees.DataSource = employeeSearch;
                        MessageBox.Show("Empleado encontrado");

                    }
                    else
                    {
                        dgvShowEmployees.DataSource = null;
                        MessageBox.Show("El Empleado no se encuentra", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese los numeros de su DUI", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvShowEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
        private void frmShowEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void frmShowEmployee_Load(object sender, EventArgs e)
        {
            showWaiting();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu(appointment, IdManager);
            frm.Show();
            this.Hide();
        }
    }
}
