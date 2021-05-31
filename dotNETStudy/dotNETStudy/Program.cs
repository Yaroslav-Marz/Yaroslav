using System;

namespace dotNETStudy
{
    class Program
    {
        static int SumCalculeted(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
        static void Main(string[] args)
        {
            int result = SumCalculeted(10, 569);
            Console.WriteLine(result);
        }
    }
}
