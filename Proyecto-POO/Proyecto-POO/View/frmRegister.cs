using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Proyecto_POO.MySQLContext;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.EntityFrameworkCore;
using Proyecto_POO.ViewModels;

namespace Proyecto_POO
{
    public partial class frmRegister : Form
    {
        Queue<CitizenVm> menu;
        private Manager IdManager { get; set; }
        public frmRegister(Queue<CitizenVm> model, Manager? manager)
        {
            InitializeComponent();
            this.IdManager = manager;
            menu = model;
        }

        private void frmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                bool verifyincoherence = txtIdentifier.Text.Length > 0 && cmbInstitution.SelectedIndex >= 0;
                bool allowemptyness = txtIdentifier.Text.Length == 0 && cmbInstitution.SelectedIndex == -1;
                bool test = verifyincoherence || allowemptyness;

                bool verify = (textBox1.Text.Length == 9 && txtPhoneNumber.Text.Length == 8 && test);
                if (verify)
                {
                    bool a = cbxDiabetes.Checked;
                    bool b = checkBox1.Checked;
                    bool c = cbxPulmonary.Checked;
                    bool d = checkBox3.Checked;
                    bool f = cbxCancer.Checked;
                    bool g = cbxOrganReceiever.Checked;
                    bool h = cbxSeropositivas.Checked;
                    bool i = cbxInmunosupresor.Checked;

                    bool[] arrayresult = new bool[8] { a, b, c, d, f, g, h, i };

                    int count = 0;

                    for (int l = 0; l < 8; l++)
                    {
                        if (arrayresult[l] == true)
                        {
                            count++;
                        }
                    }

                    int[] arrayid = new int[count];
                    int cont = 0;

                    for (int m = 0; m < 8; m++)
                    {
                        if (arrayresult[m] == true)
                        {
                            arrayid[cont] = m + 1;
                            cont++;
                        }
                    }

                    //Permitir dejar en blanco la dirección
                    string citizenemail;
                    if (txtAddress.Text != "")
                    {
                        citizenemail = txtEmail.Text;
                    }
                    else
                    {
                        citizenemail = null;
                    }


                    int place = placevacunation(textBox1.Text);

                    Institution iref = (Institution)cmbInstitution.SelectedItem;

                    var AppointmentDate = DateTime.Now.ToString("yyyy-mm-dd");
                    var AppointmentHour = DateTime.Now.ToString("HH:mm:ss");

                    using (var db = new ProyectoContext())
                    {

                        var NewAppointment = new List<Appointment>
                        {
                            new Appointment ()
                            {

                                AppointmentDate = DateTime.Now,
                                AppointmentHour = TimeSpan.Parse(AppointmentHour),
                                IdDose = 1,
                                IdPlatform = 1,
                                IdPlace = place,
                                IdManager = this.IdManager.IdManager
                            }
                        };
                        NewAppointment.ForEach(a => db.Add(a));
                        db.SaveChanges();

                        var SavedAppointments = db.Appointments
                            .OrderBy(a => a.IdAppointment)
                            .ToList();

                        int size = SavedAppointments.Count() - 1;
                        int appointmentid = SavedAppointments[size].IdAppointment;


                        if (cmbInstitution.SelectedIndex == -1)
                        {
                            var NewPacient = new List<Citizen>()
                            {
                                new Citizen()
                                {
                                    Dui = Convert.ToInt32(textBox1.Text),
                                    CitizenName = txtName.Text,
                                    Address = txtAddress.Text,
                                    Email = citizenemail,
                                    Phone = Convert.ToInt32(txtPhoneNumber.Text),
                                    Birthdate = dtpBirthdate.Value,
                                    IdAppointment = appointmentid
                                }
                            };
                            NewPacient.ForEach(c => db.Add(c));
                            db.SaveChanges();
                        }
                        else
                        {
                            Institution ibdd = db.Set<Institution>().SingleOrDefault(i => i.IdInstitution == iref.IdInstitution);
                            var NewPacient = new List<Citizen>()
                            {
                                new Citizen()
                                {
                                    Dui = Convert.ToInt32(textBox1.Text),
                                    CitizenName = txtName.Text,
                                    Address = txtAddress.Text,
                                    Email = citizenemail,
                                    Phone = Convert.ToInt32(txtPhoneNumber.Text),
                                    Birthdate = dtpBirthdate.Value,
                                    IdentifierNumber = Convert.ToInt32(txtIdentifier.Text),
                                    IdInstitution = ibdd.IdInstitution,
                                    IdAppointment = appointmentid
                                }
                            };
                            NewPacient.ForEach(c => db.Add(c));
                            db.SaveChanges();
                        }

                        var savedCitizens = db.Citizens
                             .OrderBy(c => c.Dui)
                             .ToList();

                        if (arrayid.Length != null)
                        {
                            int cnt = 0;

                            List<Diseasexcitizen> Diseases = new List<Diseasexcitizen>();

                            for (int p = 0; p < arrayid.Length; p++)
                            {
                                Diseasexcitizen disease = new Diseasexcitizen()
                                {
                                    IdDisease = arrayid[cnt],
                                    IdCitizen = Convert.ToInt32(textBox1.Text)
                                };
                                cnt++;
                                Diseases.Add(disease);
                            }
                            Diseases.ForEach(dxc => db.Add(dxc));
                            db.SaveChanges();
                            var savedDiseases = db.Diseasexcitizens
                            .OrderBy(dxc => dxc.IdCitizen)
                            .ToList();
                        }

                    }

                    MessageBox.Show("Ciudadano registrado con éxito, ahora debe continuar al módulo Prechequeo.", "Operación éxitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Asegúrese de haber ingresado la información correctamente", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    var db = new ProyectoContext();
                    var institution = db.Institutions
                        .ToList();
                    cmbInstitution.DataSource = institution;
                    cmbInstitution.ValueMember = "IdInstitution";
                    cmbInstitution.DisplayMember = "InstitutionName";
                    cmbInstitution.SelectedIndex = -1;
                    cmbInstitution.SelectedText = "Escoja la institución";
                }

            }

