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

            deck.SetDeck(8);
            deck.SetPosition(39,0);
            visual.PrintGameDeck(deck.ReadOnlyGameDeck);

        }
    }
}
