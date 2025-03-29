using System;



class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
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
               Console.WriteLine("Невірний вибір, спробуйте ще раз.");
            }
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

            default:
                Console.WriteLine("Невірний вибір!");
                return GetArrayFromUser();
        }
        return array;
    }

}
