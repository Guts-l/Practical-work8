using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_8_teselko_01._01
{
    internal class Pair : IArithmeticOperations, IComparable
    {
        private double _first;
        private double _second;

        public double First { get; set; }
        public double Second { get; set; }

        public Pair()
        {
            First = 0;
            Second = 0;
        }

        public Pair(double first, double second)
        {
            First = first;
            Second = second;
        }

        public Pair Addition(Pair secondPair)
        {
            return new Pair(First + secondPair.First, Second + secondPair.Second);
        }

        public Pair Subtraction(Pair secondPair)
        {
            return new Pair(First - secondPair.First, Second - secondPair.Second);
        }

        public Pair Multiplication(Pair secondPair)
        {
            return new Pair(First * secondPair.First, Second * secondPair.Second);
        }

        public Pair Division(Pair secondPair)
        {
            return new Pair(First / secondPair.First * 1.0, Second / secondPair.Second * 1.0);
        }

        public int CompareTo(object? obj)
        {
            Pair temp = (Pair) obj;
            if (First + Second == temp.First + temp.Second)
                return 0;
            if (First + Second > temp.First + temp.Second)
                return 1;
            return -1;
        }
    }
}
