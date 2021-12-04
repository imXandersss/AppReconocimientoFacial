
namespace AppReconocimientoFacial
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.txtNota = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CBgenero = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.CBNacionalidad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CBTonoPiel = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkCondicionPiel = new System.Windows.Forms.CheckedListBox();
            this.checkEnfermedades = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CBTipoPiel = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCapturarRostro = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNota.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNota
            // 
            this.txtNota.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtNota.Controls.Add(this.panel3);
            this.txtNota.Controls.Add(this.panel2);
            this.txtNota.Controls.Add(this.panel1);
            this.txtNota.Controls.Add(this.btnCancelar);
            this.txtNota.Controls.Add(this.btnGuardar);
            this.txtNota.Location = new System.Drawing.Point(265, 1);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(540, 595);
            this.txtNota.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtNotas);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Location = new System.Drawing.Point(22, 415);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(499, 125);
            this.panel3.TabIndex = 32;
            // 
            // txtNotas
            // 
            this.txtNotas.Location = new System.Drawing.Point(9, 26);
            this.txtNotas.Multiline = true;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(485, 88);
            this.txtNotas.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 2);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Nota";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.CBgenero);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtTel);
            this.panel2.Controls.Add(this.CBNacionalidad);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtCedula);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtEdad);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Location = new System.Drawing.Point(22, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(499, 190);
            this.panel2.TabIndex = 31;
            // 
            // CBgenero
            // 
            this.CBgenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBgenero.FormattingEnabled = true;
            this.CBgenero.Items.AddRange(new object[] {
            "F",
            "M"});
            this.CBgenero.Location = new System.Drawing.Point(133, 84);
            this.CBgenero.Name = "CBgenero";
            this.CBgenero.Size = new System.Drawing.Size(149, 21);
            this.CBgenero.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(130, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Genero";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 145);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(270, 20);
            this.txtEmail.TabIndex = 19;
            this.txtEmail.Text = "example@mail.com";
            this.txtEmail.Click += new System.EventHandler(this.txtEmail_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(292, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Telefono";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(295, 145);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(173, 20);
            this.txtTel.TabIndex = 17;
            this.txtTel.Text = "Su numero sin guiones";
            this.txtTel.Click += new System.EventHandler(this.txtTel_Click);
            // 
            // CBNacionalidad
            // 
            this.CBNacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBNacionalidad.FormattingEnabled = true;
            this.CBNacionalidad.Items.AddRange(new object[] {
            "Dominicana",
            "Venezolana",
            "Estadounidense",
            "Haitiana",
            "Chilena",
            "Colombiana",
            "Puertoriqueña"});
            this.CBNacionalidad.Location = new System.Drawing.Point(295, 84);
            this.CBNacionalidad.Name = "CBNacionalidad";
            this.CBNacionalidad.Size = new System.Drawing.Size(173, 21);
            this.CBNacionalidad.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cedula";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(295, 21);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(173, 20);
            this.txtCedula.TabIndex = 6;
            this.txtCedula.Text = "numero de identificacion sin guiones";
            this.txtCedula.Click += new System.EventHandler(this.txtCedula_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nacionalidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Edad";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(9, 84);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(97, 20);
            this.txtEdad.TabIndex = 2;
            this.txtEdad.Text = "Su edad";
            this.txtEdad.Click += new System.EventHandler(this.txtEdad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(9, 21);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(273, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Text = "Ingrese el nombre del cliente";
            this.txtNombre.Click += new System.EventHandler(this.txtNombre_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.CBTonoPiel);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.checkCondicionPiel);
            this.panel1.Controls.Add(this.checkEnfermedades);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.CBTipoPiel);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(22, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 175);
            this.panel1.TabIndex = 30;
            // 
            // CBTonoPiel
            // 
            this.CBTonoPiel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBTonoPiel.FormattingEnabled = true;
            this.CBTonoPiel.Items.AddRange(new object[] {
            "0-6",
            "7-13",
            "14-20",
            "21-27",
            "28-34",
            "35-36"});
            this.CBTonoPiel.Location = new System.Drawing.Point(12, 129);
            this.CBTonoPiel.Name = "CBTonoPiel";
            this.CBTonoPiel.Size = new System.Drawing.Size(138, 21);
            this.CBTonoPiel.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tono de piel";
            // 
            // checkCondicionPiel
            // 
            this.checkCondicionPiel.FormattingEnabled = true;
            this.checkCondicionPiel.Items.AddRange(new object[] {
            "Acne",
            "Manchas",
            "Arrugas",
            "Verrugas",
            "Cicatrices",
            "Eliminacion de tatuajes"});
            this.checkCondicionPiel.Location = new System.Drawing.Point(173, 41);
            this.checkCondicionPiel.Name = "checkCondicionPiel";
            this.checkCondicionPiel.Size = new System.Drawing.Size(142, 109);
            this.checkCondicionPiel.TabIndex = 14;
            // 
            // checkEnfermedades
            // 
            this.checkEnfermedades.FormattingEnabled = true;
            this.checkEnfermedades.Items.AddRange(new object[] {
            "Diabetes",
            "Alergias",
            "Embarazo",
            "Hipertension",
            "Cancer",
            "Insuficiencia Cardiaca",
            "Dermatitis"});
            this.checkEnfermedades.Location = new System.Drawing.Point(327, 41);
            this.checkEnfermedades.Name = "checkEnfermedades";
            this.checkEnfermedades.Size = new System.Drawing.Size(141, 109);
            this.checkEnfermedades.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(170, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Condicion de la piel";
            // 
            // CBTipoPiel
            // 
            this.CBTipoPiel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBTipoPiel.FormattingEnabled = true;
            this.CBTipoPiel.Items.AddRange(new object[] {
            "Grasa",
            "Normal",
            "Mixta",
            "Seca"});
            this.CBTipoPiel.Location = new System.Drawing.Point(12, 41);
            this.CBTipoPiel.Name = "CBTipoPiel";
            this.CBTipoPiel.Size = new System.Drawing.Size(138, 21);
            this.CBTipoPiel.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tipo de piel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Enfermedades";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(442, 557);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(79, 31);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(359, 557);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(79, 31);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCapturarRostro
            // 
            this.btnCapturarRostro.Location = new System.Drawing.Point(66, 354);
            this.btnCapturarRostro.Name = "btnCapturarRostro";
            this.btnCapturarRostro.Size = new System.Drawing.Size(112, 42);
            this.btnCapturarRostro.TabIndex = 25;
            this.btnCapturarRostro.Text = "Capturar rostro";
            this.btnCapturarRostro.UseVisualStyleBackColor = true;
            this.btnCapturarRostro.Click += new System.EventHandler(this.btnCapturarRostro_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(76, 240);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Nombre del negocio";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(53, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 113);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 608);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.btnCapturarRostro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro";
            this.Text = "Registro";
            this.txtNota.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel txtNota;
        private System.Windows.Forms.ComboBox CBNacionalidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.ComboBox CBTonoPiel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox checkCondicionPiel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CBTipoPiel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckedListBox checkEnfermedades;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnCapturarRostro;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox CBgenero;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}