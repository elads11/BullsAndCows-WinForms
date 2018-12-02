using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ex05.BullsAndCows
{
    public partial class ColorForm : Form
    {
        public Button[] m_ColorButtonArray;
        private Color m_PickedColor;
        private object m_ColorLetter;

        public Color PickedColor
        {
            get
            {
                return m_PickedColor;
            }
        }

        public object ColorLetter
        {
            get
            {
                return m_ColorLetter;
            }
        }

        public ColorForm()
        {
            m_ColorButtonArray = new Button[8];

            InitializeComponent();
            for (int i = 0; i < 4; i++)
            {
                m_ColorButtonArray[i] = m_UpperLine.m_HorizontalButtonArray[i];
            }

            for (int i = 4; i < 8; i++)
            {
                m_ColorButtonArray[i] = m_LowerLine.m_HorizontalButtonArray[i - 4];
            }

            foreach (Button button in m_ColorButtonArray)
            {
                button.Enabled = true;
            }

            designateColorsAndLettersToButtons();
        }

        private void designateColorsAndLettersToButtons()
        {
            m_ColorButtonArray[0].BackColor = Color.BlueViolet;
            m_ColorButtonArray[0].Tag = 'A';
            m_ColorButtonArray[1].BackColor = Color.Red;
            m_ColorButtonArray[1].Tag = 'B';
            m_ColorButtonArray[2].BackColor = Color.LawnGreen;
            m_ColorButtonArray[2].Tag = 'C';
            m_ColorButtonArray[3].BackColor = Color.DeepSkyBlue;
            m_ColorButtonArray[3].Tag = 'D';
            m_ColorButtonArray[4].BackColor = Color.Blue;
            m_ColorButtonArray[4].Tag = 'E';
            m_ColorButtonArray[5].BackColor = Color.Yellow;
            m_ColorButtonArray[5].Tag = 'F';
            m_ColorButtonArray[6].BackColor = Color.SaddleBrown;
            m_ColorButtonArray[6].Tag = 'G';
            m_ColorButtonArray[7].BackColor = Color.Magenta;
            m_ColorButtonArray[7].Tag = 'H';
        }

        private void colorButton_click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            this.DialogResult = DialogResult.OK;
            m_PickedColor = clickedButton.BackColor;
            m_ColorLetter = clickedButton.Tag;
            clickedButton.Enabled = false;
        }
    }
}
