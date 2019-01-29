using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakemy
{
    class Program
    {
        static void Main(string[] args)
        {
            


            Point p1 = new Point(1, 3, '*');
            p1.Draw();
            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HorisontalLine hline1 = new HorisontalLine(5,10,8,'+');
            hline1.Drow();
            VerticalLine vline1 = new VerticalLine(5, 8, 20, '+');
            vline1.Drow();

            //Console.WriteLine(i);







            Console.ReadLine();


        }
    }
}
