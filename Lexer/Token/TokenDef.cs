using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Implementation.Lexer.Token {
    public class TokenDef {
        private Regex _regex;
        private readonly TokenType _type;
        private readonly int _precedence;

        public TokenDef(TokenType type, string regexPattern, int precedence) {
            _regex = new Regex(regexPattern, RegexOptions.Compiled);
            _type = type;
            _precedence = precedence;
        }

        public IEnumerable<TokenMatch> GetMatches(string inputString) {
            MatchCollection matches = _regex.Matches(inputString);
            for (int i = 0; i < matches.Count; i++) {
                yield return new TokenMatch(
                    _type,
                    _precedence,
                    matches[i].Index, 
                    matches[i].Index + matches[i].Length,
                    matches[i].Value
                    );
            }
        }
    }
}