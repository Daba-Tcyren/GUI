%{
#include<stdio.h>
#include<string.h>
#include<stdlib.h>
int yylex(void);
void yyerror(const char *s);
%}

%union {
int ival;
double dval;
char *str;}

%token COMPLEX_TYPE NEW
%token PRINT
%token <str> IDENTIFIER
%token <ival> INTEGER_NUMBER
%token <dval> FLOAT_NUMBER

%type <dval> number signed_number

%%
start:
| start line;

line:
declaration ';'
| print_statement ';';

print_statement:
PRINT IDENTIFIER
{printf(">>> PRINT: %s\n", $2);
free($2);};

declaration:
COMPLEX_TYPE IDENTIFIER '=' NEW COMPLEX_TYPE '(' signed_number ',' signed_number ')' {printf(">>> DECLARATION: %s = (%g, %g)\n", $2, $7, $9);free($2);};

signed_number:
number { $$ = $1; }
| '-' number { $$ = -$2; };

number:
INTEGER_NUMBER { $$ = (double)$1; }
| FLOAT_NUMBER { $$ = $1; };

%%

void yyerror(const char *s)
{ printf("Syntax error: %s\n", s);}

int main()
{printf("lexical analyzer\n");
printf("Enter an expression (for example: Complex x = new Complex(1.2, -6.76);)\n");
printf("Exit Ctrl+D\n\n");
return yyparse();}