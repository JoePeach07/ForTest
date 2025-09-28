// Класс описывает правила игры. Он занимается валидацией ходов, определением победителя
namespace ForTest.Classes
{
    internal class Rules
    {
        // Метод проверяет валидность хода игрока. Метод получает позицию и размерность поля.
        public bool ValidationPlayerMove(int position, int deckSize, char symbol)

        {
            var validation = false;

            if (position > (deckSize * deckSize) || position <= 0)
            {
                validation = false;
            }
            else if (symbol == '\0')
            {
                validation = true;
            }

            return validation;
        }

        // как и в прошлый раз метод написан "в тупую", но работает
        // Метод проверяет состояние игрового поля на предмет победы или ничьи
        public int CheckWinCondition(char[,] currentDeck, char checkSymbolX, char checkSymbolO)
        {
            int numberOfOccupiedPositions = 0;
            var win = 0;
            if ((currentDeck[0, 0] == checkSymbolX && currentDeck[1, 0] == checkSymbolX && currentDeck[2, 0] == checkSymbolX) ||
                (currentDeck[0, 1] == checkSymbolX && currentDeck[1, 1] == checkSymbolX && currentDeck[2, 1] == checkSymbolX) ||
                (currentDeck[0, 2] == checkSymbolX && currentDeck[1, 2] == checkSymbolX && currentDeck[2, 2] == checkSymbolX) ||
                (currentDeck[0, 0] == checkSymbolX && currentDeck[0, 1] == checkSymbolX && currentDeck[0, 2] == checkSymbolX) ||
                (currentDeck[1, 0] == checkSymbolX && currentDeck[1, 1] == checkSymbolX && currentDeck[1, 2] == checkSymbolX) ||
                (currentDeck[2, 0] == checkSymbolX && currentDeck[2, 1] == checkSymbolX && currentDeck[2, 2] == checkSymbolX) ||
                (currentDeck[0, 0] == checkSymbolX && currentDeck[1, 1] == checkSymbolX && currentDeck[2, 2] == checkSymbolX) ||
                (currentDeck[2, 0] == checkSymbolX && currentDeck[1, 1] == checkSymbolX && currentDeck[0, 2] == checkSymbolX))
            {
                win = 1; // Победа игрока
            }
            else if (
                (currentDeck[0, 0] == checkSymbolO && currentDeck[1, 0] == checkSymbolO && currentDeck[2, 0] == checkSymbolO) ||
                (currentDeck[0, 1] == checkSymbolO && currentDeck[1, 1] == checkSymbolO && currentDeck[2, 1] == checkSymbolO) ||
                (currentDeck[0, 2] == checkSymbolO && currentDeck[1, 2] == checkSymbolO && currentDeck[2, 2] == checkSymbolO) ||
                (currentDeck[0, 0] == checkSymbolO && currentDeck[0, 1] == checkSymbolO && currentDeck[0, 2] == checkSymbolO) ||
                (currentDeck[1, 0] == checkSymbolO && currentDeck[1, 1] == checkSymbolO && currentDeck[1, 2] == checkSymbolO) ||
                (currentDeck[2, 0] == checkSymbolO && currentDeck[2, 1] == checkSymbolO && currentDeck[2, 2] == checkSymbolO) ||
                (currentDeck[0, 0] == checkSymbolO && currentDeck[1, 1] == checkSymbolO && currentDeck[2, 2] == checkSymbolO) ||
                (currentDeck[2, 0] == checkSymbolO && currentDeck[1, 1] == checkSymbolO && currentDeck[0, 2] == checkSymbolO))
            {
                win = 2;
            }

            foreach (var row in currentDeck) 
            {
                if (row != '\0')
                {
                    numberOfOccupiedPositions++;
                }
            }

            if (numberOfOccupiedPositions == 9 && win == 0) 
            {
                win = 3; // Ничья
            }

            return win;
        }

    }
}
