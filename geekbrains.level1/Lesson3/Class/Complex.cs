using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.Class
{
   class​ ​Complex
   { 
       //  1.           б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить                      
       //              работу класса. 

       public Complex Minus(Complex x)
       {
           Complex y = new Complex();
           y.im = x.im - im;
           y.re = x.re - re;
           return y;
       }

       public Complex Multi(Complex x)
            {
             Complex y = new Complex();
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }



    ​// Поля приватные. 
    ​private​ ​double​ im; 
    ​// По умолчанию элементы приватные, поэтому private можно не писать. 
    ​double​ re; 
 
    ​// Конструктор без параметров. 
    ​public​ ​Complex​() 
    { 
        im ​=​ ​0; 
        re ​=​ ​0; 
    } 
 
    ​// Конструктор, в котором задаем поля.   
    ​// Специально создадим параметр re, совпадающий с именем поля в классе. 
    ​public​ ​Complex​(​double​ _im​,​ ​double​ re) 
    { 
   ​// Здесь имена не совпадают, и компилятор легко понимает, что чем является. 
        im ​=​ _im; 
        ​// Чтобы показать, что к полю нашего класса присваивается параметр, 
        ​// используется ключевое слово this 
        // Поле ​параметр 
        this.re = re;
    }
     public Complex Plus(Complex x2)
     {
         Complex x3 = new Complex();
         x3.im = x2.im + im;
         x3.re = x2.re + re;
         return x3;
     }
     // Свойства - это механизм доступа к данным класса. 
     public double Im
     {
         get { return im; }
         set
         {
             // Для примера ограничимся только положительными числами. 
             if (value >= 0) im = value;
         }
     }
     // Специальный метод, который возвращает строковое представление данных. 
     public override string ToString()
     {
         return re + "+" + im + "i";
     }
}
   
}
