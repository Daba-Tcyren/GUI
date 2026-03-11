%{
#include "program.tab.h"
#include<stdio.h>
#include<string.h>
#include<stdlib.h>
%}

%%
"Complex" {return COMPLEX_TYPE;}
"new" {return NEW;}
"print" {return PRINT;}
[a-zA-Z_][a-zA-Z0-9_]*  {yylval.str=strdup(yytext); return IDENTIFIER;}
-?[0-9]+\.[0-9]+ {yylval.dval=atof(yytext); return FLOAT_NUMBER;}
-?[0-9]+ {yylval.ival=atoi(yytext); return INTEGER_NUMBER;}
"=" {return '=';}
"(" {return '(';}
")" {return ')';}
"," {return ',';}
";" {return ';';}
[ \n\t] ;
. {return yytext[0];}

%%

int yywrap()
{return 1;}