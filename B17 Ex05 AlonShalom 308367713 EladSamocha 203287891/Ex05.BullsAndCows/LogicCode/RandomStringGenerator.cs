using System;
using System.Text;

namespace Ex05.BullsAndCows
{
    internal class RandomStringGenerator
    {
        private const int k_AsciiValueLetterA = 65;
        private static Utilities s_Util = new Utilities();
        private int m_CurrentRandomIndex;
        private char[] m_LetterArray = new char[8];
        private Random m_RandomGenerator = new Random();
        private StringBuilder m_HiddenStringBuilder;

        public RandomStringGenerator()
        {
            int capitalLetterAscii = k_AsciiValueLetterA;
            for (int i = 0; i < 8; i++)
            {
                m_LetterArray[i] = (char)capitalLetterAscii;
                capitalLetterAscii++;
            }
        }

        public string GenerateNewRandomString()
        {
            m_HiddenStringBuilder = new StringBuilder();
            for (int i = 7; i > 3; i--)
            {
                m_CurrentRandomIndex = m_RandomGenerator.Next(i);
                s_Util.Swap(ref m_LetterArray[m_CurrentRandomIndex], ref m_LetterArray[i]);
                m_HiddenStringBuilder.Append(m_LetterArray[i]);
                m_HiddenStringBuilder.Append(" ");
            }

            m_HiddenStringBuilder.Remove(7, 1);

            return m_HiddenStringBuilder.ToString();
        }
    }
}
