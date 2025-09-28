using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTest.Classes
{
    internal class Queue
    {
        private int queueToken = 1;

        // Метод для управления очередностью ходов. Изначально метод получает 1 - X или 2 - O (зависит от выбора игрока в меню игры)
        public int ManageQueue() 
        {
            if (queueToken % 2 == 0) 
            {
                queueToken = 1;
            } else
            {
                queueToken = 2;
            }

            return queueToken;
        }

        public int GetCurrentQueue () 
        { 
            return queueToken; 
        }
    }
}
