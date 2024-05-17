parser grammar AdditionParser;
options { tokenVocab=AdditionLexer; }

// Parser rules become nodes in the parse tree. Rules are lowercase.
// equation is the start rule.
// 5 + 4
equation : INT PLUS INT; 