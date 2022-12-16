using System;
using System.Windows;
using NAudio.Wave;

namespace VoiceRecording
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        WaveIn waveIn;
        WaveFileWriter waveWriter;
        string outputFilename = "C:\\Users\\karkr\\Desktop\\2.wav";
        private void waveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (waveWriter == null) return;

            waveWriter.Write(e.Buffer, 0, e.BytesRecorded);
            waveWriter.Flush();
        }


        private void StartReconding_Click(object sender, RoutedEventArgs e)
        {
            waveIn = new WaveIn();
            waveIn.DeviceNumber = 0;
            waveIn.WaveFormat = new WaveFormat(44100, WaveIn.GetCapabilities(waveIn.DeviceNumber).Channels);

            waveIn.DataAvailable += new EventHandler<WaveInEventArgs>(waveIn_DataAvailable);
            waveWriter = new WaveFileWriter(outputFilename, waveIn.WaveFormat);
            waveIn.StartRecording();
        }

        private void StopRecording_Click(object sender, RoutedEventArgs e)
        {
            if (waveIn != null)
            {
                waveIn.StopRecording();
                waveIn.Dispose();
                waveIn = null;
            }
            if (waveWriter != null)
            {
                waveWriter.Dispose();
                waveWriter = null;
            }
            MessageBox.Show("StopRecording");
        }

        private void PlayTheRecording_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                WaveStream mainOutputStream = new WaveFileReader(outputFilename);
                WaveChannel32 volumeStream = new WaveChannel32(mainOutputStream);
                WaveOutEvent player = new WaveOutEvent();
                player.Init(volumeStream);
                player.Play();
            }
            catch 
            {
                MessageBox.Show("Файла не существует или его формат не .wav"); 
            }
            
        }
    }
}
