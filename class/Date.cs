using System;

class Date
{
    public string CurrentDate { get; }

    public Date()
    {
        CurrentDate = DateTime.Now.ToShortDateString();
    }
}
