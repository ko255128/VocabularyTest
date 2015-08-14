using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace TestProject
{
    /// <summary>
    /// CodedUITest1 的摘要描述
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        [TestInitialize()]
        public void Initialize()
        {
            Robot.Initialize("VocabularyTest.exe", "基本單字2000測驗");
        }

        [TestCleanup()]
        public void Cleanup()
        {
            Robot.CleanUp();
        }

        public CodedUITest1()
        {
        }

        [TestMethod]
        public void TestUI()
        {
            string[] path = { "Examination ", "Question Type", "AllFillInTheBlankQuestion" };
            Robot.SetComboBox("QuestionTypecomboBox", "all fill-in-blanks questions");
            Robot.ClickMenuItem(path);
            Robot.AssertMenuItemChecked("AllFillInTheBlankQuestion", true);
            //Robot.AssertMenuItemEnable("All listening-comprehension-multiple-choice questions",true);
            // 若要為這個測試產生程式碼，請在捷徑功能表上選取 [產生自動程式碼 UI 測試的程式碼]，並選取其中一個功能表項目。
            // 如需所產生程式碼的詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=179463
        }

        #region 其他測試屬性

        // 您可以使用下列其他屬性撰寫測試:

        ////在每項測試執行前先使用 TestInitialize 執行程式碼 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // 若要為這個測試產生程式碼，請在捷徑功能表上選取 [產生自動程式碼 UI 測試的程式碼]，並選取其中一個功能表項目。
        //    // 如需所產生程式碼的詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=179463
        //}

        ////在每項測試執行後使用 TestCleanup 執行程式碼
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // 若要為這個測試產生程式碼，請在捷徑功能表上選取 [產生自動程式碼 UI 測試的程式碼]，並選取其中一個功能表項目。
        //    // 如需所產生程式碼的詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=179463
        //}

        #endregion

        /// <summary>
        ///取得或設定提供目前測試回合
        ///相關資訊與功能的測試內容。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;
    }
}
