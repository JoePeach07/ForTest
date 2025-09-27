// Класс описывает методы и свойства игроков. Существует 2 типа игрока: человек и бот.
// У любого есть только 1 метод - сделать ход

namespace ForTest.Classes
{
    interface PlayerMove
    {
        // Метод для совершения хода игроком или ботом
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
            Random RandomMove = new Random();
            chousenPosition = RandomMove.Next(1, chousenPosition);
            return chousenPosition;
        }
    }
}
