using System;
using System.Windows.Forms;

namespace Ex05.BullsAndCows
{
    public partial class GuessForm : Form
    {
        private int m_ChanceChoice = 4;

        public GuessForm()
        {
            InitializeComponent();
        }

        private void m_ButtonChance_Click(object sender, EventArgs e)
        {
            m_ChanceChoice++;
            if (m_ChanceChoice == 11)
            {
                m_ChanceChoice = 4;
            }

            m_ButtonChance.Text = string.Format("Number of chances: {0}", m_ChanceChoice);
        }

        private void m_ButtonStart_Click(object sender, EventArgs e)
        {
            GameForm Game = new GameForm(m_ChanceChoice);

            this.Hide();
            this.DialogResult = DialogResult.OK;
            this.Close();
            Game.ShowDialog();
        }
    }
}
