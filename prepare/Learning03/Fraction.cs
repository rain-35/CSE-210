public class Fraction
{
    private int _rm_top;
    private int _rm_bottom;

    public void FractionInit()
    {
        _rm_top = 1;
        _rm_bottom = 1;
    }

    public void FractionOverOne(int rmTopInput)
    {
        _rm_top = rmTopInput;
        _rm_bottom = 1;
    }

    public void FractionFull(int rmTopInput, int rmBottomInput)
    {
        _rm_top = rmTopInput;
        _rm_bottom = rmBottomInput;
    }
    
    public void SetTop(int rmTopInput)
    {
        _rm_top = rmTopInput;
    }

    public void SetBottom(int rmBottomInput)
    {
        _rm_bottom = rmBottomInput;
    }

    public int GetTop()
    {
        return _rm_top;
    }

    public int GetBottom()
    {
        return _rm_bottom;
    }

    public string GetFractionString()
    {
        string rmFractionString = $"{_rm_top}/{_rm_bottom}";
        return rmFractionString;
    }

    public double GetDecimalValue()
    {
        double rmDecimalValue = (double)_rm_top / (double)_rm_bottom;
        return rmDecimalValue;
    }

}