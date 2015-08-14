using VocabularyTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject
{
    
    
    /// <summary>
    ///這是 FillQuestionTest 的測試類別，應該包含
    ///所有 FillQuestionTest 單元測試
    ///</summary>
    [TestClass()]
    public class FillQuestionTest
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
///AddBaseLineToQuestionStatement 的測試
///</summary>
[TestMethod()]
[DeploymentItem("VocabularyTest.exe")]
public void AddBaseLineToQuestionStatementTest()
{
FillQuestion_Accessor target = new FillQuestion_Accessor(); // TODO: 初始化為適當值
int numberOfBaseLine = 5; // TODO: 初始化為適當值
    target.AddBaseLineToQuestionStatement(numberOfBaseLine);
    Assert.AreEqual(" _  _  _  _  _ ", target.QuestionStatement);
}

/// <summary>
///AddEnglishTipToQuetionStatement 的測試
///</summary>
[TestMethod()]
[DeploymentItem("VocabularyTest.exe")]
public void AddEnglishTipToQuetionStatementTest()
{
FillQuestion_Accessor target = new FillQuestion_Accessor(); // TODO: 初始化為適當值
int tipIndex = 3; // TODO: 初始化為適當值
target._testedVocabulary = new Word("Test", "測試");
    target.AddEnglishTipToQuetionStatement(tipIndex);
    Assert.AreEqual("T _  _ t(4)", target._questionStatement);
    target.Initialize();
    target._testedVocabulary = new Word("a", "一個");
    target.AddEnglishTipToQuetionStatement(2);
    Assert.AreEqual(" _ (1)", target._questionStatement);
    target.Initialize();
    target._testedVocabulary = new Word("AM", "上午");
    target.AddEnglishTipToQuetionStatement(1);
    Assert.AreEqual("A _ (2)", target._questionStatement);
}

/// <summary>
///CreateNewQuestion 的測試
///</summary>
[TestMethod()]
public void CreateNewQuestionTest()
{
    Dictionary dictionary = new Dictionary();
    FillQuestion_Accessor target = new FillQuestion_Accessor(dictionary); // TODO: 初始化為適當值
    dictionary.LoadWords("dictionary2000.txt");
    target.CreateNewQuestion();
    string first = target.QuestionStatement;
    target.CreateNewQuestion();
    string second = target.QuestionStatement;
    Assert.AreNotEqual(first, second);
    Assert.AreEqual(2, target._isTestedIndex.Count);
}

/// <summary>
///GetAnswer 的測試
///</summary>
[TestMethod()]
public void GetAnswerTest()
{
 FillQuestion_Accessor target = new FillQuestion_Accessor(); // TODO: 初始化為適當值
 Assert.AreEqual(string.Empty, target.Answer);
 target._testedVocabulary = new Word("Balance", "平衡");
  string expected ="Balance"; // TODO: 初始化為適當值
    string actual;
    actual = target.Answer;
    Assert.AreEqual(expected, actual);
}

/// <summary>
///GetQuestionStatement 的測試
///</summary>
[TestMethod()]
public void GetQuestionStatementTest()
{
 FillQuestion_Accessor target = new FillQuestion_Accessor(); // TODO: 初始化為適當值
 target._testedVocabulary = new Word("Balance", "平衡");
string expected = "平衡     B _  _ a _  _  _ (7)"; // TODO: 初始化為適當值
    string actual;
    target._questionStatement = target._testedVocabulary.Chinese + "     ";
    target.AddEnglishTipToQuetionStatement(3);
    actual = target.QuestionStatement;
    Assert.AreEqual(expected, actual);;
}

/// <summary>
///Initialize 的測試
///</summary>
[TestMethod()]
public void InitializeTest()
{
FillQuestion_Accessor target = new FillQuestion_Accessor();
    target.Initialize();
    Assert.AreEqual("",target._questionStatement);
    Assert.AreEqual(0, target._isTestedIndex.Count);
}
    }
}
