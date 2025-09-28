using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Крч пришла идея реализовать инициализацию игрового поля сразу при запуске и без явного создания экземпляра класса Deck
// Нашел как это сделать, но особо не понял стоило ли оно того или нет

namespace ForTest.Classes
{
    internal class GameConfig
    {
        

        public Deck Deck { get; private set; }
        public Visual Visual { get; private set; }
        public Rules Rules { get; private set; }
        public HumanPlayers HumanPlayer { get; private set; }
        public BotPlayers BotPlayer { get; private set; }
        public Queue Queue { get; private set; }
        
   
        public void GenerateGameDeckMembers()
        {
            
            Deck = new Deck();
            Visual = new Visual();
            Rules = new Rules();
            HumanPlayer = new HumanPlayers();
            BotPlayer = new BotPlayers();
            Queue = new Queue();

            
            Deck.SetDeck(5);
            Visual.PrintGameDeck(Deck.ReadOnlyGameDeck);
        }
    }
}
