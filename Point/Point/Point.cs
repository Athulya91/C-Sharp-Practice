using System;
namespace PointsAndLines
{
    class Point
    {
        int x;
        int y;

        public Point(int a, int b)
        {
            x = a;
            y = b;
        }
        public void Print() => System.Console.WriteLine(x + "," + y);

    }
}


