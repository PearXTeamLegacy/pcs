﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace pcs.Types
{
    public interface SIcon
    {
        string Name();
        Image Icon();
        void OnClick(object sender, EventArgs e);
    }
}
