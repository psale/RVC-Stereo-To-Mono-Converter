using System;
using System.IO;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace tomono
{
    public partial class Form1 : Form
    {
        private string inputFolderPath = string.Empty;
        private string outputFolderPath = string.Empty;

        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(inputFolderPath))
            {

                MessageBox.Show("Input folder does not exist.");
                return;
            }

            if (!Directory.Exists(outputFolderPath))
            {
                MessageBox.Show("Output folder does not exist.");
                return;
            }

            try
            {
                var files = Directory.GetFiles(inputFolderPath, "*.wav");
                foreach (var file in files)
                {
                    var inputFilePath = file;
                    var outputFileName = Path.GetFileNameWithoutExtension(file) + "_converted.wav";
                    var outputFilePath = Path.Combine(outputFolderPath, outputFileName);

                    using (var reader = new WaveFileReader(inputFilePath))
                    {
                        ISampleProvider sampleProvider = reader.ToSampleProvider();


                        if (reader.WaveFormat.Channels > 1)
                        {
                            sampleProvider = new StereoToMonoSampleProvider(sampleProvider);
                        }

                        var volumeProvider = new VolumeSampleProvider(sampleProvider);
                        volumeProvider.Volume = 0.5f;  // Reduce volume by -6dB
                        var resampler = new WdlResamplingSampleProvider(volumeProvider, 44100);  // Convert sample rate to 44100 Hz
                        var to16bit = new SampleToWaveProvider16(resampler);  // Convert bit depth to 16 bit

                        WaveFileWriter.CreateWaveFile(outputFilePath, to16bit);
                    }
                }

                MessageBox.Show("The conversion was successful.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during conversion: " + ex.Message);
            }
        }

        private void btnBrowseInput_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                inputFolderPath = folderBrowserDialog.SelectedPath;

            }
        }

        private void btnBrowseOutput_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                outputFolderPath = folderBrowserDialog.SelectedPath;
                ActiveControl = null;


            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("https://www.paypal.com/paypalme/elielhillel") { UseShellExecute = true });
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
        }
    }
}
