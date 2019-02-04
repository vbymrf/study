using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{


    /// <summary>
    ///  2. Разработать статический класс ​Message​, содержащий следующие статические методы для
    /// обработки текста: 
    /// </summary>

    static class Messaga
    {
        /// <summary>
        /// а) Вывести только те слова сообщения,  которые содержат не более n букв.
        /// </summary>
        /// <param name="mes"> сообщение</param>
        /// <param name="n">количество букв</param>
        /// <returns></returns>
        static void ToStringNumber(string mes, int n)
        {
            string[] word = mes.Split(new char[] { ' ' });
            foreach (string w in word)
            {
                if (w.Length < n) Console.WriteLine(w);
            }
        }
        /// <summary>
        /// б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
        /// </summary>
        /// <param name="mes"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        static string DeletWordSimbol(string mes, int n)
        {
            string[] word = mes.Split(new char[] { ' ' });
            foreach (string w in word)
            {
                if (w.Length < n) Console.WriteLine(w);
            }
            return word[0];

        }


    }
    //
    //
    //в) Найти самое длинное слово сообщения.
    //г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
    //д) ***Создать метод, который производит частотный анализ текста.В качестве параметра в
    //него передается массив слов и текст, в качестве результата метод возвращает сколько раз
    //каждое из слов массива входит в этот текст.Здесь требуется использовать класс Dictionary.
}
