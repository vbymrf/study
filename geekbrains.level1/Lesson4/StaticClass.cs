using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
   /* 2. Реализуйте задачу 1 в виде статического класса StaticClass; 
а) Класс должен содержать статический метод, который принимает на вход массив и решает                          
задачу 1; 
б) *Добавьте статический метод для считывания массива из текстового файла. Метод должен                        
возвращать массив целых чисел; 
в)**Добавьте обработку ситуации отсутствия файла на диске.*/
    static class StaticClass
    {
        static StreamReader sr;
        public static int Para(int[] mas)
        {
            int n = 0;
            for (int i = 1; i < mas.Length; i++)
            {
                if (mas[i] % 3 == 0 || mas[i - 1] % 3 == 0) n++;
            }
            return n;
        }
        public static int[] FileArray(string f_name)
       {
           int[] mas;
         



           try
           {
               sr = new StreamReader(f_name);
               int LengtF=0;
               while (sr.ReadLine() != null) LengtF++;
               mas = new int[LengtF];
               for (int i = 0; i < LengtF; i++)
               {
                   int n;
                   
                   n=int.Parse(sr.ReadLine());
                   Console.WriteLine(n);
                   //if (int.TryParse(sr.ReadLine(), out mas[i])) throw new Exception("Прочитали не верно. В массиве ["+i+"] записано 0 по умолчанию");
                   //mas[i] = int.Parse(sr.ReadLine());
               }

               sr.Close();

           }
           catch (Exception e)
           {
               Console.WriteLine(e.Message);
               return null;
           }
           
           return mas;
       }
    }
}
