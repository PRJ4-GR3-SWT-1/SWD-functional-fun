using System;
using System.Linq;

namespace RomertalLib
{
    public class Arabic
    {
        private readonly int ArabicNum;
        public Arabic(int arabicNumIn)
        {
            ArabicNum = arabicNumIn;
        }

        public string ToRoman()
        {
            var result = new String("");
            int tal = ArabicNum;
            while (tal / 1000 > 0)
            {
                result += "M";
                tal -= 1000;
            }
            while (tal / 100 > 0)
            {
                result += "C";
                tal -= 100;
            }
            while (tal /50  > 0)
            {
                result += "L";
                tal -= 50;
            }
            while (tal / 10 > 0)
            {
                result += "X";
                tal -= 10;
            }

            //while (tal%5>0)
            //{
            //    result += "I";
            //    tal--;
            //}
            while (tal / 5 > 0)
            {
                result += "V";
                tal -= 5;
            }
            while (tal > 0)
            {
                result+="I";
                tal--;
            }

            
            return result;
        }
    }
}
