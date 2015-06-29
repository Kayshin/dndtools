using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToolCore.Interfaces.Managers
{
    public interface IOutputManager : ICore
    {
        void Write(string theString);
    }
}
