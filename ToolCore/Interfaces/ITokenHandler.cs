using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToolCore.Interfaces
{
    public interface ITokenHandler : ICore
    {
        /// <summary>
        /// List of Tokens for this handler
        /// </summary>
        IEnumerable<IToken> Tokens { get; set; }

        /// <param name="token">The token to add</param>
        IToken AddToken(IToken token);
        /// <summary>
        /// Remove a token from the list
        /// </summary>
        /// <param name="token">The token to remove</param>
        bool RemoveToken(IToken token);
        /// <summary>
        /// Print the list of tokens
        /// </summary>
        void PrintTokens();
    }
}
