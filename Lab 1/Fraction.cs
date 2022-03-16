using System;
using System.Diagnostics.CodeAnalysis;
using System.Collections.Generic;

namespace Lab_1
{
    public class Fraction : IEquatable<Fraction>, IComparable
    {
        private int counter { get; }
        private int denominator { get; }

        ///<summary>
        /// Create default fraction
        ///</summary>
        public Fraction()
        {
            counter = 0;
            denominator = 1;
        }

        /// <summary>
        /// Creates new fraction using two specified numbers
        /// </summary>
        /// <param name="counter"></param>
        /// <param name="denominator"></param>
        public Fraction(int counter, int denominator)
        {
            this.counter = counter;
            this.denominator = denominator;
        }

        /// <summary>
        /// Creates new fraction using another fraction
        /// </summary>
        /// <param name="oldFraction"></param>
        public Fraction(Fraction oldFraction)
        {
            this.counter = oldFraction.GetCounter();
            this.denominator = oldFraction.GetDenominator();
        }

        ///<summary>
        ///Returns fraction as text
        ///</summary>
        public override string ToString()
        {
            return "Counter: " + GetCounter() + "; Denominator: " + GetDenominator();
        }

        ///<summary>
        ///Return counter of fraction
        ///</summary>
        public int GetCounter()
        {
            return counter;
        }

        ///<summary>
        ///Return denominator of fraction
        ///</summary>
        public int GetDenominator()
        {
            return denominator;
        }


        public bool Equals([AllowNull] Fraction other)
        {
            return other.GetCounter() / other.GetDenominator() == GetCounter() / GetDenominator();
        }

        /// <summary>
        /// Returns fraction as decimal number
        /// </summary>
        public float ToDecimals()
        {
            return (float)GetCounter() / (float)GetDenominator();
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Fraction otherFraction = obj as Fraction;
            if(otherFraction != null)
            {
                return ToDecimals().CompareTo(otherFraction.ToDecimals());
            }
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns smallest integral value that is greater or equal to the fraction
        /// </summary>
        /// <returns></returns>
        public int Ceiling()
        {
            return (int)MathF.Ceiling(ToDecimals());
        }

        /// <summary>
        /// Returns largest integral value that is smaller or equal to the fraction
        /// </summary>
        /// <returns></returns>
        public int Floor()
        {
            return (int)MathF.Floor(ToDecimals());
        }

        public static Fraction operator +(Fraction a, Fraction b) => new Fraction(a.counter * b.denominator + b.counter * a.denominator, a.denominator * b.denominator);

        public static Fraction operator -(Fraction a) => new Fraction(-a.counter, a.denominator);
        public static Fraction operator -(Fraction a, Fraction b) => a + (-b);
        public static Fraction operator *(Fraction a, Fraction b) => new Fraction(a.counter * b.counter, a.denominator * b.denominator);
        public static Fraction operator /(Fraction a, Fraction b)
        {
            if(b.counter == 0)
            {
                throw new DivideByZeroException();
            }
            return new Fraction(a.counter * b.denominator, a.denominator * b.counter);
        }

        static void Main(string[] args)
        {
            List<Fraction> fractionList = new List<Fraction>();
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(1, 3);
            Fraction f3 = new Fraction(1, 4);

            fractionList.Add(f2);
            fractionList.Add(f3);
            fractionList.Add(f1);

            Console.WriteLine("Before sorting:");
            foreach(Fraction f in fractionList)
            {
                Console.WriteLine(f.ToString());
            }

            Console.WriteLine("\n After sorting:");
            fractionList.Sort();
            foreach (Fraction f in fractionList)
            {
                Console.WriteLine(f.ToString());
            }
            Console.ReadKey();
        }
    }
}
