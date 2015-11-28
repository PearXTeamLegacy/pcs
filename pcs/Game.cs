﻿using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using pcs.Types;
using PearXLib.Engine;
using pcs.Properties;

namespace pcs
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            foreach(PCSMod pcsm in Getting.GetMods())
            {
                pcsm.OnGamePreLoad();
            }
            a.AutoLoad();
            foreach (PCSMod pcsm in Getting.GetMods())
            {
                pcsm.OnGameLoad();
            }
            a.prepareGame();


            timerSleep.Start();
            timerFood.Start();
            timerMood.Start();
            timerPurity.Start();

            Icon = Resources.pcs;

            #region Icons init
            int column = 0;
            int row = 0;
            foreach(SIcon i in Registry.RegisteredIcons)
            {
                XIcon xi = new XIcon();
                xi.Title = i.Name();
                xi.Icon = i.Icon();
                xi.Font = new Font("Microsoft Sans MS", 13F, FontStyle.Regular);
                xi.Click += i.OnClick;
                xi.Size = new Size(90, 90 + (int)xi.TitleWidthHeight.Height);
                xi.Location = new Point((100 * row) + 10, (136 * column) + 10);
                xi.ForeColor = Color.DarkOrange;
                xi.Cursor = Cursors.Hand;
                row++;
                if (row == 8)
                {
                    column++;
                    row = 0;
                }
                panelIcons.Controls.Add(xi);
            }
            #endregion

            #region MiniIcons init
            int column2 = 0;
            int row2 = 0;
            foreach (SMiniIcon mi in Registry.RegisteredMiniIcons)
            {
                XIcon xi = new XIcon();
                xi.Icon = mi.Icon();
                xi.Click += mi.OnClick;
                xi.Size = new Size(32, 32);
                xi.Location = new Point((42 * row2) + 10, (42 * column2) + 10);
                xi.Cursor = Cursors.Hand;
                xi.Expand = 3;
                row2++;
                if (row2 == 4)
                {
                    column2++;
                    row2 = 0;
                }
                panelMiniIcons.Controls.Add(xi);
            }
            #endregion
            foreach (PCSMod pcsm in Getting.GetMods())
            {
                pcsm.OnGamePostLoad();
            }
        }

        private void timerFood_Tick(object sender, EventArgs e)
        {
            v.Food--;
        }

        private void timerSleep_Tick(object sender, EventArgs e)
        {
            v.Sleep--;
        }

        private void timerMood_Tick(object sender, EventArgs e)
        {
            v.Mood--;
        }

        private void timerPurity_Tick(object sender, EventArgs e)
        {
            v.Purity--;
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!v.forceClose)
            {
                DialogResult r = MessageBox.Show(v.l.GetString("other.closeMessage"), "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    a.AutoSave();
                    v.forceClose = true;
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                if (v.forceCloseUseSave)
                {
                    a.AutoSave();
                }
                Application.Exit();
            }
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C && !Application.OpenForms.OfType<Chat>().Any())
            {
                v.c = new Chat();
                v.c.Owner = this;
                v.c.Show();
            }
        }

        private void Game_LocationChanged(object sender, EventArgs e)
        {
            if (v.c != null)
            {
                v.c.Location = new Point((Location.X + Size.Width) - v.c.Size.Width, (Location.Y + Size.Height) - v.c.Size.Height);
            }
        }
    }
}
