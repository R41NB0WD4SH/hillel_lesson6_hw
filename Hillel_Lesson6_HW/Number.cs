namespace Hillel_Lesson6_HW;

public class Number
{
    private int _index;
    private int _frequency;


    public int Index
    {
        get
        {
            return _index;
        }
        set
        {
            _index = value;
        }
    }

    public int Frequency
    {
        get
        {
            return _frequency;
        }
        set
        {
            _frequency = value;
        }
    }

    public Number(int index)
    {
        _index = index;
        _frequency = 0;
    }
    
    
}