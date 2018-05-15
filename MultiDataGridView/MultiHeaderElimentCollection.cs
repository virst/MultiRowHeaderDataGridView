using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiDataGridView
{
    internal class MultiHeaderElimentCollection : List<MultiHeaderEliment>
    {
        public int TotalHeight(int c)
        {
            var r = 0;
            foreach (MultiHeaderEliment o in this)
            {
                if (o.Position.X <= c && c < o.Position.X + o.Position.Width)
                    r += o.Position.Height;
            }
            return r;
        }
    }
}
