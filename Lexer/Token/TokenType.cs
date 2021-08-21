namespace Implementation.Lexer.Token {
    public enum TokenType {
        Comment,
        Identifier,
        Number,
        String,
        
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
        EqualEqual,
        LessThanEqual,
        GreaterThanEqual,

        LeftParen,
        LeftBrace,
        LeftBracket,
        RightParen,
        RightBrace,
        RightBracket,
        
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

        EndOfFile
    }
}