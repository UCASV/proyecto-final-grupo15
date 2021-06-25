
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBookSecondAppointment = new System.Windows.Forms.Button();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblCitizen = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 96);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(281, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "OBSERVACIÓN";
            // 
            // btnBookSecondAppointment
            // 
            this.btnBookSecondAppointment.BackColor = System.Drawing.Color.LightBlue;
            this.btnBookSecondAppointment.Location = new System.Drawing.Point(452, 540);
            this.btnBookSecondAppointment.Name = "btnBookSecondAppointment";
            this.btnBookSecondAppointment.Size = new System.Drawing.Size(225, 42);
            this.btnBookSecondAppointment.TabIndex = 8;
            this.btnBookSecondAppointment.Text = "AGENDAR SEGUNDA CITA";
            this.btnBookSecondAppointment.UseVisualStyleBackColor = false;
            this.btnBookSecondAppointment.Click += new System.EventHandler(this.button2_Click);
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
            this.btnAddEffects.Location = new System.Drawing.Point(167, 540);
            this.btnAddEffects.Name = "btnAddEffects";
            this.btnAddEffects.Size = new System.Drawing.Size(190, 42);
            this.btnAddEffects.TabIndex = 6;
            this.btnAddEffects.Text = "AGREGAR EFECTO/S";
            this.btnAddEffects.UseVisualStyleBackColor = false;
            this.btnAddEffects.Click += new System.EventHandler(this.btnAddEffects_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(73, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(684, 189);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightBlue;
            this.btnBack.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(12, 612);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 34);
            this.btnBack.TabIndex = 54;
            this.btnBack.Text = "VOLVER";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblCitizen
            // 
            this.lblCitizen.AutoSize = true;
            this.lblCitizen.Location = new System.Drawing.Point(13, 103);
            this.lblCitizen.Name = "lblCitizen";
            this.lblCitizen.Size = new System.Drawing.Size(74, 17);
            this.lblCitizen.TabIndex = 55;
            this.lblCitizen.Text = "idCitizen";
            // 
            // frmSideEffects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 658);
            this.Controls.Add(this.lblCitizen);
            this.Controls.Add(this.btnAddEffects);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBookSecondAppointment);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "frmSideEffects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmObservation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSideEffects_FormClosing);
            this.Load += new System.EventHandler(this.frmSideEffects_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBookSecondAppointment;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddEffects;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
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
    }
}