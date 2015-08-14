using VocabularyTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject
{
    
    
    /// <summary>
    ///這是 WordTest 的測試類別，應該包含
    ///所有 WordTest 單元測試
    ///</summary>
    [TestClass()]
    public class WordTest
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
        ///Word 建構函式 的測試
        ///</summary>
        [TestMethod()]
        public void WordConstructorTest()
        {
            string english = "Happy Dragon"; // TODO: 初始化為適當值
            string chinese = "快樂龍"; // TODO: 初始化為適當值
            Word target = new Word(english, chinese);
            Assert.AreEqual("Happy Dragon", target.English);
            Assert.AreEqual("快樂龍", target.Chinese);
        }

        /// <summary>
        ///GetChinese 的測試
        ///</summary>
        [TestMethod()]
        public void GetChineseTest()
        {
            string english = "Happy"; // TODO: 初始化為適當值
            string chinese = "快樂"; // TODO: 初始化為適當值
            Word target = new Word(english, chinese); // TODO: 初始化為適當值
            string expected = "快樂"; // TODO: 初始化為適當值
            string actual;
            actual = target.Chinese;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///GetEnglish 的測試
        ///</summary>
        [TestMethod()]
        public void GetEnglishTest()
        {
            string english = "Cat"; // TODO: 初始化為適當值
            string chinese = "貓"; // TODO: 初始化為適當值
            Word target = new Word(english, chinese); // TODO: 初始化為適當值
            string expected = "Cat"; // TODO: 初始化為適當值
            string actual;
            actual = target.English;
            Assert.AreEqual(expected, actual);;
        }
    }
}
