using System.Drawing;
using System.Windows.Forms;

namespace Ex05.CustomControls
{
    public partial class FourHorizontalButtons
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
            this.Size = new Size(190, 40);

            int buttonHorizontalLocation = 0;

            for (int i = 0; i < 4; i++)
            {
                Button button = new Button();
                button.Size = new Size(40, 40);
                button.Location = new Point(buttonHorizontalLocation, 0);
                button.Enabled = false;

                m_HorizontalButtonArray[i] = button;
                this.Controls.Add(button);
                buttonHorizontalLocation += 50;
            }
        }

        #endregion
    }
}
