using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Каждое задание в своем методе
namespace ZinchenkoEV_Lesson1
{
    class Program
    {
        public static string del = "\n>>>>>>>>>>>>>>>>\n";
        public static string U1 = @" 
1) Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст,                  
  рост, вес). В результате вся информация выводится в одну строчку: 
  а) используя  склеивание; 
  б) используя форматированный вывод; 
  в) используя вывод со знаком $. ";

        public static void u1()
        {
            string f,v,r;
            int w;
            Console.WriteLine(U1+del);
            Console.WriteLine("Укажите Имя и фамилию");
               f = Console.ReadLine();
               Console.WriteLine("Укажите возраст");
               v = Console.ReadLine();
               Console.WriteLine("Укажите рост");
               r = Console.ReadLine();
               Console.WriteLine("Укажите вес");
               w =Convert.ToInt32( Console.ReadLine());
               Console.WriteLine(del+"a) "+f + " " + v + " " + r + " " + w);
               Console.WriteLine("б и в) {0} {1} {2} {3:C}",f,v,r,w); // У меня выдает рубль, вместо доллара
        }
        public static string U2 = @"
2). Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле                            
I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах. ";
        public static void u2()
        {
            Console.WriteLine(U2+del);
            double m, h;
            Console.WriteLine("Укажите Ваш вес");
            m = double.Parse(Console.ReadLine());
            Console.WriteLine("Укажите Ваш рост");
            h = double.Parse(Console.ReadLine());
            Console.WriteLine(del+"Индекс массы равен {0:F}", m / (h * h));
        }

        public static string U3 = @"
3. а) Написать программу, которая подсчитывает расстояние между точками с координатами x1,                      
y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат,                
используя спецификатор формата .2f (с двумя знаками после запятой); 
б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде                      
метода. ";
        public static void u3(){
            Console.WriteLine(U3 + del);
            Console.WriteLine("Расстояние между точками равно: {0:F2}", length(2, 3, 4, 5));
    }

        private static double length(double x1, double x2, double y1, double y2)
        {
           return Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
        }

        public static string U4 = @"
4.) Написать программу обмена значениями двух переменных: 
а) с использованием третьей переменной; 
б) *без использования третьей переменной. ";
        public static void u4()
        {
            Console.WriteLine(U4 + del);
            Console.WriteLine(@" Есть два способа
1) Арифметический 
a=a+b;
b=a-b;
a=a-b;
2) Побитовый
a=a^b;
b=b^a;
a=a^b;
");
        }
            public static string U5=@"
5. а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания. 
б) *Сделать задание, только вывод организовать в центре экрана. 
в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int                        
x,int y). ";
            public static void u5()
            {
                Console.WriteLine(U5 + del);
                string data = "Зинченко Евгений Владимирович город Москва";
                int x, y;
                Console.WriteLine("Укажите отступ по Х");
                x = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Укажите отступ по Y");
                y = Int32.Parse(Console.ReadLine());
                Print(data, x, y);
            }

            private static void Print(string data, int x, int y)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine(data);
            }
            
            
        static void Main(string[] args) // Меню выбора задания
        {
            int exercise;
            do
            {
                Console.WriteLine(del + "Укажите номер задачи от 1 до 5, или 0 прервать программу и посмотреть код"+del);
                exercise = Convert.ToInt32(Console.ReadLine());
                switch (exercise)
                {
                    case 1: u1() ; break;
                    case 2: u2(); break;
                    case 3: u3(); break;
                    case 4: u4(); break;
                    case 5: u5(); break;
                        // Шестая см ниже класс
                  

                }
            } while (exercise != 0);
      
        
        }
    }
//   6.) *Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause). 
    class Studu
    {
        public static void Print(string message)
        {
            Console.WriteLine(message);
        }
        public static void Pause()
        {
            Console.ReadKey();
        }
    }


}
