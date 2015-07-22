using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace core.bl
{
    public class MatrixItem
    {
        public List<double> items = new List<double>();

        public double restriction;
        public String Sign = staticConst.SIGNLESSEQUALLY;

        public void addItem(double item)
        {
            items.Add(item);
        }
    }
}
