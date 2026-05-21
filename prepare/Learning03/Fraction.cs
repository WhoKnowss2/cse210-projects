using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    // Validation + setter
    public void SetBottom(int bottom) =>
        _bottom = (bottom == 0) ? 1 : bottom;

    // Getters and setters
    public int GetTop() => _top;
    public void SetTop(int top) => _top = top;
    public int GetBottom() => _bottom;

    // Default constructor
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor for whole numbers
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // Constructor for numerator/denominator
    public Fraction(int top, int bottom)
    {
        _top = top;
        SetBottom(bottom);
    }

    // Methods
    public string GetFractionString() => $"{_top}/{_bottom}";
    public double GetDecimalValue() => (double)_top / (double)_bottom;
}
