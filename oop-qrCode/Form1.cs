using System;
using System.IO;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace oop_qrCode
{
    public partial class qr : Form
    {
        public qr()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCapture;
            
        void qr_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        }

        private void scan_Click(object sender, EventArgs e)
        {
            videoCapture = new VideoCaptureDevice(filterInfoCollection[1].MonikerString);
            videoCapture.NewFrame += CaptureDevice_NewFrame;
            videoCapture.Start(); timer1.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            camera.Image = (Bitmap) eventArgs.Frame.Clone();
        }

        private void qr_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCapture != null && videoCapture.IsRunning)
            {
                videoCapture.SignalToStop(); videoCapture.WaitForStop();
                videoCapture.NewFrame -= new NewFrameEventHandler(CaptureDevice_NewFrame);
                videoCapture = null;
            }
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {        
            if (camera.Image != null)
            {
                var barcodeReader = new BarcodeReader();
                var result = barcodeReader.Decode((Bitmap) camera.Image);
                if (result != null)
                {
                    // note: path can be changed accdg. to preferred file destination
                    var path = @"C:\Users\Benedict Fernando\Documents";

                    // process extracted data from 'result'
                    await outputTxt(result.ToString(), path); timer1.Stop();

                    // exit application
                    MessageBox.Show("QR Code was successfully scanned! " +
                        "Result is located at:\n\n" + path);
                    Application.Exit();
                }
            }
        }
        public static async Task outputTxt(string text, string path)
        {
            await File.WriteAllTextAsync(path + @"\qrCode.txt", text);
        }
    }
}
