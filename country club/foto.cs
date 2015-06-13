using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  System.IO; 
using  System.Drawing.Imaging;
using  AForge.Video;
using AForge.Video.DirectShow;


namespace country_club
{
    public partial class foto : Form
    {
        public foto()
        {
            InitializeComponent();
            BuscarDispositivos();
        }
        private bool ExistenDispositivos = false;
        private FilterInfoCollection DispositivosDeVideo;
        private VideoCaptureDevice FuenteDeVideo = null;
        public void CargarDispositivos(FilterInfoCollection Dispositivos)
        {
            for (int i = 0; i < Dispositivos.Count; i++)

                cboDispositivos.Items.Add(Dispositivos[i].Name.ToString());
            //cboDispositivos es nuestro combobox

            cboDispositivos.Text = cboDispositivos.Items[0].ToString();

        }
        public void BuscarDispositivos()
        {

            DispositivosDeVideo =
            new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (DispositivosDeVideo.Count == 0)

                ExistenDispositivos =
                false;
            else
            {

                ExistenDispositivos =
                true;

                CargarDispositivos(DispositivosDeVideo);

            }

        }
        public void TerminarFuenteDeVideo()
        {
            if (!(FuenteDeVideo == null))

                if (FuenteDeVideo.IsRunning)
                {

                    FuenteDeVideo.SignalToStop();

                    FuenteDeVideo =
                    null;

                }

        }
        private void video_NuevoFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();

            pbfoto.Image = Imagen;
            //pbFotoUser es nuestro pictureBox

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (btnfoto.Text == "iniciar")
            {
                if (ExistenDispositivos)
                {

                    FuenteDeVideo = new VideoCaptureDevice(DispositivosDeVideo[cboDispositivos.SelectedIndex].MonikerString);

                    FuenteDeVideo.NewFrame += new NewFrameEventHandler(video_NuevoFrame);

                    FuenteDeVideo.Start();

                    btnfoto.Text = "Detener";

                    cboDispositivos.Enabled = false;

                    //gbMenu.Text = DispositivosDeVideo[cboDispositivos.SelectedIndex].Name.ToString();

                }
                else

                    MessageBox.Show("Error: No se encuentra dispositivo.");

            }
            else
            {
                if (FuenteDeVideo.IsRunning)
                {

                    TerminarFuenteDeVideo();

                    btnfoto.Text = "iniciar";

                    cboDispositivos.Enabled = true;

                }

            }
           

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pbfotog.Image = pbfoto.Image;

           // pbfoto.Image.Save("C:\\Users\\Andres Barros\\Pictures\\Camera Roll", ImageFormat.Jpeg);

            string ruta = Path.Combine("C:\\Users\\Andres Barros\\Pictures\\Camera Roll", "imagen.jpg");
            pbfotog.Image.Save(ruta, ImageFormat.Jpeg);
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
           
        }

    }
}
