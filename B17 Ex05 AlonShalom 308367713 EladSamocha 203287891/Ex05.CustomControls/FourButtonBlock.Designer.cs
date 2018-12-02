using System.Drawing;
using System.Windows.Forms;

namespace Ex05.CustomControls
{
    public partial class FourButtonBlock
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
            this.Size = new Size(35, 35);

            int buttonHorizontalLocation = 0;
            for (int i = 0; i < 2; i++)
            {
                Button buttonScoreResult = new Button();
                buttonScoreResult.Size = new Size(15, 15);
                buttonScoreResult.Location = new Point(buttonHorizontalLocation, 0);
                buttonScoreResult.Enabled = false;
                m_BlockButtonArray[i] = buttonScoreResult;
                this.Controls.Add(buttonScoreResult);
                buttonHorizontalLocation += 20;
            }

            buttonHorizontalLocation = 0;
            for (int i = 2; i < 4; i++)
            {
                Button buttonScoreResult = new Button();
                buttonScoreResult.Size = new Size(15, 15);
                buttonScoreResult.Location = new Point(buttonHorizontalLocation, 20);
                buttonScoreResult.Enabled = false;
                m_BlockButtonArray[i] = buttonScoreResult;
                this.Controls.Add(buttonScoreResult);
                buttonHorizontalLocation += 20;
            }
        }

        #endregion
    }
}
