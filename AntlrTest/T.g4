grammar T;

expr : ID | INT ;

ID : [a-zA-Z_]+ [a-zA-Z0-9_]* ;

INT : [0-9]+ ;

COMMET : '/*' .*? '*/' -> channel(HIDDEN) ;

WS : [ \t\n\r]+ -> skip ;