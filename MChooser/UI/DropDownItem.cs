using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MChooser.UI
{
    public class DropDownItem
    {
        public string DisplayValue;
        public string Value;

        public DropDownItem(string displayValue, string systemValue)
        {
            this.DisplayValue = displayValue;
            this.Value = systemValue;
        }

        public override string ToString()
        {
            return this.DisplayValue;
        }
    }
}
