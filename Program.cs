using System;

delegate void DisplayMessage(string message);

class Program
{
    static void ShowMessage(string message)
    {
        Console.WriteLine($"Повідомлення: {message}");
    }

    static void ShowMessageInTitle(string message)
    {
        Console.Title = message;
    }

    static void Main(string[] args)
    {
        
        DisplayMessage display = ShowMessage;

        
        display("Hello,Vlad!");

       
        display = ShowMessageInTitle;

       
        display("Новий заголовок ");
    }
}
