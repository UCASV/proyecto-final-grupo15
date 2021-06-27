using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.EntityFrameworkCore;
using Proyecto_POO.MySQLContext;
using Proyecto_POO.ViewModels;

namespace Proyecto_POO
{
    public partial class frmSideEffects : Form
    {
        int Horario;
        int hora13;
        int hora14;
        string Horariofinal;
        private Manager IdManager { get; set; }
        public frmSideEffects(Queue<CitizenVm1> models, Manager IdManager)
        {
            InitializeComponent();
            this.IdManager = IdManager;
            dgvObservation.DataSource = models.ToList();
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

        private void btnAddEffects_Click(object sender, EventArgs e)
        {
            /*var db = new ProyectoContext();
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
            }*/

            var db = new ProyectoContext();
            // Agregando segunda cita :)
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
            {
                Horariofinal = Horario + ":" + hora13;
            }

            if (Horario == 14)
            {
                Horariofinal = Horario + ":" + hora14;
            }
            MessageBox.Show("La fecha de su nueva cita es: " + 
                resultado + ", en el lugar: " + place + " en la hora: " + Horariofinal);

            label4.Text = "" + IdManager.IdManager;
            int manager = Convert.ToInt32(label4.Text);
            label3.Text = "" + Horariofinal;
            string hour = label3.Text;               
            Appointment a = new();
            a.AppointmentDate = fecha;
            a.AppointmentHour = TimeSpan.Parse(hour);
            a.IdDose = 2;
            a.IdPlatform = 1;
            a.IdPlace = idPlace;
            a.IdManager = manager;
            db.Add(a);
            db.SaveChanges();
            frmMenu frm = new frmMenu(null, IdManager);
            frm.Show();
            this.Hide();
        }

        private void frmSideEffects_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
