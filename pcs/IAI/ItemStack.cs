﻿using System.ComponentModel;
using pcs.Components;
using pcs.Forms;

namespace pcs.IAI
{
    public class ItemStack
    {
        protected ObjectData _Data = new ObjectData();
        protected Item _Item = new Item();
        protected int _StackCount = 1;
        protected string _SubID = "";

        public ItemStack(Item itm, int count = 1, string subID = "")
        {
            Item = itm;
            StackCount = count;
            SubID = subID;
        }

        /// <summary>
        /// An Item's data.
        /// </summary>
        public ObjectData Data
        {
            get { return _Data; }
            set { _Data = value; InventoryGUI.UpdateInventory(); }
        }

        /// <summary>
        /// An Item's data.
        /// </summary>
        public Item Item
        {
            get { return _Item; }
            set { _Item = value; InventoryGUI.UpdateInventory(); }
        }

        /// <summary>
        /// Items in stack
        /// </summary>
        public virtual int StackCount
        {
            get { return _StackCount; }
            set { _StackCount = value; InventoryGUI.UpdateInventory(); }
        }

        /// <summary>
        /// Item's sub-ID.
        /// </summary>
        public virtual string SubID
        {
            get { return _SubID; }
            set { _SubID = value; InventoryGUI.UpdateInventory(); }
        }

        public static bool Equals(ItemStack one, ItemStack two, ItemStackCompareOptions o)
        {
            bool defEquals = one.Item == two.Item && one.SubID == two.SubID;
            switch (o)
            {
                case ItemStackCompareOptions.Default:
                    return defEquals;
                case ItemStackCompareOptions.ByData:
                    return defEquals && one.Data == two.Data;
                case ItemStackCompareOptions.ByCount:
                    return defEquals && one.StackCount == two.StackCount;
                case ItemStackCompareOptions.ByDataAndCount:
                    return defEquals && one.Data == two.Data && one.StackCount == two.StackCount;
            }
            return false;
        }
    }

    public enum ItemStackCompareOptions
    {
        Default,
        ByData,
        ByCount,
        ByDataAndCount
    }
}
