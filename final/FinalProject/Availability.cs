public class Availability
{
    private int _day;
    private int _availableTime;

    public Availability()
    {}
    public Availability(int day, int time)
    {
        _day = day;
        _availableTime = time;
    }

    public int GetDay()
    {
        return _day;
    }

    public void SetTime(int newTime)
    {       
        _availableTime = newTime;
    }

    public string GetAvailability()
    {
        DayOfWeek thisDay = (DayOfWeek)_day;
        return $"{thisDay} - {_availableTime} minutes";
    }

    public string StringRepresentation()
    {
        return $"Availabilty:{_day}|{_availableTime}";
    }
}