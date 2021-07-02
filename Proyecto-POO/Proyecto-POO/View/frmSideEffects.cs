using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Colors;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using MySql.EntityFrameworkCore;
using Proyecto_POO.MySqlContext;
using Proyecto_POO.ViewModels;

namespace Proyecto_POO
{
    public partial class frmSideEffects : Form
    {
        Queue<CitizenVm> addWaiting;
        int Horario;
        int hora13;
        int hora14;
        string Horariofinal;
        private Manager IdManager { get; set; }
        public frmSideEffects(Queue<CitizenVm> models, Queue<CitizenVm1> vacqueue, Manager IdManager)
        {
            InitializeComponent();
            this.IdManager = IdManager;
            addWaiting = models;
            dgvObservation.DataSource = vacqueue.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void frmSideEffects_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private int verifyAppointment()
        {
            var db = new ProyectoContext();
            List<Appointment> appointments = db.Appointments.ToList();
            List<Citizen> citizens = db.Citizens.ToList();
            List<Appointment> idDose = appointments
                .Where(a => a.IdDose == 2 && a.IdCitizen == Convert.ToInt32(lblCitizen.Text)).ToList();
            var result = idDose.Count();
            return result;
        }

        private void btnAddEffects_Click(object sender, EventArgs e)
        {
            lblCitizen.Text = dgvObservation.CurrentRow.Cells[0].Value.ToString();
            var db = new ProyectoContext();
            List<Effectsxcitizen> effectsxcitizens = db.Effectsxcitizens.ToList();
            bool cbx1 = cbxSensibility.Checked;
            bool cbx2 = cbxReddering.Checked;
            bool cbx3 = cbxFatigue.Checked;
            bool cbx4 = cbxHeadache.Checked;
            bool cbx5 = cbxFever.Checked;
            bool cbx6 = cbxMyalgia.Checked;
            bool cbx7 = cbxArthrargia.Checked;
            bool cbx8 = cbxAnaphylaxis.Checked;
            bool cbx9 = cbxOthers.Checked;

            bool[] array = new bool[9] { cbx1, cbx2, cbx3, cbx4, cbx5, cbx6, cbx7, cbx8, cbx9 };

            int count = 0;
            for (int i = 0; i < 9; i++)
            {
                if (array[i] == true)
                    count++;
            }

            int[] idsArray = new int[count];
            int position = 0;
            for (int j = 0; j < 9; j++)
            {
                if (array[j] == true)
                {
                    idsArray[position] = j + 1;
                    position++;
                }
            }

            if (idsArray.Length > 0)
            {
                int result = 0;
                List<Effectsxcitizen> Effects = new List<Effectsxcitizen>();
                for (int k = 0; k < idsArray.Length; k++)
                {
                    Effectsxcitizen effectsxcitizen = new Effectsxcitizen()
                    {
                        IdEffect = idsArray[result],
                        IdCitizen = Convert.ToInt32(lblCitizen.Text)
                    };
                    result++;
                    Effects.Add(effectsxcitizen);
                }
                Effects.ForEach(exc => db.Add(exc));
                db.SaveChanges();
                var savedEffects = db.Effectsxcitizens.OrderBy(dxc => dxc.IdCitizen).ToList();
            }

            // Agregando segunda cita :)

            List<Appointment> appointments = db.Appointments.ToList();
            /*List<Appointment> appointmentsDose = appointments
                .Where(a => a.IdCitizen == Convert.ToInt32(dgvObservation.CurrentRow.Cells[0].Value))
                .ToList();*/
            List<Appointment> firstDose = appointments
                .Where(a1 => a1.IdDose == 1 && a1.IdCitizen == Convert.ToInt32(dgvObservation.CurrentRow.Cells[0].Value))
                .ToList();
            List<Appointment> secondDose = appointments
                .Where(a2 => a2.IdDose == 3 && a2.IdCitizen == Convert.ToInt32(dgvObservation.CurrentRow.Cells[0].Value))
                .ToList();
            // firstDose.FirstOrDefault().IdDose
            if (firstDose.Count() > 0)
            {
                btnPDF.Enabled = true;
                var hourNow = DateTime.Now.ToString("HH:mm:ss");
                Appointment ap = firstDose.FirstOrDefault();
                ap.AppointmentHour = TimeSpan.Parse(hourNow);
                ap.IdDose = 2;
                db.Update(ap);
                db.SaveChanges();
                //Aqui se agrega el registro para la segunda dosis
                Random rnd = new Random();
                int idPlace = rnd.Next(1, 3);
                var dateNow = DateTime.Now.ToString("yyyy-MM-dd");
                label2.Text = " " + dateNow;
                DateTime fecha = Convert.ToDateTime(label2.Text);
                fecha = fecha.AddDays(42);
                string resultado = fecha.ToString("yyyy-MM-dd");
                Random aleatorio = new Random();

                Horario = aleatorio.Next(13, 14);
                hora13 = aleatorio.Next(10, 59);
                hora14 = aleatorio.Next(00, 50);

                var place = db.VaccinationPlaces
                    .ToList()
                    .Find(model => model.IdPlace == idPlace)
                    .PlaceName;

                if (Horario == 13)
                    Horariofinal = Horario + ":" + hora13;

                if (Horario == 14)
                    Horariofinal = Horario + ":" + hora14;

                label4.Text = "" + IdManager.IdManager;
                int manager = Convert.ToInt32(label4.Text);
                label3.Text = "" + Horariofinal;
                string hour = label3.Text;
                Appointment a = new();
                a.AppointmentDate = fecha;
                a.AppointmentHour = TimeSpan.Parse(hour);
                a.IdDose = 3;
                a.IdPlatform = 1;
                a.IdPlace = idPlace;
                a.IdManager = manager;
                a.IdCitizen = Convert.ToInt32(lblCitizen.Text);
                db.Add(a);
                db.SaveChanges();
                CitizenVm models = new();
                models.Dui = Convert.ToInt32(dgvObservation.CurrentRow.Cells[0].Value);
                models.CitizenName = dgvObservation.CurrentRow.Cells[1].Value.ToString();
                models.Address = dgvObservation.CurrentRow.Cells[2].Value.ToString();
                models.Birthdate = Convert.ToDateTime(dgvObservation.CurrentRow.Cells[3].Value);
                models.Email = dgvObservation.CurrentRow.Cells[4].Value.ToString();
                models.Phone = Convert.ToInt32(dgvObservation.CurrentRow.Cells[5].Value);
                models.IdInstitution = Convert.ToInt32(dgvObservation.CurrentRow.Cells[6].Value);
                var posicion = addWaiting.Peek();
                addWaiting.Dequeue();
                MessageBox.Show("La fecha de su nueva cita es: " +
                resultado + ", en el lugar: " + place + " en la hora: " + Horariofinal, "Operación éxitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (secondDose.Count() > 0)
            {
                btnPDF.Enabled = false;
                var hourNow = DateTime.Now.ToString("HH:mm:ss");
                Appointment a = secondDose.FirstOrDefault();
                a.AppointmentHour = TimeSpan.Parse(hourNow);
                a.IdDose = 4;
                db.Update(a);
                db.SaveChanges();

                MessageBox.Show("Ha recibido las dos dosis de la vacuna, finalizando así su proceso de vacunación.", "Proceso finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var posicion = addWaiting.Peek();
                addWaiting.Dequeue();
            }

            var SavedAppointments = db.Appointments
                        .OrderBy(a => a.IdAppointment)
                        .ToList();
            int size = SavedAppointments.Count() - 1;
            int appointmentId = SavedAppointments[size].IdAppointment;
            Random random = new Random();
            Appointmentxemployee axe = new();
            axe.IdAppointment = appointmentId;
            axe.IdEmployee = random.Next(1, 15);
            db.Add(axe);
            db.SaveChanges();
            var savedAxE = db.Appointmentxemployees.OrderBy(axe => axe.IdAppointment).ToList();
        }

        private void frmSideEffects_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            var db = new ProyectoContext();
            var C = db.Citizens.ToList();
            var A = db.Appointments.ToList();
            var VP = db.VaccinationPlaces.ToList();

            var appointment =
                from appointments in A
                join citizensA in C on appointments.IdCitizen equals citizensA.Dui
                where appointments.IdDose == 3
                where citizensA.Dui == Convert.ToInt32(dgvObservation.CurrentRow.Cells[0].Value)
                select new { aDate = appointments.AppointmentDate, aHour = appointments.AppointmentHour };

            var place =
                from vaccinationplaces in VP
                join appointments in A on vaccinationplaces.IdPlace equals appointments.IdPlace
                join citizens in C on appointments.IdCitizen equals citizens.Dui
                where appointments.IdDose == 3
                where citizens.Dui == Convert.ToInt32(dgvObservation.CurrentRow.Cells[0].Value)
                select new { vpName = vaccinationplaces.PlaceName };

            DateTime date = Convert.ToDateTime(appointment.FirstOrDefault().aDate);
            var appointmentDate = date.ToString("dd-MM-yyyy");

            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Must have write permissions to the path folder
                        FileStream file = new FileStream(saveFileDialog.FileName, FileMode.Create);
                        PdfWriter writer = new PdfWriter(file);
                        PdfDocument pdf = new PdfDocument(writer);
                        Document document = new Document(pdf);
                        // Encabezado
                        Paragraph header = new Paragraph("Vacunación COVID-19")
                           .SetTextAlignment(TextAlignment.CENTER)
                           .SetFontSize(20).SetFontColor(WebColors.GetRGBColor("#4D5053"));
                        float[] width = { 50, 50 };
                        document.Add(header);
                        // Línea
                        LineSeparator ls = new LineSeparator(new SolidLine())
                            .SetStrokeColor(WebColors.GetRGBColor("#639ED5"));
                        document.Add(ls);
                        // Salto de línea
                        Paragraph blank = new Paragraph(" ");
                        document.Add(blank);
                        // Texto inicial
                        Paragraph patientName = new Paragraph("Nombre del/la paciente: " + dgvObservation.CurrentRow.Cells[1].Value.ToString());
                        Paragraph patientDUI = new Paragraph("DUI: " + dgvObservation.CurrentRow.Cells[0].Value.ToString());
                        Paragraph patientDate = new Paragraph("Fecha y hora de vacunación: " + dgvObservation.CurrentRow.Cells[7].Value.ToString() + " " + dgvObservation.CurrentRow.Cells[8].Value.ToString());
                        Paragraph titleEffects = new Paragraph("Efectos secundarios presentados: ");
                        // Agregando al pdf
                        document.Add(patientName);
                        document.Add(patientDUI);
                        document.Add(patientDate);
                        document.Add(titleEffects);

                        // Carga de valores de los nombres de los efectos secundarios
                        List<SideEffect> sideEffects = db.SideEffects.ToList();
                        List<Effectsxcitizen> savedSideEffects = db.Effectsxcitizens.Where(exc => exc.IdCitizen == Convert.ToInt32(dgvObservation.CurrentRow.Cells[0].Value.ToString())).ToList();
                        foreach (var Effects in savedSideEffects)
                        {
                            if (savedSideEffects.Count() > 0)
                            {
                                List<SideEffect> showSideEffects = db.SideEffects.Where(sd => sd.IdEffect == Convert.ToInt32(Effects.IdEffect)).ToList();
                                foreach (var EffectName in showSideEffects)
                                {
                                    Paragraph citizenEffects = new Paragraph("- " + EffectName.SideEffect1.ToString());
                                    document.Add(citizenEffects);
                                }
                            }
                            else
                            {
                                Paragraph citizenEffects = new Paragraph("No presentó efectos secundarios.");
                                document.Add(citizenEffects);
                            }
                        }

                        document.Add(blank);
                        float[] ancho = { 3, 2 };
                        // Creación de tabla
                        Table table = new Table(width);
                        table.SetWidth(UnitValue.CreatePercentValue(100));
                        Cell cell11 = new Cell(1, 1)
                            .SetBackgroundColor(WebColors.GetRGBColor("#639ED5"))
                            .SetTextAlignment(TextAlignment.CENTER)
                            .Add(new Paragraph("Fecha de segunda cita"));
                        Cell cell12 = new Cell(1, 2)
                            .SetTextAlignment(TextAlignment.CENTER)
                            .Add(new Paragraph(appointmentDate));
                        Cell cell21 = new Cell(2, 1)
                            .SetBackgroundColor(WebColors.GetRGBColor("#639ED5"))
                            .SetTextAlignment(TextAlignment.CENTER)
                            .Add(new Paragraph("Hora de segunda cita"));
                        Cell cell22 = new Cell(2, 2)
                            .SetTextAlignment(TextAlignment.CENTER)
                            .Add(new Paragraph(appointment.FirstOrDefault().aHour.ToString()));
                        Cell cell31 = new Cell(1, 3)
                            .SetBackgroundColor(WebColors.GetRGBColor("#639ED5"))
                            .SetTextAlignment(TextAlignment.CENTER)
                            .Add(new Paragraph("Lugar de vacunación"));
                        Cell cell32 = new Cell(3, 2)
                            .SetBackgroundColor(ColorConstants.WHITE)
                            .SetTextAlignment(TextAlignment.CENTER)
                            .Add(new Paragraph(place.FirstOrDefault().vpName.ToString()));

                        // Agregando la tabla al pdf
                        table.AddCell(cell11);
                        table.AddCell(cell12);
                        table.AddCell(cell21);
                        table.AddCell(cell22);
                        table.AddCell(cell31);
                        table.AddCell(cell32);
                        document.Add(table);
                        document.Add(blank);
                        document.Add(ls);
                        // Footer
                        Paragraph footer = new Paragraph("Reporte generado el " + DateTime.Now.ToString())
                           .SetTextAlignment(TextAlignment.RIGHT)
                           .SetFontSize(10);
                        document.Add(footer);
                        // Se finaliza la generación del documento
                        document.Close();
                    }
                }
        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu(addWaiting, IdManager);
            frm.Show();
            this.Hide();
        }
    }
}
