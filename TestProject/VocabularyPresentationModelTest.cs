using VocabularyTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;
using System.Collections.Generic;

namespace TestProject
{
    
    
    /// <summary>
    ///這是 VocabularyPresentationModelTest 的測試類別，應該包含
    ///所有 VocabularyPresentationModelTest 單元測試
    ///</summary>
    [TestClass()]
    public class VocabularyPresentationModelTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///取得或設定提供目前測試回合的相關資訊與功能
        ///的測試內容。
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

        #region 其他測試屬性
        // 
        //您可以在撰寫測試時，使用下列的其他屬性:
        //
        //在執行類別中的第一項測試之前，先使用 ClassInitialize 執行程式碼
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //在執行類別中的所有測試之後，使用 ClassCleanup 執行程式碼
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //在執行每一項測試之前，先使用 TestInitialize 執行程式碼
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //在執行每一項測試之後，使用 TestCleanup 執行程式碼
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///VocabularyPresentationModel 建構函式 的測試
        ///</summary>
        [TestMethod()]
        public void VocabularyPresentationModelConstructorTest()
        {
            VocabularyMode vocabularyModes = new VocabularyMode(); ; // TODO: 初始化為適當值
            VocabularyPresentationModel_Accessor target = new VocabularyPresentationModel_Accessor(vocabularyModes);
            Assert.AreEqual(vocabularyModes, target._vocabularyMode);
        }

        /// <summary>
        ///ChangedQuestionTypeComboBoxSelectedIndex 的測試
        ///</summary>
        [TestMethod()]
        public void ChangedQuestionTypeComboBoxSelectedIndexTest()
        {
            VocabularyMode vocabularyModes = new VocabularyMode(); // TODO: 初始化為適當值
            VocabularyPresentationModel target = new VocabularyPresentationModel(vocabularyModes); // TODO: 初始化為適當值
            int selectIndex = 0; // TODO: 初始化為適當值
            target.ChangedQuestionTypeComboBoxSelectedIndex(selectIndex);
            Assert.AreEqual(true, target.AllFillInTheBlankQuestionsToolStripMenuItemChecked);
            Assert.AreEqual(false, target.AllFillInTheBlankQuestionsToolStripMenuItemEnabled);
            Assert.AreEqual(false, target.AllListeningComprehensionMultipleChoiceQuestionsToolStripMenuItemChecked);
            Assert.AreEqual(true, target.AllListeningComprehensionMultipleChoiceQuestionsToolStripMenuItemEnabled);
            Assert.AreEqual(false, target.PickUpQuestionsRandomlyToolStripMenuItemChecked);
            Assert.AreEqual(true, target.PickUpQuestionsRandomlyToolStripMenuItemEnabled);

            target.ChangedQuestionTypeComboBoxSelectedIndex(1);
            Assert.AreEqual(false, target.AllFillInTheBlankQuestionsToolStripMenuItemChecked);
            Assert.AreEqual(true, target.AllFillInTheBlankQuestionsToolStripMenuItemEnabled);
            Assert.AreEqual(true, target.AllListeningComprehensionMultipleChoiceQuestionsToolStripMenuItemChecked);
            Assert.AreEqual(false, target.AllListeningComprehensionMultipleChoiceQuestionsToolStripMenuItemEnabled);
            Assert.AreEqual(false, target.PickUpQuestionsRandomlyToolStripMenuItemChecked);
            Assert.AreEqual(true, target.PickUpQuestionsRandomlyToolStripMenuItemEnabled);

            target.ChangedQuestionTypeComboBoxSelectedIndex(2);
            Assert.AreEqual(false, target.AllFillInTheBlankQuestionsToolStripMenuItemChecked);
            Assert.AreEqual(true, target.AllFillInTheBlankQuestionsToolStripMenuItemEnabled);
            Assert.AreEqual(false, target.AllListeningComprehensionMultipleChoiceQuestionsToolStripMenuItemChecked);
            Assert.AreEqual(true, target.AllListeningComprehensionMultipleChoiceQuestionsToolStripMenuItemEnabled);
            Assert.AreEqual(true, target.PickUpQuestionsRandomlyToolStripMenuItemChecked);
            Assert.AreEqual(false, target.PickUpQuestionsRandomlyToolStripMenuItemEnabled);
        }

