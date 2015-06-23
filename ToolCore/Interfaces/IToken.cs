using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToolCore
{
    public interface IToken : ICore
    {
        /// <summary>
        /// Owner
        /// </summary>
        IPlayer Owner { get; set; }

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
