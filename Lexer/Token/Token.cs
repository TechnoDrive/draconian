using Implementation.Language;

namespace Implementation.Lexer.Token {
    public struct Token {
        public TokenType Type;
        public string Lexeme;

        public Token(TokenType type, string lexeme) {
            Type = type;
            Lexeme = lexeme;
        }

        public override string ToString() {
            return $"Token {{ Type: {Type}, Lexeme: {Lexeme} }}";
        }
    }
}