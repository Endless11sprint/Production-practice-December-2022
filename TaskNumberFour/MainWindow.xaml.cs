using System.Windows;
using Microsoft.Ink;
using System.IO;
using System.Speech.Synthesis;
using System;

namespace TaskNumberFour
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            VoicedWord = CreatingARandomWordInAnArray();
            DataContext = VoicedWord;
        }
        string VoicedWord;


        private void buttonClick(object sender, RoutedEventArgs e)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                theInkCanvas.Strokes.Save(ms);
                var myInkCollector = new InkCollector();
                var ink = new Ink();
                ink.Load(ms.ToArray());
                using (RecognizerContext context = new RecognizerContext())
                {
                    if (ink.Strokes.Count > 0)
                    {
                        context.Strokes = ink.Strokes;
                        RecognitionStatus status;
                        var result = context.Recognize(out status);
                        if (status == RecognitionStatus.NoError)
                        {
                            textBox1.Text = result.TopString;
                            //string VoicedWord = CreatingARandomWordInAnArray();
                            if (result.TopString == VoicedWord)
                            {
                                MessageBox.Show("Вы правильно написали озвученное слово!");
                                VoicedWord = CreatingARandomWordInAnArray();
                            }
                            else
                            {
                                MessageBox.Show("Вы НЕ правильно написали озвученное слово!");
                                VoicedWord = CreatingARandomWordInAnArray();

                            }
                        }
                        else
                        {
                            MessageBox.Show("Распознавание не удалось");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Строка не обнаружена");
                    }
                }
            }
        }
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            theInkCanvas.Strokes.Clear();
        }
       
        public string CreatingARandomWordInAnArray()
        {
            Random random = new Random();
            int value = random.Next(0, 2);
            string[] arrWord = new string[2] { "МАМА", "ПАПА" };
            return arrWord[value];
        }
        public void VoiceActingOfTheWord(string theSpokenWord)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            //Озвучка
            synth.Speak(theSpokenWord);
        }

        private void btnVoiceOver_Click(object sender, RoutedEventArgs e)
        {
            //string VoicedWord = CreatingARandomWordInAnArray();
            VoiceActingOfTheWord(VoicedWord);
        }
    }
}