using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Robot.Keyboard;

namespace Robot.KeyboardTracker
{
    public class KeyboardTracker
    {
        private static readonly Char[] readableCharacters = new Char[]
        {
            'a','A','ą','Ą','b','B','c','C','ć','Ć','d','D','e','E','ę','Ę','f','F',
            'g','G','h','H','i','I','j','J','k','K','l','L','ł','Ł','m','M','n','N',
            'ń','Ń','o','O','ó','Ó','p','P','q','Q','r','R','t','T','u','U','v','V',
            'x','X','y','Y','ź','Ź','ż','Ż','z','Z',',','<','.','>','/','?',';',':',
            '\'','"','\\','|','[','{',']','}','`','~','!','@','#','$','%','^','&','*',
            '(',')','-','_','+','=','1','2','3','4','5','6','7','8','9','0',' ','\t',
            '\n', (char) 0x08
        };

        public void Track()
        {
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
                        var virtualKey = (Keys)i;
                        var c = this.GetReadableCharacter(virtualKey, shift, alt);
                        Console.Write(c);
                    }
                }
            }

        }


        private char GetCharacter(Keys key, bool shift, bool alt)
        {
            char character = Char.MinValue;
            switch (key)
            {
                case Keys.A:
                    if (alt)
                    {
                        character = 'Ą';
                        break;
                    }
                    character = 'A';
                    break;
                case Keys.B:
                    character = 'B';
                    break;
                case Keys.C:
                    if (alt)
                    {
                        character = 'Ć';
                        break;
                    }
                    character = 'C';
                    break;
                case Keys.D:
                    character = 'D';
                    break;
                case Keys.E:
                    if (alt)
                    {
                        character = 'Ę';
                        break;
                    }
                    character = 'E';
                    break;
                case Keys.F:
                    character = 'F';
                    break;
                case Keys.G:
                    character = 'G';
                    break;
                case Keys.H:
                    character = 'H';
                    break;
                case Keys.I:
                    character = 'I';
                    break;
                case Keys.J:
                    character = 'J';
                    break;
                case Keys.K:
                    character = 'K';
                    break;
                case Keys.L:
                    if (alt)
                    {
                        character = 'Ł';
                        break;
                    }
                    character = 'L';
                    break;
                case Keys.M:
                    character = 'M';
                    break;
                case Keys.N:
                    if (alt)
                    {
                        character = 'Ń';
                        break;
                    }
                    character = 'N';
                    break;
                case Keys.O:
                    if (alt)
                    {
                        character = 'Ó';
                        break;
                    }
                    character = 'O';
                    break;
                case Keys.P:
                    character = 'P';
                    break;
                case Keys.Q:
                    character = 'Q';
                    break;
                case Keys.R:
                    character = 'R';
                    break;
                case Keys.S:
                    if (alt)
                    {
                        character = 'Ś';
                        break;
                    }
                    character = 'S';
                    break;
                case Keys.T:
                    character = 'T';
                    break;
                case Keys.U:
                    character = 'U';
                    break;
                case Keys.V:
                    character = 'V';
                    break;
                case Keys.W:
                    character = 'W';
                    break;
                case Keys.X:
                    if (alt)
                    {
                        character = 'Ź';
                        break;
                    }
                    character = 'X';
                    break;
                case Keys.Y:
                    character = 'Y';
                    break;
                case Keys.Z:
                    if (alt)
                    {
                        character = 'Ż';
                        break;
                    }
                    character = 'Z';
                    break;
                case Keys.N0:
                    if (shift)
                    {
                        character = ')';
                        break;
                    }
                    character = '0';
                    break;
                case Keys.N1:
                    if (shift)
                    {
                        character = '!';
                        break;
                    }
                    character = '1';
                    break;
                case Keys.N2:
                    if (shift)
                    {
                        character = '@';
                        break;
                    }
                    character = '2';
                    break;
                case Keys.N3:
                    if (shift)
                    {
                        character = '#';
                        break;
                    }
                    character = '3';
                    break;
                case Keys.N4:
                    if (shift)
                    {
                        character = '$';
                        break;
                    }
                    character = '4';
                    break;
                case Keys.N5:
                    if (shift)
                    {
                        character = '%';
                        break;
                    }
                    character = '5';
                    break;
                case Keys.N6:
                    if (shift)
                    {
                        character = '^';
                        break;
                    }
                    character = '6';
                    break;
                case Keys.N7:
                    if (shift)
                    {
                        character = '&';
                        break;
                    }
                    character = '7';
                    break;
                case Keys.N8:
                    if (shift)
                    {
                        character = '*';
                        break;
                    }
                    character = '8';
                    break;
                case Keys.N9:
                    if (shift)
                    {
                        character = '(';
                        break;
                    }
                    character = '9';
                    break;
                case Keys.OEMMinus: // _-
                    if (shift)
                    {
                        character = '_';
                        break;
                    }
                    character = '-';
                    break;
                case Keys.OEMPlus: // =+
                    if (shift)
                    {
                        character = '+';
                        break;
                    }
                    character = '=';
                    break;
                case Keys.OEMComma: // ,<
                    if (shift)
                    {
                        character = '<';
                        break;
                    }
                    character = ',';
                    break;
                case Keys.OEMPeriod: // .>
                    if (shift)
                    {
                        character = '>';
                        break;
                    }
                    character = '.';
                    break;
                case Keys.OEM1: // ;:
                    if (shift)
                    {
                        character = ':';
                        break;
                    }
                    character = ';';
                    break;
                case Keys.OEM2: // /?
                    if (shift)
                    {
                        character = '?';
                        break;
                    }
                    character = '/';
                    break;
                case Keys.OEM3: // `~
                    if (shift)
                    {
                        character = '~';
                        break;
                    }
                    character = '`';
                    break;
                case Keys.OEM4: // [{
                    if (shift)
                    {
                        character = '{';
                        break;
                    }
                    character = '[';
                    break;
                case Keys.OEM5: // \|
                    if (shift)
                    {
                        character = '|';
                        break;
                    }
                    character = '\\';
                    break;
                case Keys.OEM6: // ]}
                    if (shift)
                    {
                        character = '}';
                        break;
                    }
                    character = ']';
                    break;
                case Keys.OEM7: // '"
                    if (shift)
                    {
                        character = '"';
                        break;
                    }
                    character = '\'';
                    break;
                case Keys.Back:
                    character = (char)Keys.Back;
                    break;
                case Keys.Tab:
                    character = '\t';
                    break;
                case Keys.CapsLock:
                    character = (char)58;
                    break;
                case Keys.Space:
                    character = ' ';
                    break;
                case Keys.Return:
                    character = '\n';
                    break;
                case Keys.LeftShift:
                    character = (char)Keys.LeftShift;
                    break;
                case Keys.RightShift:
                    character = (char)Keys.RightShift;
                    break;
                case Keys.LeftControl:
                    character = (char)Keys.LeftControl;
                    break;
                case Keys.RightControl:
                    character = (char)Keys.RightControl;
                    break;
                case Keys.Menu: // left alt
                    character = (char)Keys.Menu;
                    break;
                case Keys.RightMenu: // right alt
                    character = (char)Keys.RightMenu;
                    break;
                case Keys.Left:
                    character = (char)Keys.Left;
                    break;
                case Keys.Right:
                    character = (char)Keys.Right;
                    break;
                case Keys.Up:
                    character = (char)Keys.Up;
                    break;
                case Keys.Down:
                    character = (char)Keys.Down;
                    break;
                case Keys.F1:
                    character = (char)Keys.F1;
                    break;
                case Keys.F2:
                    character = (char)Keys.F2;
                    break;
                case Keys.F3:
                    character = (char)Keys.F3;
                    break;
                case Keys.F4:
                    character = (char)Keys.F4;
                    break;
                case Keys.F5:
                    character = (char)Keys.F5;
                    break;
                case Keys.F6:
                    character = (char)Keys.F6;
                    break;
                case Keys.F7:
                    character = (char)Keys.F7;
                    break;
                case Keys.F8:
                    character = (char)Keys.F8;
                    break;
                case Keys.F9:
                    character = (char)Keys.F9;
                    break;
                case Keys.F10:
                    character = (char)Keys.F10;
                    break;
                case Keys.F11:
                    character = (char)Keys.F11;
                    break;
                case Keys.F12:
                    character = (char)Keys.F12;
                    break;
                case Keys.Escape:
                    character = (char)Keys.Escape;
                    break;
                case Keys.NumLock:
                    character = (char)69;
                    break;
                case Keys.Numpad0: // Insert with Shift
                    if (shift)
                    {
                        character = (char)210;
                        break;
                    }
                    character = '0';
                    break;
                case Keys.Numpad1: // End with Shift
                    if (shift)
                    {
                        character = (char)207;
                        break;
                    }
                    character = '1';
                    break;
                case Keys.Numpad2: // Down Arrow with Shift
                    if (shift)
                    {
                        character = (char)208;
                        break;
                    }
                    character = '2';
                    break;
                case Keys.Numpad3: // Page Down with Shift
                    if (shift)
                    {
                        character = (char)209;
                        break;
                    }
                    character = '3';
                    break;
                case Keys.Numpad4: // Left Arrow with Shift
                    if (shift)
                    {
                        character = (char)203;
                        break;
                    }
                    character = '4';
                    break;
                case Keys.Numpad5:
                    character = '5';
                    break;
                case Keys.Numpad6: // Right Arrow with Shift
                    if (shift)
                    {
                        character = (char)205;
                        break;
                    }
                    character = '6';
                    break;
                case Keys.Numpad7: // Home with Shift
                    if (shift)
                    {
                        character = (char)199;
                        break;
                    }
                    character = '7';
                    break;
                case Keys.Numpad8: // Up Arrow with Shift
                    if (shift)
                    {
                        character = (char)200;
                        break;
                    }
                    character = '8';
                    break;
                case Keys.Numpad9:
                    character = '9';
                    break;
                case Keys.Add:
                    character = '+';
                    break;
                case Keys.Subtract:
                    character = '-';
                    break;
                case Keys.Multiply: // Print Screen Up with Shift
                    character = '*';
                    break;
                case Keys.Separator: // Delete with Shift
                    if (shift)
                    {
                        character = (char)211;
                        break;
                    }
                    character = '/';
                    break;
            }

            if (shift)
            {
                return Char.ToUpper(character);
            }
            else
            {
                return Char.ToLower(character);
            }

        }

        private char? GetReadableCharacter(Keys key, bool shift, bool alt)
        {
            var character = GetCharacter(key, shift, alt);
            if (readableCharacters.Contains(character))
                return character;

            return null;
        }
    }
}
