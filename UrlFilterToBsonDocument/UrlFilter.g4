grammar UrlFilter;

parse
    : expr EOF
    ;

expr
    : expr LOGOP expr   # LogicalOperation
    | '(' expr ')'      # ParenthesizedExpression
    | comparison        # ComparisonExpression
    ;

comparison
    : IDENTIFIER OP value
    ;

value
    : STRING
    | NUMBER
    | DATETIME
    | BOOLEAN
    | IDENTIFIER
    ;
    
OP
    : 'eq'
    | 'neq'
    | 'gt'
    | 'gte'
    | 'lt'
    | 'lte'
    ;

LOGOP
    : 'and'
    | 'or'
    ;


BOOLEAN
    : 'true' 
    | 'false' 
    ;

IDENTIFIER
    : [a-zA-Z_][a-zA-Z_]+ 
    ;
    
STRING
    : '"' ~('\r' | '\n' | '"')* '"' 
    ;
    
DATETIME
    : [0-9]+ '-' [0-9-+:.TZ]*
    ;
    
NUMBER
    : '-'? INT ('.' [0-9]+)? 
    ;
    
fragment INT: '0' | [1-9] [0-9]* ;
fragment DIGIT: [0-9] ;

WS
    : [ \t\r\n]+ -> skip
    ;