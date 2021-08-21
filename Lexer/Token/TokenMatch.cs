namespace Implementation.Lexer.Token {
    public class TokenMatch {
        public TokenType TokenType;
        public int Precedence;
        public int StartIndex;
        public int EndIndex;
        public string Value;
        
        public TokenMatch(TokenType tokenType, int precedence, int startIndex, int endIndex, string value) {
            TokenType = tokenType;
            Precedence = precedence;
            StartIndex = startIndex;
            EndIndex = endIndex;
            Value = value;
        }
    }
}