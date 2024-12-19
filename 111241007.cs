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
        static void MyHomeWork01()
        {
            Console.WriteLine("執行 MyHomeWork01：");

            int[] intArray = new int[10];
            float[] floatArray = new float[8];
            double[] doubleArray = new double[4];
            string[] stringArray = new string[5];

            int intSum = 0;
            Console.WriteLine("請輸入10個整數：");
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write($"整數[{i}] = ");
                intArray[i] = int.Parse(Console.ReadLine());
                intSum += intArray[i];
            }
            Console.WriteLine("您輸入的整數為：");
            foreach (var item in intArray)
                Console.Write(item + " ");
            Console.WriteLine($"\n整數平均值 = {(double)intSum / intArray.Length}");

            float floatSum = 0;
            Console.WriteLine("\n請輸入8個浮點數：");
            for (int i = 0; i < floatArray.Length; i++)
            {
                Console.Write($"浮點數[{i}] = ");
                floatArray[i] = float.Parse(Console.ReadLine());
                floatSum += floatArray[i];
            }
            Console.WriteLine("您輸入的浮點數為：");
            foreach (var item in floatArray)
                Console.Write(item + " ");
            Console.WriteLine($"\n浮點數平均值 = {floatSum / floatArray.Length}");

            double doubleSum = 0;
            Console.WriteLine("\n請輸入4個倍精確度數：");
            for (int i = 0; i < doubleArray.Length; i++)
            {
                Console.Write($"倍精確度數[{i}] = ");
                doubleArray[i] = double.Parse(Console.ReadLine());
                doubleSum += doubleArray[i];
            }
            Console.WriteLine("您輸入的倍精確度數為：");
            foreach (var item in doubleArray)
                Console.Write(item + " ");
            Console.WriteLine($"\n倍精確度數平均值 = {doubleSum / doubleArray.Length}");

            Console.WriteLine("\n請輸入5個字串：");
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.Write($"字串[{i}] = ");
                stringArray[i] = Console.ReadLine();
            }
            Console.WriteLine("您輸入的字串為：");
            foreach (var item in stringArray)
                Console.Write(item + " ");
            Console.WriteLine();
        }

        // MyHomeWork02: 
        static void MyHomeWork02()
        {
            Console.WriteLine("執行 MyHomeWork02：");

            int[] intArray = { 1, 2, 3, 4, 5 };
            float[] floatArray = { 1.2f, 2.3f, 3.4f, 4.5f, 5.6f };
            double[] doubleArray = { 1.22, 2.33, 3.44, 4.55, 5.66 };
            string[] stringArray = { "王小明", "陳大明", "李小英", "張小美", "陳不良" };

            int intSum = 0;
            Console.WriteLine("整數陣列：");
            foreach (var item in intArray)
            {
                Console.Write(item + " ");
                intSum += item;
            }
            Console.WriteLine($"\n整數平均值 = {(double)intSum / intArray.Length}");

            float floatSum = 0;
            Console.WriteLine("\n浮點數陣列：");
            foreach (var item in floatArray)
            {
                Console.Write(item + " ");
                floatSum += item;
            }
            Console.WriteLine($"\n浮點數平均值 = {floatSum / floatArray.Length}");

            double doubleSum = 0;
            Console.WriteLine("\n倍精確度數陣列：");
            foreach (var item in doubleArray)
            {
                Console.Write(item + " ");
                doubleSum += item;
            }
            Console.WriteLine($"\n倍精確度數平均值 = {doubleSum / doubleArray.Length}");

            Console.WriteLine("\n字串陣列：");
            foreach (var item in stringArray)
                Console.Write(item + " ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("請選擇要執行的功能：");
            Console.WriteLine("1. 執行 MyHomeWork01 ");
            Console.WriteLine("2. 執行 MyHomeWork02 ");
            Console.Write("請輸入選項 (1 或 2): ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                MyHomeWork01();
            }
            else if (choice == "2")
            {
                MyHomeWork02();
            }
            else
            {
                Console.WriteLine("輸入錯誤，請重新執行程式並輸入正確的選項。");
            }
        }
    }
}

