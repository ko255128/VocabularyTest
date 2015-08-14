using VocabularyTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestProject
{
    
    
    /// <summary>
    ///這是 SelectionQuestionTest 的測試類別，應該包含
    ///所有 SelectionQuestionTest 單元測試
    ///</summary>
    [TestClass()]
    public class SelectionQuestionTest
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
///SelectionQuestion 建構函式 的測試
///</summary>
///CreateNewQuestion 的測試
///</summary>
[TestMethod()]
public void CreateNewQuestionTest()
{
Dictionary questionLibrary = new Dictionary(); // TODO: 初始化為適當值
questionLibrary.LoadWords("dictionary2000.txt");
SelectionQuestion_Accessor target = new SelectionQuestion_Accessor(questionLibrary); // TODO: 初始化為適當值
    target.CreateNewQuestion();
    Word first = target._testedVocabulary;
    Assert.AreEqual(1, target._isTestedIndex.Count);
    Assert.AreEqual(4, target._selection.Count);
    target.CreateNewQuestion();
    Word second = target._testedVocabulary;
    Assert.AreEqual(2, target._isTestedIndex.Count);
    Assert.AreNotEqual(first.English, second.English);
}

/// <summary>
///GetAnswer 的測試
///</summary>
[TestMethod()]
public void GetAnswerTest()
{
Dictionary questionLibrary = new Dictionary(); // TODO: 初始化為適當值
SelectionQuestion_Accessor target = new SelectionQuestion_Accessor(questionLibrary); // TODO: 初始化為適當值
string expected1 = "accept"; // TODO: 初始化為適當值
string expected2 = "[動詞] 接受";
questionLibrary.LoadWords("dictionary2000.txt");
target._testedVocabulary = questionLibrary.GetWord(10);
target._isChineseSelection = false;
    string actual;
    actual = target.Answer;
    Assert.AreEqual(expected1, actual);
    target._isChineseSelection = true;
    actual = target.Answer;
    Assert.AreEqual(expected2, actual);
}

/// <summary>
///GetIsChineseSelection 的測試
///</summary>
[TestMethod()]
public void GetIsChineseSelectionTest()
{
Dictionary questionLibrary = null; // TODO: 初始化為適當值
SelectionQuestion_Accessor target = new SelectionQuestion_Accessor(questionLibrary); // TODO: 初始化為適當值
bool expected = false; // TODO: 初始化為適當值
    bool actual;
    target._isChineseSelection = false;
    actual = target.IsChineseSelection;
    Assert.AreEqual(expected, actual);
    target._isChineseSelection = true;
    expected = true;
    actual = target.IsChineseSelection;
    Assert.AreEqual(expected, actual);
}

/// <summary>
///GetQuestion 的測試
///</summary>
[TestMethod()]
public void GetQuestionTest()
{
Dictionary questionLibrary = new Dictionary(); // TODO: 初始化為適當值
SelectionQuestion_Accessor target = new SelectionQuestion_Accessor(questionLibrary); // TODO: 初始化為適當值
string expected = "accept"; // TODO: 初始化為適當值
questionLibrary.LoadWords("dictionary2000.txt");
target._testedVocabulary = questionLibrary.GetWord(10);
    string actual;
    actual = target.Question;
    Assert.AreEqual(expected, actual);
}

/// <summary>
///GetSelection 的測試
///</summary>
[TestMethod()]
public void SelectionTest()
{
Dictionary questionLibrary = new Dictionary(); // TODO: 初始化為適當值
SelectionQuestion_Accessor target = new SelectionQuestion_Accessor(questionLibrary); // TODO: 初始化為適當值
questionLibrary.LoadWords("dictionary2000.txt");
target.CreateNewQuestion();
    List<int> actual;
    actual = target.Selection;
    Assert.AreEqual(4, actual.Count);
    int index = -1;
    for (int i = 0; i < questionLibrary.NumberOfVocabulary; i++)
    {
        if (questionLibrary.GetWord(i).English == target.Question)
        {
            index = i;
            break;
        }
    }
    Assert.AreEqual(true, target._selection.Contains(index));
    for (int i = 0; i < 3; i++)
    {
        for (int j = i+1; j < 4; j++)
        {
            Assert.AreNotEqual(target._selection[i], target._selection[j]);
        }
    }
}

/// <summary>
///Initialize 的測試
///</summary>
[TestMethod()]
public void InitializeTest()
{
Dictionary questionLibrary = new Dictionary(); // TODO: 初始化為適當值
SelectionQuestion_Accessor target = new SelectionQuestion_Accessor(questionLibrary); // TODO: 初始化為適當值
questionLibrary.LoadWords("dictionary2000.txt");
target.CreateNewQuestion();
    target.Initialize();
    Assert.AreEqual(0,target._selection.Count);
    Assert.AreEqual(0, target._isTestedIndex.Count);
}
    }
}
