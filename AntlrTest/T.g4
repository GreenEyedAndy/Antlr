grammar T;

line
  : elems? EOF
  ;
  
elems
  : expr ( LOGOP expr )*
  ;
  
expr 
  : PROP OP VALUE
  ;

OP : 'eq'
   | 'gt'
   | 'lt'
   | 'gte'
   | 'lte'
   | 'in'
   | 'ne'
   | 'nin'
   | 'regex'
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

STRING : '"' .+? '"' ;

POSITIVE : [0-9]+ [0-9]* ;

NEGATIVE : '-' [0-9]+ [0-9]* ;

WS : [ \t\n\r]+ -> skip ;