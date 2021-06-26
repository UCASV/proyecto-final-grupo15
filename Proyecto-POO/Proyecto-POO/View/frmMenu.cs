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
            label_id.Text = "" + IdManager.IdManager;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
