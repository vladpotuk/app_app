using System;

class Program
{
    static void Main(string[] args)
    {
        Action<string> displayMessage = message => Console.WriteLine(message);

       
        Action displayTime = () =>
        {
            Time time = new Time();
            displayMessage($"Поточний час: {time.CurrentTime}");
        };
        displayTime();

        
        Action displayDate = () =>
        {
            Date date = new Date();
            displayMessage($"Поточна дата: {date.CurrentDate}");
        };
        displayDate();

        
        Action displayDayOfWeek = () =>
        {
            DayOfWeek dayOfWeek = new DayOfWeek();
            displayMessage($"Поточний день тижня: {dayOfWeek.CurrentDay}");
        };
        displayDayOfWeek();

        
        Func<double, double, double> calculateTriangleArea = (baseLength, height) => 0.5 * baseLength * height;
        displayMessage($"Площа трикутника: {calculateTriangleArea(5, 7)}");

        
        Func<double, double, double> calculateRectangleArea = (length, width) => length * width;
        displayMessage($"Площа прямокутника: {calculateRectangleArea(5, 7)}");
    }
}
