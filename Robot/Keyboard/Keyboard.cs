using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Robot.Keyboard
{
    public static class Keyboard
    {
        public static int Delay { get; set; } = 15;

        public static void KeyDown(Keys key)
        {
            Thread.Sleep(Delay);

            WinApi.INPUT[] inputs = new WinApi.INPUT[1];
            inputs[0].type = (int)WinApi.INPUT_TYPE.INPUT_KEYBOARD;
            inputs[0].ki.dwFlags = 0;
            inputs[0].ki.wVk = (byte) key;
            inputs[0].ki.wScan = GetScanCode(key);

            uint intReturn = WinApi.SendInput(1, inputs, System.Runtime.InteropServices.Marshal.SizeOf(inputs[0]));
            if (intReturn != 1)
            {
                throw new Exception("Could not send key: " + key);
            }
        }

        public static void KeyUp(Keys key)
        {
            Thread.Sleep(Delay);
            WinApi.INPUT[] inputs = new WinApi.INPUT[1];
            inputs[0].type = (int) WinApi.INPUT_TYPE.INPUT_KEYBOARD;
            inputs[0].ki.wVk = (byte) key;
            inputs[0].ki.wScan = GetScanCode(key);
            inputs[0].ki.dwFlags = WinApi.KEYEVENTF_KEYUP;
            uint intReturn = WinApi.SendInput(1, inputs, System.Runtime.InteropServices.Marshal.SizeOf(inputs[0]));
            if (intReturn != 1)
            {
                throw new Exception("Could not send key: " + key);
            }
        }

        public static void WriteText(string text)
        {
            var charArray = text.ToCharArray();
            foreach (char c in charArray)
            {
                WriteChar(c);
            }
        }

        public static void WriteChar(char value)
        {
            var isUpper = Char.IsUpper(value);

            if (isUpper)
            {
                KeyDown(Keys.LeftShift);
            }

            switch (Char.ToLower(value))
            {
                case ' ':
                    KeyDown(Keys.Space);
                    KeyUp(Keys.Space);
                    break;
                case '\t':
                    KeyDown(Keys.Tab);
                    KeyUp(Keys.Tab);
                    break;
                case '\n':
                    KeyDown(Keys.Return);
                    KeyUp(Keys.Return);
                    break;
                case 'a':
                    KeyDown(Keys.A);
                    KeyUp(Keys.A);
                    break;
                case 'ą':
                    KeyDown(Keys.RightMenu);
                    KeyDown(Keys.A);
                    KeyUp(Keys.A);
                    KeyUp(Keys.RightMenu);
                    break;
                case 'b':
                    KeyDown(Keys.B);
                    KeyUp(Keys.B);
                    break;
                case 'c':
                    KeyDown(Keys.C);
                    KeyUp(Keys.C);
                    break;
                case 'ć':
                    KeyDown(Keys.RightMenu);
                    KeyDown(Keys.C);
                    KeyUp(Keys.C);
                    KeyUp(Keys.RightMenu);
                    break;
                case 'd':
                    KeyDown(Keys.D);
                    KeyUp(Keys.D);
                    break;
                case 'e':
                    KeyDown(Keys.E);
                    KeyUp(Keys.E);
                    break;
                case 'ę':
                    KeyDown(Keys.RightMenu);
                    KeyDown(Keys.E);
                    KeyUp(Keys.E);
                    KeyUp(Keys.RightMenu);
                    break;
                case 'f':
                    KeyDown(Keys.F);
                    KeyUp(Keys.F);
                    break;
                case 'g':
                    KeyDown(Keys.G);
                    KeyUp(Keys.G);
                    break;
                case 'h':
                    KeyDown(Keys.H);
                    KeyUp(Keys.H);
                    break;
                case 'i':
                    KeyDown(Keys.I);
                    KeyUp(Keys.I);
                    break;
                case 'j':
                    KeyDown(Keys.J);
                    KeyUp(Keys.J);
                    break;
                case 'k':
                    KeyDown(Keys.K);
                    KeyUp(Keys.K);
                    break;
                case 'l':
                    KeyDown(Keys.L);
                    KeyUp(Keys.L);
                    break;
                case 'ł':
                    KeyDown(Keys.RightMenu);
                    KeyDown(Keys.L);
                    KeyUp(Keys.L);
                    KeyUp(Keys.RightMenu);
                    break;
                case 'm':
                    KeyDown(Keys.M);
                    KeyUp(Keys.M);
                    break;
                case 'n':
                    KeyDown(Keys.N);
                    KeyUp(Keys.N);
                    break;
                case 'ń':
                    KeyDown(Keys.RightMenu);
                    KeyDown(Keys.N);
                    KeyUp(Keys.N);
                    KeyUp(Keys.RightMenu);
                    break;
                case 'o':
                    KeyDown(Keys.O);
                    KeyUp(Keys.O);
                    break;
                case 'ó':
                    KeyDown(Keys.RightMenu);
                    KeyDown(Keys.O);
                    KeyUp(Keys.O);
                    KeyUp(Keys.RightMenu);
                    break;
                case 'p':
                    KeyDown(Keys.P);
                    KeyUp(Keys.P);
                    break;
                case 'q':
                    KeyDown(Keys.Q);
                    KeyUp(Keys.Q);
                    break;
                case 'r':
                    KeyDown(Keys.R);
                    KeyUp(Keys.R);
                    break;
                case 's':
                    KeyDown(Keys.S);
                    KeyUp(Keys.S);
                    break;
                case 'ś':
                    KeyDown(Keys.RightMenu);
                    KeyDown(Keys.S);
                    KeyUp(Keys.S);
                    KeyUp(Keys.RightMenu);
                    break;
                case 't':
                    KeyDown(Keys.T);
                    KeyUp(Keys.T);
                    break;
                case 'u':
                    KeyDown(Keys.U);
                    KeyUp(Keys.U);
                    break;
                case 'v':
                    KeyDown(Keys.V);
                    KeyUp(Keys.V);
                    break;
                case 'w':
                    KeyDown(Keys.W);
                    KeyUp(Keys.W);
                    break;
                case 'x':
                    KeyDown(Keys.X);
                    KeyUp(Keys.X);
                    break;
                case 'y':
                    KeyDown(Keys.Y);
                    KeyUp(Keys.Y);
                    break;
                case 'z':
                    KeyDown(Keys.Z);
                    KeyUp(Keys.Z);
                    break;
                case 'ż':
                    KeyDown(Keys.RightMenu);
                    KeyDown(Keys.Z);
                    KeyUp(Keys.Z);
                    KeyUp(Keys.RightMenu);
                    break;
                case 'ź':
                    KeyDown(Keys.RightMenu);
                    KeyDown(Keys.X);
                    KeyUp(Keys.X);
                    KeyUp(Keys.RightMenu);
                    break;


                case '1':
                    KeyDown(Keys.N1);
                    KeyUp(Keys.N1);
                    break;
                case '!':
                    KeyDown(Keys.LeftShift);
                    KeyDown(Keys.N1);
                    KeyUp(Keys.N1);
                    KeyUp(Keys.LeftShift);
                    break;
                case '2':
                    KeyDown(Keys.N2);
                    KeyUp(Keys.N2);
                    break;
                case '@':
                    KeyDown(Keys.LeftShift);
                    KeyDown(Keys.N2);
                    KeyUp(Keys.N2);
                    KeyUp(Keys.LeftShift);
                    break;
                case '3':
                    KeyDown(Keys.N3);
                    KeyUp(Keys.N3);
                    break;
                case '#':
                    KeyDown(Keys.LeftShift);
                    KeyDown(Keys.N3);
                    KeyUp(Keys.N3);
                    KeyUp(Keys.LeftShift);
                    break;
                case '4':
                    KeyDown(Keys.N4);
                    KeyUp(Keys.N4);
                    break;
                case '$':
                    KeyDown(Keys.LeftShift);
                    KeyDown(Keys.N4);
                    KeyUp(Keys.N4);
                    KeyUp(Keys.LeftShift);
                    break;
                case '5':
                    KeyDown(Keys.N5);
                    KeyUp(Keys.N5);
                    break;
                case '%':
                    KeyDown(Keys.LeftShift);
                    KeyDown(Keys.N5);
                    KeyUp(Keys.N5);
                    KeyUp(Keys.LeftShift);
                    break;
                case '6':
                    KeyDown(Keys.N6);
                    KeyUp(Keys.N6);
                    break;
                case '^':
                    KeyDown(Keys.LeftShift);
                    KeyDown(Keys.N6);
                    KeyUp(Keys.N6);
                    KeyUp(Keys.LeftShift);
                    break;
                case '7':
                    KeyDown(Keys.N7);
                    KeyUp(Keys.N7);
                    break;
                case '&':
                    KeyDown(Keys.LeftShift);
                    KeyDown(Keys.N7);
                    KeyUp(Keys.N7);
                    KeyUp(Keys.LeftShift);
                    break;
                case '8':
                    KeyDown(Keys.N8);
                    KeyUp(Keys.N8);
                    break;
                case '*':
                    KeyDown(Keys.LeftShift);
                    KeyDown(Keys.N8);
                    KeyUp(Keys.N8);
                    KeyUp(Keys.LeftShift);
                    break;
                case '9':
                    KeyDown(Keys.N9);
                    KeyUp(Keys.N9);
                    break;
                case '(':
                    KeyDown(Keys.LeftShift);
                    KeyDown(Keys.N9);
                    KeyUp(Keys.N9);
                    KeyUp(Keys.LeftShift);
                    break;
                case '0':
                    KeyDown(Keys.N0);
                    KeyUp(Keys.N0);
                    break;
                case ')':
                    KeyDown(Keys.LeftShift);
                    KeyDown(Keys.N0);
                    KeyUp(Keys.N0);
                    KeyUp(Keys.LeftShift);
                    break;
                case ',':
                    KeyDown(Keys.OEMComma);
                    KeyUp(Keys.OEMComma);
                    break;
                case '<':
                    KeyDown(Keys.LeftShift);
                    KeyDown(Keys.OEMComma);
                    KeyUp(Keys.OEMComma);
                    KeyUp(Keys.LeftShift);
                    break;
                case '.':
                    KeyDown(Keys.OEMPeriod);
                    KeyUp(Keys.OEMPeriod);
                    break;
                case '>':
                    KeyDown(Keys.LeftShift);
                    KeyDown(Keys.OEMPeriod);
                    KeyUp(Keys.OEMPeriod);
                    KeyUp(Keys.LeftShift);
                    break;
                case '/':
                    KeyDown(Keys.OEM2);
                    KeyUp(Keys.OEM2);
                    break;
                case '?':
                    KeyDown(Keys.LeftShift);
                    KeyDown(Keys.OEM2);
                    KeyUp(Keys.OEM2);
                    KeyUp(Keys.LeftShift);
                    break;
                case ';':
                    KeyDown(Keys.OEM1);
                    KeyUp(Keys.OEM1);
                    break;
                case ':':
                    KeyDown(Keys.LeftShift);
                    KeyDown(Keys.OEM1);
                    KeyUp(Keys.OEM1);
                    KeyUp(Keys.LeftShift);
                    break;
                case '\'':
                    KeyDown(Keys.OEM7);
                    KeyUp(Keys.OEM7);
                    break;
                case '"':
                    KeyDown(Keys.LeftShift);
                    KeyDown(Keys.OEM7);
                    KeyUp(Keys.OEM7);
                    KeyUp(Keys.LeftShift);
                    break;
                case '\\':
                    KeyDown(Keys.OEM5);
                    KeyUp(Keys.OEM5);
                    break;
                case '|':
                    KeyDown(Keys.LeftShift);
                    KeyDown(Keys.OEM5);
                    KeyUp(Keys.OEM5);
                    KeyUp(Keys.LeftShift);
                    break;
                case '[':
                    KeyDown(Keys.OEM4);
                    KeyUp(Keys.OEM4);
                    break;
                case '{':
                    KeyDown(Keys.LeftShift);
                    KeyDown(Keys.OEM4);
                    KeyUp(Keys.OEM4);
                    KeyUp(Keys.LeftShift);
                    break;
                case ']':
                    KeyDown(Keys.OEM6);
                    KeyUp(Keys.OEM6);
                    break;
                case '}':
                    KeyDown(Keys.LeftShift);
                    KeyDown(Keys.OEM6);
                    KeyUp(Keys.OEM6);
                    KeyUp(Keys.LeftShift);
                    break;
                case '-':
                    KeyDown(Keys.OEMMinus);
                    KeyUp(Keys.OEMMinus);
                    break;
                case '_':
                    KeyDown(Keys.LeftShift);
                    KeyDown(Keys.OEMMinus);
                    KeyUp(Keys.OEMMinus);
                    KeyUp(Keys.LeftShift);
                    break;
                case '=':
                    KeyDown(Keys.OEMPlus);
                    KeyUp(Keys.OEMPlus);
                    break;
                case '+':
                    KeyDown(Keys.LeftShift);
                    KeyDown(Keys.OEMPlus);
                    KeyUp(Keys.OEMPlus);
                    KeyUp(Keys.LeftShift);
                    break;
                case '`':               // ????
                    KeyDown(Keys.OEM3);
                    KeyUp(Keys.OEM3);
                    break;
                case '~':               // ????
                    KeyDown(Keys.LeftShift);
                    KeyDown(Keys.OEM3);
                    KeyUp(Keys.OEM3);
                    KeyUp(Keys.LeftShift);
                    break;
                case '←':
                    KeyDown(Keys.Left);
                    KeyUp(Keys.Left);
                    break;
                case '↑':
                    KeyDown(Keys.Up);
                    KeyUp(Keys.Up);
                    break;
                case '→':
                    KeyDown(Keys.Right);
                    KeyUp(Keys.Right);
                    break;
                case '↓':
                    KeyDown(Keys.Down);
                    KeyUp(Keys.Down);
                    break;
            }

            if (isUpper)
            {
                KeyUp(Keys.LeftShift);
            }

            KeyUp(Keys.LeftShift);
        }

        public static char GetCharacter(Keys key, bool shift, bool alt)
        {
            char character = Char.MinValue;
            switch (key)
            {
                case Keys.A:
                    if(alt)
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

            if(shift)
            {
                return Char.ToUpper(character);
            }
            else
            {
                return Char.ToLower(character);
            }
            
        }

        //public static char GetReadableCharacter(Keys key, bool shift, bool alt)
        //{
        //    var character = GetCharacter(key, shift, alt);
        //    if (character >= 32 && character <= 126)
        //        return character;
        //    if (character >= 32 && character <= 126)
        //        return character;
        //    retrun nul
        //}

        private static byte GetScanCode(Keys key)
        {
            switch (key)
            {
                case Keys.A:
                    return 0x9E;
                case Keys.B:
                    return 0xB0;
                case Keys.C:
                    return 0xAE;
                case Keys.D:
                    return 0xA0;
                case Keys.E:
                    return 0x92;
                case Keys.F:
                    return 0xA1;
                case Keys.G:
                    return 0xA2;
                case Keys.H:
                    return 0xA3;
                case Keys.I:
                    return 0x97;
                case Keys.J:
                    return 0xA4;
                case Keys.K:
                    return 0xA5;
                case Keys.L:
                    return 0xA6;
                case Keys.M:
                    return 0xB2;
                case Keys.N:
                    return 0xB1;
                case Keys.O:
                    return 0x98;
                case Keys.P:
                    return 0x99;
                case Keys.Q:
                    return 0x90;
                case Keys.R:
                    return 0x93;
                case Keys.S:
                    return 0x9F;
                case Keys.T:
                    return 0x94;
                case Keys.U:
                    return 0x96;
                case Keys.V:
                    return 0xAF;
                case Keys.W:
                    return 0x91;
                case Keys.X:
                    return 0xAD;
                case Keys.Y:
                    return 0x95;
                case Keys.Z:
                    return 0xAC;
                case Keys.N0:
                    return 0x8B;
                case Keys.N1:
                    return 0x82;
                case Keys.N2:
                    return 0x83;
                case Keys.N3:
                    return 0x84;
                case Keys.N4:
                    return 0x85;
                case Keys.N5:
                    return 0x86;
                case Keys.N6:
                    return 0x87;
                case Keys.N7:
                    return 0x88;
                case Keys.N8:
                    return 0x89;
                case Keys.N9:
                    return 0x8A;
                case Keys.OEMMinus: // _-
                    return 0x8C;
                case Keys.OEMPlus: // =+
                    return 0x8D;
                case Keys.OEMComma: // ,<
                    return 0xB3;
                case Keys.OEMPeriod: // .>
                    return 0xB4;
                case Keys.OEM1: // ;:
                    return 0xA7;
                case Keys.OEM2: // /?
                    return 0xB5;
                case Keys.OEM3: // ~
                    return 0xA9;
                case Keys.OEM4: // [{
                    return 0x9A;
                case Keys.OEM5: // \|
                    return 0xAB;
                case Keys.OEM6: // ]}
                    return 0x9B;
                case Keys.OEM7: // '"
                    return 0xA8;
                case Keys.Back:
                    return 0x8E;
                case Keys.Tab:
                    return 0x8F;
                case Keys.CapsLock:
                    return 0xBA;
                case Keys.Space:
                    return 0xB9;
                case Keys.Return:
                    return 0x9C;
                case Keys.LeftShift:
                    return 0xAA;
                case Keys.RightShift:
                    return 0xB6;
                case Keys.LeftControl:
                    return 0x9D;
                case Keys.Menu: // left alt
                    return 0xB8;
                case Keys.RightMenu: // right alt
                    return 0xB8;
                case Keys.Left:
                    return 0xCB;
                case Keys.Right:
                    return 0xCD;
                case Keys.Up:
                    return 0xC8;
                case Keys.Down:
                    return 0xD0;
                case Keys.F1:
                    return 0xBB;
                case Keys.F2:
                    return 0xBC;
                case Keys.F3:
                    return 0xBD;
                case Keys.F4:
                    return 0xBE;
                case Keys.F5:
                    return 0xBF;
                case Keys.F6:
                    return 0xC0;
                case Keys.F7:
                    return 0xC1;
                case Keys.F8:
                    return 0xC2;
                case Keys.F9:
                    return 0xC3;
                case Keys.F10:
                    return 0xC4;
                case Keys.F11:
                    return 0xD7;
                case Keys.F12:
                    return 0xD8;
                case Keys.Escape:
                    return 0x81;
                case Keys.NumLock:
                    return 0xC5;
                case Keys.Numpad0: // Insert with Shift
                    return 0xD2;
                case Keys.Numpad1: // End with Shift
                    return 0xCF;
                case Keys.Numpad2: // Down Arrow with Shift
                    return 0xD0;
                case Keys.Numpad3: // Page Down with Shift
                    return 0xD1;
                case Keys.Numpad4: // Left Arrow with Shift
                    return 0xCB;
                case Keys.Numpad5:
                    return 0xCC;
                case Keys.Numpad6: // Right Arrow with Shift
                    return 0xCD;
                case Keys.Numpad7: // Home with Shift
                    return 0xC7;
                case Keys.Numpad8: // Up Arrow with Shift
                    return 0xC8;
                case Keys.Numpad9: // Page Up with Shift
                    return 0xC9;
                case Keys.Add:
                    return 0xCE;
                case Keys.Subtract:
                    return 0xCA;
                case Keys.Multiply: // Print Screen Up with Shift
                    return 0xB7;
                case Keys.Separator: // Delete with Shift
                    return 0xD3;
            }

            return 0;
        }

    }
}
