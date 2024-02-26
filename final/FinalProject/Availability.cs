public class Availability
{
    private int _day;
    private int _availableTime;

    // private List<DateOnly> _availableDates;   - may add later to use with date ranges

    public Availability()
    {}
    public Availability(int day, int time)
    {
        _day = day;
        _availableTime = time;
    }

    public (int day, int time) GetDayTimeAvailable()
    {
        return (_day, _availableTime);
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