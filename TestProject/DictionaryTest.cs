using VocabularyTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject
{
    
    
    /// <summary>
    ///這是 DictionaryTest 的測試類別，應該包含
    ///所有 DictionaryTest 單元測試
    ///</summary>
    [TestClass()]
    public class DictionaryTest
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


[TestMethod()]
public void GetNumberOfVocbularyTest()
{
Dictionary target = new Dictionary(); // TODO: 初始化為適當值
target.LoadWords("../../../Dictionary2000.txt");
int expected = 2074; // TODO: 初始化為適當值
    int actual;
    actual = target.NumberOfVocabulary;
    Assert.AreEqual(expected, actual);
}

/// <summary>
///GetWord 的測試
///</summary>
[TestMethod()]
public void GetWordTest()
{
Dictionary target = new Dictionary(); // TODO: 初始化為適當值
target.LoadWords("../../../Dictionary2000.txt");
int index = 34; // TODO: 初始化為適當值
    Word actual;
    actual = target.GetWord(index);
    Assert.AreEqual("[動詞] 同意",actual.Chinese);
    Assert.AreEqual("agree", actual.English);
}

/// <summary>
///IgnoreSpectiveWords 的測試
///</summary>
[TestMethod()]
[DeploymentItem("VocabularyTest.exe")]
public void IgnoreSpectiveWordsTest()
{
Dictionary_Accessor target = new Dictionary_Accessor(); // TODO: 初始化為適當值
    bool actual;
    actual = target.IgnoreSpectiveWords(" ");
    Assert.AreEqual(true, actual);
    actual = target.IgnoreSpectiveWords(" 基本1000");
    Assert.AreEqual(true, actual);
    actual = target.IgnoreSpectiveWords(" 基本2000");
    Assert.AreEqual(true, actual);
    actual = target.IgnoreSpectiveWords("5");
    Assert.AreEqual(true, actual);
    actual = target.IgnoreSpectiveWords("What");
    Assert.AreEqual(false, actual);
}

/// <summary>
///SplitLine 的測試
///</summary>
[TestMethod()]
[DeploymentItem("VocabularyTest.exe")]
public void SplitLineTest()
{
Dictionary_Accessor target = new Dictionary_Accessor(); // TODO: 初始化為適當值
string line = " 基本20  Happy Ribbat  [名詞]快樂兔  1024"; // TODO: 初始化為適當值
string[] expected = {"Happy Ribbat","[名詞]快樂兔"}; // TODO: 初始化為適當值
    string[] actual;
    actual = target.SplitLine(line);
    Assert.AreEqual(expected[0], actual[0]);
    Assert.AreEqual(expected[1], actual[1]);
}
    }
}
