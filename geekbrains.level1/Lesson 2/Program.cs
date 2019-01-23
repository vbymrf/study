using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Lesson_2
{
    class Program
    {
        //1. Написать метод, возвращающий минимальное из трёх чисел. 
        public static int Min(int a,int b,int c){
            if (a <= b)
            {
                if (a <= c) return a;
                else  return c;                
            }
            else
            {
                if (b <= c) return b;
                else return c;  
            }
        }
        //2. Написать метод подсчета количества цифр числа.
        public static int Number(int a)
        {
            int num = 0;
            do
            {
                a = a / 10;
                num++;
            } while (a != 0);
            return num;
        }
        //3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечётных положительных чисел.
        public static void NotEven()
        {
            Console.WriteLine("Введите последовательность чисел, кроме '0'. Ноль завершит ввод");
            int a = int.Parse(Console.ReadLine());
            int ev = 0;
            while (a != 0)
            {
                if (a % 2 != 0) ev+=a;
                Console.WriteLine("Следующее");
                a = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Сумма не четных чисел в последовательности =" + ev);
        }
//        4. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. На                            
//выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password:                          
//GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь                    
//вводит логин и пароль, программа пропускает его дальше или не пропускает. С помощью                          
//цикла do while ограничить ввод пароля тремя попытками. 

        public static bool Validation(string loginV, string passwordV)
        {
            string login = "root";
            string password = "GeekBrains";
            if (login.Equals(loginV) && password.Equals(passwordV))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void Authorization()
        {
           
          string loginV;
          string passwordV;
            int on = 0;
            do
            {
                Console.WriteLine("Введите логин");
                loginV = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                passwordV = Console.ReadLine();
                if (Validation(loginV, passwordV))
                {
                    Console.WriteLine("Вы вошли");
                    break;
                }
                else
                {
                    on++;
                    Console.WriteLine(" Не правильно указан логин или пароль \n Повторите попытку:");
                }
            } while (on<3);
        }
//        5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс                        
//массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме. 

        public static void Mass()
        {
            double m, h,i;
            Console.WriteLine("Введите ваш вес");
            m = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите ваш рост");
            h = double.Parse(Console.ReadLine());
            i=m/(h*h);
            Console.WriteLine("Ваш индекс равен "+i);
            if (i>25) Console.WriteLine("Вам нужно худеть");
            else if(i<18.5) Console.WriteLine("Вам нужно набрать вес");
            else Console.WriteLine("У вас нормальный вес");
//б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса. 
            if (i > 25) Console.WriteLine("Вам нужно худеть на "+ (i-25)*(h*h) + " кг");
            else if (i < 18.5) Console.WriteLine("Вам нужно набрать вес на " + (18.5-i) * (h * h)+" кг");            
        }
//        6. *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000                            
//000. «Хорошим» называется число, которое делится на ​сумму своих цифр​. Реализовать                      
//подсчёт времени выполнения программы, используя структуру DateTime. 
        public static void Good()
        {
            DateTime a = DateTime.Now;            
            int sum=0, su,s;
            for (int i = 1; i < 1000000000; i++)
            {
                s = i;
                su = 0;
                while (true)
                {
                    if (s < 10)
                    {
                        su += s; break;
                    }
                    su += s % 10;
                    s = s / 10;                    
                }
                if (i % su == 0) sum++;
            }
            Console.WriteLine("Количество хороших чисел = " + sum + " \n Затрачено время на поиск = " + (a - DateTime.Now));

        }
//        7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b). 

        public static void RecursionA(int a,int b)
        {
            if (a == b)
            {
                Console.WriteLine(a);
                return;
            }
            Console.WriteLine(a);            
            RecursionA(a + 1, b);
        }
//б) *Разработать рекурсивный метод, который считает сумму чисел от a до b. 
        public static int RecursionB(int a, int b)
        {
            if (a > b) return 0;
            if (a == b) return a;
            return a+RecursionB(a + 1, b);
        }
        static void Main(string[] args)
        {
            Min(1, 2, 3);
            Number(123);
            NotEven();
            Authorization();
            Mass();
            Good();
            RecursionA(1, 6);
            Console.WriteLine(RecursionB(1, 6));
            Console.ReadKey();
        }
    }
}
