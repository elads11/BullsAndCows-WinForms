using System.Windows.Forms;

namespace Ex05.CustomControls
{
    public partial class GamePhaseControls : UserControl
    {
        public Button[] m_GameButtonsArray;

        public GamePhaseControls()
        {
            InitializeComponent();
            m_GameButtonsArray = new Button[9];

            for (int i = 0; i < 4; i++)
            {
                m_GameButtonsArray[i] = m_HorizontalButtons.m_HorizontalButtonArray[i];
            }

            m_GameButtonsArray[4] = m_MiddleButton;
            for (int i = 5; i < 9; i++)
            {
                m_GameButtonsArray[i] = m_BlockButtons.m_BlockButtonArray[i - 5];
            }
        }

        public Button MiddleButton
        {
            get
            {
                return m_MiddleButton;
            }
        }

        public FourHorizontalButtons HorizontalButtons
        {
            get
            {
                return m_HorizontalButtons;
            }
        }

        public void EnableHorizontalButtons()
        {
            m_HorizontalButtons.EnableButtons();
        }
    }
}
