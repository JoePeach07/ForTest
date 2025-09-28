using System;
using static System.Net.Mime.MediaTypeNames;

namespace ForTest.Classes
{
    // Как же я замучался делать методы меню, постоянно уходил в бесконечный цикл. 
    // За то узнал про TryParse, штука удобная. А то я хз был как меню обратно возвращать без рекурсии
    internal class Menu
    {
        // Метод для отображения главного меню
        public int ShowMenu() //1
        {
            
                Console.WriteLine("1. Начать игру");
                Console.WriteLine("2. Выход");
                Console.Write("Выберите пункт меню: ");

                string input = Console.ReadLine();

                if (int.TryParse(input, out int choice) && (choice == 1))
                {
                    return choice; // Возвращаем корректный выбор
                    
                }
                else if (int.TryParse(input, out int choice1) && (choice1 == 2))
                {
                    Console.WriteLine("Выход из игры.");
                    Environment.Exit(0);
                }
            return 2;
        }

        // Метод для выбора режима игры
        public int ShowGameModeMenu() //2 Реализую в конце, пока нужно довести до ума игру против бота
        {
           
                Console.WriteLine("Выбер режа игры:");
                Console.WriteLine("1. PvP");
                Console.WriteLine("2. PvE");
                Console.Write("Ваш выбор: ");

                string input = Console.ReadLine();

                if (int.TryParse(input, out int choice) && (choice == 1))
                {
                    return choice; // Возвращаем режим PvP
                }
                else if (int.TryParse(input, out int choice2) && (choice == 2))
                {
                    return choice2; // Возвращаем режим PvE
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Попробуйте снова.");
                }
            return 0;
        }


        // Метод для выбора знака для игры
        public int ChooseSimbolMenu() //3
        {
            while (true)
            {
                Console.WriteLine("\n1. Играть X - 1-ый ход");
                Console.WriteLine("2. Играть O - 2-ой ход");
                Console.WriteLine("3. Случайная очередность");
                Console.Write("Играть за: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int choice) && (choice == 1 || choice == 2))
                {
                    return choice;
                }
                else if (int.TryParse(input, out int choice1) && (choice1 == 3))
                {
                    Random rand = new Random();

                    int randomChoice = rand.Next(1, 3); // Генерируем случайное число 1 или 2. Прикол в том, что Next(1,3) генерирует 1 или 2 А я и не понимал

                    return randomChoice;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Попробуйте снова.231");
                }
                
            }
        }


        // Метод для отображения меню игрока 
        public int ShowPlayerMenu(int playerNumber) //4
        {
            while (true)
            {
                Console.WriteLine($"\nХод игрока {playerNumber}:");
                Console.WriteLine("1. Сделать ход");
                Console.WriteLine("2. Вывести игровое поле");
                Console.WriteLine("3. Завершить игру");
                Console.Write("Ваш выбор: ");

                string input = Console.ReadLine();

                if (int.TryParse(input, out int choise1) && (choise1 == 1))
                {
                    return choise1; 
                }
                else if (int.TryParse(input, out int choise2) && (choise2 == 2))
                {
                    return choise2;
                }
                else if (int.TryParse(input, out int choise3) && (choise3 == 3))
                {
                    return choise3;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Попробуйте снова.");
                }
                
            }

            
        }
    }
}
