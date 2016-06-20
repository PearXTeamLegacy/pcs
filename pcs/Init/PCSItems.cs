﻿using pcs.Components.IAI;
using pcs.Core;
using pcs.Items;

namespace pcs.Init
{
    public class PCSItems
    {
        public static Item Sand = new Item(PCS.Loc.GetString("item.sand"), "PCS:Sand", PCSImages.Sand, 160);
        public static Item Crasher = new ItemCrasher();
    }
}
