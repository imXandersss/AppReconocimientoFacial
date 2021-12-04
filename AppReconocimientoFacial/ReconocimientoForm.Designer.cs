
namespace AppReconocimientoFacial
{
    partial class ReconocimientoForm
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
            this.CamaraBox = new System.Windows.Forms.PictureBox();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CamaraBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CamaraBox
            // 
            this.CamaraBox.Location = new System.Drawing.Point(261, 12);
            this.CamaraBox.Name = "CamaraBox";
            this.CamaraBox.Size = new System.Drawing.Size(715, 468);
            this.CamaraBox.TabIndex = 0;
            this.CamaraBox.TabStop = false;
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(12, 642);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(163, 50);
            this.btnCapturar.TabIndex = 1;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(250, 642);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(163, 50);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // ReconocimientoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 723);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.CamaraBox);
            this.Name = "ReconocimientoForm";
            this.Text = "ReconocimientoForm";
            this.Load += new System.EventHandler(this.ReconocimientoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CamaraBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox CamaraBox;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Button btnAgregar;
    }
}