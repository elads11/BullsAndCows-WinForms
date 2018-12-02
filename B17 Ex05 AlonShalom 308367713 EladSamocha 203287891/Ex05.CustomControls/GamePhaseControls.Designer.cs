using System.Drawing;
using System.Windows.Forms;

namespace Ex05.CustomControls
{
    public partial class GamePhaseControls
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Size = new Size(325, 40);

            m_HorizontalButtons = new FourHorizontalButtons();

            m_MiddleButton = new Button();
            m_MiddleButton.Location = new Point(205, 10);
            m_MiddleButton.Enabled = false;

            m_BlockButtons = new FourButtonBlock();
            m_BlockButtons.Location = new Point(290, 3);

            this.Controls.Add(m_HorizontalButtons);
            this.Controls.Add(m_MiddleButton);
            this.Controls.Add(m_BlockButtons);
        }

        private FourHorizontalButtons m_HorizontalButtons;
        private FourButtonBlock m_BlockButtons;
        private Button m_MiddleButton;
        
        #endregion
    }
}
