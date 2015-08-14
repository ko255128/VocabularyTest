using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpeechLib;

namespace VocabularyTest
{
    public class VocabularyMode 
    {
        private const int SECOND_PER_MINUTE = 60; //每分鐘60秒
        private const int MINUTE_PER_HOUR = 60;   //每小時60分
        private const string FILE_ADDRESS = "dictionary2000.txt"; //字典檔位置
        private int _numberOfQuestion; //總題數
        private int _numberOfAnswer = 0; //已回答題數
        private int _correct = 0; //正確數
        private int _questionType = 0; //考試題型 0:全填充題 1:全選擇題  2:隨機產生填充或選擇題
        private double _score = 0; //得分數
        private int _selectionAnswer; //選擇題正解選項
        private bool _isLoadDictionary = false; //是否已讀取字典黨
        private bool _isFillQuestion = true; //是否為填充題   True 為填充題 False 為選擇題
        static private Dictionary _dictionary = new Dictionary();   //宣告字典
        private FillQuestion _fillQuestion = new FillQuestion(_dictionary);  //宣告是非題
        private SelectionQuestion _selectionQuestion = new SelectionQuestion(_dictionary); //宣告選擇題
        private int _hour = 0;  //小時
        private int _minute = 0;//分
        private int _second = 0;//秒

        public string TimeText //取得TIMLABEL
        {
            get
            {
                const string FORMAT = "D2";
                const string COLON = ":";
                return _hour.ToString(FORMAT) + COLON + _minute.ToString(FORMAT) + COLON + _second.ToString(FORMAT); //回傳時間 (格式 HH/MM/SS)
            }
        }

        public int QuestionType
        {
            set
            {
                _questionType = value;
            }
        }

        public int NumberOfQuestion //設定總題數
        {
            set
            {
                _numberOfQuestion = value;
            }
            get
            {
                return _numberOfQuestion;
            }
        }

        public void Initialize() //初始化
        {

            _numberOfAnswer = 0;
            _correct = 0;
            _score = 0;
            _isFillQuestion = true;
            if (!_isLoadDictionary)  //若尚未讀入字典
            {
                _dictionary.LoadWords(FILE_ADDRESS); //讀入字典黨
                _isLoadDictionary = true;
            }
            _fillQuestion.Initialize();
            _selectionQuestion.Initialize();
        }

        public void AddOneSecond()  //時間增加一秒鐘
        {
            _second++; //時間增加1秒
            if (_second == SECOND_PER_MINUTE) //若秒數等於60 進位到分鐘
            {
                _second = 0;
                _minute++;
            }
            if (_minute == MINUTE_PER_HOUR) //若分鐘等於60 進位到小時
            {
                _minute = 0;
                _hour++;
            }
        }

        public void RestTimer() //時間重製
        {
            _second = 0;
            _minute = 0;
            _hour = 0;
        }

        public string CheckAnswer(string answer, int selectedIndex)  //確認答案
        {
            const string CORRECT = "Correct!!"; //回答正確顯示字串
            const string ANSWER_FAIL = "It should be "; //回答錯誤前段字串
            const string RIGHT_BRACKETS = ")";
            const string LEFT_BRACKETS = "(";
            const string BLANK = " ";
            _numberOfAnswer++;  //回答題數 + 1
            if ((_isFillQuestion && answer == _fillQuestion.Answer) || (!_isFillQuestion && selectedIndex == _selectionAnswer))
            {
                _correct++;
                return CORRECT;
            }
            else
            {
                if (_isFillQuestion)
                    return ANSWER_FAIL + _fillQuestion.Answer;
                else
                    return ANSWER_FAIL + LEFT_BRACKETS + _selectionAnswer.ToString() + RIGHT_BRACKETS + BLANK + _selectionQuestion.Answer;
            }
        }

        public string GetNewFillQuestion()  //取得新填充題
        {
            _isFillQuestion = true;
            _fillQuestion.CreateNewQuestion();  //產生新的填充題
            return _fillQuestion.QuestionStatement; //回傳題目
        }

        public List<string> CreateNewSelectionQuestion()  //產生新的選擇題
        {
            _isFillQuestion = false;
            List<string> selectionString = new List<string>();  //宣告選擇題選項文字
            List<int> selectionIndex; //選擇題選項索引
            _selectionQuestion.CreateNewQuestion(); //產生新的問題
            selectionIndex = _selectionQuestion.Selection; //取得選項索引
            foreach (int ints in selectionIndex) //將索引轉成顯示文字
            {
                if (_selectionQuestion.IsChineseSelection)
                    selectionString.Add(_dictionary.GetWord(ints).Chinese);
                else
                    selectionString.Add(_dictionary.GetWord(ints).English);
            }
            selectionString.Sort(); //因是隨機產生其他選項 所以用排序產生隨機選項位置
            _selectionAnswer = selectionString.IndexOf(_selectionQuestion.Answer) + 1;//設定正解選項位置
            return selectionString;//回傳選項文字
        }

        public void SpeechSelectionQuestion()  //念出選擇題問題
        {
            SpVoice speech = new SpVoice();
            speech.Speak(_selectionQuestion.Question, SpeechVoiceSpeakFlags.SVSFlagsAsync);
        }

        public void CreateQuestionType()  //決定題型
        {
            if (_questionType == 0) //若題型為 0 設定為考填充題
                _isFillQuestion = true;
            else if (_questionType == 1) //若題型為 1 設定為考選擇題
                _isFillQuestion = false;
            else //若都不是 則隨機產生
            {
                RandomValue randomValues = new RandomValue();
                _isFillQuestion = randomValues.CreateRandomBool();
            }
        }

        public bool IsFillQuestion //是否為填充題
        {
            get
            {
                return _isFillQuestion;
            }
        }

        private void CalculateScore() //計算分數
        {
            const double ONE_HUNDRED_PERCENTAGE = 100; //百分之百
            _score = (double)_correct / (double)_numberOfQuestion * ONE_HUNDRED_PERCENTAGE;
        }

        public int NumberOfVocabulary  //單字數
        {
            get
            {
                return _dictionary.NumberOfVocabulary;
            }
        }

        public bool IsEndOfQuestion//判斷是否結束測驗
        {
            get
            {
                if (_numberOfAnswer == _numberOfQuestion)
                    return true;
                else
                    return false;
            }
        }

        public double Score  //取得分數
        {
            get
            {
                CalculateScore();
                return _score;
            }
        }

        public int NumberOfCorrect//取得正確數
        {
            get
            {
                return _correct;
            }
        }

        public int NumberOfAnswered//取得已回答數
        {
            get
            {
                return _numberOfAnswer;
            }
        }

        public int SelectionAnswer //選擇題答案
        {
            get
            {
                return _selectionAnswer;
            }
        }

        public string FillAnswer  //填充題答案
        {
            get
            {
                return _fillQuestion.Answer;
            }
        }

        public string FillQuestion  //填充題題目
        {
            get
            {
                return _fillQuestion.QuestionStatement;
            }
        }
    }
}
