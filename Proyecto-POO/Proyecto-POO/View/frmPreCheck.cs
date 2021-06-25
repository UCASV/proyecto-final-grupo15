using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_POO.MySQLContext;
using MySql.EntityFrameworkCore;

namespace Proyecto_POO
{
    public partial class frmPreCheck : Form
    {
        public frmPreCheck()
        {
            InitializeComponent();
        }

        private void frmPreCheck_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void updateCheckBoxes()
        {
            var db = new ProyectoContext();
            List<Diseasexcitizen> diseasexcitizens = db.Diseasexcitizens.ToList();
            List<Diseasexcitizen> diseases = new List<Diseasexcitizen>();
            List<Diseasexcitizen> diabetes = diseasexcitizens.Where(dxc => dxc.IdDisease == 1 && dxc.IdCitizen == Convert.ToInt32(txtDui.Text)).ToList();
            diabetes.ForEach(d =>
            {
                cbxDiabetes.Checked = true;
                
            });
            db.SaveChanges();
            List<Diseasexcitizen> cardio = diseasexcitizens.Where(dxc => dxc.IdDisease == 2 && dxc.IdCitizen == Convert.ToInt32(txtDui.Text)).ToList();
            cardio.ForEach(c =>
            {
                cbxCardio.Checked = true;
            });
            List<Diseasexcitizen> pulmonar = diseasexcitizens.Where(dxc => dxc.IdDisease == 3 && dxc.IdCitizen == Convert.ToInt32(txtDui.Text)).ToList();
            pulmonar.ForEach(p =>
            {
                cbxPulmonar.Checked = true;
            });
            List<Diseasexcitizen> renal = diseasexcitizens.Where(dxc => dxc.IdDisease == 4 && dxc.IdCitizen == Convert.ToInt32(txtDui.Text)).ToList();
            renal.ForEach(d =>
            {
                cbxRenal.Checked = true;
            });
            List<Diseasexcitizen> cancer = diseasexcitizens.Where(dxc => dxc.IdDisease == 5 && dxc.IdCitizen == Convert.ToInt32(txtDui.Text)).ToList();
            cancer.ForEach(d =>
            {
                cbxCancer.Checked = true;
            });
            List<Diseasexcitizen> organos = diseasexcitizens.Where(dxc => dxc.IdDisease == 6 && dxc.IdCitizen == Convert.ToInt32(txtDui.Text)).ToList();
            organos.ForEach(d =>
            {
                cbxOrganReceptor.Checked = true;
            });
            List<Diseasexcitizen> seropositivas = diseasexcitizens.Where(dxc => dxc.IdDisease == 7 && dxc.IdCitizen == Convert.ToInt32(txtDui.Text)).ToList();
            seropositivas.ForEach(d =>
            {
                cbxSeropositivas.Checked = true;
            });
            List<Diseasexcitizen> tratamiento = diseasexcitizens.Where(dxc => dxc.IdDisease == 8 && dxc.IdCitizen == Convert.ToInt32(txtDui.Text)).ToList();
            tratamiento.ForEach(d =>
            {
                cbxCardio.Checked = true;
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cbxAccept.Checked == true)
            {
                validateDate();
                var db = new ProyectoContext();
                var result = db.Citizens.Where(c => (c.Dui.Equals(Convert.ToInt32(txtDui.Text)))).ToList();
                try
                {
                    //List<Institution> selectedInstituion = institutions.OrderByDescending(i => i.IdInstitution == r.IdInstitution).ToList();
                    //var selectedInstituion = db.Institutions.OrderByDescending(i => i.IdInstitution == cmbInstitution.SelectedIndex).ToList();
                    Citizen c = result[0];
                    if (txtName.Text != "" && txtName.Text != string.Empty)
                    {
                        if (txtAddress.Text != "" && txtAddress.Text != string.Empty)
                        {
                            if (txtPhone.Text != "" && txtPhone.Text != string.Empty)
                            {
                                if (dtpBirthdate.Value >= dtpBirthdate.MinDate && dtpBirthdate.Value <= dtpBirthdate.MaxDate)
                                {
                                    c.Dui = Convert.ToInt32(txtDui.Text);
                                    c.CitizenName = txtName.Text;
                                    c.Address = txtAddress.Text;
                                    c.Phone = Convert.ToInt32(txtPhone.Text);
                                    if (txtEmail.Text != "" || txtEmail.Text != string.Empty || txtEmail.Text != null)
                                        c.Email = txtEmail.Text;
                                    else
                                        c.Email = null;
                                    c.Birthdate = dtpBirthdate.Value;
                                    if (txtIdentifierNumber.Text != "" || txtIdentifierNumber.Text != string.Empty || txtIdentifierNumber.Text != null)
                                        c.IdentifierNumber = Convert.ToInt32(txtIdentifierNumber.Text);
                                    else
                                        c.IdentifierNumber = null;
                                    c.IdInstitution = Convert.ToInt32(lblId.Text);
                                    //updateCheckBoxes();
                                    db.Update(c);
                                    db.SaveChanges();
                                    MessageBox.Show("Se han verificado los datos del/la ciudadano/a. Procediendo a monitoreo de citas.", "Operación éxitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    frmAppoinmentMonitoring frm = new frmAppoinmentMonitoring();
                                    frm.Show();
                                    this.Hide();
                                }
                                else
                                    MessageBox.Show("El valor para fecha de nacimiento no es válido.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);   
                            }
                            else
                                MessageBox.Show("El campo teléfono es un campo requerido, favor rellenarlo.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                            MessageBox.Show("El campo dirección actual es un campo requerido, favor rellenarlo.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show("El campo nombre es un campo requerido, favor rellenarlo.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception)
                {
                    MessageBox.Show("Algo salio mal. Por favor ingrese solamente valores válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Debe aceptar que desea recibir la dosis de vacuna.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            frm.Show();
            this.Hide();
        }

        private void frmPreCheck_Load(object sender, EventArgs e)
        {
            validateDate();
            var db = new ProyectoContext();
            List<Disease> diseases = db.Diseases.ToList();
            // Fijamos el texto de cada checkbox acorde a las enfermedades crónicas que complican o impiden el
            // proceso de vacunación
            List<Disease> diabetes = diseases.Where(d => d.IdDisease == 1).ToList();
            diabetes.ForEach(d =>
            {
                cbxDiabetes.Text = d.ChronicDisease;
            });
            List<Disease> cardio = diseases.Where(d => d.IdDisease == 2).ToList();
            cardio.ForEach(d =>
            {
                cbxCardio.Text = d.ChronicDisease;
            });
            List<Disease> pulmonar = diseases.Where(d => d.IdDisease == 3).ToList();
            pulmonar.ForEach(d =>
            {
                cbxPulmonar.Text = d.ChronicDisease;
            });
            List<Disease> renal = diseases.Where(d => d.IdDisease == 4).ToList();
            renal.ForEach(d =>
            {
                cbxRenal.Text = d.ChronicDisease;
            });
            List<Disease> cancer = diseases.Where(d => d.IdDisease == 5).ToList();
            cancer.ForEach(d =>
            {
                cbxCancer.Text = d.ChronicDisease;
            });
            List<Disease> organos = diseases.Where(d => d.IdDisease == 6).ToList();
            organos.ForEach(d =>
            {
                cbxOrganReceptor.Text = d.ChronicDisease;
            });
            List<Disease> seropositivas = diseases.Where(d => d.IdDisease == 7).ToList();
            seropositivas.ForEach(d =>
            {
                cbxSeropositivas.Text = d.ChronicDisease;
            });
            List<Disease> tratamiento = diseases.Where(d => d.IdDisease == 8).ToList();
            tratamiento.ForEach(d =>
            {
                cbxInmunosupresor.Text = d.ChronicDisease;
            });
        }

        private void validateDate()
        {
            DateTime date = DateTime.Today;
            var minYear = (date.Year - 100);
            var maxYear = (date.Year - 18);
            var minDate = (minYear  + "/" + date.Month + "/" + date.Day).ToString();
            var maxDate = maxYear.ToString() + "/12/31";
            dtpBirthdate.MinDate = Convert.ToDateTime(minDate);
            dtpBirthdate.MaxDate = Convert.ToDateTime(maxDate);
        }

        private void clearFields()
        {
            validateDate();
            // Limpiar los campos al momento de ejecutar la búsqueda
            txtDui.Clear();
            txtName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtIdentifierNumber.Clear();
            lblInstitution.Text = "";
            dtpBirthdate.Value = dtpBirthdate.MaxDate;
            cbxDiabetes.Checked = false;
            cbxCardio.Checked = false;
            cbxPulmonar.Checked = false;
            cbxRenal.Checked = false;
            cbxCancer.Checked = false;
            cbxOrganReceptor.Checked = false;
            cbxSeropositivas.Checked = false;
            cbxCardio.Checked = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            clearFields();
            var db = new ProyectoContext();
            List<Citizen> citizens = db.Citizens.ToList();
            List<Institution> institutions = db.Institutions.ToList();
            List<Diseasexcitizen> diseasexcitizens = db.Diseasexcitizens.ToList();

            // Obtenemos el valor ingresado por el gestor y lo utilizamos para buscar al ciudadano por medio del DUI
            try
            {
                int dui = Convert.ToInt32(txtSearch.Text);
                List<Citizen> result = citizens.Where(c => c.Dui == dui).ToList();

                if (result.Count() > 0)
                {
                    txtSearch.Clear();
                    result.ForEach(r =>
                    {
                        txtDui.Text = r.Dui.ToString();
                        txtName.Text = r.CitizenName;
                        txtAddress.Text = r.Address;
                        txtPhone.Text = r.Phone.ToString();
                        txtEmail.Text = r.Email;
                        dtpBirthdate.Value = Convert.ToDateTime(r.Birthdate);
                        txtIdentifierNumber.Text = r.IdentifierNumber.ToString();
                        List<Institution> selectedInstituion = institutions.Where(i => i.IdInstitution == r.IdInstitution).ToList();
                        selectedInstituion.ForEach(s =>
                        {
                            lblId.Text = s.IdInstitution.ToString();
                            lblInstitution.Text = s.InstitutionName;
                        });
                        // Realizamos la consulta para mostrar chequeadas las enfermedades crónicas que el ciudadano padece
                        List<Diseasexcitizen> diabetes = diseasexcitizens.Where(dxc => dxc.IdDisease == 1 && dxc.IdCitizen == dui).ToList();
                        diabetes.ForEach(d =>
                        {
                            cbxDiabetes.Checked = true;
                        });
                        List<Diseasexcitizen> cardio = diseasexcitizens.Where(dxc => dxc.IdDisease == 2 && dxc.IdCitizen == dui).ToList();
                        cardio.ForEach(d =>
                        {
                            cbxCardio.Checked = true;
                        });
                        List<Diseasexcitizen> pulmonar = diseasexcitizens.Where(dxc => dxc.IdDisease == 3 && dxc.IdCitizen == dui).ToList();
                        pulmonar.ForEach(d =>
                        {
                            cbxPulmonar.Checked = true;
                        });
                        List<Diseasexcitizen> renal = diseasexcitizens.Where(dxc => dxc.IdDisease == 4 && dxc.IdCitizen == dui).ToList();
                        renal.ForEach(d =>
                        {
                            cbxRenal.Checked = true;
                        });
                        List<Diseasexcitizen> cancer = diseasexcitizens.Where(dxc => dxc.IdDisease == 5 && dxc.IdCitizen == dui).ToList();
                        cancer.ForEach(d =>
                        {
                            cbxCancer.Checked = true;
                        });
                        List<Diseasexcitizen> organos = diseasexcitizens.Where(dxc => dxc.IdDisease == 6 && dxc.IdCitizen == dui).ToList();
                        organos.ForEach(d =>
                        {
                            cbxOrganReceptor.Checked = true;
                        });
                        List<Diseasexcitizen> seropositivas = diseasexcitizens.Where(dxc => dxc.IdDisease == 7 && dxc.IdCitizen == dui).ToList();
                        seropositivas.ForEach(d =>
                        {
                            cbxSeropositivas.Checked = true;
                        });
                        List<Diseasexcitizen> tratamiento = diseasexcitizens.Where(dxc => dxc.IdDisease == 8 && dxc.IdCitizen == dui).ToList();
                        tratamiento.ForEach(d =>
                        {
                            cbxCardio.Checked = true;
                        });
                    });
                    MessageBox.Show("Ciudadano encontrado.", "Operación éxitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("El ciudadano no posee registro de cita. ¿Desea realizar un registro de cita para este ciudadano?", "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Algo salió mal con la búsqueda. Intente ingresar solamente carácteres numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxOrganReceptor_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
