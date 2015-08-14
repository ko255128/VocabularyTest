using VocabularyTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestProject
{


    /// <summary>
    ///這是 VocabularyModeTest 的測試類別，應該包含
    ///所有 VocabularyModeTest 單元測試
    ///</summary>
    [TestClass()]
    public class VocabularyModeTest
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
        ///CaculateScore 的測試  要收改
        ///</summary>
        [TestMethod()]
        [DeploymentItem("VocabularyTest.exe")]
        public void CaculateScoreTest()
        {
            VocabularyMode_Accessor target = new VocabularyMode_Accessor(); // TODO: 初始化為適當值
            target._correct = 5;
            target._numberOfQuestion = 20;
            target.CalculateScore();
            Assert.AreEqual((double)5 / (double)20 * (double)100, target._score);
            target._correct = 1;
            target._numberOfQuestion = 3;
            target.CalculateScore();
            Assert.AreEqual((double)1 / (double)3 * (double)100, target._score);
        }


        /// <summary>
        ///CreatNewSelectionQuestion 的測試
        ///</summary>
        [TestMethod()]
        public void CreatNewSelectionQuestionTest()
        {
            VocabularyMode_Accessor target = new VocabularyMode_Accessor(); // TODO: 初始化為適當值
            Dictionary dictionary = new Dictionary();
            target.Initialize();
            List<string> actual;
            dictionary.LoadWords("dictionary2000.txt");
            actual = target.CreateNewSelectionQuestion();
            if (target._selectionQuestion.IsChineseSelection)
            {
                for (int i = 0; i < 4; i++)
                    Assert.AreEqual(true, actual.Contains(dictionary.GetWord(target._selectionQuestion.Selection[i]).Chinese));
            }
            else
            {
                for (int i = 0; i < 4; i++)
                    Assert.AreEqual(true, actual.Contains(dictionary.GetWord(target._selectionQuestion.Selection[i]).English));

            }
        }

        /// <summary>
        ///GetCurrect 的測試
        ///</summary>
        [TestMethod()]
        public void GetCurrectTest()
        {
            VocabularyMode_Accessor target = new VocabularyMode_Accessor(); // TODO: 初始化為適當值
            int expected = 5; // TODO: 初始化為適當值\
            target._correct = 5;
            int actual;
            actual = target.NumberOfCorrect;
            Assert.AreEqual(expected, actual);
        }



        /// <summary>
        ///IsFillQuestion 的測試
        ///</summary>
        [TestMethod()]
        public void IsFillQuestionTest()
        {
            VocabularyMode_Accessor target = new VocabularyMode_Accessor(); // TODO: 初始化為適當值
            bool expected = false; // TODO: 初始化為適當值
            bool actual;
            target._isFillQuestion = false;
            actual = target.IsFillQuestion;
            Assert.AreEqual(expected, actual);
            target._isFillQuestion = true;
            actual = target.IsFillQuestion;
            Assert.AreEqual(true, actual);
        }

        /// <summary>
        ///GetNewFillQuestion 的測試
        ///</summary>
        [TestMethod()]
        public void GetNewFillQuestionTest()
        {
            VocabularyMode_Accessor target = new VocabularyMode_Accessor(); // TODO: 初始化為適當值
            target.Initialize();
            string actual;
            actual = target.GetNewFillQuestion();
            string expected = target._fillQuestion.QuestionStatement;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///GetNumberOfAnswered 的測試
        ///</summary>
        [TestMethod()]
        public void GetNumberOfAnsweredTest()
        {
            VocabularyMode_Accessor target = new VocabularyMode_Accessor(); // TODO: 初始化為適當值
            int expected = 0; // TODO: 初始化為適當值
            int actual;
            target.Initialize();
            actual = target.NumberOfAnswered;
            Assert.AreEqual(expected, actual);
            target._isFillQuestion = false;
            target.GetNewFillQuestion();
            target.CheckAnswer("HAHA",0);
            actual = target.NumberOfAnswered;
            Assert.AreEqual(1, actual);
            target.CreateNewSelectionQuestion();
            target.CheckAnswer("NONO",0);
            actual = target.NumberOfAnswered;
            Assert.AreEqual(2, actual);
        }

        /// <summary>
        ///CheckAnswer 的測試
        ///</summary>
        [TestMethod()]
        public void CheckAnswerTest()
        {
            VocabularyMode_Accessor target = new VocabularyMode_Accessor(); // TODO: 初始化為適當值
            string actual;
            target.Initialize();
            target._isFillQuestion = true;
            target.GetNewFillQuestion();
            actual = target.CheckAnswer(target._fillQuestion.Answer,0);
            Assert.AreEqual("Correct!!", actual);
            target.GetNewFillQuestion();
            actual = target.CheckAnswer("AlwaysFail",0);
            Assert.AreEqual("It should be " + target._fillQuestion.Answer, actual);
            target._isFillQuestion = false;
            target.CreateNewSelectionQuestion();
            actual = target.CheckAnswer("",target._selectionAnswer);
            Assert.AreEqual("Correct!!", actual);
            target.CreateNewSelectionQuestion();
            actual = target.CheckAnswer("AlwaysFail",0);
            Assert.AreEqual("It should be " + "(" + target._selectionAnswer.ToString() + ") " + target._selectionQuestion.Answer, actual);
        }

        /// <summary>
        ///CreatQuestionType 的測試
        ///</summary>
        [TestMethod()]
        public void CreatQuestionTypeTest()
        {
            VocabularyMode_Accessor target = new VocabularyMode_Accessor(); // TODO: 初始化為適當值
            target.Initialize();
            target.QuestionType = 0;
            target.CreateQuestionType();
            Assert.AreEqual(true, target._isFillQuestion);
            target.QuestionType = 1;
            target.CreateQuestionType();
            Assert.AreEqual(false, target._isFillQuestion);
            target.QuestionType = 2;
            target.CreateQuestionType();
            Assert.AreEqual(target.IsFillQuestion, target._isFillQuestion);
        }

        /// <summary>
        ///GetNumberOfVocabulary 的測試
        ///</summary>
        [TestMethod()]
        public void GetNumberOfVocabularyTest()
        {
            VocabularyMode target = new VocabularyMode(); // TODO: 初始化為適當值
            int expected = 2074; // TODO: 初始化為適當值
            target.Initialize();
            int actual;
            actual = target.NumberOfVocabulary;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///GetScore 的測試
        ///</summary>
        [TestMethod()]
        public void GetScoreTest()
        {
            VocabularyMode_Accessor target = new VocabularyMode_Accessor(); // TODO: 初始化為適當值
            target._correct = 20;
            target._numberOfQuestion = 25;
            target.CalculateScore();
            double expected = target._score;
            double actual;
            actual = target.Score;
            Assert.AreEqual(expected, actual);
        }



        /// <summary>
        ///Initialize 的測試
        ///</summary>
        [TestMethod()]
        public void InitializeTest()
        {
            VocabularyMode_Accessor target = new VocabularyMode_Accessor(); // TODO: 初始化為適當值
            target.Initialize();
            target.CreateNewSelectionQuestion();
            target._isFillQuestion = false;
            target.CheckAnswer("HAHA",0);
            target.Initialize();
            Assert.AreEqual(0, target._numberOfAnswer);
            Assert.AreEqual(0, target._correct);
            Assert.AreEqual(true, target._isFillQuestion);
        }

        /// <summary>
        ///IsEndOfQuestion 的測試
        ///</summary>
        [TestMethod()]
        public void IsEndOfQuestionTest()
        {
            VocabularyMode_Accessor target = new VocabularyMode_Accessor(); // TODO: 初始化為適當值
            bool expected = false; // TODO: 初始化為適當值
            bool actual;
            target.NumberOfQuestion = 10;
            target._numberOfAnswer = 5;
            actual = target.IsEndOfQuestion;
            Assert.AreEqual(expected, actual);
            target.NumberOfQuestion = 10;
            target._numberOfAnswer = 10;
            actual = target.IsEndOfQuestion;
            Assert.AreEqual(true, actual);
        }

        /// <summary>
        ///NumberOfQuestion 的測試
        ///</summary>
        [TestMethod()]
        public void NumberOfQuestionTest()
        {
            VocabularyMode_Accessor target = new VocabularyMode_Accessor(); // TODO: 初始化為適當值
            int expected = 10; // TODO: 初始化為適當值
            int actual;
            target._numberOfQuestion = 10;
            target.NumberOfQuestion = expected;
            actual = target.NumberOfQuestion;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///AddOneSecond 的測試
        ///</summary>
        [TestMethod()]
        public void AddOneSecondTest()
        {
            VocabularyMode_Accessor target = new VocabularyMode_Accessor(); // TODO: 初始化為適當值
            target.RestTimer();
            target.AddOneSecond();
            Assert.AreEqual(target._second, 1);
            Assert.AreEqual(target._minute, 0);
            Assert.AreEqual(target._hour, 0);
            Assert.AreEqual(target.TimeText, "00:00:01");
            target.RestTimer();
            for (int i = 0; i < 61; i++)
                target.AddOneSecond();
            Assert.AreEqual(target._second, 1);
            Assert.AreEqual(target._minute, 1);
            Assert.AreEqual(target._hour, 0);
            Assert.AreEqual(target.TimeText, "00:01:01");
            target.RestTimer();
            for (int i = 0; i < 3743; i++)
                target.AddOneSecond();
            Assert.AreEqual(23,target._second);
            Assert.AreEqual(2, target._minute);
            Assert.AreEqual(1,target._hour);
            Assert.AreEqual(target.TimeText, "01:02:23");

        }

        /// <summary>
        ///SpeechSelectionQuestion 的測試
        ///</summary>
        [TestMethod()]
        public void SpeechSelectionQuestionTest()
        {
            VocabularyMode target = new VocabularyMode(); // TODO: 初始化為適當值
            target.Initialize();
            target.CreateNewSelectionQuestion();
            target.SpeechSelectionQuestion();
        }

        /// <summary>
        ///RestTimer 的測試
        ///</summary>
        [TestMethod()]
        public void RestTimerTest()
        {
            VocabularyMode target = new VocabularyMode(); // TODO: 初始化為適當值
            for(int i =0;i<4324;i++)
                target.AddOneSecond();
            target.RestTimer();
            Assert.AreEqual("00:00:00", target.TimeText);
        }
    }
}
