namespace BowlingGame
{
    public class Game
    {
        private int[] rolls = new int[21];
        private int _rollCounter = 0;
        private static int MAX_PINS = 10;
        private static int TOTAL_ROUNDS = 10;
        
        public void Roll(int pinsKnocked)
        {
            rolls[_rollCounter] = pinsKnocked;
            _rollCounter++;
        }

        public int Score()
        {
            int score = 0;
            int rollNumber = 0;

            for (int round = 0; round < TOTAL_ROUNDS; round++)
            {

                if (WasStrike(rolls[rollNumber]))
                {
                    score += rolls[rollNumber] + rolls[rollNumber + 1] + rolls[rollNumber + 2];
                    rollNumber++;
                }
                else if (WasSpare(rollNumber))
                {
                    score += rolls[rollNumber] + rolls[rollNumber + 1] + rolls[rollNumber + 2];
                    rollNumber += 2;
                }
                else
                {
                    score += rolls[rollNumber] + rolls[rollNumber + 1];
                    rollNumber += 2;
                }
            }

            return score;
        }

        private bool WasStrike(int pinsKnocked)
        {
            return pinsKnocked == MAX_PINS;
        }

        private bool WasSpare(int rollNumber)
        {
            return rolls[rollNumber] + rolls[rollNumber + 1] == MAX_PINS;
        }
    }
}