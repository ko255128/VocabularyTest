using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VocabularyTest
{
    public class SelectionQuestion　: FillQuestion  //選擇題 繼承自 填充題
    {
        List<int> _selection = new List<int>();   //選擇項目索引
        private const string EMPTY = "";  //空白
        private const string BASE_LINE = " _ "; //底線
        private bool _isChineseSelection = false; //如果是true 代表選中文 False 代表選英文
        override public void Initialize() //初始化
        {
            _selection.Clear();  //選項清空
            _isTestedIndex.Clear();//考過項目清空
        }

        public SelectionQuestion(Dictionary questionLibrary) //建構元 
        {
            this._questionLibrary = questionLibrary; //設定題庫
        }

        override public void CreateNewQuestion() //產生新題目
        {
            _selection.Clear();  //清除選項
            int libraryIndex; //題庫索引
            const int NUMBER_OF_SELECTION = 4; //選項數
            do   //取亂數值(此亂數不在考過項目索引內)
            {
                libraryIndex = _randomValue.CreateRandomValue(0, _questionLibrary.NumberOfVocabulary);
            } while (_isTestedIndex.Contains(libraryIndex));
            _isTestedIndex.Add(libraryIndex); //將此索引存入考過項目中
            _selection.Add(libraryIndex);  //將此索引放入選項中
            _testedVocabulary = _questionLibrary.GetWord(libraryIndex); //取得考題單字
            for (int i = 1; i < NUMBER_OF_SELECTION; i++)  // 取得剩下三個選項
            {
                int index; //索引值
                do //取亂數(此亂數不在選項清單中)
                {
                    index = _randomValue.CreateRandomValue(0, _questionLibrary.NumberOfVocabulary);
                } while (_selection.Contains(index));
                _selection.Add(index);//加入選項清單中
            }
            _isChineseSelection = _randomValue.CreateRandomBool(); //隨機決定題型(選中文 或英文)
        }

        public string Question //回傳題目
        {
            get
            {
                return _testedVocabulary.English;
            }
        }

        public override string Answer //回傳答案
        {
            get
            {
                if (_isChineseSelection)
                    return _testedVocabulary.Chinese;
                else
                    return _testedVocabulary.English;
            }
        }

        public List<int> Selection
        {
            get
            {
                return _selection;
            }
        }

        public bool IsChineseSelection
        {
            get
            {
                return _isChineseSelection;
            }
        }
    }
}
