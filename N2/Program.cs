using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2 //Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. Знаки препинания не используются. Составить программу, определяющую является ли строка палиндромом без учёта пробелов и регистра (пример палиндрома – «А роза упала на лапу Азора»).
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = str1.Replace(" ","");
            //string [] strArray1 = str2.Split();
            string str3 = "";
            foreach (char c in str2)  //char - символ
            {
                str3 = c + str3;
            }
            string.Compare(str2, str3, true);
            if (string.Compare(str2, str3, true)==0)
            {
                Console.WriteLine("Строка есть палиндром");
            }
            else
            {
                Console.WriteLine("Строка не есть палиндром");
            }

            //Console.WriteLine(string.Compare(str2, str3, true));
            
            Console.ReadKey();
        }
        
    }
}
