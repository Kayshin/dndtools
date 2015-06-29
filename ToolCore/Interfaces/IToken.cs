using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToolCore.Interfaces
{
    public interface IToken : ICore
    {
        /// <summary>
        /// Initiative
        /// </summary>
        int Initiative { get; set; }
        /// <summary>
        /// Maximum Health
        /// </summary>
        int MaxHealth { get; set; }
        /// <summary>
        /// Current Health
        /// </summary>
        int CurrentHealth { get; set; }
        /// <summary>
        /// Temporary Health
        /// </summary>
        int TempHealth { get; set; }
    }
}
