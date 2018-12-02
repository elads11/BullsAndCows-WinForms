using System.Windows.Forms;

namespace Ex05.CustomControls
{
    public partial class FourButtonBlock : UserControl
    {
        public Button[] m_BlockButtonArray = new Button[4];

        public FourButtonBlock()
        {
            InitializeComponent();
        }
    }
}
