using System;
using System.Globalization;
using System.Runtime.ExceptionServices;
using System.Security;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Homework_for_4th_day
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Task1
            //Verilmiş ədədlər siyahısındaki ədədlərdən ən kiçiyini tapan metod
            //int[] numbers = { 23, 45, 678, 987, 98, 12 };  
            //var minnumber = FindMin(numbers);
            //Console.WriteLine(minnumber);
            #endregion

            #region Task2
            //Verilmiş yazıda verilmiş chardan neçə ədəd olduğunu tapan metod
            //Console.WriteLine("Bir soz daxil edin ");
            //string word =  Console.ReadLine();
            //Console.WriteLine("Bir eded daxil edin");
            //char findChar=Convert.ToChar(Console.ReadLine());
            //var result = CharStr(word, findChar);
            //Console.WriteLine(result);
            #endregion

            #region Task3
            /*Verilmiş ədədlər siyahısında verilmiş ədədin yerləşdiyi indexi tapan metod,*/
            /* əgər həmin ədəd siyahıda yoxdursa - 1 qaytarsın, varsa ilk yerləşdiyi indexi.*/
            //int[] digit = { 34, 56, 345, 11, 9 };
            //var result = IndexOfDigit(digit, 11);
            //Console.WriteLine(result);
            #endregion

            #region Task4
            //Verilmiş yazını əksinə çevirən metod(misalçün metoda "salam" göndərsəniz metod geriyə "malas" return etməlidir)
            //Console.WriteLine("Bir soz daxil edin ");
            //string word = Console.ReadLine();
            //var result = OppositeWord(word);
            //Console.WriteLine(result);
            #endregion

            #region Task5
            ////Verilmiş yazıda rəqəm olub olmadığını tapan metod
            //Console.WriteLine("Bir soz yazin");
            //string word = Console.ReadLine();
            //var result = HasNumber(word);
            //Console.WriteLine(result);
            #endregion
         




        }

            #region Task1
        //static int FindMin(int[] numbers)
        //{
        //    int min = numbers[0];
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        if (numbers[i] < min)
        //            min = numbers[i];
        //    }

        //    return min;
        #endregion

            #region Task2
        //static int CharStr(string word, char cr)
        //{
        //    int count = 0;
        //    for (int i = 0; i < word.Length ; i++)
        //    {
        //        if (word[i] == cr)
        //        {
        //            count++;
        //        }
        //    }return count;
        //}
        #endregion
  
            #region Task3
        //static int IndexOfDigit(int[] digit,int num)
        //{
        //    for (int i = 0; i < digit.Length; i++)
        //    {
        //        if (digit[i] == num)
        //        {
        //            return i;
        //        }
        //    }
        //    return -1;
        //}
        #endregion
  
            #region Task4 
        //static string OppositeWord(string word)
        #endregion

            #region Task5
        //static bool HasNumber(string word)
        //{
        //    char[] number = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        //    for (int e = 0; e < word.Length; e++)
        //    {
        //        for (int i = 0; i < number.Length; i++)
        //        {
        //            if (word[e] == number[i])
        //            {
        //                return true;
        //            }                    
        //        }
        //    }
        //    return false;
        //}
         #endregion
 


    }
}