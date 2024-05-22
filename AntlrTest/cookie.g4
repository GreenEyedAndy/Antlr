grammar cookie;

cookie
   : av_pairs*
   ;

name
   : attr
   ;

av_pairs
   : av_pair (';' av_pair)*
   ;

av_pair
   : attr ('=' value)?
   ;

attr
   : token
   ;

value
   : word
   ;

word
   : token
   | quoted_string
   ;

token
   : TOKEN
   ;

quoted_string
   : STRING
   ;


STRING
   : '"' (~ ('"' | '\n'))* '"'
   ;


TOKEN
   : ('0' .. '9' | 'a' .. 'z' | 'A' .. 'Z' | '-' | ' ' | '/' | '_' | ':' | ',')+
   ;


DIGIT
   : '0' .. '9'
   ;


WS
   : [\t\r\n] -> skip
   ;