using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Ex05.CustomControls;

namespace Ex05.BullsAndCows
{
    internal partial class GameForm
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
        private void InitializeComponent(int i_BoardSize)
        {
            int boardHeight = 60;

            m_BlackButtons = new FourHorizontalButtons();
            m_BlackButtons.Location = new Point(10, 10);
            foreach (Button blackButton in m_BlackButtons.m_HorizontalButtonArray)
            {
                blackButton.BackColor = Color.Black;
            }

            for (int i = 0; i < i_BoardSize; i++)
            {
                GamePhaseControls gamePhase = new GamePhaseControls();
                Button scoreResultButton = gamePhase.MiddleButton;
                gamePhase.Location = new Point(10, boardHeight);
                this.Controls.Add(gamePhase);
                m_GamePhaseArray[i] = gamePhase;
                foreach (Button guessButton in gamePhase.HorizontalButtons.m_HorizontalButtonArray)
                {
                    guessButton.Click += new EventHandler(guessButton_Click);
                }

                scoreResultButton.Click += new EventHandler(scoreResultButton_Click);
                scoreResultButton.Text = "->>";
                boardHeight += 50;
            }

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "Bulls and Cows";
            this.Size = new Size(350, 300 + (i_BoardSize - 4) * 50);
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Controls.Add(m_BlackButtons);
        }

        private FourHorizontalButtons m_BlackButtons;

        #endregion
    }
}