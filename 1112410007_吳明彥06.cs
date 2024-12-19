using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0000
{
    
internal class Program
    {
        //1112410007_吳明彥
        static double CountPi(int n)
        {

            if (n < 4 || n > 15)
            {
                return -1;
            }

            double pi = 0.0;


            for (int i = 0; i <= n; i++)
            {
                pi += Math.Pow(-1, i) / (2 * i + 1);
            }

            return pi * 4;
        }


        static double GetCircumference(double r, int n)
        {
            double pi = CountPi(n);

            if (pi == -1)
            {
                return -1;
            }

            return 2 * pi * r;
        }


        static double GetCircleArea(double r, int n)
        {
            double pi = CountPi(n);

            if (pi == -1)
            {
                return -1;
            }
            return pi * r * r;
        }

        static void Main(string[] args)
        {

            Console.Write("請輸入圓的半徑 (可包含小數點): ");
            if (!double.TryParse(Console.ReadLine(), out double radius) || radius <= 0)
            {

                Console.WriteLine("輸入的半徑無效！");
                return;

            }

            Console.Write("請輸入計算圓周率的精度 n (4 <= n <= 15): ");
            if (!int.TryParse(Console.ReadLine(), out int precision) || precision < 4 || precision > 15)
            {

                Console.WriteLine("輸入的精度無效！");
                return;

            }


            double pi = CountPi(precision);

            if (pi == -1)
            {

                Console.WriteLine("精度輸入錯誤，程式結束！");
                return;

            }

            Console.WriteLine("使用者設定精度 n: {0}", precision);
            Console.WriteLine("計算得到的圓周率 π: {0:g}", pi);

            double circumference = GetCircumference(radius, precision);
            double area = GetCircleArea(radius, precision);

            Console.WriteLine("圓周長: {0}", circumference);
            Console.WriteLine("圓面積: {0}", area);
        }
    }
}

