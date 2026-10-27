
using System;
using System.Collections.Generic;

public class TaskService
{
    private readonly List<string> tasks = new();

    public void AddTask(string title)
    {
        if (string.IsNullOrWhiteSpace(title))
        {
            Console.WriteLine("Назва завдання не може бути порожньою!");
            return;
        }

        tasks.Add(title.Trim());
        Console.WriteLine("Завдання успішно додано!");
    }
}
