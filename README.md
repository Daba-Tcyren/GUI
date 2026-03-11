Лабораторная работа №2: Разработка лексического анализатора (сканера)

Название: Разработка лексического анализатора (сканера) для языка программирования

Цель работы: Изучить назначение и принципы работы лексического анализатора в структуре компилятора. Спроектировать алгоритм (диаграмму состояний) и выполнить программную реализацию сканера для выделения лексем из входного текста. Интегрировать разработанный модуль в ранее созданный графический интерфейс языкового процессора.

Сведения об авторе
    Студент: Тарбаев Даба-Цырен
    Группа: АП-327

Постановка задачи
Разработать лексический анализатор (сканер) в соответствии с индивидуальным вариантом задания, интегрировать его в приложение из лабораторной работы №1 и обеспечить вывод результатов.

Требования к реализации сканера:

    Спроектировать диаграмму состояний конечного автомата

    Разработать программный модуль лексического анализа, который:

        принимает на вход строку (исходный текст программы)

        выделяет все допустимые лексемы согласно варианту

        классифицирует лексемы по типам

        обрабатывает недопустимые символы с указанием позиции

        учитывает многострочность входного текста

Вариант задания
Тема 4. Объявление комплексного числа с инициализацией на языке C#

Примеры корректных входных строк:

Complex c1 = new Complex(1.2, 6.0);
Complex var = new Complex(-3.5, -2);
Complex name = new Complex(10, -6.76);
Complex x = new Complex(-5, 3.14);

Допустимые лексемы:
Условный код	- Тип лексемы	- Лексемы
1	Ключевое слово Complex	
2	Ключевое слово new	
3	Идентификатор	c1, var, x, name
4	Оператор присваивания	=
5	Разделитель (пробел)	(пробел)
6	Оператор конструктора (	
7	Оператор конструктора )	
8	Знак минуса	-
9	Целое без знака	0, 42, 100
10	Вещественное число	1.2, 3.14, -6.76
11	Оператор перечисления	,
12	Оператор завершения	;
-1	Недопустимый символ	@, #, $ и т.д.


Диаграмма состояний
<img width="2404" height="3844" alt="Лаба 2 тфяк-Страница — 2" src="https://github.com/user-attachments/assets/5e3ad840-c47a-4cac-8d29-03a2adfe83f4" />
Рисунок 1 - Диаграмма состяний
Тестовые примеры
Представлен пример успешной обработки одной строки. (Рисунок 2) 
<img width="984" height="727" alt="изображение" src="https://github.com/user-attachments/assets/beb6e120-6f6d-4621-914d-39b04edad8b7" />
Рисунок 2 - Пример успешной обработки

Пример с недопустимыми символами в строке. (Рисунок 3) 
<img width="987" height="730" alt="изображение" src="https://github.com/user-attachments/assets/a21a6af4-dbd1-442b-8c37-cd3cf17c9156" />
Рисунок 3 - Пример с недопустимыми символами обработки

Многострочный пример. (Рисунок 4) 
<img width="983" height="729" alt="изображение" src="https://github.com/user-attachments/assets/37b7149c-b1b5-4ca5-9868-19422ebcd6ef" />
Рисунок 4 - Многострочный пример

Дополнительное задание

Были установлены FLEX&BISON и разработана грамматика для них. Результат прдеставлен на рисунке 5
<img width="655" height="552" alt="изображение" src="https://github.com/user-attachments/assets/667c9a86-7e58-408b-99e3-dff1c3bf706f" />
Рисунок 5 - Успешно просканирвоанная строка и синтаксическая ошибка 

Файл program.l 
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

Файл program.y 
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
