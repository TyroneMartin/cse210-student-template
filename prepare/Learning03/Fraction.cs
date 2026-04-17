using System;
using System.Diagnostics.Contracts;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

public class Fraction
{
    // attribute/variables
    private int _numerator;
    private int _denominator;
    // ---

    // Constructor 
    // *--------------------------------------------
    public Fraction()
    {
        // no parameters that initializes the number to 1/1
        _numerator = 1;
        _denominator = 1;
    }
    public Fraction(int wholeNumber)
    {
        // one parameter for the top and that initializes the denominator to 1
        _numerator = wholeNumber;
        _denominator = 1;
    }
    public Fraction(int top, int bottom)
    {
        // Constructor that has two parameters
        _numerator = top;
        _denominator = bottom;
    }
    // *--------------------------------------------



    // Getters and Setters
    public int GetNumerator()
    {
        return _numerator;
    }

    public void SetNumerator(int top)
    {
        _numerator = top;
    }

    public int GetDenominator()
    {
        return _denominator;
    }

    public void SetDenominator(int bottom)
    {
        _denominator = bottom;
    }




    // method -------------------------------------------------------------
    public string GetFractionString()
    {
        // string fraction = $"{_numerator}/{_denominator}";
        // return fraction;

        return $"{_numerator}/{_denominator}";

    }
    public double GetDecimalValue()
    {
        return _numerator / (double) _denominator;
    }


}