using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTest.Classes
{
    interface MenuInterface
    {
        void ShowMenu();
    }
    internal class Menu
    {
        public void ShowMenu()
        {
            Console.WriteLine("Выберите режим игры:");
            Console.WriteLine("1. Игрок против Игрока \n2. Игрок против Бота\n3. Выход");
            Console.Write("Введите номер режима (1 - играть X , 2 - играть O):");
        }
    }
}
