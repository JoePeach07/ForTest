// Класс отвечает  за выведение актуального состояния игрового поля.
// Изначально поле выводится пустым, затем в процессе игры пустые ячейки заполняются X или O

namespace ForTest.Classes
{
    internal class Visual
    {
        public void PrintGAmeDeck(char[,] Deck) 
        {
            for (int i = 0; i < Deck.GetLength(0); i++) 
            {
                Console.WriteLine();
                for (int j = 0; j < Deck.GetLength(1); j++) 
                {
                    Console.Write($"| {Deck[i, j]} |");
                }
            }
        }
    }
}
