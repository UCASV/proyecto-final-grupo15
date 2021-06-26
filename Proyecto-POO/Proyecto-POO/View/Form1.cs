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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var db = new ProyectoContext();
            string user = txtUser.Text;
            string password = txtPassword.Text;

            List<Manager> managers = db.Managers
                .ToList();

            List<Manager> result = managers
                .Where(u => u.Username == user && u.ManagerPassword == password)
                .ToList();

            if (result.Count() > 0)
            {
                MessageBox.Show("Bienvenido!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                var M = db.Managers.ToList();
                var B = db.Booths.ToList();

                var innerjoin =
                    from booths in B
                    join managersJ in M on booths.IdManager equals managersJ.IdManager
                    select new { IdB = booths.IdBooth };

                var hourNow = DateTime.Now.ToString("HH:mm:ss");
                var dateNow = DateTime.Now.ToString("yyyy-MM-dd");
               
                Record r = new();
                r.IdBooth = innerjoin.FirstOrDefault().IdB;
                r.IdManager = result[0].IdManager;
                r.RecordDate = DateTime.Parse(dateNow);
                r.RecordHour = TimeSpan.Parse(hourNow);
                db.Add(r);
                db.SaveChanges();
                frmMenu frm = new frmMenu(result[0]);
                frm.Show();
                this.Hide();
            }
            else
                MessageBox.Show("ERROR!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void lblForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
