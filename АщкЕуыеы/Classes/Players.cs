// Класс описывает методы и свойства игроков. Существует 2 типа игрока: человек и бот.
// У любого есть только 1 метод - сделать ход

namespace ForTest.Classes
{
    interface PlayerMove
    {
        // Метод для совершения хода игроком
        int MakeMove(int chousenPosition);
    }

    internal class HumanPlayers : PlayerMove
    {
        public int MakeMove(int chousenPosition)
        {
           return chousenPosition;
        }
    }
    

    

    internal class BotPlayers : PlayerMove
    {
        public int MakeMove(int chousenPosition)
        {
            return chousenPosition;
        }
    }
}
