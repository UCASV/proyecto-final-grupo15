using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_POO.MySqlContext;
using Proyecto_POO.ViewModels;
using MySql.EntityFrameworkCore;

namespace Proyecto_POO
{
    public partial class frmPreCheck : Form
    {   
        //Queue<CitizenVm> menu;
        List<Institution> institutions;

        Queue<CitizenVm> addAppointmentMonitoring = new Queue<CitizenVm>()
        {
            
        };
        
        private void showWaitingList()
        {
            using (var context = new ProyectoContext())
            {
                var showCitizens = context.Citizens
                    .ToList();
                var citizenVm = new List<CitizenVm>();

                showCitizens.ForEach(e => citizenVm.Add(CitizenMapper.MapCitizenToCitizenVm(e)));
            }
        }
        private Manager IdManager { get; set; }

        public frmPreCheck(Queue<CitizenVm> model, Manager? IdManager)
        {
            InitializeComponent();
            this.IdManager = IdManager;            
            if(model != null)
            {
                addAppointmentMonitoring = model;
            }
        }

        private void frmPreCheck_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void updateCheckBoxes()
        {
            bool a = cbxDiabetes.Checked;
            bool b = cbxCardio.Checked;
            bool c = cbxPulmonar.Checked;
            bool d = cbxRenal.Checked;
            bool e = cbxCancer.Checked;
            bool f = cbxOrganReceptor.Checked;
            bool g = cbxSeropositivas.Checked;
            bool h = cbxInmunosupresor.Checked;

            bool[] arrayResult = new bool[8] { a, b, c, d, e, f, g, h };

            var db = new ProyectoContext();
            var DXC = db.Diseasexcitizens.ToList();

            int add = 0;

            for (int i = 0; i < 7; i++)
            {
                var disease =
                from diseasexcitizen in DXC
                where diseasexcitizen.IdDisease == i + 1
                where diseasexcitizen.IdCitizen == Convert.ToInt32(txtDui.Text)
                select new { idDisease = diseasexcitizen.IdDisease, idCitizen = diseasexcitizen.IdCitizen };
                var queryResult = disease.Count();
                if (arrayResult[i] == true && queryResult == 0)
                    add++;
            }

            int[] addIds = new int[add];
            int addPosition = 0;
            for (int j = 0; j < 7; j++)
            {
                var disease =
                from diseasexcitizen in DXC
                where diseasexcitizen.IdDisease == j + 1
                where diseasexcitizen.IdCitizen == Convert.ToInt32(txtDui.Text)
                select new { idDisease = diseasexcitizen.IdDisease, idCitizen = diseasexcitizen.IdCitizen };
                var queryResult = disease.Count();
                if (arrayResult[j] == true && queryResult == 0)
                {
                    addIds[addPosition] = j + 1;
                    addPosition++;
                }
            }

            if (addIds.Length > 0)
            {
                int result = 0;
                List<Diseasexcitizen> Diseases = new List<Diseasexcitizen>();
                for (int k = 0; k < addIds.Length; k++)
                {
                    Diseasexcitizen diseasexcitizen = new Diseasexcitizen()
                    {
                        IdDisease = addIds[result],
                        IdCitizen = Convert.ToInt32(txtDui.Text)
                    };
                    result++;
                    Diseases.Add(diseasexcitizen);
                }
                Diseases.ForEach(dxc => db.Add(dxc));
                db.SaveChanges();
                var savedDiseases = db.Diseasexcitizens.OrderBy(dxc => dxc.IdCitizen).ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cbxAccept.Checked == true)
            {
                validateDate();
                var db = new ProyectoContext();
                var result = db.Citizens.Where(c => (c.Dui.Equals(Convert.ToInt32(txtDui.Text)))).ToList();
                //try
                {
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
                                    if (txtIdentifierNumber.Text != "" || txtIdentifierNumber.Text != string.Empty)
                                        c.IdentifierNumber = Convert.ToInt32(txtIdentifierNumber.Text);
                                    else
                                        c.IdentifierNumber = 0;
                                    if (lblInstitution.Text != "" || lblInstitution.Text != string.Empty)
                                        c.IdInstitution = Convert.ToInt32(lblId.Text);
                                    else
                                        c.IdInstitution = 7;
                                    updateCheckBoxes();
                                    db.Update(c);
                                    db.SaveChanges();
                                    MessageBox.Show("Se han verificado los datos del/la ciudadano/a. Dirijase a monitoreo de citas.", "Operación éxitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    var hourNow = DateTime.Now.ToString("HH:mm:ss");
                                    var dateNow = DateTime.Now.ToString("dd-MM-yyyy");
                                    CitizenVm model = new();
                                    model.Dui = Convert.ToInt32(txtDui.Text);
                                    model.CitizenName = txtName.Text;
                                    model.Address = txtAddress.Text;
                                    model.Birthdate = dtpBirthdate.Value;
                                    model.Email = txtEmail.Text;
                                    model.Phone = Convert.ToInt32(txtPhone.Text);
                                    model.IdInstitution = Convert.ToInt32(lblId.Text);                                    
                                    addAppointmentMonitoring.Enqueue(model);
                                    clearFields();
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
                /*catch (Exception)
                {
                    MessageBox.Show("Algo salió mal. Por favor ingrese solamente valores válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/
            }
            else
                MessageBox.Show("Debe aceptar que desea recibir la dosis de vacuna.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu(addAppointmentMonitoring, IdManager);
            frm.Show();
            this.Hide();
        }

        private void frmPreCheck_Load(object sender, EventArgs e)
        {
            validateDate();
            showWaitingList();
            label10.Text = "" + IdManager.IdManager;
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

        // Función para validar las fechas a ingresar al sistema, que la edad mínima sea menor a 18 años y menor o igual a 100 año
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
            cbxAccept.Checked = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            clearFields();
            var db = new ProyectoContext();
            institutions = db.Institutions.ToList();
            List<Citizen> citizens = db.Citizens.ToList();
            List<Appointment> appointments = db.Appointments.ToList();
            List<Diseasexcitizen> diseasexcitizens = db.Diseasexcitizens.ToList();

            // Obtenemos el valor ingresado por el gestor y lo utilizamos para buscar al ciudadano por medio del DUI
            try
            {
                int dui = Convert.ToInt32(txtSearch.Text);
                List<Citizen> result = citizens.Where(c => c.Dui == dui).ToList();
                List<Appointment> appointmentDate = appointments
                    .Where(a => a.AppointmentDate == DateTime.Today && a.IdCitizen == dui && a.IdDose == 1 || a.AppointmentDate == DateTime.Today && a.IdDose == 3 )
                    .OrderBy(a => a.AppointmentDate).ToList();
                if (result.Count() > 0 && appointmentDate.Count() > 0)
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
                        List<Institution> selectedInstituion = institutions
                            .Where(i => i.IdInstitution == r.IdInstitution).ToList();
                        selectedInstituion.ForEach(s =>
                        {
                            lblId.Text = s.IdInstitution.ToString();
                            lblInstitution.Text = s.InstitutionName;
                        });
                        // Realizamos la consulta para mostrar chequeadas las enfermedades crónicas que el ciudadano padece
                        List<Diseasexcitizen> diabetes = diseasexcitizens
                            .Where(dxc => dxc.IdDisease == 1 && dxc.IdCitizen == dui).ToList();
                        diabetes.ForEach(d =>
                        {
                            cbxDiabetes.Checked = true;
                        });
                        List<Diseasexcitizen> cardio = diseasexcitizens
                            .Where(dxc => dxc.IdDisease == 2 && dxc.IdCitizen == dui).ToList();
                        cardio.ForEach(d =>
                        {
                            cbxCardio.Checked = true;
                        });
                        List<Diseasexcitizen> pulmonar = diseasexcitizens
                            .Where(dxc => dxc.IdDisease == 3 && dxc.IdCitizen == dui).ToList();
                        pulmonar.ForEach(d =>
                        {
                            cbxPulmonar.Checked = true;
                        });
                        List<Diseasexcitizen> renal = diseasexcitizens
                            .Where(dxc => dxc.IdDisease == 4 && dxc.IdCitizen == dui).ToList();
                        renal.ForEach(d =>
                        {
                            cbxRenal.Checked = true;
                        });
                        List<Diseasexcitizen> cancer = diseasexcitizens
                            .Where(dxc => dxc.IdDisease == 5 && dxc.IdCitizen == dui).ToList();
                        cancer.ForEach(d =>
                        {
                            cbxCancer.Checked = true;
                        });
                        List<Diseasexcitizen> organos = diseasexcitizens
                            .Where(dxc => dxc.IdDisease == 6 && dxc.IdCitizen == dui).ToList();
                        organos.ForEach(d =>
                        {
                            cbxOrganReceptor.Checked = true;
                        });
                        List<Diseasexcitizen> seropositivas = diseasexcitizens
                            .Where(dxc => dxc.IdDisease == 7 && dxc.IdCitizen == dui).ToList();
                        seropositivas.ForEach(d =>
                        {
                            cbxSeropositivas.Checked = true;
                        });
                        List<Diseasexcitizen> tratamiento = diseasexcitizens
                            .Where(dxc => dxc.IdDisease == 8 && dxc.IdCitizen == dui).ToList();
                        tratamiento.ForEach(d =>
                        {
                            cbxInmunosupresor.Checked = true;
                        });
                    });
                    MessageBox.Show("Ciudadano encontrado.", "Operación éxitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result.Count() > 0 && appointmentDate.Count() == 0)
                    MessageBox.Show("El/la ciudadano/a no posee registro de cita para el día de hoy. Por favor vuelva el día que indicó realizar su vacunación.", "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("El/la ciudadano/a no posee registro de cita. Proceda a registrarlo en el módulo de 'Registro'.", "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
