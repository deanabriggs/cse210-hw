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

    public void AddAvailability(int day, int time)
    {
        _day = day;
        _availableTime = time;
    }

    public void ChangeAvailability(int day, int time)
    {
        _day = day;
        _availableTime = time;
    }

    public string GetAvailability()
    {
        return $"{_day} - {_availableTime} minutes";
    }
}