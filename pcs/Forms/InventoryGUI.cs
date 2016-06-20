﻿using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using pcs.Components;
using pcs.Components.Controls;
using pcs.Components.IAI;
using pcs.Player;

namespace pcs.Forms
{
    public partial class InventoryGUI : PCSForm
    {
        public static InventoryGUI Instance = new InventoryGUI();

        public InventoryGUI()
        {
            InitializeComponent();
        }

        public void UpdateInventory()
        {
            new Thread(() =>
            {
                if(IsHandleCreated)
                    Invoke(new MethodInvoker(() => panelInv.Controls.Clear()));
                else
                    panelInv.Controls.Clear();

                int x = 0;
                int y = 0;
                foreach (var v in PlayerInventory.Inventory)
                {
                    PCSInvItemC item = new PCSInvItemC
                    {
                        ItemImage = v.Item.Icon(v),
                        ItemName = v.Item.Name(v),
                        ItemDesc = v.Item.Description(v),
                        ItemAmount = v.StackCount
                    };

                    item.Location = new Point(x * (item.Width + 4), y * item.Height);
                    item.MouseClick += (sender, args) =>
                    {
                        int index = PlayerInventory.Inventory.IndexOf(v);
                        ItemStack s = PlayerInventory.Inventory[index];
                        v.Item.OnUse(args.Button, ref s);
                        if (s != v)
                        {
                            PlayerInventory.Inventory[index] = s;
                            UpdateInventory();
                        }
                    };
                    if (x == 6)
                    {
                        x = -1;
                        y++;
                    }

                    if(IsHandleCreated)
                        Invoke(new MethodInvoker(() => panelInv.Controls.Add(item)));
                    else
                        panelInv.Controls.Add(item);
                    x++;
                }
            }).Start();
        }

        protected override void OnShown(EventArgs e)
        {
            UpdateInventory();
        }
    }
}
