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

            Deck deck = new Deck();
            Visual visual = new Visual();
            Rules rules = new Rules();
            HumanPlayers humanPlayer = new HumanPlayers();
            BotPlayers botPlayer = new BotPlayers();

            deck.SetDeck(3);            
            visual.PrintGameDeck(deck.ReadOnlyGameDeck);


        }
    }
}
// Ход игрока и позиция для проверки должны совпадать.
// В дальнейшей реализации позиция для проверки и ход игрока будут записываться в одну переменную внутри метода в классе Program
// Возможно стоит реализовать метод внутри Rules для возвращения позиции на проверку и хода игрока