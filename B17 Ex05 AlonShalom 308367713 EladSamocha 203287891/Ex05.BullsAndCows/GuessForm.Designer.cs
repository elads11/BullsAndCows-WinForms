using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ex05.BullsAndCows
{
    public partial class GuessForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            m_ButtonChance = new Button();
            m_ChanceButtonText = "Number of chances: 4";
            m_ButtonChance.Text = m_ChanceButtonText;
            m_ButtonChance.Location = new Point(15, 30);            
            m_ButtonChance.Size = new Size(250, 50);
            m_ButtonChance.Click += new EventHandler(m_ButtonChance_Click);

            m_ButtonStart = new Button();
            m_ButtonStart.Text = "Start";
            m_ButtonStart.Location = new Point(180, 200);
            m_ButtonStart.Click += new EventHandler(m_ButtonStart_Click);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "Choose Game settings";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.Controls.Add(m_ButtonStart);
            this.Controls.Add(m_ButtonChance);
        }

        #endregion

        private Button m_ButtonChance;
        private Button m_ButtonStart;
        private string m_ChanceButtonText;
    }
}