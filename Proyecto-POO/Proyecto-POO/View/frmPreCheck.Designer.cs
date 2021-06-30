
namespace Proyecto_POO
{
    partial class frmPreCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPreCheck));
            this.btnContinue = new System.Windows.Forms.Button();
            this.cbxAccept = new System.Windows.Forms.CheckBox();
            this.txtIdentifierNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxInmunosupresor = new System.Windows.Forms.CheckBox();
            this.cbxSeropositivas = new System.Windows.Forms.CheckBox();
            this.cbxOrganReceptor = new System.Windows.Forms.CheckBox();
            this.cbxCancer = new System.Windows.Forms.CheckBox();
            this.cbxRenal = new System.Windows.Forms.CheckBox();
            this.cbxPulmonar = new System.Windows.Forms.CheckBox();
            this.cbxCardio = new System.Windows.Forms.CheckBox();
            this.cbxDiabetes = new System.Windows.Forms.CheckBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDui = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.lblInstitution = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbInstitution = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnContinue
            // 
            this.btnContinue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnContinue.BackColor = System.Drawing.Color.LightBlue;
            this.btnContinue.Location = new System.Drawing.Point(236, 604);
            this.btnContinue.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(190, 50);
            this.btnContinue.TabIndex = 49;
            this.btnContinue.Text = "CONTINUAR";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbxAccept
            // 
            this.cbxAccept.AutoSize = true;
            this.cbxAccept.Location = new System.Drawing.Point(153, 577);
            this.cbxAccept.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxAccept.Name = "cbxAccept";
            this.cbxAccept.Size = new System.Drawing.Size(358, 21);
            this.cbxAccept.TabIndex = 48;
            this.cbxAccept.Text = "¿ACEPTA RECIBIR LA DOSIS DE LA VACUNA?";
            this.cbxAccept.UseVisualStyleBackColor = true;
            // 
            // txtIdentifierNumber
            // 
            this.txtIdentifierNumber.Location = new System.Drawing.Point(274, 370);
            this.txtIdentifierNumber.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtIdentifierNumber.MaxLength = 20;
            this.txtIdentifierNumber.Name = "txtIdentifierNumber";
            this.txtIdentifierNumber.Size = new System.Drawing.Size(364, 25);
            this.txtIdentifierNumber.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(28, 373);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 17);
            this.label7.TabIndex = 46;
            this.label7.Text = "NÚMERO DE IDENTIFICADOR";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxInmunosupresor);
            this.groupBox1.Controls.Add(this.cbxSeropositivas);
            this.groupBox1.Controls.Add(this.cbxOrganReceptor);
            this.groupBox1.Controls.Add(this.cbxCancer);
            this.groupBox1.Controls.Add(this.cbxRenal);
            this.groupBox1.Controls.Add(this.cbxPulmonar);
            this.groupBox1.Controls.Add(this.cbxCardio);
            this.groupBox1.Controls.Add(this.cbxDiabetes);
            this.groupBox1.Location = new System.Drawing.Point(28, 441);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(610, 130);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ENFERMEDADES QUE PADECE";
            // 
            // cbxInmunosupresor
            // 
            this.cbxInmunosupresor.AutoSize = true;
            this.cbxInmunosupresor.Location = new System.Drawing.Point(351, 105);
            this.cbxInmunosupresor.Name = "cbxInmunosupresor";
            this.cbxInmunosupresor.Size = new System.Drawing.Size(15, 14);
            this.cbxInmunosupresor.TabIndex = 7;
            this.cbxInmunosupresor.UseVisualStyleBackColor = true;
            // 
            // cbxSeropositivas
            // 
            this.cbxSeropositivas.AutoSize = true;
            this.cbxSeropositivas.Location = new System.Drawing.Point(351, 78);
            this.cbxSeropositivas.Name = "cbxSeropositivas";
            this.cbxSeropositivas.Size = new System.Drawing.Size(15, 14);
            this.cbxSeropositivas.TabIndex = 6;
            this.cbxSeropositivas.UseVisualStyleBackColor = true;
            // 
            // cbxOrganReceptor
            // 
            this.cbxOrganReceptor.AutoSize = true;
            this.cbxOrganReceptor.Location = new System.Drawing.Point(351, 51);
            this.cbxOrganReceptor.Name = "cbxOrganReceptor";
            this.cbxOrganReceptor.Size = new System.Drawing.Size(15, 14);
            this.cbxOrganReceptor.TabIndex = 5;
            this.cbxOrganReceptor.UseVisualStyleBackColor = true;
            this.cbxOrganReceptor.CheckedChanged += new System.EventHandler(this.cbxOrganReceptor_CheckedChanged);
            // 
            // cbxCancer
            // 
            this.cbxCancer.AutoSize = true;
            this.cbxCancer.Location = new System.Drawing.Point(351, 21);
            this.cbxCancer.Name = "cbxCancer";
            this.cbxCancer.Size = new System.Drawing.Size(15, 14);
            this.cbxCancer.TabIndex = 4;
            this.cbxCancer.UseVisualStyleBackColor = true;
            // 
            // cbxRenal
            // 
            this.cbxRenal.AutoSize = true;
            this.cbxRenal.Enabled = false;
            this.cbxRenal.Location = new System.Drawing.Point(7, 105);
            this.cbxRenal.Name = "cbxRenal";
            this.cbxRenal.Size = new System.Drawing.Size(15, 14);
            this.cbxRenal.TabIndex = 3;
            this.cbxRenal.UseVisualStyleBackColor = true;
            // 
            // cbxPulmonar
            // 
            this.cbxPulmonar.AutoSize = true;
            this.cbxPulmonar.Enabled = false;
            this.cbxPulmonar.Location = new System.Drawing.Point(7, 78);
            this.cbxPulmonar.Name = "cbxPulmonar";
            this.cbxPulmonar.Size = new System.Drawing.Size(15, 14);
            this.cbxPulmonar.TabIndex = 2;
            this.cbxPulmonar.UseVisualStyleBackColor = true;
            // 
            // cbxCardio
            // 
            this.cbxCardio.AutoSize = true;
            this.cbxCardio.Enabled = false;
            this.cbxCardio.Location = new System.Drawing.Point(7, 54);
            this.cbxCardio.Name = "cbxCardio";
            this.cbxCardio.Size = new System.Drawing.Size(15, 14);
            this.cbxCardio.TabIndex = 1;
            this.cbxCardio.UseVisualStyleBackColor = true;
            // 
            // cbxDiabetes
            // 
            this.cbxDiabetes.AutoSize = true;
            this.cbxDiabetes.Enabled = false;
            this.cbxDiabetes.Location = new System.Drawing.Point(7, 24);
            this.cbxDiabetes.Name = "cbxDiabetes";
            this.cbxDiabetes.Size = new System.Drawing.Size(15, 14);
            this.cbxDiabetes.TabIndex = 0;
            this.cbxDiabetes.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(274, 308);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtEmail.MaxLength = 200;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(364, 25);
            this.txtEmail.TabIndex = 43;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(274, 273);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtPhone.MaxLength = 8;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(364, 25);
            this.txtPhone.TabIndex = 42;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(274, 236);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtAddress.MaxLength = 200;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(364, 25);
            this.txtAddress.TabIndex = 41;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(274, 196);
            this.txtName.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(364, 25);
            this.txtName.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(28, 308);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "CORREO ELECTRONICO";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(28, 276);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "TELÉFONO";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(28, 239);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "DIRECCION ACTUAL";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(28, 199);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "NOMBRE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDui
            // 
            this.txtDui.Location = new System.Drawing.Point(274, 163);
            this.txtDui.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtDui.Name = "txtDui";
            this.txtDui.ReadOnly = true;
            this.txtDui.Size = new System.Drawing.Size(364, 25);
            this.txtDui.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 166);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "DUI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(28, 114);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtSearch.MaxLength = 9;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Ingrese el número de DUI del ciudadano";
            this.txtSearch.Size = new System.Drawing.Size(436, 25);
            this.txtSearch.TabIndex = 33;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(514, 102);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(124, 46);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.Text = "BUSCAR";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 88);
            this.panel1.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(220, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(244, 37);
            this.label8.TabIndex = 0;
            this.label8.Text = "PRECHEQUEO";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightBlue;
            this.btnBack.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(12, 644);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 27);
            this.btnBack.TabIndex = 51;
            this.btnBack.Text = "VOLVER";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(28, 404);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 17);
            this.label9.TabIndex = 52;
            this.label9.Text = "INSTITUCIÓN";
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.CalendarFont = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthdate.Location = new System.Drawing.Point(273, 338);
            this.dtpBirthdate.MinDate = new System.DateTime(1921, 1, 1, 0, 0, 0, 0);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(365, 25);
            this.dtpBirthdate.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(28, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 17);
            this.label6.TabIndex = 54;
            this.label6.Text = "FECHA DE NACIMIENTO";
            // 
            // lblInstitution
            // 
            this.lblInstitution.AutoSize = true;
            this.lblInstitution.Location = new System.Drawing.Point(274, 404);
            this.lblInstitution.Name = "lblInstitution";
            this.lblInstitution.Size = new System.Drawing.Size(0, 17);
            this.lblInstitution.TabIndex = 8;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(206, 404);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 17);
            this.lblId.TabIndex = 56;
            this.lblId.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 581);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 17);
            this.label10.TabIndex = 57;
            this.label10.Text = "label10";
            this.label10.Visible = false;
            // 
            // cmbInstitution
            // 
            this.cmbInstitution.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbInstitution.FormattingEnabled = true;
            this.cmbInstitution.Location = new System.Drawing.Point(274, 401);
            this.cmbInstitution.Name = "cmbInstitution";
            this.cmbInstitution.Size = new System.Drawing.Size(364, 25);
            this.cmbInstitution.TabIndex = 53;
            this.cmbInstitution.Visible = false;
            // 
            // frmPreCheck
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(668, 686);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblInstitution);
            this.Controls.Add(this.dtpBirthdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbInstitution);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.cbxAccept);
            this.Controls.Add(this.txtIdentifierNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDui);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "frmPreCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPreCheck";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPreCheck_FormClosing);
            this.Load += new System.EventHandler(this.frmPreCheck_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.CheckBox cbxAccept;
        private System.Windows.Forms.TextBox txtIdentifierNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDui;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.CheckBox cbxRenal;
        private System.Windows.Forms.CheckBox cbxPulmonar;
        private System.Windows.Forms.CheckBox cbxCardio;
        private System.Windows.Forms.CheckBox cbxDiabetes;
        private System.Windows.Forms.CheckBox cbxInmunosupresor;
        private System.Windows.Forms.CheckBox cbxSeropositivas;
        private System.Windows.Forms.CheckBox cbxOrganReceptor;
        private System.Windows.Forms.CheckBox cbxCancer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblInstitution;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbInstitution;
    }
}