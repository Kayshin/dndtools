using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToolCore
{
    public class TokenHandler : Core, ITokenHandler
    {
        public IEnumerable<IToken> Tokens { get; set; }

        public TokenHandler()
            : base()
        {
            Tokens = new List<IToken>();
        }

        public TokenHandler(string name)
            : base(name)
        {
            Tokens = new List<IToken>();
        }

        public IToken AddToken(IToken token)
        {
            ((List<IToken>)Tokens).Add(token);
            return Tokens.Last();
        }

        public bool RemoveToken(IToken token)
        {
            return ((List<IToken>)Tokens).Remove(token);
        }

        public void PrintTokens()
        {
            foreach (var token in Tokens)
            {
                token.Print();
            }
        }
    }
}
