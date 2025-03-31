using rybalka;
using shulzhenko;
using System;
using sobko;
using chub;
using mukohorenko;
using System.Text;

class Program
{
    static int[] array = new int[0];

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("""
              ====================================
                         ГОЛОВНЕ МЕНЮ           
              ====================================
              1 - Створити масив (випадково або вручну)
              2 - Виконати завдання студентів
              3 - Вивести поточний стан масиву
              4 - Завершити програму
              Ваш вибір: 
              """);

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    array = GetArrayFromUser();
                    PrintArray();
                    break;
                case "2":
                    ChooseTask();
                    break;
                case "3":
                    PrintArray();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Некоректний вибір, спробуйте ще раз.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static int[] GetArrayFromUser()
    {
        Console.Clear();
        Console.WriteLine("""
        ====================================
               ВВЕДЕННЯ МАСИВУ          
        ====================================
        1 - В один рядок через пробіл
        2 - Ввести довжину, а потім заповнити числами
        3 - Ввести довжину і заповнити рандомом
        0 - Повернутися у головне меню        
        """);
        Console.Write("Ваш вибір: ");

        string choice = Console.ReadLine();
        int[] newArray = new int[0];

        switch (choice)
        {
            case "1":
                Console.Write("Введіть масив через пробіл: ");
                string[] input = Console.ReadLine().Split();
                newArray = Array.ConvertAll(input, int.Parse);
                break;

            case "2":
                Console.Write("Введіть довжину масиву: ");
                int length = int.Parse(Console.ReadLine());
                newArray = new int[length];
                Console.WriteLine("Введіть числа:");
                for (int i = 0; i < length; i++)
                {
                    Console.Write($"Елемент {i + 1}: ");
                    newArray[i] = int.Parse(Console.ReadLine());
                }
                break;

            case "3":
                Console.Write("Введіть довжину масиву: ");
                int size = int.Parse(Console.ReadLine());
                newArray = new int[size];
                Random rand = new Random();
                for (int i = 0; i < size; i++)
                {
                    newArray[i] = rand.Next(-100, 101);
                }
                break;

            case "0":
                return array;

            default:
                Console.WriteLine("Помилка!");
                return GetArrayFromUser();
        }

        return newArray;
    }

    static void ChooseTask()
    {
        if (array.Length == 0)
        {
            Console.WriteLine("Масив ще не створено! Спочатку створіть масив.");
            Console.ReadKey();
            return;
        }

        while (true)
        {
            Console.Clear();
            Console.WriteLine("""
                ====================================
                       ВИБІР ЗАВДАННЯ          
                ====================================
                1 - Шульженко Софія: Вставити перед кожним парним елементом 1
                2 - Мукогоренко Максим: Знищити всі елементи з парними індексами
                3 - Рибалка Владислав: Вставити після кожного від’ємного елемента його модуль
                4 - Чуб Роман: Якщо максимум парний V, замінити на два V/2; якщо непарний, не змінювати
                5 - Собко Владислав: Вставити в початок мінімум, а в кінець максимум
                6 - Створити новий масив перед виконанням іншого варіанту
                0 - Повернутися до головного меню
                """);

            Console.Write("Ваш вибір: ");
            string choice = Console.ReadLine();
            Console.WriteLine("====================================");
            Console.WriteLine($"Масив до змін: {string.Join(" ", array)}");

            switch (choice)
            {
                case "1":
                    array = Task16.Run(array);
                    break;
                case "2":
                    array = Task6.Run(array);
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
                case "6":
                    array = GetArrayFromUser();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Неправильний вибір, спробуйте ще раз.");
                    Console.ReadKey();
                    continue;
            }

            Console.WriteLine($"Масив після змін: {string.Join(" ", array)}");
            Console.WriteLine("Натисніть Enter, щоб продовжити...");
            Console.ReadLine();
        }
    }

    
}
