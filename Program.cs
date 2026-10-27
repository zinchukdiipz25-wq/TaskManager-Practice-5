
using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        TaskService service = new TaskService();

        while (true)
        {
            Console.WriteLine("\n=== Менеджер завдань ===");
            Console.WriteLine("1. Додати завдання");
            Console.WriteLine("0. Вихід");
            Console.Write("Ваш вибір: ");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Введіть назву завдання: ");
                    string title = Console.ReadLine() ?? "";
                    service.AddTask(title);
                    break;

                case "0":
                    Console.WriteLine("Завершення роботи.");
                    return;

                default:
                    Console.WriteLine("Невідома команда!");
                    break;
            }
        }
    }
}
