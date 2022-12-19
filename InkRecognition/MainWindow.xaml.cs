using System.Windows;
using Microsoft.Ink;
using System.IO;
using System;

namespace InkRecognition
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
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
                            textBox1.Text = result.TopString;
                        else
                        {
                            MessageBox.Show("Recognition failed");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No stroke detected");
                    }
                }
            }
        }
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            theInkCanvas.Strokes.Clear();
        }
    }
}