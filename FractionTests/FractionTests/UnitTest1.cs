using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_1;

namespace FractionTests
{
    [TestClass]
    public class FractionTests
    {
        [TestMethod]
        public void CreateDefaultFraction()
        {
            Fraction defaultFraction = new Fraction();

            
        }

        [TestMethod]
        public void CreateCustomFraction()
        {
            Fraction customFraction = new Fraction(1,2);
        }
        [TestMethod]
        public void CreateCopiedFraction()
        {
            Fraction customFraction = new Fraction(1, 2);
            Fraction copiedFraction = new Fraction(customFraction);
        }

        [TestMethod]
        public void ConvertFractionToString()
        {
            Fraction fr = new Fraction();
            fr.ToString();
        }

        [TestMethod]
        public void AddFractions()
        {
            Fraction a = new Fraction(1, 2);
            Fraction b = new Fraction(1, 4);

            Fraction c = a + b;
        }

        [TestMethod]
        public void SubtractFractions()
        {
            Fraction a = new Fraction(1, 2);
            Fraction b = new Fraction(1, 4);

            Fraction c = a - b;
        }

        [TestMethod]
        public void MultiplyFractions()
        {
            Fraction a = new Fraction(1, 2);
            Fraction b = new Fraction(1, 4);

            Fraction c = a * b;
        }

        [TestMethod]
        public void DivideFractions()
        {
            Fraction a = new Fraction(1, 2);
            Fraction b = new Fraction(1, 4);

            Fraction c = a / b;
        }

        [TestMethod]
        public void DivideFractionsByZero()
        {
            Fraction a = new Fraction(1, 2);
            Fraction b = new Fraction(0, 4);

            Fraction c = a + b;
        }

        [TestMethod]
        public void CompareFraction()
        {
            Fraction a = new Fraction(1, 2);
            Fraction b = new Fraction(0, 4);

            int c = a.CompareTo(b);
        }

        [TestMethod]
        public void EqualFraction()
        {
            Fraction a = new Fraction(1, 2);
            Fraction b = new Fraction(0, 4);

            bool c = a.Equals(b);
        }

        [TestMethod]
        public void GetValues()
        {
            Fraction a = new Fraction(1, 2);
            int num = a.GetCounter();
            int den = a.GetDenominator();
        }

        [TestMethod]
        public void TestCeiling()
        {
            Fraction a = new Fraction(1, 2);
            a.Ceiling();
        }

        [TestMethod]
        public void TestFloor()
        {
            Fraction a = new Fraction(1, 2);
            a.Floor();
        }
    }
}
