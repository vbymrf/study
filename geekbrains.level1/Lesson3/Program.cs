using System;
using System.Collections;
using System.Threading.Tasks;

namespace Lesson3
{
  
 
    ​class​ ​Program 
    { 
        ​static​ ​void​ ​Main​(​string​[]​ args) 
        {
//1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.                  
//Продемонстрировать работу структуры. 
             
            Struct.Complex complex1; 
            complex1​.​re ​=​ ​1; 
            complex1​.​im ​=​ ​1;  
            ​Struct.Complex complex2; 
            complex2​.​re ​=​ ​2; 
            complex2​.​im ​=​ ​2;
            Console.WriteLine("Структура 1  = " + complex1 + "  ;  Структура 2  =  " + complex2);
            Console.WriteLine("Структура 1 минус структура 2    = " + complex1.Minus(complex2));

//  1.           б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить                      
//              работу класса. 
//               в) Добавить диалог с использованием switch демонстрирующий работу класса. 
            Class.Complex complex3=new Class.Complex(2,4);            
            Class.Complex complex4=new Class.Complex(5,2);
            
            Console.WriteLine("Структура 1  = " + complex3 + "  ;  Структура 2  =  " + complex4);
            Console.WriteLine("Укажите операцию над комплекстными числами: + -  * ");
            string st = Console.ReadLine();
             switch (st) {
                 case "+": Console.WriteLine("Структура 1 плюс структура 2    = " + complex3.Plus(complex4)); break;
                 case "-": Console.WriteLine("Структура 1 минус структура 2    = " + complex3.Minus(complex4)); break;
                 case "*": Console.WriteLine("Структура 1 умножить структура 2    = " + complex3.Multi(complex4)); break;
                 
             }
// 2. а) С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).                              
//Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму                      
//вывести на экран, используя tryParse. 

             string ch;
             int vv,sum=0;
             ArrayList Number=new ArrayList();
             bool flag=true;
             do
             {
                 Console.WriteLine("Введите положительное число , больше нуля:");
                 Number.Add(Console.ReadLine());
                 
                 if (!int.TryParse((string)Number[Number.Count-1], out vv) | vv < 0)
                 {
                     Console.WriteLine("Ввели не правильно");
                     continue;
                 }
                 else if (!int.TryParse((string)Number[Number.Count-1], out vv) | vv == 0)
                 {
                     Console.WriteLine("ввод закончен \n Нечетные числа:");
                     foreach (string str in Number ){
                            int.TryParse(str, out vv);
                         
                         if (vv % 2 != 0)
                         {
                            Console.WriteLine(" "+ vv);
                            sum += vv;
                         }                         
                     }
                        
                     Console.WriteLine("Сумма не четных чисел = "+ sum );
                     flag = false;
                 }

             } while (flag);
                      

             Console.ReadKey();
        }
         
    } 

}
