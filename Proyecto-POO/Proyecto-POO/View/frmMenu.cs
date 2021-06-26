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

namespace Proyecto_POO
{
    public partial class frmMenu : Form
    {
        
        private Manager IdManager { get; set; }
        private Booth IdBooth { get; set; }

        public frmMenu(Manager? IdManager)
        {
            InitializeComponent();
            this.IdManager = IdManager;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmRegister frm = new frmRegister(IdManager);
            frm.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmPreCheck frm = new frmPreCheck(IdManager);
            frm.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            frmVaccination frm = new frmVaccination(null, IdManager);
            frm.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            var db = new ProyectoContext();
            var M = db.Managers.ToList();
            var B = db.Booths.ToList();

            var innerjoin =
                from booths in B 
                join managers in M on booths.IdManager equals managers.IdManager
                select new { IdB = booths.IdBooth};

            var hourNow = DateTime.Now.ToString("HH:mm:ss");
            var dateNow = DateTime.Now.ToString("yyyy-MM-dd");
            label_id.Text = "" + IdManager.IdManager;
            lblFecha.Text = "" + dateNow;
            lblHora.Text = "" + hourNow;
            labelCabina.Text = "" + innerjoin.FirstOrDefault().IdB;

            string RecordDate = lblFecha.Text;
            string RecordHour = lblHora.Text;
            int IdBooth =  Convert.ToInt32(labelCabina.Text);

            Record r = new();
            r.IdBooth = IdBooth;
            r.IdManager = this.IdManager.IdManager;
            r.RecordDate = DateTime.Parse(RecordDate);
            r.RecordHour = TimeSpan.Parse(RecordHour);
            db.Add(r);
            db.SaveChanges();
            MessageBox.Show("insertado!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
