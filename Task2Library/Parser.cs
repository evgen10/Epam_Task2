using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Library
{
    public class Parser
    {
        //значение нуля в unicode
        private const int zeroInUnicode = 48;

        //коллекция найденных цифр в строке
        private List<int> intNumbers;


        public int ParseStringToInt(string num)
        {
            intNumbers = new List<int>();
            if (num == string.Empty || num == null)
            {
                throw new ArgumentNullException("The string is empty or null");
            }

            GetNumeralsList(num);

            return GetNumber();
        }



        private void GetNumeralsList(string num)
        {
            //флаг показывает что число было найдено
            bool numberFound = false;
            //флаг показывает что пробел был найден
            bool spaceFound = false;


            for (int i = 0; i < num.Length; i++)
            {
                //если символ является цифрой
                if (IsNumeral(num[i]))
                {
                    //если было найдено число после другого числа и пробела вида "35  4"
                    if (numberFound && spaceFound)
                    {
                        throw new FormatException();
                    }


                    int tempNum = num[i] - zeroInUnicode;

                    intNumbers.Add(tempNum);

                    numberFound = true;
                    spaceFound = false;            
                   

                }
                else if (num[i] == ' ')
                {
                    spaceFound = true;                
                    continue;
                }                
                else
                {
                    throw new FormatException();
                }

            }
        }

        private int GetNumber()
        {
            //разряд числа
            int digit = intNumbers.Count - 1;

            int totalNumber = 0;

            
            if (intNumbers.Count == 0)
            {
                throw new FormatException();
            }

            for (int i = 0; i < intNumbers.Count; digit--, i++)
            {
                checked
                {
                    totalNumber += intNumbers[i] * (int)Math.Pow(10, digit);
                }
            }

            return totalNumber;
        }


        private bool IsNumeral(char symbol)
        {
            return symbol >= '0' && symbol <= '9';
        }

    }
}
