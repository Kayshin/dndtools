using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToolCore
{
    public interface ICore
    {
        /// <summary>
        /// Id of the object
        /// </summary>
        Guid Id
        {
            get;
            set;
        }

        /// <summary>
        /// Name of the object
        /// </summary>
        string Name
        {
            get;
            set;
        }

        void Print();
    }
}
