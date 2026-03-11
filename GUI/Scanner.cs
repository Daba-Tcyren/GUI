using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class Token
    {
        public readonly int id;
        public readonly string type;
        public readonly string name;
        public readonly string location;
        public Token(int id, string type, string name, string location)
        {
            this.id = id;
            this.type = type;
            this.name = name;
            this.location = location;
        }
    }

    public class Scanner
    {
        private enum States { START, ID, OUT, ASGN, ERROR };
        private States cur_state = States.START;
        private string text;
        private char liter;
        private int currentPosition = 0;
        private int positionLine = 0;
        private int currentLine = 1;

        private string buffer = "";

        private List<Token> tokens = new List<Token>();
        public List<Token> analyze(string inputText)
        {
            text = inputText;
            text += " ";

            getNext();

            while (currentPosition <= text.Length - 1)
            {
                if(char.IsLetter(liter))
                {
                    buffer += liter;
                    while (char.IsLetterOrDigit(liter = getChar()))
                    {
                        buffer += liter;
                    }
                    switch (buffer)
                    {
                        case "Complex":
                            addToken(1, "Ключевое слово Complex", buffer, currentLine);
                            break;
                        case "new":
                            addToken(2, "Ключевое слово new", buffer, currentLine);
                            break;
                        default:
                            addToken(3, "Идентификатор", buffer, currentLine);
                            break;
                    }
                    buffer = "";
                }
                else if (char.IsDigit(liter))
                {
                    buffer += liter;
                    while (char.IsDigit(liter = getChar()))
                    {
                        buffer += liter;
                    }
                    if(liter == '.')
                    {
                        buffer += liter;
                        while (char.IsDigit(liter = getChar()))
                        {
                            buffer += liter;
                        }
                        addToken(10, "Вещественное число", buffer, currentLine);
                    }
                    else
                    {
                        addToken(9, "Целое без знака", buffer, currentLine);
                    }
                    buffer = "";
                }
                else
                    switch (liter)
                    {
                        case '\0':
                            getNext();
                            break;
                        case '\n':
                            positionLine = 0;
                            currentLine++;
                            getNext();
                            break;
                        case '=':
                            addToken(4, "Оператор присваивания", liter.ToString(), currentLine);
                            getNext();
                            break;
                        case ' ':
                            addToken(5, "Разделитель", liter.ToString(), currentLine);
                            getNext();
                            break;
                        case '(':
                            addToken(6, "Оператор конструктора", liter.ToString(), currentLine);
                            getNext();
                            break;
                        case ')':
                            addToken(7, "Оператор конструктора", liter.ToString(), currentLine);
                            getNext();
                            break;
                        case '-':
                            addToken(8, "Знак минуса", liter.ToString(), currentLine);
                            getNext();
                            break;
                        case ',':
                            addToken(11, "Оператор перечисления", liter.ToString(), currentLine);
                            getNext();
                            break;
                        case ';': 
                            addToken(12, "Оператор заврешения", liter.ToString(), currentLine);
                            getNext();
                            break;
                        default:
                            addToken(-1, "Недопустимый символ", liter.ToString(),  currentLine);
                            getNext();
                            break;
                    }
            }

            return tokens;
        }
        private char getChar()
        {
            try
            {
                char liter1 = text[currentPosition];
                currentPosition++;
                positionLine++;
                return liter1;
            }
            catch (IndexOutOfRangeException ex)
            {
                throw new Exception("В конце строки не обнаружено ;");
            }
        }
        private void getNext()
        {
            liter = getChar();
        }
        private void addToken(int id, string type, string name, int location)
        {
            string loc = getLocation(name, location);
            tokens.Add(new Token(id, type, name, loc));
        }
        private string getLocation(string name, int curr_line)
        {
            int Length = name.Length;
            if (Length == 1 && cur_state != States.ID) Length = 0;
            int leng = positionLine - Length;
            if (Length > 0)
            {
                return $"строка {curr_line}, {leng}-{positionLine - 1}";
            }
            return $"строка {curr_line}, {leng}-{positionLine}";
        }
    }
}
