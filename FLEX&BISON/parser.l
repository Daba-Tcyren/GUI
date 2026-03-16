%{
#define YYSTYPE std::string
#define YY_NO_UNISTD_H

#include <string>
#include "parser.tab.hpp"

int line_number = 0;
%}

%option c++
%option noyywrap

%%

"Complex"|"complex" {
    yylval = yytext;
    return COMPLEX_TYPE;
}

"new" {
    yylval = yytext;
    return NEW;
}

"=" {
    yylval = yytext;
    return EQUALS;
}

";" {
    yylval = yytext;
    return SEMICOLON;
}

"(" {
    yylval = yytext;
    return OPEN_PAREN;
}

")" {
    yylval = yytext;
    return CLOSE_PAREN;
}

"," {
    yylval = yytext;
    return COMMA;
}

[a-zA-Z][a-zA-Z0-9]* {
    yylval = yytext;
    return ID;
}

[+-]?[0-9]+(\.[0-9]+)?([Ee][+-]?[0-9]+)? {
    yylval = yytext;
    return NUMBER;
}

\n {
    line_number++;
}

. {
    yylval = yytext;
    return LEXERROR;
}

%%