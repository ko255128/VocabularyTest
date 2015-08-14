using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VocabularyTest
{
    public class Word //單字類別
    {
        private string _english; //英文
        private string _chinese; //中文
        public Word(String english, String chinese) //建構元
        {
            _english = english;  //存入英文
            _chinese = chinese;  //存入中文
        }

        public string Chinese //取得英文
        {
            get
            {
                return _chinese;
            }
        }

        public string English //取得中文
        {
            get
            {
                return _english;
            }
        }
    }
}