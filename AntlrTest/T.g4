grammar T;

line
  : expr + EOF
  ;
  
expr 
  : PROP OP VALUE
  | PROP OP VALUE LOGOP expr
  ;

OP : 'eq'
   | 'gte'
   ;

LOGOP : 'and'
      | 'or'
      | 'xor'
      ;

VALUE : STRING | POSITIVE | NEGATIVE | BOOL ;

BOOL : TRUE | FALSE ;

TRUE : 'true';

FALSE : 'false';

PROP : [a-zA-Z_]+ [a-zA-Z0-9_-]* ;

STRING : '"' [a-zA-Z_-]+ [a-zA-Z0-9_-]* '"' ;

POSITIVE : [0-9]+ [0-9]* ;

NEGATIVE : '-' [0-9]+ [0-9]* ;

WS : [ \t\n\r]+ -> skip ;