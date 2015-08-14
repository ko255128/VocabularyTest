using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VocabularyTest
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        private static VocabularyMode _mode = new VocabularyMode();
        private static VocabularyPresentationModel _presentationModel = new VocabularyPresentationModel(_mode);
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new VocabularyTestView(_presentationModel));
        }
    }
}
