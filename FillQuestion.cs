using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VocabularyTest
{
    public class FillQuestion
    {
        const string EMPTY = "";  //空白
        const string BASE_LINE = " _ "; //底線
        private string _questionStatement = EMPTY; //題目字串
        protected Word _testedVocabulary; //考題單字
        protected List<int> _isTestedIndex = new List<int>(); //已考過的題庫索引
        protected Dictionary _questionLibrary; //考題庫
        protected RandomValue _randomValue = new RandomValue(); //亂數

        public FillQuestion() //無引數建構元
        {
        }

        public FillQuestion(Dictionary questionLibrary) //建構元
        {
            this._questionLibrary = questionLibrary; //設定題庫
        }

        virtual public void Initialize() //初始化
        {
            _questionStatement = EMPTY;  
            _isTestedIndex.Clear(); //清除已考過的題庫索引
        }

        private void AddBaseLineToQuestionStatement(int numberOfBaseLine)  //加入 NumberOfBaseLine 個 底線
        {
            for (int i = 0; i < numberOfBaseLine; i++)
                _questionStatement = _questionStatement + BASE_LINE;
        }

        private void AddEnglishTipToQuetionStatement(int tipIndex)  //加入英文提示
        {
            const int LENGTH_IS_ONE = 1;   //長度為1
            const int LENGTH_IS_TWO = 2;   //長度為2
            const string RIGHT_BRACKETS = ")"; //左括號
            const string LEFT_BRACKETS = "(";  //又括號
            if (_testedVocabulary.English.Length == LENGTH_IS_ONE)   //若長度為1只顯示底線 
                _questionStatement = _questionStatement + BASE_LINE;
            else
            {
                _questionStatement = _questionStatement + _testedVocabulary.English[0];  //顯示第一個字母
                if (_testedVocabulary.English.Length == LENGTH_IS_TWO)  //若長度為2不顯示任何提示
                    AddBaseLineToQuestionStatement(LENGTH_IS_ONE);
                else   //若長度在2以上 那就會顯示第二個提示
                {
                    AddBaseLineToQuestionStatement(tipIndex - 1);
                    _questionStatement = _questionStatement + _testedVocabulary.English[tipIndex];
                    AddBaseLineToQuestionStatement(_testedVocabulary.English.Length - tipIndex - 1);
                }
            }
            _questionStatement = _questionStatement + LEFT_BRACKETS + _testedVocabulary.English.Length.ToString() + RIGHT_BRACKETS; //加入單字長數
        }

        virtual public void CreateNewQuestion()  //產生填充題
        {
            int testLibraryIndex;  //題庫索引位置
            const string FIVE_BLANK = "     "; //五個空格
            bool continueFlag = true;
            do  //取得新的題庫索引位置(尚未考過的)
            {
                testLibraryIndex = _randomValue.CreateRandomValue(0, _questionLibrary.NumberOfVocabulary);
                if (!_isTestedIndex.Contains(testLibraryIndex))
                {
                    _isTestedIndex.Add(testLibraryIndex);
                    continueFlag = false;
                }
            } while (continueFlag);
            _testedVocabulary = _questionLibrary.GetWord(testLibraryIndex); //根據所以取得單字
            int tipIndex = _randomValue.CreateRandomValue(1, _testedVocabulary.English.Length); //提示索引位置
            _questionStatement = _testedVocabulary.Chinese + FIVE_BLANK;   //將題目字串先加入中文
            AddEnglishTipToQuetionStatement(tipIndex);
        }

        public string QuestionStatement
        {
            get 
            {
                return _questionStatement;
            }
        }

        public virtual string Answer
        {
            get
            {
                if(_testedVocabulary != null)
                    return _testedVocabulary.English;
                return string.Empty;
            }
        }
    }
}
