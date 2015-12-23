using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        delegate void PointToFunction(int numberOne, int numberTwo);

        static void Main(string[] args)
        {
            PointToFunction pointToAdd = AddTwoNumber;
            PointToFunction pointToSub = SubstractTwoNumber;
            PointToFunction pointToMul = MulTwoNumber;
            PointToFunction pointToDiv = DivTwoNumber;
            Console.WriteLine("ADD");
            pointToAdd.Invoke(10, 20);
            Console.WriteLine("Sub");
            pointToSub.Invoke(100, 50);
            Console.WriteLine("Mult");
            pointToSub.Invoke(100, 50);
            Console.WriteLine("DIV");
            pointToSub.Invoke(100, 50);
            var result = 20.IsGreaterThan(10); Console.WriteLine(result);  
            Console.Read();
        }

        static void AddTwoNumber(int numberOne, int numberTwo)
        {
            Console.WriteLine((numberOne + numberTwo).ToString());
        }
        static void SubstractTwoNumber(int numberOne, int numberTwo)
        {
            Console.WriteLine((numberOne - numberTwo).ToString());
        }
        static void MulTwoNumber(int numberOne, int numberTwo)
        {
            Console.WriteLine((numberOne * numberTwo).ToString());
        }
        static void DivTwoNumber(int numberOne, int numberTwo)
        {
            Console.WriteLine((numberOne / numberTwo).ToString());
        }
    }

    //Utility Extensions

    public static class UtilExtensions
    {
        public static bool IsGreaterThan<T>(this T x, T y) where T : IComparable<T>
        {
            return (x.CompareTo(y) > 0);
        }
    }

}
