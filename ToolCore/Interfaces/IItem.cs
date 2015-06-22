using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ToolCore
{
    public interface IItem : ICore
    {
        string Name
        {
            get;
            set;
        }

        int Value
        {
            get;
            set;
        }
    }
}
