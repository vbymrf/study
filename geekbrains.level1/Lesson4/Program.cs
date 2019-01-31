using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class Program
    {
    /*    1. Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые                      
значения от –10 000 до 10 000 включительно. Заполнить случайными числами. Написать                        
программу, позволяющую найти и вывести количество пар элементов массива, в которых только                        
одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих                            
элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.  
     * */
        public  int[] mas;
        public  int Para()
        {
            int n=0;
            mas=Mas(20,-10000,10000);
            for (int i = 1; i < mas.Length; i++)
            {
                if (mas[i] % 3 == 0 || mas[i - 1] % 3 == 0) n++;
            }                
                return n;
        }
        public int[] Mas(int lengthMas, int min, int max)
        {
            int[] mas = new int[lengthMas];
            Random r = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = r.Next(min, max);
            }
                return mas;            
        }
        public static void PrintMas(int[] mas)
        {
            if (mas != null)
            {
                for (int i = 0; i < mas.Length; i++)
                    Console.Write("[{0}]={1};\t", i, mas[i]);
            }
        }
        static void Main(string[] args)
        {
            // Задача 1
            Console.WriteLine("Задача 1");
            Program pr=new Program();            
            Console.WriteLine(pr.Para());
            PrintMas(pr.mas);
            
            // Задача 2
            // Создан класс для нее StaticClass
            Console.WriteLine("Задача 2");
            int[] maC=StaticClass.FileArray("mas.txt");
            try
            {
                PrintMas(maC);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

              
            Console.ReadKey();
            
        }
    }
}
