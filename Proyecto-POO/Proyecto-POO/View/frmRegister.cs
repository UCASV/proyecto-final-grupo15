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
using Proyecto_POO.MySqlContext;
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
        public string AppointmentDate = DateTime.Now.ToShortDateString();
        public string AppointmentHour = DateTime.Now.ToString("HH:mm:ss");
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
            var dbc = new ProyectoContext();
            List<Appointment> appointments = dbc.Appointments.ToList();

            int dui = Convert.ToInt32(textBox1.Text);
            List<Appointment> reservedAppointment = appointments
                .Where(a => a.IdPlatform == 2 && a.IdCitizen == dui)
                .OrderBy(a => a.IdCitizen).ToList();
            List<Appointment> existingAppointment = appointments
                .Where(ap => ap.IdDose == 1 && ap.IdCitizen == dui || ap.IdDose == 3 && ap.IdCitizen == dui)
                .OrderBy(ap => ap.IdCitizen).ToList();
            if (reservedAppointment.Count() == 0 && existingAppointment.Count() == 0)
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
                            citizenemail = txtEmail.Text;
                        else
                            citizenemail = null;


                        int place = placevacunation(textBox1.Text);

                        Institution iref = (Institution)cmbInstitution.SelectedItem;

                        using (var db = new ProyectoContext())
                        {
                            var SavedAppointments = db.Appointments
                                .OrderBy(a => a.IdAppointment)
                                .ToList();

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
                                    Birthdate = dtpBirthdate.Value
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
                                    //IdAppointment = appointmentid
                                }
                            };
                                NewPacient.ForEach(c => db.Add(c));
                                db.SaveChanges();
                            }

                            var savedCitizens = db.Citizens
                                 .OrderBy(c => c.Dui)
                                 .ToList();

                            var NewAppointment = new List<Appointment>
                        {
                            new Appointment ()
                            {
                                AppointmentDate = DateTime.Now,
                                AppointmentHour = TimeSpan.Parse(AppointmentHour),
                                IdDose = 1,
                                IdPlatform = 1,
                                IdPlace = place,
                                IdManager = this.IdManager.IdManager,
                                IdCitizen = Convert.ToInt32(textBox1.Text)
                            }
                        };
                            NewAppointment.ForEach(a => db.Add(a));
                            db.SaveChanges();


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
            else if (reservedAppointment.Count() > 0)
                MessageBox.Show("No es posible registrar al/la ciudadano/la debido a que ya realizó un registro en el sitio web. Diríjase a prechequeo.", "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (existingAppointment.Count() > 0)
                MessageBox.Show("El/la ciudadano/a ya posee una cita para una dosis de la vacuna. Diríjase a prechequeo.", "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        FileStream file = new FileStream(saveFileDialog.FileName, FileMode.Create);
                        Document document = new Document(PageSize.A4);
                        PdfWriter pdf = PdfWriter.GetInstance(document, file);
                        document.Open();
                        iTextSharp.text.Font font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.COURIER, 20);
                        Paragraph info = new Paragraph("INFORMACIÓN DEL USUARIO");
                        info.Alignment = 1;
                        Paragraph lineSeparator = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, 1, 5)));
                        document.Add(info);
                        document.Add(lineSeparator);
                        document.Add(Chunk.NEWLINE);
                        iTextSharp.text.Font font1 = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 15);
                        Paragraph idpar = new Paragraph("ID: " + textBox1.Text);
                        idpar.Alignment = 1;
                        Paragraph namepar = new Paragraph("Nombre: " + txtName.Text);
                        namepar.Alignment = 1;
                        document.Add(idpar);
                        document.Add(namepar);
                        document.Add(Chunk.NEWLINE);
                        PdfPTable table = new PdfPTable(3);
                        PdfPCell header = new PdfPCell(new Phrase("Detalles de cita"));
                        header.Colspan = 3;
                        header.HorizontalAlignment = 1;
                        PdfPCell camp1 = new PdfPCell(new Phrase("Fecha"));
                        camp1.VerticalAlignment = 1;
                        camp1.HorizontalAlignment = 1;
                        camp1.BackgroundColor = new iTextSharp.text.BaseColor(176, 196, 222);
                        PdfPCell info1 = new PdfPCell(new Phrase(AppointmentDate));
                        info1.VerticalAlignment = 1;
                        info1.HorizontalAlignment = 1;
                        info1.Colspan = 2;
                        PdfPCell camp2 = new PdfPCell(new Phrase("Hora"));
                        camp2.VerticalAlignment = 1;
                        camp2.HorizontalAlignment = 1;
                        camp2.BackgroundColor = new iTextSharp.text.BaseColor(176, 196, 222);
                        PdfPCell info2 = new PdfPCell(new Phrase(AppointmentHour));
                        info2.VerticalAlignment = 1;
                        info2.HorizontalAlignment = 1;
                        info2.Colspan = 2;
                        PdfPCell camp3 = new PdfPCell(new Phrase("Lugar de vacunación"));
                        camp3.VerticalAlignment = 1;
                        camp3.HorizontalAlignment = 1;
                        camp3.BackgroundColor = new iTextSharp.text.BaseColor(176, 196, 222);
                        camp3.Colspan = 3;
                        PdfPCell info3 = new PdfPCell(new Phrase(vaccplace[0].PlaceName));
                        info3.VerticalAlignment = 0;
                        info3.HorizontalAlignment = 1;
                        info3.Colspan = 3;
                        table.AddCell(header);
                        table.AddCell(camp1);
                        table.AddCell(info1);
                        table.AddCell(camp2);
                        table.AddCell(info2);
                        table.AddCell(camp3);
                        table.AddCell(info3);
                        document.Add(table);

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
