using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Windows;
using NAudio.Wave;
namespace TaskNumberFourFillingTheArrayWithADatabase
{
    public partial class VoiceActingOfAlreadyAddedWords : Window
    {
        public VoiceActingOfAlreadyAddedWords()
        {
            InitializeComponent();
            ComboSelectWord.ItemsSource = AddingWordsToTheComboboxThatHaveNotYetBeenVoiced();
            
        }
        WaveIn waveIn;
        WaveFileWriter waveWriter;
        EducationalPracticeEntities context = new EducationalPracticeEntities();
        //List<byte> audioBytes = new List<byte>(new byte[] { });

        private void WaveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (!Dispatcher.CheckAccess())
            {
                Dispatcher.BeginInvoke(new EventHandler<WaveInEventArgs>(WaveIn_DataAvailable), sender, e);
            }
            else
            {
                waveWriter.Write(e.Buffer, 0, e.BytesRecorded);
            }
        }
        void WaveIn_RecordingStopped(object sender, EventArgs e)
        {
            if (!Dispatcher.CheckAccess())
            {
                Dispatcher.BeginInvoke(new EventHandler(WaveIn_RecordingStopped), sender, e);
            }
            else
            {
                waveIn.Dispose();
                waveIn = null;
                waveWriter.Close();
                waveWriter = null;
            }
        }
        private IEnumerable<EnglishWord> AddingWordsToTheComboboxThatHaveNotYetBeenVoiced()
        {
           
            context.EnglishWord.Load();
            var allWordsInEnglish = context.EnglishWord.ToList();
            var unwrittenWords = from word in allWordsInEnglish
                                 where word.idPathsToVoiceFilesThatWereCreatedByTheUserEnglishWord_fk_== null
                                 select word;
            return unwrittenWords.ToList();
        }
        public void StartReconding_Click(object sender, RoutedEventArgs e)
        {
            waveIn = new WaveIn();
            //Дефолтное устройство для записи (если оно имеется)
            waveIn.DeviceNumber = 0;
            //Прикрепляем к событию DataAvailable обработчик, возникающий при наличии записываемых данных
            waveIn.DataAvailable += WaveIn_DataAvailable;
            //Прикрепляем обработчик завершения записи
            waveIn.RecordingStopped += WaveIn_RecordingStopped;
            //Формат wav-файла - принимает параметры - частоту дискретизации и количество каналов(здесь mono)
            waveIn.WaveFormat = new WaveFormat(22050, 1);
            waveWriter = new WaveFileWriter("intermediateRecordFileInBinary.wav", waveIn.WaveFormat);
            //Начало записи
            waveIn.StartRecording();
        }
        private void StopRecording_Click(object sender, RoutedEventArgs e)
        {
            if (waveIn != null)
            {
                waveIn.StopRecording();
                MessageBox.Show("Запись окончена");
                //var bytes = File.ReadAllBytes("intermediateRecordFileInBinary.wav");
            }
        }
        private void intermediateRecordFileInBinaryDelet()
        {
            FileInfo fileInf = new FileInfo("intermediateRecordFileInBinary.wav");
            fileInf.Delete();
        }

        private void PlayTheRecording_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var bytes = File.ReadAllBytes("intermediateRecordFileInBinary.wav");

                using (Stream s = new MemoryStream(bytes.ToArray()))
                {
                    System.Media.SoundPlayer myPlayer = new System.Media.SoundPlayer(s);
                    myPlayer.Play();
                }
            }
            catch
            {
                MessageBox.Show("Файла не существует или его формат не .wav");
            }
        }

        private void SaveRecording_Click(object sender, RoutedEventArgs e)
        {
            PathsToVoiceFilesThatWereCreatedByTheUser pathsToVoiceFilesThatWereCreatedByTheUser = new PathsToVoiceFilesThatWereCreatedByTheUser();
            var bytes = File.ReadAllBytes("intermediateRecordFileInBinary.wav");
            pathsToVoiceFilesThatWereCreatedByTheUser.Path = bytes.ToString();
            
            context.EnglishWord.Load();
            
            intermediateRecordFileInBinaryDelet();
        }
    }
}
