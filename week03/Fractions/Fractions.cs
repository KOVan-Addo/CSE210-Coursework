
public class Fraction
{
    // Private attributes
    private int _top;
    private int _bottom;

    // Constructor 1: Default fraction (1/1)
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor 2: One parameter (5/1)
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    // Constructor 3: Two parameters (3/4)
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getter for the top number
    public int GetTop()
    {
        return _top;
    }

    // Setter for the top number
    public void SetTop(int top)
    {
        _top = top;
    }

    // Getter for the bottom number
    public int GetBottom()
    {
        return _bottom;
    }

    // Setter for the bottom number
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Return the fraction as a string
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Return the fraction as a decimal
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}
