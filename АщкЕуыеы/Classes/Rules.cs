// Класс описывает правила игры. Он занимается валидацией ходов, определением победителя, определяет очередность ходов.

namespace ForTest.Classes
{
    internal class Rules
    {
        // Метод проверяет валидность хода игрока. Класс получает позицию и размерность поля.
        public bool ValidationPlayerMove (int position, int deckSize, char symbol) 
        
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

    }
}
