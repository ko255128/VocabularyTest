using VocabularyTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
namespace TestProject
{
    
    
    /// <summary>
    ///這是 RandomValueTest 的測試類別，應該包含
    ///所有 RandomValueTest 單元測試
    ///</summary>
    [TestClass()]
    public class RandomValueTest
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
        ///CreateRandomBool 的測試
        ///</summary>
        [TestMethod()]
        public void CreateRandomBoolTest()
        {
            RandomValue target = new RandomValue(); // TODO: 初始化為適當值
            List<bool> temp = new List<bool>();
            for (int i = 0; i < 200; i++)
            {
                temp.Add(target.CreateRandomBool());
            }
            Assert.AreEqual(true, temp.Contains(true)&&temp.Contains(false));
        }

        /// <summary>
        ///CreateRandomValue 的測試
        ///</summary>
        [TestMethod()]
        public void CreateRandomValueTest()
        {
            RandomValue target = new RandomValue(); // TODO: 初始化為適當值
            List<int> temp = new List<int>();
            for(int i =0 ;i<10000;i++)
            {
                temp.Add(target.CreateRandomValue(0, 100));
            }
            for(int i=0; i<100;i++)
                Assert.AreEqual(true, temp.Contains(i));
        }
    }
}
