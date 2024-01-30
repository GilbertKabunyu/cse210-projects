using System;

class Program
{
    static void Main(string[] args)
    {
        fraction f1 = new fraction(3, 4);
        // showing decimals and fractions
        console.WriteLine("The fraction is " + f1.GetFractionString());
        console.WriteLine("The decimal value is " + f1.GetDecimalValue());

        f1.SetTop(5);
        f1.SetBottom(6);

        // new fraction and decimals display
        console.WriteLine("The new fraction is " + f1.GetFractionString());
        console.WriteLine("The new decimal value is " + f1.GetDecimalValue());
    }
}