        /// <summary>
        ///CreateQuestion 的測試
        ///</summary>
        [TestMethod()]
        [DeploymentItem("VocabularyTest.exe")]
        public void CreateQuestionTest()
        {
            VocabularyMode param0 = new VocabularyMode();
            VocabularyPresentationModel_Accessor target = new VocabularyPresentationModel_Accessor(param0); // TODO: 初始化為適當值
            param0.Initialize();
            param0.QuestionType = 0;
            param0.CreateQuestionType();
            target.CreateQuestion();
            Assert.IsTrue(target.IsAnswerTextBoxEnabled);
            Assert.AreEqual(true, target.QuestionGroupBoxText.Contains("Fill in the Blanks"));
            Assert.AreEqual(false, target._isSelectionQuestionTableLayoutPanelVisabled);
            Assert.AreEqual(true, target._isFillQuestionTableLayoutPanelVisiabled);
            Assert.AreEqual("", target.AnswerTextBoxText);
            Assert.AreEqual(param0.FillQuestion, target.QuestionLabelText);
            param0.QuestionType = 1;
            param0.CreateQuestionType();
            target.CreateQuestion();
            Assert.AreEqual(true, target.QuestionGroupBoxText.Contains("Listehning Comprehension Multiple Choice Question"));
            Assert.AreEqual(true, target._isSelectionQuestionTableLayoutPanelVisabled);
            Assert.AreEqual(false, target._isFillQuestionTableLayoutPanelVisiabled);
            Assert.IsFalse(target.IsAnswerTextBoxEnabled);
        }

