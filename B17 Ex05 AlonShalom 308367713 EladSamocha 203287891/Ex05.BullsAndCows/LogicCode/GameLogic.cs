using System.Text;

namespace Ex05.BullsAndCows
{
    internal class GameLogic
    {
        private readonly string r_HiddenString;
        private string m_CurrentScore;
        
        public GameLogic()
        {
            // $G$ CSS-001 (-5) Bad local variable name (should be camelCased)
            RandomStringGenerator HiddenStringGenerator = new RandomStringGenerator();
            r_HiddenString = HiddenStringGenerator.GenerateNewRandomString();
        }

        public string HiddenString
        {
            get
            {
                return r_HiddenString;
            }
        }

        public string CalculateScore(string i_InputString)
        {
            int correctLetterAndPlacementCounter = 0;
            int onlyCorrectLetterCounter = 0;
            string scoreString;

            for (int i = 0; i < 7; i = i + 2)
            {
                if (i_InputString[i] == r_HiddenString[i])
                {
                    correctLetterAndPlacementCounter++;
                    continue;
                }

                for (int j = 0; j < 7; j = j + 2)
                {
                    if (i_InputString[i] == r_HiddenString[j])
                    {
                        onlyCorrectLetterCounter++;
                    }
                }
            }

            scoreString = scoreStringBuilder(correctLetterAndPlacementCounter, onlyCorrectLetterCounter);

            return scoreString;
        }

        private string scoreStringBuilder(int i_VCounter, int i_Xcounter)
        {
            StringBuilder scoreBuilder = new StringBuilder();

            for (int i = 0; i < i_VCounter; i++)
            {
                // $G$ NTT-999 (-5) You should have used constants here
                scoreBuilder.Append("V ");
            }

            for (int i = 0; i < i_Xcounter; i++)
            {
                scoreBuilder.Append("X ");
            }

            if ((i_VCounter + i_Xcounter) == 4)
            {
                scoreBuilder.Remove(7, 1);
            }

            while (scoreBuilder.Length < 7)
            {
                scoreBuilder.Append(" ");
            }

            m_CurrentScore = scoreBuilder.ToString();
            return scoreBuilder.ToString();
        }

        public bool WinGame()
        {
            bool isGameWon = false;

            if (m_CurrentScore == "V V V V")
            {
                isGameWon = true;
            }

            return isGameWon;
        }
    }
}
