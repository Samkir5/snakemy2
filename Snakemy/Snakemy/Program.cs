﻿using System;
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

           //Console.SetBufferSize(120, 30);
            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(80, 25);
            Console.SetWindowSize(80, 25);


            HorisontalLine Upline = new HorisontalLine(0,78,0,'+');
            HorisontalLine Downline = new HorisontalLine(0, 78, 24, '+');
            VerticalLine  Leftline = new VerticalLine(0, 0, 24, '+');
            VerticalLine Rightline = new VerticalLine(78, 0, 24, '+');

            Upline.Drow();
            Leftline.Drow();
            Downline.Drow();
            Rightline.Drow();


            Point p1 = new Point(4, 5, '*');
            p1.Draw();

            //Console.WriteLine(i);







            Console.ReadLine();


        }
    }
}
