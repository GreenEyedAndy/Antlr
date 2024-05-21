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

VALUE : STRING | POSITIVE | NEGATIVE | BOOL | TIMESTAMP;

BOOL : TRUE | FALSE ;

TRUE : 'true';

FALSE : 'false';

TIMESTAMP : [0-9]+ [0-9-:.TZ]* ; 

STRING : '"' .+? '"' ;

POSITIVE : [0-9]+ [0-9]* ;

NEGATIVE : '-' [0-9]+ [0-9]* ;

PROP : [a-zA-Z_]+ [a-zA-Z0-9_-]* ;

WS : [ \t\n\r]+ -> skip ;
