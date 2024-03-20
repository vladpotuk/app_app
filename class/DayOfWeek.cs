using System;

class DayOfWeek
{
    public string CurrentDay { get; }

    public DayOfWeek()
    {
        CurrentDay = DateTime.Now.DayOfWeek.ToString();
    }
}
