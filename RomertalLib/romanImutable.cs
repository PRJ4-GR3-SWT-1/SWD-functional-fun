using System;
using System.Linq;

namespace RomertalLib
{
    public class ArabicImutable
    {
        private readonly int _arabicNum;
        public ArabicImutable(int arabicNumIn)
        {
            _arabicNum = arabicNumIn;
        }

        public string ToRoman(int input)
        {
            var result = new String("");
            int tal = input;
            while (tal / 1000 > 0)
            {
                result += "M";
                tal -= 1000;
            }
            if (tal > 800)
            {
                while (tal % 1000 > 800)
                {
                    result += "C";
                    tal += 100;
                }

                result += "M";
                tal -= 1000;
            }
            while (tal / 500 > 0)
            {
                result += "D";
                tal -= 500;
            }
            if (tal > 300)
            {
                while (tal % 500 > 300)
                {
                    result += "C";
                    tal += 100;
                }

                result += "D";
                tal -= 500;
            }
            while (tal / 100 > 0)
            {
                result += "C";
                tal -= 100;
            }
            if (tal > 80)
            {
                while (tal % 100 > 80)
                {
                    result += "X";
                    tal += 10;
                }

                result += "C";
                tal -= 100;
            }
            while (tal / 50 > 0)
            {
                result += "L";
                tal -= 50;
            }
            if (tal > 30)
            {
                while (tal % 50 > 30)
                {
                    result += "X";
                    tal += 10;
                }

                result += "L";
                tal -= 50;
            }
            while (tal / 10 > 0)
            {
                result += "X";
                tal -= 10;
            }
            if (tal > 8)
            {
                while (tal % 10 > 8)
                {
                    result += "I";
                    tal += 1;
                }

                result += "X";
                tal -= 10;
            }
            while (tal / 5 > 0)
            {
                result += "V";
                tal -= 5;
            }

            if (tal > 3)
            {
                while (tal % 5 > 3)
                {
                    result += "I";
                    tal++;
                }

                result += "V";
                tal -= 5;
            }

            while (tal > 0)
            {
                result += "I";
                tal--;
            }


            return result;
        }
    }
}
