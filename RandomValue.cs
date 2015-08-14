using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VocabularyTest
{
    public class RandomValue  //產生亂數
    {
        private Random _random = new Random(Guid.NewGuid().GetHashCode()); //宣告亂數
        public int CreateRandomValue(int indexMin, int indexMax)   //產生範圍內隨機數字
        {
            return _random.Next(indexMin, indexMax);
        }

        public bool CreateRandomBool()//隨機產生布林
        {
            const int STATUS = 2;
            if (_random.Next(0, STATUS) == 0)
                return false;
            else
                return true;
        }
    }
}
