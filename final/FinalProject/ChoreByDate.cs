using System.Security.Cryptography;

public class ChoreByDate
{
    private Chore _chore;
    private DateOnly _date;

    public ChoreByDate(Chore chore, DateOnly date)
    {
        _chore = chore;
        _date = date;
    }

    public void SetChoreList(Chore chore, DateOnly date)
    {
        _chore = chore;
        _date = date;
    }

    public (Chore chore, DateOnly date) GetChoreDateList()
    {
        return (_chore, _date);
    }

}