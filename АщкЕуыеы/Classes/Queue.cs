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
        public int ManageQueue(int queue) 
        {
            if (queue % 2 == 0) 
            {
                queue = 1;
            } else
            {
                queue = 2;
            }

            return queue;
        }

        public int getQueue () 
        { 
            return queueToken; 
        }
    }
}
