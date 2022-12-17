using System;
using System.Windows;
using System.Speech.Synthesis;
using System.Data.Entity.Core.Common.EntitySql;
using System.Data.Common;
using System.Data.Entity;

namespace TaskNumberThree
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }
        string[] arrWord = new string[3] {"class", "variable", "example"};
        public string CreatingARandomWordInAnArray()
        {
            Random random = new Random();
            int value = random.Next(0, 2);
            return arrWord[value];
        }
        public void VoiceActingOfTheWord(string theSpokenWord)
        {  
            SpeechSynthesizer synth = new SpeechSynthesizer(); 
            synth.SetOutputToDefaultAudioDevice();
            //Озвучка
            synth.Speak(theSpokenWord);
        }

        private void BtnPlaySound_Click(object sender, RoutedEventArgs e)
        {
            string pronouncedWord = CreatingARandomWordInAnArray();
            VoiceActingOfTheWord(pronouncedWord);
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
            string[] arrWordBD = new string [numberOfEntriesInTheWordsColumn];
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

        private void BtnPlaySoundBD_Click(object sender, RoutedEventArgs e)
        {
            string pronouncedWordDB = GetAllEnglishWord();
            VoiceActingOfTheWord(pronouncedWordDB);
        }
    }
}
