﻿namespace pcs
{
    partial class SaveManager
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
            this.panelSaves = new System.Windows.Forms.Panel();
            this.textBoxSaveName = new System.Windows.Forms.TextBox();
            this.buttonReset = new PearXLib.Engine.XButton();
            this.buttonSave = new PearXLib.Engine.XButton();
            this.panelSaves.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSaves
            // 
            this.panelSaves.AutoScroll = true;
            this.panelSaves.Location = new System.Drawing.Point(1, 0);
            this.panelSaves.Name = "panelSaves";
            this.panelSaves.Size = new System.Drawing.Size(362, 214);
            this.panelSaves.TabIndex = 0;
            // 
            // textBoxSaveName
            // 
            this.textBoxSaveName.Location = new System.Drawing.Point(68, 226);
            this.textBoxSaveName.Name = "textBoxSaveName";
            this.textBoxSaveName.Size = new System.Drawing.Size(163, 20);
            this.textBoxSaveName.TabIndex = 0;
            this.textBoxSaveName.Visible = false;
            this.textBoxSaveName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSaveName_KeyDown);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.Transparent;
            this.buttonReset.ColorPressed = System.Drawing.Color.Red;
            this.buttonReset.GradientColor1 = System.Drawing.Color.Red;
            this.buttonReset.GradientColorFocused1 = System.Drawing.Color.DarkRed;
            this.buttonReset.Location = new System.Drawing.Point(280, 220);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(83, 64);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Transparent;
            this.buttonSave.ColorPressed = System.Drawing.Color.MidnightBlue;
            this.buttonSave.GradientColor1 = System.Drawing.Color.Blue;
            this.buttonSave.GradientColorFocused1 = System.Drawing.Color.DarkBlue;
            this.buttonSave.Location = new System.Drawing.Point(12, 220);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(262, 64);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // SaveManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 285);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.textBoxSaveName);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.panelSaves);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "SaveManager";
            this.Text = "SaveManager";
            this.Load += new System.EventHandler(this.SaveManager_Load);
            this.panelSaves.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSaves;
        private PearXLib.Engine.XButton buttonSave;
        private System.Windows.Forms.TextBox textBoxSaveName;
        private PearXLib.Engine.XButton buttonReset;
    }
}