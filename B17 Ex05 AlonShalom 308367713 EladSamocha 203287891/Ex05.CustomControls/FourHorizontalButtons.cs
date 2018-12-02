using System.Windows.Forms;

namespace Ex05.CustomControls
{
    public partial class FourHorizontalButtons : UserControl
    {
        public Button[] m_HorizontalButtonArray = new Button[4];

        public FourHorizontalButtons()
        {
            InitializeComponent();
        }

        internal void EnableButtons()
        {
            foreach (Button button in m_HorizontalButtonArray)
            {
                button.Enabled = true;
            }
        }
    }
}
