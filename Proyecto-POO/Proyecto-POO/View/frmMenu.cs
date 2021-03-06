using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_POO.ViewModels;
using Proyecto_POO.MySqlContext;

namespace Proyecto_POO
{
    public partial class frmMenu : Form
    {
        
        private Manager IdManager { get; set; }
        Queue<CitizenVm> menu;

        public frmMenu(Queue<CitizenVm>? model, Manager? IdManager)
        {
            InitializeComponent();
            menu = model;
            //model.ToList();
            this.IdManager = IdManager;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmRegister frm = new frmRegister(menu, IdManager);
            frm.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmPreCheck frm = new frmPreCheck(menu,IdManager);
            frm.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

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

        private void label4_Click(object sender, EventArgs e)
        {
            frmAppoinmentMonitoring frm = new frmAppoinmentMonitoring(menu, IdManager);
            frm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            frmAppoinmentMonitoring frm = new frmAppoinmentMonitoring(menu, IdManager);
            frm.Show();
            this.Hide();
        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            frmShowEmployee frm = new frmShowEmployee(menu, IdManager);
            frm.Show();
            this.Hide();
        }
    }
}
