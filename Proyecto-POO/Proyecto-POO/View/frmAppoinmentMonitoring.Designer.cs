
namespace Proyecto_POO
{
    partial class frmAppoinmentMonitoring
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAppoinmentMonitoring));
            this.dgvMonitoring = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonitoring)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMonitoring
            // 
            this.dgvMonitoring.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonitoring.Location = new System.Drawing.Point(56, 176);
            this.dgvMonitoring.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvMonitoring.Name = "dgvMonitoring";
            this.dgvMonitoring.ReadOnly = true;
            this.dgvMonitoring.Size = new System.Drawing.Size(705, 137);
            this.dgvMonitoring.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 118);
            this.panel1.TabIndex = 51;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_POO.Properties.Resources.vaccination;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(130, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(237, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "MONITOREO DE CITAS";
            // 
            // btnAddToList
            // 
            this.btnAddToList.BackColor = System.Drawing.Color.LightBlue;
            this.btnAddToList.Location = new System.Drawing.Point(320, 338);
            this.btnAddToList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(195, 41);
            this.btnAddToList.TabIndex = 52;
            this.btnAddToList.Text = "AGREGAR A LISTA";
            this.btnAddToList.UseVisualStyleBackColor = false;
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightBlue;
            this.btnBack.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(10, 395);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 34);
            this.btnBack.TabIndex = 53;
            this.btnBack.Text = "VOLVER";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 54;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(500, 17);
            this.label3.TabIndex = 55;
            this.label3.Text = "Seleccione al/la ciudadano/a dando click en la celda con la flecha.";
            // 
            // frmAppoinmentMonitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 452);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddToList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvMonitoring);
            this.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "frmAppoinmentMonitoring";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAppoinmentMonitoring";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAppoinmentMonitoring_FormClosing);
            this.Load += new System.EventHandler(this.frmAppoinmentMonitoring_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonitoring)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvMonitoring;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddToList;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}