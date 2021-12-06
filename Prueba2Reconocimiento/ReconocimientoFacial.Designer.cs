
namespace Prueba2Reconocimiento
{
    partial class ReconocimientoFacial
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReconocimientoFacial));
            this.picCapture = new System.Windows.Forms.PictureBox();
            this.btnCapture = new System.Windows.Forms.Button();
            this.btnDetectedFaces = new System.Windows.Forms.Button();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.picDetected = new System.Windows.Forms.PictureBox();
            this.txtPersonName = new System.Windows.Forms.TextBox();
            this.btnTrain = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDetected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // picCapture
            // 
            this.picCapture.Location = new System.Drawing.Point(-1, 13);
            this.picCapture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picCapture.Name = "picCapture";
            this.picCapture.Size = new System.Drawing.Size(472, 524);
            this.picCapture.TabIndex = 0;
            this.picCapture.TabStop = false;
            // 
            // btnCapture
            // 
            this.btnCapture.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCapture.Location = new System.Drawing.Point(851, 55);
            this.btnCapture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(153, 53);
            this.btnCapture.TabIndex = 1;
            this.btnCapture.Text = "Encender";
            this.btnCapture.UseVisualStyleBackColor = false;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click_1);
            // 
            // btnDetectedFaces
            // 
            this.btnDetectedFaces.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDetectedFaces.Location = new System.Drawing.Point(851, 134);
            this.btnDetectedFaces.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDetectedFaces.Name = "btnDetectedFaces";
            this.btnDetectedFaces.Size = new System.Drawing.Size(153, 48);
            this.btnDetectedFaces.TabIndex = 2;
            this.btnDetectedFaces.Text = "Detectar";
            this.btnDetectedFaces.UseVisualStyleBackColor = false;
            this.btnDetectedFaces.Click += new System.EventHandler(this.btnDetectedFaces_Click_1);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddPerson.Location = new System.Drawing.Point(857, 217);
            this.btnAddPerson.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(145, 54);
            this.btnAddPerson.TabIndex = 3;
            this.btnAddPerson.Text = "Agregar Persona";
            this.btnAddPerson.UseVisualStyleBackColor = false;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click_1);
            // 
            // picDetected
            // 
            this.picDetected.Location = new System.Drawing.Point(857, 311);
            this.picDetected.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picDetected.Name = "picDetected";
            this.picDetected.Size = new System.Drawing.Size(145, 101);
            this.picDetected.TabIndex = 4;
            this.picDetected.TabStop = false;
            // 
            // txtPersonName
            // 
            this.txtPersonName.Location = new System.Drawing.Point(857, 466);
            this.txtPersonName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPersonName.Name = "txtPersonName";
            this.txtPersonName.Size = new System.Drawing.Size(145, 22);
            this.txtPersonName.TabIndex = 5;
            // 
            // btnTrain
            // 
            this.btnTrain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTrain.Location = new System.Drawing.Point(857, 496);
            this.btnTrain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(147, 43);
            this.btnTrain.TabIndex = 6;
            this.btnTrain.Text = "Reconocer";
            this.btnTrain.UseVisualStyleBackColor = false;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(479, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 256);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(479, 283);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(364, 256);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(857, 442);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cedula";
            // 
            // ReconocimientoFacial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.txtPersonName);
            this.Controls.Add(this.picDetected);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.btnDetectedFaces);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.picCapture);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReconocimientoFacial";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDetected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCapture;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.Button btnDetectedFaces;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.PictureBox picDetected;
        private System.Windows.Forms.TextBox txtPersonName;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}

