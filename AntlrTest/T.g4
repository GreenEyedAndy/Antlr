grammar T;

parse
    : expr EOF
    ;

expr
    : expr LOGOP expr   # LogicalOperation
    | '(' expr ')'      # ParenthesizedExpression
    | comparison        # ComparisonExpression
    ;

comparison
    : IDENTIFIER op value
    ;

op
    : 'eq'
    | 'neq'
    | 'gt'
    | 'gte'
    | 'lt'
    | 'lte'
    ;

value
    : STRING
    | NUMBER
    | BOOLEAN
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
    : [a-zA-Z_][a-zA-Z_0-9]*
    ;

STRING
    : '"' (~["\\] | '\\' .)* '"'
    ;

NUMBER
    : [0-9]+ ('.' [0-9]+)?
    ;

WS
    : [ \t\r\n]+ -> skip
    ;
