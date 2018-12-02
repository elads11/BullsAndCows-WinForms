using System;
using System.Drawing;
using System.Windows.Forms;
using Ex05.CustomControls;

namespace Ex05.BullsAndCows
{
    public partial class ColorForm
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
            m_UpperLine = new FourHorizontalButtons();
            m_UpperLine.Location = new Point(5, 10);
            foreach (Button colorButton in m_UpperLine.m_HorizontalButtonArray)
            {
                colorButton.Click += new EventHandler(colorButton_click);
            }

            m_LowerLine = new FourHorizontalButtons();
            m_LowerLine.Location = new Point(5, 55);
            foreach (Button colorButton in m_LowerLine.m_HorizontalButtonArray)
            {
                colorButton.Click += new EventHandler(colorButton_click);
            }

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "ColorForm";
            this.Size = new Size(220, 145);
            this.Controls.Add(m_UpperLine);
            this.Controls.Add(m_LowerLine);
        }

        private FourHorizontalButtons m_UpperLine;
        private FourHorizontalButtons m_LowerLine;
        
        #endregion
    }
}