using System;
Class Point
{
    int x;
    int y;
    Point(int a, int b)
    {
        X = a;
        y = b;
    }
    public void print()
    {
        System.console.writeLine( x + ',' + y);
    }

}
Point P = new Point(10,20);

P.print();