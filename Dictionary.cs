using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace VocabularyTest
{
    public class Dictionary  //字典類別
    {
        private List<Word> _vocabulary = new List<Word>();
        private bool _isLoadWords = false;
        public void LoadWords(string fileName)
        {
            if (_isLoadWords)
                return;
            else
                _isLoadWords = true;
            const string EMPTY_LINE = "";//空白行
            StreamReader file = new StreamReader(fileName, Encoding.Default);
            while (!file.EndOfStream)//讀檔直到結尾處
            {
                string line = file.ReadLine();//讀入一行
                if (line.Equals(EMPTY_LINE)) // 空白行不做任和處理
                    continue;
                else
                {
                    string[] splitResult = SplitLine(line);//分割字串
                    _vocabulary.Add(new Word(splitResult[0], splitResult[1]));//將分割的字串 轉存成字典的詞彙
                }
            }
        }

        private bool IgnoreSpectiveWords(string vocabulary)// 忽略字詞 是忽略詞 回傳 true 反之回傳false
        {
            const string IGNORE_BLANK = " ";  //忽略的空白
            const string IGNORE_FIRST_WORD = " 基本1"; //第一忽略詞
            const string IGNORE_SECOND_WORD = " 基本2";//第二個忽略詞
            const string IGNORE_NUMBER_ZERO = "0"; //忽略數字0
            const string LETTER_SMALL_A = "a"; //小寫a
            if (vocabulary.Contains(IGNORE_FIRST_WORD) || vocabulary.Contains(IGNORE_SECOND_WORD)) //忽略詞彙:包含有"基本1"、"基本2"
                return true;
            else if (vocabulary == IGNORE_BLANK)//忽略空白
                return true;
            else if (vocabulary.CompareTo(IGNORE_NUMBER_ZERO) >= 0 && vocabulary.CompareTo(LETTER_SMALL_A) < 0)//忽略數字
                return true;
            else
                return false;
        }

        private string[] SplitLine(string line)
        {
            const int MAX_ARRAY_ADDRESS = 2;  //最大陣列儲存數
            const string DOUBLE_BLANK = "  "; //雙空白
            string[] stringSparators = new string[] { DOUBLE_BLANK };//分割依據(兩個空白)
            string[] result = new string[MAX_ARRAY_ADDRESS];//回傳字串陣列(分 中英文 固只有兩個)
            int index = 0;//索引值
            foreach (string words in line.Split(stringSparators, StringSplitOptions.RemoveEmptyEntries))//分割字串並且檢視每個分割詞彙
            {
                if (!IgnoreSpectiveWords(words))//若非忽略字詞
                {
                    result[index] = words;  //存入字彙
                    index++;//索引值+1
                    if (index == MAX_ARRAY_ADDRESS)
                        break;
                }
            }
            return result;//回傳
        }

        public int NumberOfVocabulary//取得字彙數量
        {
            get
            {
                return _vocabulary.Count();//回傳字彙數量
            }
        }

        public Word GetWord(int index)//取得指定字彙
        {
            return _vocabulary[index];//回傳字彙
        }
    }
}
