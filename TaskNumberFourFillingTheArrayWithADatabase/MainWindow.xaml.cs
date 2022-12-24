using System.Windows;
using Microsoft.Ink;
using System.IO;
using System.Speech.Synthesis; 
using System;
using System.Data.Entity;

namespace TaskNumberFourFillingTheArrayWithADatabase
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            VoicedWord = GetAllEnglishWord();
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
                            if (result.TopString == VoicedWord)
                            {
                                MessageBox.Show("Вы правильно написали озвученное слово!");
                                VoicedWord = GetAllEnglishWord();
                            }
                            else
                            {
                                MessageBox.Show("Вы НЕ правильно написали озвученное слово!");
                                VoicedWord = GetAllEnglishWord();
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
        public int CountElementsRowWord()
        {
            EducationalPracticeEntities context = new EducationalPracticeEntities();
            context.EnglishWord.Load();
            int count = context.EnglishWord.Local.Count;
            return count;
        }

        public string GetAllEnglishWord()
        {
            EducationalPracticeEntities context = new EducationalPracticeEntities();
            int numberOfEntriesInTheWordsColumn = CountElementsRowWord();
            string[] arrWordBD = new string[numberOfEntriesInTheWordsColumn];
            int count = 0;
            foreach (EnglishWord englishWord in context.EnglishWord)
            {
                arrWordBD[count] = englishWord.Word.ToString();
                count++;
            }
            Random random = new Random();
            int value = random.Next(0, arrWordBD.Length);
            return arrWordBD[value];
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
            VoiceActingOfTheWord(VoicedWord);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            VoiceActingOfAlreadyAddedWords window1= new VoiceActingOfAlreadyAddedWords();
            window1.Show();
        }
            
    }
}
