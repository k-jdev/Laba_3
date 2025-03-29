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

}
