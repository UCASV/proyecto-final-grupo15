
namespace Proyecto_POO
{
    partial class frmSideEffects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSideEffects));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxOthers = new System.Windows.Forms.CheckBox();
            this.cbxAnaphylaxis = new System.Windows.Forms.CheckBox();
            this.cbxArthrargia = new System.Windows.Forms.CheckBox();
            this.cbxMyalgia = new System.Windows.Forms.CheckBox();
            this.cbxFever = new System.Windows.Forms.CheckBox();
            this.cbxHeadache = new System.Windows.Forms.CheckBox();
            this.cbxFatigue = new System.Windows.Forms.CheckBox();
            this.cbxReddering = new System.Windows.Forms.CheckBox();
            this.cbxSensibility = new System.Windows.Forms.CheckBox();
            this.btnAddEffects = new System.Windows.Forms.Button();
            this.dgvObservation = new System.Windows.Forms.DataGridView();
            this.lblCitizen = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnFinal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObservation)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 134);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_POO.Properties.Resources.sideeffects;
            this.pictureBox1.Location = new System.Drawing.Point(533, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(288, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "OBSERVACIÓN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxOthers);
            this.groupBox1.Controls.Add(this.cbxAnaphylaxis);
            this.groupBox1.Controls.Add(this.cbxArthrargia);
            this.groupBox1.Controls.Add(this.cbxMyalgia);
            this.groupBox1.Controls.Add(this.cbxFever);
            this.groupBox1.Controls.Add(this.cbxHeadache);
            this.groupBox1.Controls.Add(this.cbxFatigue);
            this.groupBox1.Controls.Add(this.cbxReddering);
            this.groupBox1.Controls.Add(this.cbxSensibility);
            this.groupBox1.Location = new System.Drawing.Point(73, 347);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 159);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EFECTOS SECUNDARIOS PRESENTADOS";
            // 
            // cbxOthers
            // 
            this.cbxOthers.AutoSize = true;
            this.cbxOthers.Location = new System.Drawing.Point(319, 107);
            this.cbxOthers.Name = "cbxOthers";
            this.cbxOthers.Size = new System.Drawing.Size(66, 21);
            this.cbxOthers.TabIndex = 8;
            this.cbxOthers.Text = "Otros";
            this.cbxOthers.UseVisualStyleBackColor = true;
            this.cbxOthers.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // cbxAnaphylaxis
            // 
            this.cbxAnaphylaxis.AutoSize = true;
            this.cbxAnaphylaxis.Location = new System.Drawing.Point(319, 79);
            this.cbxAnaphylaxis.Name = "cbxAnaphylaxis";
            this.cbxAnaphylaxis.Size = new System.Drawing.Size(100, 21);
            this.cbxAnaphylaxis.TabIndex = 7;
            this.cbxAnaphylaxis.Text = "Anafilaxia";
            this.cbxAnaphylaxis.UseVisualStyleBackColor = true;
            // 
            // cbxArthrargia
            // 
            this.cbxArthrargia.AutoSize = true;
            this.cbxArthrargia.Location = new System.Drawing.Point(319, 53);
            this.cbxArthrargia.Name = "cbxArthrargia";
            this.cbxArthrargia.Size = new System.Drawing.Size(88, 21);
            this.cbxArthrargia.TabIndex = 6;
            this.cbxArthrargia.Text = "Artrargia";
            this.cbxArthrargia.UseVisualStyleBackColor = true;
            // 
            // cbxMyalgia
            // 
            this.cbxMyalgia.AutoSize = true;
            this.cbxMyalgia.Location = new System.Drawing.Point(319, 25);
            this.cbxMyalgia.Name = "cbxMyalgia";
            this.cbxMyalgia.Size = new System.Drawing.Size(80, 21);
            this.cbxMyalgia.TabIndex = 5;
            this.cbxMyalgia.Text = "Mialgia";
            this.cbxMyalgia.UseVisualStyleBackColor = true;
            // 
            // cbxFever
            // 
            this.cbxFever.AutoSize = true;
            this.cbxFever.Location = new System.Drawing.Point(6, 132);
            this.cbxFever.Name = "cbxFever";
            this.cbxFever.Size = new System.Drawing.Size(73, 21);
            this.cbxFever.TabIndex = 4;
            this.cbxFever.Text = "Fiebre";
            this.cbxFever.UseVisualStyleBackColor = true;
            // 
            // cbxHeadache
            // 
            this.cbxHeadache.AutoSize = true;
            this.cbxHeadache.Location = new System.Drawing.Point(6, 105);
            this.cbxHeadache.Name = "cbxHeadache";
            this.cbxHeadache.Size = new System.Drawing.Size(147, 21);
            this.cbxHeadache.TabIndex = 3;
            this.cbxHeadache.Text = "Dolor de cabeza";
            this.cbxHeadache.UseVisualStyleBackColor = true;
            // 
            // cbxFatigue
            // 
            this.cbxFatigue.AutoSize = true;
            this.cbxFatigue.Location = new System.Drawing.Point(6, 78);
            this.cbxFatigue.Name = "cbxFatigue";
            this.cbxFatigue.Size = new System.Drawing.Size(71, 21);
            this.cbxFatigue.TabIndex = 2;
            this.cbxFatigue.Text = "Fátiga";
            this.cbxFatigue.UseVisualStyleBackColor = true;
            // 
            // cbxReddering
            // 
            this.cbxReddering.AutoSize = true;
            this.cbxReddering.Location = new System.Drawing.Point(6, 51);
            this.cbxReddering.Name = "cbxReddering";
            this.cbxReddering.Size = new System.Drawing.Size(142, 21);
            this.cbxReddering.TabIndex = 1;
            this.cbxReddering.Text = "Enrrojecimiento";
            this.cbxReddering.UseVisualStyleBackColor = true;
            // 
            // cbxSensibility
            // 
            this.cbxSensibility.AutoSize = true;
            this.cbxSensibility.Location = new System.Drawing.Point(6, 24);
            this.cbxSensibility.Name = "cbxSensibility";
            this.cbxSensibility.Size = new System.Drawing.Size(239, 21);
            this.cbxSensibility.TabIndex = 0;
            this.cbxSensibility.Text = "Dolor/sensibilidad en el área";
            this.cbxSensibility.UseVisualStyleBackColor = true;
            // 
            // btnAddEffects
            // 
            this.btnAddEffects.BackColor = System.Drawing.Color.LightBlue;
            this.btnAddEffects.Location = new System.Drawing.Point(316, 541);
            this.btnAddEffects.Name = "btnAddEffects";
            this.btnAddEffects.Size = new System.Drawing.Size(190, 42);
            this.btnAddEffects.TabIndex = 6;
            this.btnAddEffects.Text = "AGREGAR EFECTO/S";
            this.btnAddEffects.UseVisualStyleBackColor = false;
            this.btnAddEffects.Click += new System.EventHandler(this.btnAddEffects_Click);
            // 
            // dgvObservation
            // 
            this.dgvObservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObservation.Location = new System.Drawing.Point(73, 191);
            this.dgvObservation.Name = "dgvObservation";
            this.dgvObservation.ReadOnly = true;
            this.dgvObservation.RowTemplate.Height = 25;
            this.dgvObservation.Size = new System.Drawing.Size(684, 91);
            this.dgvObservation.TabIndex = 5;
            // 
            // lblCitizen
            // 
            this.lblCitizen.AutoSize = true;
            this.lblCitizen.Location = new System.Drawing.Point(2, 147);
            this.lblCitizen.Name = "lblCitizen";
            this.lblCitizen.Size = new System.Drawing.Size(74, 17);
            this.lblCitizen.TabIndex = 55;
            this.lblCitizen.Text = "idCitizen";
            this.lblCitizen.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 516);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 56;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 592);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 57;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 554);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 58;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 554);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 592);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 60;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 592);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 61;
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.Color.LightBlue;
            this.btnPDF.Enabled = false;
            this.btnPDF.Location = new System.Drawing.Point(79, 541);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(188, 42);
            this.btnPDF.TabIndex = 62;
            this.btnPDF.Text = "GENERAR PDF";
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // btnFinal
            // 
            this.btnFinal.BackColor = System.Drawing.Color.LightBlue;
            this.btnFinal.Location = new System.Drawing.Point(554, 541);
            this.btnFinal.Name = "btnFinal";
            this.btnFinal.Size = new System.Drawing.Size(185, 42);
            this.btnFinal.TabIndex = 63;
            this.btnFinal.Text = "FINALIZAR VACUNACIÓN";
            this.btnFinal.UseVisualStyleBackColor = false;
            this.btnFinal.Click += new System.EventHandler(this.btnFinal_Click);
            // 
            // frmSideEffects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 629);
            this.Controls.Add(this.btnFinal);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCitizen);
            this.Controls.Add(this.btnAddEffects);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvObservation);
            this.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "frmSideEffects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Observación";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSideEffects_FormClosing);
            this.Load += new System.EventHandler(this.frmSideEffects_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObservation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddEffects;
        private System.Windows.Forms.DataGridView dgvObservation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbxOthers;
        private System.Windows.Forms.CheckBox cbxAnaphylaxis;
        private System.Windows.Forms.CheckBox cbxArthrargia;
        private System.Windows.Forms.CheckBox cbxMyalgia;
        private System.Windows.Forms.CheckBox cbxFever;
        private System.Windows.Forms.CheckBox cbxHeadache;
        private System.Windows.Forms.CheckBox cbxFatigue;
        private System.Windows.Forms.CheckBox cbxReddering;
        private System.Windows.Forms.CheckBox cbxSensibility;
        private System.Windows.Forms.Label lblCitizen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnFinal;
    }
}