// Fraction.cs
using System;

public class Fraction
{
    // Attributes for the top and bottom numbers
    private int top;
    private int bottom;

    // Constructors
    public Fraction() // Constructor that has no parameters that initializes the number to 1/1
    {
        top = 1;
        bottom = 1;
    }

    public Fraction(int top) // Constructor that has one parameter for the top and that initializes the denominator to 1
    {
        this.top = top;
        bottom = 1;
    }

    public Fraction(int top, int bottom) // Constructor that has two parameters, one for the top and one for the bottom
    {
        this.top = top;
        this.bottom = bottom;
    }

    // Getters and setters for the top and bottom numbers
    public int GetTop()
    {
        return top;
    }

    public void SetTop(int top)
    {
        this.top = top;
    }

    public int GetBottom()
    {
        return bottom;
    }

    public void SetBottom(int bottom)
    {
        this.bottom = bottom;
    }

    // Methods to return representations of both the fractional and decimal views
    public string GetFractionString() // Method that returns the fraction in the form 3/4
    {
        return top + "/" + bottom;
    }

    public double GetDecimalValue() // Method that returns a double that is the result of dividing the top number by the bottom number
    {
        return (double)top / bottom;
    }
}