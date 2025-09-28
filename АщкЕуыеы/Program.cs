// Игра в крестики - нолики
// В этом классе будут созданый методы навигации в меню, взаимодействия с игрой.
// Тут будет запущен основной цикл игры через while 

using ForTest.Classes;

namespace ForTest

{
    internal class Program

    {
        static void Main(string[] args)

        {
            Menu menu = new Menu();
            GameConfig gameConfig = new GameConfig();
            gameConfig.GenerateGameDeckMembers();

            Console.WriteLine("Добро пожаловать в игру, которую я так устал делать(!");
            StartMenuNavigation(menu, gameConfig);
        }

        // Баля! Это мой МАГНУМ-КАЛУС. Я так хотел сделать меню аккуратным и компактным, что решил вынести реализацию в отдельный класс
        // Тут нет Try Catch, ведь отлавливает за него TryParse неправильный ввод
        // словил прикол с того, что нужно передавать в методы меню сам объект меню, иначе он не видит методы
        // игру в PvP я не реализовывал, а то в 3 ночи уже голова не варит


        // Метод вызова основного меню
        public static void StartMenuNavigation(Menu menu, GameConfig gameConfig)
        {
            while (true)
            {
                int menuChoice = menu.ShowMenu();
                switch (menuChoice)
                {
                    case 1:
                        StartGame(menu, gameConfig);
                        break;

                    default:
                        Console.WriteLine("Некорректный ввод. Попробуйте снова.");
                        break;
                }
            }
        }

        // Метод для начала игры
        public static void StartGame(Menu menu, GameConfig gameConfig)
        {
            BotPlayers bot = new BotPlayers();
            HumanPlayers human = new HumanPlayers();

            // Выбор символа игрока
            human.SetMyQueue(ChooseSimbolMenuNavigation(menu, bot, human));
            bot.SetMyQueue(human.GetMyQueue() == 1 ? 2 : 1);

            Console.WriteLine($"\nИгрок играет за {(human.GetMyQueue() == 1 ? Deck.GameSymbols.X : Deck.GameSymbols.O)}");
            Console.WriteLine($"Бот играет за {(bot.GetMyQueue() == 1 ? Deck.GameSymbols.X : Deck.GameSymbols.O)}\n");

            // Запуск игры
            PlayGame(menu, gameConfig, human, bot);
        }

        // Метод вызова меню выбора символа
        public static int ChooseSimbolMenuNavigation(Menu menu, BotPlayers bot, HumanPlayers human)
        {
            int chosenQueue = menu.ChooseSimbolMenu();
            while (true)
            {
                if (chosenQueue == 1)
                {
                    
                    break;
                }
                else if (chosenQueue == 2)
                {
                    
                    break;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Попробуйте снова.");
                }
            }
            return chosenQueue;
        }

        // Метод игрового процесса
        public static void PlayGame(Menu menu, GameConfig gameConfig, HumanPlayers human, BotPlayers bot)
        {
            Queue queue = new Queue();
            Rules rules = gameConfig.Rules;
            Deck deck = gameConfig.Deck;
            Visual visual = gameConfig.Visual;

            while (true)
            {
                int currentPlayer = queue.GetCurrentQueue();
                Console.WriteLine($"\nХод {(currentPlayer == human.GetMyQueue() ? "игрока" : "бота")}");

                if (currentPlayer == human.GetMyQueue())
                {
                    int playerMenuChoice = menu.ShowPlayerMenu(currentPlayer);
                    switch (playerMenuChoice)
                    {
                        case 1: 
                            Console.Write("Введите номер ячейки: ");
                            string input = Console.ReadLine();
                            if (int.TryParse(input, out int position))
                            {
                                if (rules.ValidationPlayerMove(position, deck.GetDeckSize(), deck.GetSymbolOnPosition(position)))
                                {
                                    deck.SetPosition(position, currentPlayer);
                                    visual.PrintGameDeck(deck.ReadOnlyGameDeck); 
                                    queue.ManageQueue();
                                }
                                else
                                {
                                    Console.WriteLine("Некорректный ход. Попробуйте снова.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Некорректный ввод. Попробуйте снова.");
                            }
                            break;

                        case 2: // Вывести игровое поле
                            visual.PrintGameDeck(deck.ReadOnlyGameDeck);
                            break;

                        case 3: // Завершить игру
                            Console.WriteLine("Игра завершена.");
                            StartMenuNavigation(menu,gameConfig);
                            break;
                            
                    }
                }
                else
                {
                    // Ход бота
                    int botMove = bot.MakeMove(deck.GetDeckSize() * deck.GetDeckSize());
                    if (rules.ValidationPlayerMove(botMove, deck.GetDeckSize(), deck.GetSymbolOnPosition(botMove)))
                    {
                        Console.WriteLine($"Бот выбрал ячейку {botMove}");
                        deck.SetPosition(botMove, currentPlayer);
                        visual.PrintGameDeck(deck.ReadOnlyGameDeck); // Выводим поле после хода
                        queue.ManageQueue();
                    }
                }

                // Проверка победителя
                int winCondition = rules.CheckWinCondition(deck.ReadOnlyGameDeck, (char)Deck.GameSymbols.X, (char)Deck.GameSymbols.O);
                if (winCondition != 0)
                {
                    if (winCondition == 1)
                    {
                        Console.WriteLine("Победил игрок!");
                        deck.SetDeck(3);
                    }
                    else if (winCondition == 2)
                    {
                        Console.WriteLine("Победил бот!");
                        deck.SetDeck(3);
                    }
                    else if (winCondition == 3)
                    {
                        Console.WriteLine("Ничья!");
                        deck.SetDeck(3);
                    }
                    break;
                }
            }
        }
    }
}
// Ход игрока и позиция для проверки должны совпадать.
// В дальнейшей реализации позиция для проверки и ход игрока будут записываться в одну переменную внутри метода в классе Program
// Возможно стоит реализовать метод внутри Rules для возвращения позиции на проверку и хода игрока