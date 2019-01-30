using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Snakemy
{
    class Program
    {
        static void Main(string[] args)
        {

           //Console.SetBufferSize(120, 30);
            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(80, 25);
            Console.SetWindowSize(80, 25);


            HorisontalLine Upline = new HorisontalLine(0,78,0,'+');
            HorisontalLine Downline = new HorisontalLine(0, 78, 24, '+');
            VerticalLine  Leftline = new VerticalLine(0, 24, 0, '+');
            VerticalLine Rightline = new VerticalLine(0, 24, 78, '+');

            Upline.Drow();
            Leftline.Drow();
            Downline.Drow();
            Rightline.Drow();


            Point p = new Point(4, 5, '*');
            Snake snake = new Snake( p, 4, Direction.RIGHT);
            snake.Drow();
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();



            //Console.WriteLine(i);







            Console.ReadLine();


        }
    }
}
