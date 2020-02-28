using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Robot
{
    public static class Keyboard
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        static extern byte VkKeyScan(char ch);

        public static void KeyDown(Keys key)
        {
            Thread.Sleep(50);
            keybd_event((byte) key, GetScanCode(key), 0, 0); // Key down
        }

        public static void KeyUp(Keys key)
        {
            Thread.Sleep(50);
            keybd_event((byte)key, GetScanCode(key), 0x0002, 0); // Key down
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
