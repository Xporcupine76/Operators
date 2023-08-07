using System;
using System.ComponentModel.DataAnnotations;

namespace myOperators
{
    class Program
    {
        static void PrintDate()
        {

            Console.WriteLine("today is {0:D}", DateTime.Now);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(6,7));

            PrintDate();
            Console.ReadLine();

            double x = 5, y = 10;
            Swap(ref x, ref y);

            double[] arr = { 5, -1, 4,-5 };
            double max, min;
            summarizeArray(arr,out max, out min);
            Console.WriteLine("max={0}, min={1}", max, min);

            Console.WriteLine("x = {0}, y = {1}", x, y);

            Console.WriteLine("1+2={0}", FindSum(1,2));
            Console.WriteLine("4+5+10={0}", FindSum(4,5,10));


        }
        static int Sum(int a, int b)
        {


            int add = a + b;
            return add;

        }
        static void Swap(ref double x, ref double y)
        {

            double temp = x;
            x= y;
            y = temp;

        }
      static void summarizeArray(double[] arr,out double max, out double min)
        {

            Array.Sort(arr);
            min = arr[0];  
            max = arr[arr.Length-1];

        }
        static double FindSum(params double[] values) 
        {
         double sum = 0;
            foreach(var d in values)
            sum += d;

            return sum;

        
        }

    }
}
