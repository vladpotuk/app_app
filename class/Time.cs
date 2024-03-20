using System;

class Time
{
    public string CurrentTime { get; }

    public Time()
    {
        CurrentTime = DateTime.Now.TimeOfDay.ToString();
    }
}
