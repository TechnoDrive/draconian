using System.Collections.Generic;
using System.Linq;

using Implementation.Lexer.Token;

using static Implementation.Lexer.Token.TokenType;

namespace Implementation.Lexer {
    public class Lexer {
        private List<TokenDef> _tokenDefinitions = new List<TokenDef> {
            new TokenDef(String, @"""(?:\.|(\\\"")|[^\""""\n])*""", 1),
            new TokenDef(Number, @"(\d+)(.\d+)?", 1),
            new TokenDef(Identifier, @"[_a-zA-Z][_a-zA-Z0-9]{0,32}", 2),
            new TokenDef(Comment, @"#.*", 1),

            new TokenDef(Plus, @"\+", 1),
            new TokenDef(Minus, @"-", 1),
            new TokenDef(Mult, @"\*", 1),
            new TokenDef(Div, @"/", 1),
            
            new TokenDef(Dot, @"\.", 1),
            new TokenDef(Comma, @",", 1),
            new TokenDef(Colon, @":", 1),
            new TokenDef(Semicolon, @";", 1),
            
            new TokenDef(Not, @"!", 2),
            new TokenDef(Equal, @"=", 2),
            new TokenDef(LessThan, @"<", 2),
            new TokenDef(GreaterThan, @">", 2),
            
            new TokenDef(NotEqual, @"!=", 1),
            new TokenDef(EqualEqual, @"==", 1),
            new TokenDef(LessThanEqual, @"<=", 1),
            new TokenDef(GreaterThanEqual, @">=", 1),

            new TokenDef(LeftParen, @"\(", 1),
            new TokenDef(LeftBrace, @"\[", 1),
            new TokenDef(LeftBracket, @"\{", 1),
            new TokenDef(RightParen, @"\)", 1),
            new TokenDef(RightBrace, @"\]", 1),
            new TokenDef(RightBracket, @"}", 1),

            new TokenDef(Abstract, "abstract", 1),
            new TokenDef(Pub, "pub", 1),
            new TokenDef(Class, "class", 1),
            new TokenDef(Parent, "parent", 1),
            new TokenDef(This, "this", 1),
            new TokenDef(Fun, "fun", 1),
            new TokenDef(Let, "let", 1),
            new TokenDef(Val, "val", 1),
            new TokenDef(If, "if", 1),
            new TokenDef(Else, "else", 1),
            new TokenDef(For, "for", 1),
            new TokenDef(While, "while", 1),
            new TokenDef(When, "when", 1),
            new TokenDef(ForEach, "forEach", 1),
            new TokenDef(As, "as", 1),
            new TokenDef(Import, "import", 1),
            new TokenDef(Export, "export", 1),
        };
        
        public IEnumerable<Token.Token> Tokenize(string input)
        {
            IEnumerable<TokenMatch> tokenMatches = FindTokenMatches(input);

            List<IGrouping<int, TokenMatch>> groupedByIndex = tokenMatches.GroupBy(x => x.StartIndex)
                .OrderBy(x => x.Key)
                .ToList();

            TokenMatch lastMatch = null;
            
            foreach (IGrouping<int, TokenMatch> t in groupedByIndex) {
                TokenMatch bestMatch = t.OrderBy(x => x.Precedence).First();
                if (lastMatch != null && bestMatch.StartIndex < lastMatch.EndIndex)
                    continue;

                yield return new Token.Token(bestMatch.TokenType, bestMatch.Value);

                lastMatch = bestMatch;
            }

            yield return new Token.Token(EndOfFile, null);
        }

        private IEnumerable<TokenMatch> FindTokenMatches(string input)
        {
            var tokenMatches = new List<TokenMatch>();

            foreach (var tokenDefinition in _tokenDefinitions)
                tokenMatches.AddRange(tokenDefinition.GetMatches(input).ToList());

            return tokenMatches;
        }
    }
}