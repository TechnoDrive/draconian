using Implementation.Language;

namespace Implementation.Lexer.Token {
    public struct Token {
        public TokenType Type;
        public string Lexeme;
        public Location Location;

        public Token(TokenType type, string lexeme, Location location) {
            Type = type;
            Lexeme = lexeme;
            Location = location;
        }

        public override string ToString() {
            return $"Token {{ Type: {Type}, Lexeme: {Lexeme}, Location: {Location} }}";
        }
    }
}