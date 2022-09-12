using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class Rational
    {
        public int Numerator { get; private set; }
        public int Denominator { get; private set; }

        public Rational(int numerator = 0, int denominator = 1)
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }
        public override string ToString()
        {
            return ($"{this.Numerator} / {this.Denominator}");
        }
        public void IncreaseBy(Rational other)
        {
            this.Numerator = this.Numerator * other.Denominator + other.Numerator * this.Denominator;
            this.Denominator = this.Denominator * other.Denominator;
        }
        public void DecreaseBy(Rational other)
        {
            this.Numerator = this.Numerator * other.Denominator - other.Numerator * this.Denominator;
            this.Denominator = this.Denominator * other.Denominator;
        }
    }
}
