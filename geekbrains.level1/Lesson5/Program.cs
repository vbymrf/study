using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Lesson5
{
    class Program
    {
        /// <summary>
        ///  1/ Создать программу, которая будет проверять корректность ввода логина.Корректным
        ///логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита
        ///или цифры, при этом цифра не может быть первой: 
        ///а) без использования регулярных выражений;
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>

        static bool LogIn(string login)
        {
            if (login == null) return false;

            if (login.Length < 2 || login.Length > 10) return false;
            if (char.IsNumber(login[0])) return false;

            for (int i = 0; i < login.Length; i++)
            {
                if (login[i] < (int)'0' || (login[i] > (int)'9' && login[0] < (int)'A') || (login[i] > (int)'Z' && login[i] < (int)'a')
                || login[i] > (int)'z') return false;
            }
            return true;
        }
        /// <summary>
        ///  1.) б) ** с использованием регулярных выражений.*/
        /// </summary>
        /// <param name="args"></param>
        static bool LogIn2(string login)
        {
            Regex a = new Regex(@"^[a-zA-Z][a-zA-Z\d]{1,9}$");
            if (a.IsMatch(login)) return true;
            else return false;
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Задача 1 Проверка логина ");
            // 1.a В метод  вставлен допустимый логин: 
            Console.WriteLine("Проверка в цикле = " + LogIn("HGgfhj56"));
            // 1.б В метод  вставлен допустимый логин: 
            Console.WriteLine("Проверка регулярным выражением = " + LogIn2("h123456789"));





            Console.ReadKey();
        }
    }
}