            catch (Exception)
            {
                MessageBox.Show("Datos no válidos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                var db = new ProyectoContext();
                var institution = db.Institutions
                    .ToList();
                cmbInstitution.DataSource = institution;
                cmbInstitution.ValueMember = "IdInstitution";
                cmbInstitution.DisplayMember = "InstitutionName";
                cmbInstitution.SelectedIndex = -1;
                cmbInstitution.SelectedText = "Escoja la institución";

            }

        }

        private int placevacunation(string text)
        {
            int d = Convert.ToInt32(text);
            if (d % 2 != 0)
            {
                int p = 1;
                return p;
            }
            else
            {
                int p = 2;
                return p;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu(menu, IdManager);
            frm.Show();
            this.Hide();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            var db = new ProyectoContext();
            var institution = db.Institutions
                .ToList();
            cmbInstitution.DataSource = institution;
            cmbInstitution.ValueMember = "IdInstitution";
            cmbInstitution.DisplayMember = "InstitutionName";
            cmbInstitution.SelectedIndex = -1;
            cmbInstitution.SelectedText = "Escoja la institución";

            dtpBirthdate.MaxDate = DateTime.Today;

        }
        // Este es el boton de generar pdf
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var bd = new ProyectoContext();
                var placeslist = bd.VaccinationPlaces
                    .OrderBy(v => v.IdPlace)
                    .ToList();

                var filter = placeslist
                    .Where(v => v.IdPlace.Equals(placevacunation(textBox1.Text)))
                    .ToList();
                List<VaccinationPlace> vaccplace = new List<VaccinationPlace>();
                foreach (VaccinationPlace vacc in filter)
                {
                    vaccplace.Add(vacc);
                }

                var SavedAppointments = bd.Appointments
                            .OrderBy(a => a.IdAppointment)
                            .ToList();

                int size = SavedAppointments.Count() - 1;
                int appointmentid = SavedAppointments[size].IdAppointment;
                string appointmentdate = SavedAppointments[size].AppointmentDate.ToString();
                string appointmenthour = SavedAppointments[size].AppointmentHour.ToString();


                using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        FileStream file = new FileStream(saveFileDialog.FileName, FileMode.Create);
                        Document document = new Document(PageSize.A4);
                        PdfWriter pdf = PdfWriter.GetInstance(document, file);
                        document.Open();
                        document.Add(new Paragraph("Detalles de cita"));
                        document.Add(Chunk.NEWLINE);
                        document.Add(new Paragraph("ID: " + textBox1.Text));
                        document.Add(new Paragraph("Nombre: " + txtName.Text));
                        document.Add(new Paragraph("Fecha: " + appointmentdate));
                        document.Add(new Paragraph("Hora: " + appointmenthour));
                        document.Add(new Paragraph("Lugar de vacunación: " + vaccplace[0].PlaceName));
                        document.Close();
                        pdf.Close();
                    }
                }

            }

            catch (Exception)
            {
                MessageBox.Show("Asegúrese de haber registrado al usuario", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

        }
    }
}
