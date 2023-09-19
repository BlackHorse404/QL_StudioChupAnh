using System;
using System.Drawing;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Windows.Forms;
using ZXing;
using QLStudio_THHQT.DAL;
using System.Data.SqlClient;
using QLStudio_THHQT.GUI;
using QLStudio_THHQT.Ultilities;

namespace QLStudio_THHQT
{
    public partial class ScanQRCode : Form
    {
        public ScanQRCode()
        {
            InitializeComponent();
        }

        private void stopScan()
        {
            if (FinalFrame.IsRunning == true)
            {
                FinalFrame.Stop();
            }
        }

        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;

        private void ScanQRCode_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
            {
                comboBox1.Items.Add(Device.Name);

            }
            comboBox1.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();
            timer1.Enabled = true;
            timer1.Start();

            //run scan
            FinalFrame = new VideoCaptureDevice(CaptureDevice[comboBox1.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //throw new NotImplementedException();
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void ScanQRCode_FormClosed(object sender, FormClosedEventArgs e)
        {
            stopScan();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                BarcodeReader Reader = new BarcodeReader();
                Result result = Reader.Decode((Bitmap)pictureBox1.Image);
                if (result != null)
                {
                    string decoded = result.ToString().Trim();
                    
                    if (decoded != "")
                    {
                        timer1.Stop();

                        //if (MessageBox.Show(decoded, "KQ", MessageBoxButtons.OK) == DialogResult.OK)
                        //    timer1.Start();

                        DBconfig.username = decoded.Split(',')[0];
                        DBconfig.password = decoded.Split(',')[1];

                        SqlConnection conn = DBconfig.getConnection();
                        try
                        {
                            conn.Open();
                            this.Hide();
                            frmMain f = new frmMain();
                            f.Closed += (s, args) => this.Close();
                            f.Show();
                        }
                        catch (SqlException err)
                        {
                            More.showNoticeErrorFromSQL(err.Number);
                            timer1.Start();
                        }
                        finally
                        {
                            conn.Close();
                            stopScan();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                timer1.Start();
            }
        }
    }
}
