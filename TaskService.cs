
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

    public void ShowTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("Список завдань порожній.");
            return;
        }

        Console.WriteLine("\n=== Список завдань ===");

        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {tasks[i]}");
        }
    }
}
