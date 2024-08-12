using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> todoList = new List<string>();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nYapılacaklar Listesi Uygulaması");
            Console.WriteLine("1. Yapılacak İş Ekle");
            Console.WriteLine("2. Yapılacak İş Sil");
            Console.WriteLine("3. Listeyi Göster");
            Console.WriteLine("4. Çıkış");
            Console.Write("Seçiminizi yapın: ");

            switch (Console.ReadLine())
            {
                case "1":
                    AddTask(todoList);
                    break;
                case "2":
                    RemoveTask(todoList);
                    break;
                case "3":
                    ShowTasks(todoList);
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyin.");
                    break;
            }
        }
    }

    static void AddTask(List<string> todoList)
    {
        Console.Write("Eklemek istediğiniz yapılacak işi girin: ");
        string task = Console.ReadLine();
        todoList.Add(task);
        Console.WriteLine("İş eklendi.");
    }

    static void RemoveTask(List<string> todoList)
    {
        ShowTasks(todoList);
        Console.Write("Silmek istediğiniz işin numarasını girin: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= todoList.Count)
        {
            todoList.RemoveAt(index - 1);
            Console.WriteLine("İş silindi.");
        }
        else
        {
            Console.WriteLine("Geçersiz index, işlem yapılmadı.");
        }
    }

    static void ShowTasks(List<string> todoList)
    {
        if (todoList.Count == 0)
        {
            Console.WriteLine("Listede yapılacak iş bulunmamaktadır.");
        }
        else
        {
            Console.WriteLine("\nYapılacak İşler Listesi:");
            for (int i = 0; i < todoList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {todoList[i]}");
            }
        }
    }
}
