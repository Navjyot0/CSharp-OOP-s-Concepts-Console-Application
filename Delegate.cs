using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPs
{
    delegate void Area(int length, int width);
    delegate int Perimeter(int length, int width);
    delegate bool IsSquare(int length, int width);

    class Delegate
    {
        private void Area(int lenght, int width)
        {
            Console.WriteLine("Area : " + (lenght * width));
        }
        private int Perimeter(int length, int width)
        {
            return length + width;
        }
        private bool IsSquare(int length, int width)
        {
            if (length == width)
                return true;
            return false;
        }
        static void Main()
        {
            Delegate D1 = new Delegate();
            Area delArea = D1.Area;
            Perimeter delPerimeter = D1.Perimeter;
            IsSquare delIsSquare = D1.IsSquare;

            delArea.Invoke(12, 12);
            int P=delPerimeter.Invoke(12, 12);
            Console.WriteLine("Perimeter : " + P);
            bool status = delIsSquare.Invoke(12, 12);
            Console.WriteLine(status);

            Console.ReadKey();
        }
    }
}
