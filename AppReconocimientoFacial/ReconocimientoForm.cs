using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Face;
using Emgu.CV.CvEnum;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace AppReconocimientoFacial
{
    public partial class ReconocimientoForm : Form
    {
        
        private Capture videoCaptura = null;
        private Image<Bgr, Byte> frameActual = null;
        Mat frame = new Mat();


        public ReconocimientoForm()
        {
            InitializeComponent();
        }

        private void ReconocimientoForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            videoCaptura = new Capture();
            videoCaptura.ImageGrabbed += ProcessFrame;
            videoCaptura.Start();
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            //Esta parte captura el video
            videoCaptura.Retrieve(frame, 0);
            frameActual = frame.ToImage<Bgr, Byte>().Resize(CamaraBox.Width, CamaraBox.Height, Inter.Cubic);


            //Esta parte renderiza el video 
            CamaraBox.Image = frameActual.Bitmap;

        }
    }
}
