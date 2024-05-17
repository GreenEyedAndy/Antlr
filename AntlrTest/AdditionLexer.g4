lexer grammar AdditionLexer;

// Lexer rules return tokens. Lexer rules are uppercase.
PLUS : '+';
INT : [0-9]+ ; // INT is one or more digits

// Ignore whitespace.
WS : [ \t\r\n]+ -> skip ;
