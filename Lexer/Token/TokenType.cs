namespace Implementation.Lexer.Token {
    public enum TokenType {
        Plus,
        Minus,
        Mult,
        Div,
        
        Dot,
        Comma,
        Colon,
        Semicolon,
        
        Not,
        Equal,
        LessThan,
        GreaterThan,
        
        NotEqual,
        DoubleEqual,
        LessThanEqual,
        GreaterThanEqual,

        Comment,
        Identifier,
        Number,
        String,
        
        Abstract,
        Pub,
        Class,
        Parent,
        This,
        Fun,
        Let,
        Val,
        If,
        Else,
        For,
        While,
        When,
        ForEach,
        As,
        Import,
        Export,
        
        LeftParen,
        LeftBrace,
        LeftBracket,
        RightParen,
        RightBrace,
        RightBracket,
    }
}