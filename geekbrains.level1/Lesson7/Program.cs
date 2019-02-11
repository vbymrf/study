// Требуется добавить в проект ссылки на на сборки System.Drawing и System.Windows.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lesson7
{
    class PaintEvent
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        //static int n = 0;
        //internal static double NumberFinish2(double geni)
        //{
        //    if (geni <= 2) return 1;
        //    n++;
        //    if ((geni % 2) == 0) n += 0;
        //    else n +=1;
        //    Math.Truncate(NumberFinish2(geni / 2) / 2);
        //    return n;
        //}
        static void Main()
        {
            //Console.WriteLine(NumberFinish2(5));
            //Console.ReadKey();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

}