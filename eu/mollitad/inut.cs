private int _days;

public int Days
{
    get { return _days; }
    set
    {
        if (value < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(value), "Number of days cannot be negative.");
        }
        _days = value;
    }
}
