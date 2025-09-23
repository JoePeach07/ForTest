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

        char  [,] gameDeck;

        // Метод инициализирует игровое поле заданного размера и заполняет его пустыми символами
        public void SetDeck(int size)
        {

            gameDeck = new char[size, size];

            for (var i = 0; i < size; i++) 
            {
                for (var j = 0; j < size; j++)
                {
                    gameDeck[i, j] = (char)GameSymbols.Empty; 
                }
            }
        }

        // Свойство возвращает копию игрового поля для его визуализации
        public char[,] readOnlyGameDeck
        {
            get { return (char[,])gameDeck.Clone(); }
        }

        // Метод устанавливает символ X или O в указанную позицию
        // Позиция указывается в виде одномерного индекса, который преобразуется в двумерные координаты
        public void setPosition(int x) 
        {

        }

    }
}