        /// <summary>
        ///GetAboutDictionaryMessageBoxText 的測試
        ///</summary>
        [TestMethod()]
        public void AboutDictionaryMessageBoxTextTest()
        {
            VocabularyMode vocabularyModes = new VocabularyMode(); // TODO: 初始化為適當值
            VocabularyPresentationModel target = new VocabularyPresentationModel(vocabularyModes); // TODO: 初始化為適當值
            string expected = "Total 2074 words in the dictionary."; // TODO: 初始化為適當值
            string actual;
            actual = target.AboutDictionaryMessageBoxText;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Initialize 的測試
        ///</summary>
        [TestMethod()]
        [DeploymentItem("VocabularyTest.exe")]
        public void InitializeTest()
        {
            VocabularyMode param0 = new VocabularyMode();
            VocabularyPresentationModel_Accessor target = new VocabularyPresentationModel_Accessor(param0); // TODO: 初始化為適當值
            target.Initialize();
            Assert.IsTrue(target.IsStartButtonEnabled);
            Assert.IsTrue(target.StartToolStripMenuItemEnabled);
            Assert.IsFalse(target.IsNextButtonEnabled);
            Assert.IsFalse(target.NextTooStripMenuItemEnabled);
            Assert.IsFalse(target.StopTooStripMenuItemEnabled);
            Assert.IsFalse(target.IsStopButtonEnabled);
            Assert.IsTrue(target.IsChooseNumberOfQuestionLayoutPanelVisiabled);
            Assert.IsFalse(target.IsFillQuestionTableLayoutPanelVisiabled);
            Assert.IsFalse(target.IsSelectionQuestionTableLayoutPanelVisabled);
            Assert.AreEqual("Customize Your Examination", target.QuestionGroupBoxText);
            Assert.AreEqual("00:00:00", target.TimeLabelText);
        }

        /// <summary>
        ///InitializeToolStripMenuItems 的測試
        ///</summary>
        [TestMethod()]
        [DeploymentItem("VocabularyTest.exe")]
        public void InitializeToolStripMenuItemsTest()
        {
            VocabularyMode param0 = new VocabularyMode();
            VocabularyPresentationModel_Accessor target = new VocabularyPresentationModel_Accessor(param0); // TODO: 初始化為適當值
            target.InitializeToolStripMenuItems();
            Assert.IsTrue(target.StartToolStripMenuItemEnabled);
            Assert.IsFalse(target.NextTooStripMenuItemEnabled);
            Assert.IsFalse(target.StopTooStripMenuItemEnabled);
        }

        /// <summary>
        ///PressAllFillInTheBlankQuestionsToolStripMenuItem 的測試
        ///</summary>
        [TestMethod()]
        public void PressAllFillInTheBlankQuestionsToolStripMenuItemTest()
        {
            VocabularyMode vocabularyModes = new VocabularyMode(); // TODO: 初始化為適當值
            VocabularyPresentationModel target = new VocabularyPresentationModel(vocabularyModes); // TODO: 初始化為適當值
            target.PressAllFillInTheBlankQuestionsToolStripMenuItem();
            Assert.IsTrue(target.AllFillInTheBlankQuestionsToolStripMenuItemChecked);
            Assert.IsFalse(target.AllFillInTheBlankQuestionsToolStripMenuItemEnabled);
            Assert.IsFalse(target.AllListeningComprehensionMultipleChoiceQuestionsToolStripMenuItemChecked);
            Assert.IsTrue(target.AllListeningComprehensionMultipleChoiceQuestionsToolStripMenuItemEnabled);
            Assert.IsFalse(target.PickUpQuestionsRandomlyToolStripMenuItemChecked);
            Assert.IsTrue(target.PickUpQuestionsRandomlyToolStripMenuItemEnabled);
        }

        /// <summary>
        ///PressAllListeningComprehensionMultipleChoiceQuestionsToolStripMenuItem 的測試
        ///</summary>
        [TestMethod()]
        public void PressAllListeningComprehensionMultipleChoiceQuestionsToolStripMenuItemTest()
        {
            VocabularyMode vocabularyModes = new VocabularyMode(); // TODO: 初始化為適當值
            VocabularyPresentationModel target = new VocabularyPresentationModel(vocabularyModes); // TODO: 初始化為適當值
            target.PressAllListeningComprehensionMultipleChoiceQuestionsToolStripMenuItem();
            Assert.IsFalse(target.AllFillInTheBlankQuestionsToolStripMenuItemChecked);
            Assert.IsTrue(target.AllFillInTheBlankQuestionsToolStripMenuItemEnabled);
            Assert.IsTrue(target.AllListeningComprehensionMultipleChoiceQuestionsToolStripMenuItemChecked);
            Assert.IsFalse(target.AllListeningComprehensionMultipleChoiceQuestionsToolStripMenuItemEnabled);
            Assert.IsFalse(target.PickUpQuestionsRandomlyToolStripMenuItemChecked);
            Assert.IsTrue(target.PickUpQuestionsRandomlyToolStripMenuItemEnabled);
        }

        /// <summary>
        ///PressListenButton 的測試
        ///</summary>
        [TestMethod()]
        public void PressListenButtonTest()
        {
            VocabularyMode vocabularyModes = new VocabularyMode(); // TODO: 初始化為適當值
            VocabularyPresentationModel target = new VocabularyPresentationModel(vocabularyModes); // TODO: 初始化為適當值
            vocabularyModes.QuestionType = 1;
            vocabularyModes.CreateQuestionType();
            vocabularyModes.CreateNewSelectionQuestion();
            target.PressListenButton();
            Assert.IsTrue(true);
        }

        /// <summary>
        ///PressNextButton 的測試
        ///</summary>
        [TestMethod()]
        public void PressNextButtonTest()
        {
            VocabularyMode vocabularyModes = new VocabularyMode(); // TODO: 初始化為適當值
            VocabularyPresentationModel target = new VocabularyPresentationModel(vocabularyModes); // TODO: 初始化為適當值
            vocabularyModes.QuestionType = 0;
            vocabularyModes.CreateQuestionType();
            vocabularyModes.GetNewFillQuestion();
            target.PressNextButton(vocabularyModes.FillAnswer,0);
            Assert.AreEqual("Correct!!", target.StatusBarText);
            vocabularyModes.GetNewFillQuestion();
            target.PressNextButton("ALWAYS FAIL", 0);
            Assert.AreEqual("It should be " + target.PreviousFillQuestionAnswer, target.StatusBarText);
            vocabularyModes.QuestionType = 1;
            vocabularyModes.CreateQuestionType();
            vocabularyModes.CreateNewSelectionQuestion();
            target.PressNextButton("", vocabularyModes.SelectionAnswer);
            Assert.AreEqual("Correct!!", target.StatusBarText);
            vocabularyModes.CreateNewSelectionQuestion();
            target.PressNextButton("", 0);
            Assert.IsTrue(target.StatusBarText.Contains("It should be ("+target.PreviousSelectionAnswer.ToString()+")"));
            vocabularyModes.Initialize();
            vocabularyModes.NumberOfQuestion = 1;
            target.PressNextButton("", 0);
            Assert.IsTrue(target.IsChooseNumberOfQuestionLayoutPanelVisiabled);
            Assert.IsFalse(target.IsFillQuestionTableLayoutPanelVisiabled);
            Assert.IsFalse(target.IsSelectionQuestionTableLayoutPanelVisabled);
            Assert.AreEqual("得分: 0% (0/1)", target.MessageBoxText);
            vocabularyModes.NumberOfQuestion = 4;
            vocabularyModes.QuestionType = 0;
            vocabularyModes.CreateQuestionType();
            for(int i=0 ; i<2 ; i++)
                target.PressNextButton(vocabularyModes.FillAnswer, 0);
            for (int i = 0; i < 2; i++)
                target.PressNextButton("", 0);
            Assert.AreEqual("得分: 50% (2/4)", target.MessageBoxText);
            vocabularyModes.NumberOfQuestion = 10;
            vocabularyModes.QuestionType = 0;
            vocabularyModes.CreateQuestionType();
            for (int i = 0; i < 10; i++)
                target.PressNextButton(vocabularyModes.FillAnswer, 0);
            Assert.AreEqual("得分: 100% (10/10)", target.MessageBoxText);
        }

        /// <summary>
        ///PressPickUpQuestionsRndomlyToolStripMenuItem 的測試
        ///</summary>
        [TestMethod()]
        public void PressPickUpQuestionsRndomlyToolStripMenuItemTest()
        {
            VocabularyMode vocabularyModes = new VocabularyMode(); // TODO: 初始化為適當值
            VocabularyPresentationModel target = new VocabularyPresentationModel(vocabularyModes); // TODO: 初始化為適當值
            target.PressPickUpQuestionsRndomlyToolStripMenuItem();
            Assert.IsFalse(target.AllFillInTheBlankQuestionsToolStripMenuItemChecked);
            Assert.IsTrue(target.AllFillInTheBlankQuestionsToolStripMenuItemEnabled);
            Assert.IsFalse(target.AllListeningComprehensionMultipleChoiceQuestionsToolStripMenuItemChecked);
            Assert.IsTrue(target.AllListeningComprehensionMultipleChoiceQuestionsToolStripMenuItemEnabled);
            Assert.IsTrue(target.PickUpQuestionsRandomlyToolStripMenuItemChecked);
            Assert.IsFalse(target.PickUpQuestionsRandomlyToolStripMenuItemEnabled);
        }

        /// <summary>
        ///PressStartButton 的測試
        ///</summary>
        [TestMethod()]
        public void PressStartButtonTest()
        {
            VocabularyMode vocabularyModes = new VocabularyMode(); // TODO: 初始化為適當值
            VocabularyPresentationModel_Accessor target = new VocabularyPresentationModel_Accessor(vocabularyModes); // TODO: 初始化為適當值
            int numberOfQuestions = 5; // TODO: 初始化為適當值
            int questionType = 0; // TODO: 初始化為適當值
            target.PressStartButton(numberOfQuestions, questionType);
            Assert.IsFalse(target.IsStartButtonEnabled);
            Assert.IsFalse(target.StartToolStripMenuItemEnabled);
            Assert.IsTrue(target.IsStopButtonEnabled);
            Assert.IsTrue(target.StopTooStripMenuItemEnabled);
            Assert.IsTrue(target.IsNextButtonEnabled);
            Assert.IsTrue(target.NextTooStripMenuItemEnabled);
            Assert.IsTrue(target.IsStartTest);
        }

        /// <summary>
        ///PressStopButton 的測試
        ///</summary>
        [TestMethod()]
        public void PressStopButtonTest()
        {
            VocabularyMode vocabularyModes = new VocabularyMode(); // TODO: 初始化為適當值
            VocabularyPresentationModel target = new VocabularyPresentationModel(vocabularyModes); // TODO: 初始化為適當值
            vocabularyModes.QuestionType = 0;
            vocabularyModes.CreateQuestionType();
            target.PressStartButton(10, 0);
            target.PressStopButton(vocabularyModes.FillAnswer, 0);
            Assert.AreEqual("Correct!!", target.StatusBarText);
            Assert.AreEqual("得分: 100% (1/1)", target.MessageBoxText);
            vocabularyModes.QuestionType = 0;
            vocabularyModes.CreateQuestionType();
            target.PressStartButton(10, 0);
            target.PressStopButton(vocabularyModes.FillAnswer, 0);
            target.PressStartButton(10, 0);
            for (int i = 0; i < 2; i++)
                target.PressNextButton(vocabularyModes.FillAnswer, 0);
            target.PressNextButton("", 0);
            target.PressStopButton("", 0);
            Assert.AreEqual("得分: 50% (2/4)", target.MessageBoxText);
            Assert.AreEqual("It should be "+target.PreviousFillQuestionAnswer, target.StatusBarText);
            Assert.IsFalse(target.IsStartTest);
        }

        /// <summary>
        ///ProcessEndQuestion 的測試
        ///</summary>
        [TestMethod()]
        [DeploymentItem("VocabularyTest.exe")]
        public void ProcessEndQuestionTest()
        {
            VocabularyMode param0 = new VocabularyMode(); // TODO: 初始化為適當值
            VocabularyPresentationModel_Accessor target = new VocabularyPresentationModel_Accessor(param0); // TODO: 初始化為適當值
            target.Initialize();
            target.PressStartButton(10, 0);
            for (int i = 0; i < 2; i++)
                target.PressNextButton(param0.FillAnswer, 0);
            target.ProcessEndQuestion();
            Assert.IsFalse(target.IsStartTest);
            Assert.IsFalse(target.IsSelectionQuestionTableLayoutPanelVisabled);
            Assert.IsFalse(target.IsFillQuestionTableLayoutPanelVisiabled);
            Assert.AreEqual("得分: 20% (2/10)", target.MessageBoxText);
        }

        /// <summary>
        ///ProcessFillQuestion 的測試
        ///</summary>
        [TestMethod()]
        [DeploymentItem("VocabularyTest.exe")]
        public void ProcessFillQuestionTest()
        {
            VocabularyMode param0 = new VocabularyMode(); // TODO: 初始化為適當值
            VocabularyPresentationModel_Accessor target = new VocabularyPresentationModel_Accessor(param0); // TODO: 初始化為適當值
            target.ProcessFillQuestion();
            Assert.IsTrue(target.IsFillQuestionTableLayoutPanelVisiabled);
            Assert.IsFalse(target.IsSelectionQuestionTableLayoutPanelVisabled);
            Assert.IsTrue(target.QuestionGroupBoxText.Contains("Fill in the Blanks"));
        }

        /// <summary>
        ///ProcessSelectionQuestion 的測試
        ///</summary>
        [TestMethod()]
        [DeploymentItem("VocabularyTest.exe")]
        public void ProcessSelectionQuestionTest()
        {
            VocabularyMode param0 = new VocabularyMode(); // TODO: 初始化為適當值
            VocabularyPresentationModel_Accessor target = new VocabularyPresentationModel_Accessor(param0); // TODO: 初始化為適當值
            target.ProcessSelectionQuestion();
            Assert.AreEqual("(1) " + target._selection[0], target.FirstRadioButtonText);
            Assert.AreEqual("(2) " + target._selection[1], target.SecondRadioButtonText);
            Assert.AreEqual("(3) " + target._selection[2], target.ThirdRadioButtonText);
            Assert.AreEqual("(4) " + target._selection[3], target.FourthRadioButtonText);
            Assert.IsTrue(target._isSelectionQuestionTableLayoutPanelVisabled);
            Assert.IsFalse(target._isFillQuestionTableLayoutPanelVisiabled);
            Assert.IsTrue(target.QuestionGroupBoxText.Contains("Listehning Comprehension Multiple Choice Question"));
        }

        /// <summary>
        ///RsetTimer 的測試
        ///</summary>
        [TestMethod()]
        public void RsetTimerTest()
        {
            VocabularyMode vocabularyModes = new VocabularyMode(); // TODO: 初始化為適當值
            VocabularyPresentationModel target = new VocabularyPresentationModel(vocabularyModes); // TODO: 初始化為適當值
            for (int i = 0; i < 9999; i++)
                target.RunTimer();
            target.RsetTimer();
            Assert.AreEqual("00:00:00", target.TimeLabelText);
        }

        /// <summary>
        ///RunTimer 的測試
        ///</summary>
        [TestMethod()]
        public void RunTimerTest()
        {
            VocabularyMode vocabularyModes = new VocabularyMode(); // TODO: 初始化為適當值
            VocabularyPresentationModel target = new VocabularyPresentationModel(vocabularyModes); // TODO: 初始化為適當值
            target.RunTimer();
            Assert.AreEqual("00:00:01", target.TimeLabelText);
            Assert.IsFalse(target.IsTimeUp);
            for (int i = 0; i < 9999; i++)
                target.RunTimer();
            Assert.AreEqual("02:46:40", target.TimeLabelText);
            target.RsetTimer();
            for (int i = 0; i < 20; i++)
                target.RunTimer();
            Assert.AreEqual("00:00:20", target.TimeLabelText);
            Assert.IsTrue(target.IsTimeUp);
        }

        /// <summary>
        ///UnCheckAndEnableAllQuestionTypeSubtManuItem 的測試
        ///</summary>
        [TestMethod()]
        [DeploymentItem("VocabularyTest.exe")]
        public void UnCheckAndEnableAllQuestionTypeSubtManuItemTest()
        {
            VocabularyMode vocabularyModes = new VocabularyMode(); // TODO: 初始化為適當值
            VocabularyPresentationModel_Accessor target = new VocabularyPresentationModel_Accessor(vocabularyModes); // TODO: 初始化為適當值
            target.UnCheckAndEnableAllQuestionTypeSubtManuItem();
            Assert.IsFalse(target.AllFillInTheBlankQuestionsToolStripMenuItemChecked);
            Assert.IsTrue(target.AllFillInTheBlankQuestionsToolStripMenuItemEnabled);
            Assert.IsFalse(target.AllListeningComprehensionMultipleChoiceQuestionsToolStripMenuItemChecked);
            Assert.IsTrue(target.AllListeningComprehensionMultipleChoiceQuestionsToolStripMenuItemEnabled);
            Assert.IsFalse(target.PickUpQuestionsRandomlyToolStripMenuItemChecked);
            Assert.IsTrue(target.PickUpQuestionsRandomlyToolStripMenuItemEnabled); 
        }

        /// <summary>
        ///FormSize 的測試
        ///</summary>
        [TestMethod()]
        public void FormSizeTest()
        {
            VocabularyMode vocabularyModes = new VocabularyMode(); // TODO: 初始化為適當值
            VocabularyPresentationModel target = new VocabularyPresentationModel(vocabularyModes); // TODO: 初始化為適當值
            Size actual;
            actual = target.FormSize;
            Assert.AreEqual(new Size(500, 208), actual);
            target.PressStartButton(10, 0);
            actual = target.FormSize;
            Assert.AreEqual(new Size(370, 208), actual);
            vocabularyModes.Initialize();
            target.PressStartButton(10, 1);
            actual = target.FormSize;
            Assert.AreEqual(new Size(350, 344), actual);
        }

        /// <summary>
        ///ProcessBarStep 的測試
        ///</summary>
        [TestMethod()]
        public void ProcessBarStepTest()
        {
            VocabularyMode vocabularyModes = new VocabularyMode(); // TODO: 初始化為適當值
            VocabularyPresentationModel target = new VocabularyPresentationModel(vocabularyModes); // TODO: 初始化為適當值
            int actual;
            actual = target.ProcessBarStep;
            Assert.AreEqual(5,actual);
        }
    }
}
