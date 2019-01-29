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
            // создаем списки для  x, y, sym
            List<int> newlistx = new List<int>(4) {1,2,3,4 };
            List<int> newlisty = new List<int>(4) {5,6,7,8 };
            List<char> newlistsym = new List<char>(4) {'*','#','$','!'};
            // создаем точки     
            Point p1 = new Point(newlistx[0], newlisty[0], newlistsym[0]);
            Point p2 = new Point(newlistx[1], newlisty[1], newlistsym[1]);
            Point p3 = new Point(newlistx[2], newlisty[2], newlistsym[2]);
            Point p4 = new Point(newlistx[3], newlisty[3], newlistsym[3]);
            // cоздаем список из точек
            List<Point> pList = new List<Point>(4) { p1, p2, p3, p4 };
           
            // создадим переменную сохраняющую сколько раз выполнялся цикл:
            int j = 0;
            // выполняем цикл по всем точкам из списка
            foreach (Point i in pList)
                { 
                i.Draw(); // вызывем функцию Draw для вывода точки на экран
                Console.Write(" точка №" + (j + 1));
                j++; // по окончании выполнения блока кода, увелич j на 1
            }// закончили цикл 



            /*Point p1 = new Point(1, 3, '*');
            p1.Draw();
            Point p2 = new Point(4, 5, '#');
            p2.Draw();
            Point p3 = new Point(5, 6, '$');
            p3.Draw();
            Point p4 = new Point(6, 7, '!');
            p4.Draw();*/



            List<int> newlist =new  List<int>();
            newlist.Add(0);
            newlist.Add(1);
            newlist.Add(2);


            int x = newlist[0];
            int y = newlist[1];
            int z = newlist[2];

            foreach (int i in newlist)
            {
               // Console.WriteLine(i);
            }
            newlist.RemoveAt(0);

            



            Console.ReadLine();


        }
    }
}
