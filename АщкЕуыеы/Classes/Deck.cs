// Класс хранит в себе референс размерности доски и так же следит за ее актуальным состоянием

namespace ForTest.Classes
{   internal class Deck
    {
        public enum GameSymbols
        {
            Empty = '\0',
            X = 'X',
            O = 'O'
        }

        private char[,] gameDeck;


        // Метод инициализирует игровое поле заданного размера и заполняет его пустыми символами
        public void SetDeck(int setSize)
        {

            gameDeck = new char[setSize, setSize];

            for (var i = 0; i < setSize; i++) 
            {
                for (var j = 0; j < setSize; j++)
                {
                    gameDeck[i, j] = (char)GameSymbols.Empty; 
                }
            }
        }

        // Свойство возвращает копию игрового поля для его визуализации
        public char[,] ReadOnlyGameDeck
        {
            get { return (char[,])gameDeck.Clone(); }
        }

        // Метод устанавливает символ X или O в указанную позицию
        // Позиция указывается в виде одномерного индекса, который преобразуется в двумерные координаты
        // Перед установкой символа класс Rules валидирует ход
        public void SetPosition(int x, int token) 
        {
            if (token == 0)
            {
                gameDeck[(x - 1) / gameDeck.GetLength(0), (x - 1) % gameDeck.GetLength(1)] = (char)GameSymbols.X;
            }
            else if(token == 1)
            {
                gameDeck[(x - 1) / gameDeck.GetLength(0), (x - 1) % gameDeck.GetLength(1)] = (char)GameSymbols.O;
            }
        }

    }
}
