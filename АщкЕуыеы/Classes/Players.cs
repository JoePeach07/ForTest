// Класс описывает методы и свойства игроков. Существует 2 типа игрока: человек и бот.
// У любого есть только 1 метод - сделать ход

namespace ForTest.Classes
{
    interface PlayerMove
    {
        // Метод для совершения хода игроком или ботом
        int MakeMove(int chousenPosition);

        // Из-за реализации игрового меню пришлось расширять интерфейс
        void SetMyQueue(int myQueue);
        int GetMyQueue();

    }

    internal class HumanPlayers : PlayerMove
    {
        private int humanQueue;
        public int MakeMove(int chousenPosition)
        {
           return chousenPosition;
        }
        public void SetMyQueue(int muQueue) 
        {
            humanQueue = muQueue;
        }
        public int GetMyQueue() 
        {             
            return humanQueue;
        }

    }
    

    

    internal class BotPlayers : PlayerMove
    {
        private int botQueue;
        public int MakeMove(int chousenPosition)
        {
            Random RandomMove = new Random();
            chousenPosition = RandomMove.Next(1, chousenPosition+1);
            return chousenPosition;
        }
        public void SetMyQueue(int muQueue)
        {
            botQueue = muQueue;
        }
        public int GetMyQueue()
        {
            return botQueue;
        }
    }
}
