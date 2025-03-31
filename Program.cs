using rybalka;
using shulzhenko;
using System;
using sobko;
using chub;
using System.Text;



class Program
{
    static void Main()
    {
        while (true)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            
            Console.WriteLine("====================================");
            Console.WriteLine("           ГОЛОВНЕ МЕНЮ           ");
            Console.WriteLine("====================================");
            Console.WriteLine("1 - Почати виконувати програму");
            Console.WriteLine("2 - Завершити програму");
            Console.Write("Ваш вибір: ");

            string choice = Console.ReadLine();
            if (choice == "2") break;

            if (choice == "1")
            {
                int[] array = GetArrayFromUser();
                ChooseTask(array);
            }
            else
            {
                Console.WriteLine("Некоректний вибір, спробуйте ще раз.");
                Console.WriteLine("Через 4 секунди відбудеться оновлення консолі.");
            }
          
          
            Thread.Sleep(4000);
            Console.Clear();

        }
    }

    static int[] GetArrayFromUser()
    {
        Console.Clear();
        Console.WriteLine("====================================");
        Console.WriteLine("       ВВЕДЕННЯ МАСИВУ          ");
        Console.WriteLine("====================================");
        Console.WriteLine("1 - В один рядок через пробіл");
        Console.WriteLine("2 - Ввести довжину, а потім заповнити числами");
        Console.WriteLine("3 - Ввести довжину і заповнити рандомом");
        Console.WriteLine("0 - Повернутися у головне меню ");
        Console.Write("Ваш вибір: ");

        string choice = Console.ReadLine();
        int[] array = new int[0];

        switch (choice)
        {
            case "1":
                Console.Write("Введіть масив через пробіл: ");
                string[] input = Console.ReadLine().Split();
                array = Array.ConvertAll(input, int.Parse);
                break;

            case "2":
                Console.Write("Введіть довжину масиву: ");
                int length = int.Parse(Console.ReadLine());
                array = new int[length];
                Console.WriteLine("Введіть числа:");
                for (int i = 0; i < length; i++)
                {
                    Console.Write($"Елемент {i + 1}: ");
                    array[i] = int.Parse(Console.ReadLine());
                }
                break;

            case "3":
                Console.Write("Введіть довжину масиву: ");
                int size = int.Parse(Console.ReadLine());
                array = new int[size];
                Random rand = new Random();
                for (int i = 0; i < size; i++)
                {
                    array[i] = rand.Next(1, 101);
                }
                Console.WriteLine("Згенерований масив: " + string.Join(" ", array));
                break;
            case "0":
                Main();
                Console.WriteLine();
                break;

            default:
                Console.WriteLine("Помилка!");
                return GetArrayFromUser();
        }
        return array;
    }
    static void ChooseTask(int[] array)
    {

        while (true)
        {
            
            Console.WriteLine("====================================");
            Console.WriteLine("       ВИБІР ЗАВДАННЯ          ");
            Console.WriteLine("====================================");
            Console.WriteLine("1 - Шульженко Софія: Вставити перед кожним парним елементом 1");
            Console.WriteLine("2 - Мукогоренко Максим: Знищити всі елементи з парними індексами");
            Console.WriteLine("3 - Рибалка Владислав: Вставити після кожного від’ємного елемента його модуль");
            Console.WriteLine("4 - Чуб Роман: Якщо максимум парний V, замінити на два V/2; якщо непарний, не змінювати");
            Console.WriteLine("5 - Собко Владислав: Вставити в початок мінімум, а в кінець максимум");
            Console.WriteLine("0 - Повернутися до головного меню");
            Console.Write("Ваш вибір: ");

            string choice = Console.ReadLine();
            Console.WriteLine("====================================");
            switch (choice)
            {
                case "1":
                    array = Task16.Run(array);
                    break;
                case "2":
                    break;
                case "3":
                    array = Task14.Run(array);
                    break;
                case "4":
                    array = Task13_sigmaAlfa228.Run(array);

                    break;
                case "5":
                    Task11.Run(ref array);
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Здається було введене неправильне значення, спробуте ще раз.");
                    Console.WriteLine("Через 4 секунди відбудеться оновлення консолі.");
                    Thread.Sleep(4000);
                    Console.Clear();
                    continue;
            }
            Console.WriteLine("Масив після змін: " + string.Join(" ", array));
            Console.WriteLine("====================================");
            Console.WriteLine("Натисніть Enter, щоб продовжити...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
