using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Ex05.CustomControls;

namespace Ex05.BullsAndCows
{
    internal partial class GameForm : Form
    {
        private const int k_AsciiValueLetterA = 65;
        private static ColorForm s_ColorForm = new ColorForm();
        private static GameLogic s_GameManager = new GameLogic();
        private readonly int r_GameLength;
        private GamePhaseControls[] m_GamePhaseArray;
        private int m_CurrentGamePhase = 0;

        public GameForm(int io_BoardSize)
        {
            r_GameLength = io_BoardSize;
            m_GamePhaseArray = new GamePhaseControls[io_BoardSize];
            InitializeComponent(io_BoardSize);
            m_GamePhaseArray[0].EnableHorizontalButtons();
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (s_ColorForm.ShowDialog() == DialogResult.OK)
            {
                if (clickedButton.BackColor != DefaultBackColor)
                {
                    Color PreviousColor = clickedButton.BackColor;
                    foreach (Button colorButton in s_ColorForm.m_ColorButtonArray)
                    {
                        if (colorButton.BackColor == PreviousColor)
                        {
                            colorButton.Enabled = true;
                            break;
                        }
                    }
                }

                clickedButton.BackColor = s_ColorForm.PickedColor;
                clickedButton.Tag = s_ColorForm.ColorLetter;
                if (isAllColorsChosen(m_GamePhaseArray[m_CurrentGamePhase]))
                {
                    m_GamePhaseArray[m_CurrentGamePhase].MiddleButton.Enabled = true;
                }
            }
        }

        private bool isAllColorsChosen(GamePhaseControls i_CurrentLine)
        {
            bool isAllColorChosen = true;

            for (int i = 0; i < 4; i++)
            {
                if (i_CurrentLine.HorizontalButtons.m_HorizontalButtonArray[i].BackColor == DefaultBackColor)
                {
                    isAllColorChosen = false;
                    break;
                }
            }

            return isAllColorChosen;
        }

        private void scoreResultButton_Click(object sender, EventArgs e)
        {
            string currentLineScore;
            currentLineScore = s_GameManager.CalculateScore(convertButtonSelectionToStringOfLetters());
            graphiclyDisplayScore(currentLineScore);
            m_GamePhaseArray[m_CurrentGamePhase].Enabled = false;
            if (m_CurrentGamePhase != r_GameLength - 1)
            {
                if (!s_GameManager.WinGame())
                {
                    m_CurrentGamePhase++;
                    m_GamePhaseArray[m_CurrentGamePhase].EnableHorizontalButtons();
                    s_ColorForm = new ColorForm();
                }
            }

            if (s_GameManager.WinGame())
            {
                revealHiddenColors(s_GameManager.HiddenString);
            }
        }

        private string convertButtonSelectionToStringOfLetters()
        {
            StringBuilder GuessBuilder = new StringBuilder();

            for (int i = 0; i < 4; i++)
            {
                GuessBuilder.Append(m_GamePhaseArray[m_CurrentGamePhase].m_GameButtonsArray[i].Tag);
                GuessBuilder.Append(" ");
            }

            GuessBuilder.Remove(7, 1);
            return GuessBuilder.ToString();
        }

        private void graphiclyDisplayScore(string i_ScoreString)
        {
            int unpaintedBlock = 5;

            for (int i = 0; i < 7; i += 2)
            {
                if (i_ScoreString[i] == 'V')
                {
                    m_GamePhaseArray[m_CurrentGamePhase].m_GameButtonsArray[unpaintedBlock].BackColor = Color.Black;
                    unpaintedBlock++;
                }
                
                if (i_ScoreString[i] == 'X')
                {
                    m_GamePhaseArray[m_CurrentGamePhase].m_GameButtonsArray[unpaintedBlock].BackColor = Color.Yellow;
                    unpaintedBlock++;
                }
            }
        }

        private void revealHiddenColors(string i_HiddenString)
        {
            int blackButtonIndex = 0;

            for (int i = 0; i < 7; i += 2)
            {
                m_BlackButtons.m_HorizontalButtonArray[blackButtonIndex].BackColor =
                    s_ColorForm.m_ColorButtonArray[i_HiddenString[i] - k_AsciiValueLetterA].BackColor;
                blackButtonIndex++;
            }
        }
    }
}
