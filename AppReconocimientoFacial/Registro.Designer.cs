
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.CBNacionalidad = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CBNacionalidad);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtCedula);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtEdad);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Location = new System.Drawing.Point(362, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 445);
            this.panel1.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(32, 48);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Edad";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(32, 107);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nacionalidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cedula";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(32, 243);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(100, 20);
            this.txtCedula.TabIndex = 6;
            // 
            // CBNacionalidad
            // 
            this.CBNacionalidad.FormattingEnabled = true;
            this.CBNacionalidad.Location = new System.Drawing.Point(32, 173);
            this.CBNacionalidad.Name = "CBNacionalidad";
            this.CBNacionalidad.Size = new System.Drawing.Size(121, 21);
            this.CBNacionalidad.TabIndex = 8;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Registro";
            this.Text = "Registro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CBNacionalidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
    }
}