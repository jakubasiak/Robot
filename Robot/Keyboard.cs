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

        public static void WriteChar(char value)
        {
            Key key = GetKey(value);
            if (key != null)
            {
                keybd_event(key.Value, key.ScanCode, 0, 0); // Key down
                Thread.Sleep(100);
                keybd_event(key.Value, key.ScanCode, 0x0002, 0); // Key up
            }

        }

        private static Key GetKey(char value)
        {
            Key key = null;
            switch (value)
            {
                case 'a':
                    key = new Key() { Dscription = "a", Value = 0x41, ScanCode = 0x9E };
                    break;
                case 'b':
                    key = new Key() { Dscription = "b", Value = 0x42, ScanCode = 0xB0 };
                    break;
                case 'c':
                    key = new Key() { Dscription = "c", Value = 0x43, ScanCode = 0xAE };
                    break;
                case 'd':
                    key = new Key() { Dscription = "d", Value = 0x44, ScanCode = 0xA0 };
                    break;
                case 'e':
                    key = new Key() { Dscription = "e", Value = 0x45, ScanCode = 0x92 };
                    break;
                case 'f':
                    key = new Key() { Dscription = "f", Value = 0x46, ScanCode = 0xA1 };
                    break;
                case 'g':
                    key = new Key() { Dscription = "g", Value = 0x47, ScanCode = 0xA2 };
                    break;
                case 'h':
                    key = new Key() { Dscription = "h", Value = 0x48, ScanCode = 0xA3 };
                    break;
                case 'i':
                    key = new Key() { Dscription = "i", Value = 0x49, ScanCode = 0x97 };
                    break;
                case 'j':
                    key = new Key() { Dscription = "j", Value = 0x4A, ScanCode = 0xA4 };
                    break;
                case 'k':
                    key = new Key() { Dscription = "k", Value = 0x4B, ScanCode = 0xA5 };
                    break;
                case 'l':
                    key = new Key() { Dscription = "l", Value = 0x4C, ScanCode = 0xA6 };
                    break;
                case 'm':
                    key = new Key() { Dscription = "m", Value = 0x4D, ScanCode = 0xB2 };
                    break;
                case 'n':
                    key = new Key() { Dscription = "n", Value = 0x4E, ScanCode = 0xB1 };
                    break;
                case 'o':
                    key = new Key() { Dscription = "o", Value = 0x4F, ScanCode = 0x98 };
                    break;
                case 'p':
                    key = new Key() { Dscription = "p", Value = 0x50, ScanCode = 0x99 };
                    break;
                case 'q':
                    key = new Key() { Dscription = "q", Value = 0x51, ScanCode = 0x90 };
                    break;
                case 'r':
                    key = new Key() { Dscription = "r", Value = 0x52, ScanCode = 0x93 };
                    break;
                case 's':
                    key = new Key() { Dscription = "s", Value = 0x53, ScanCode = 0x9F };
                    break;
                case 't':
                    key = new Key() { Dscription = "t", Value = 0x54, ScanCode = 0x94 };
                    break;
                case 'u':
                    key = new Key() { Dscription = "u", Value = 0x55, ScanCode = 0x96 };
                    break;
                case 'v':
                    key = new Key() { Dscription = "v", Value = 0x56, ScanCode = 0xAF };
                    break;
                case 'w':
                    key = new Key() { Dscription = "w", Value = 0x57, ScanCode = 0x91 };
                    break;
                case 'x':
                    key = new Key() { Dscription = "x", Value = 0x58, ScanCode = 0xAD };
                    break;
                case 'y':
                    key = new Key() { Dscription = "y", Value = 0x59, ScanCode = 0x95 };
                    break;
                case 'z':
                    key = new Key() { Dscription = "z", Value = 0x5A, ScanCode = 0xAC };
                    break;


                case '1':
                    key = new Key() { Dscription = "1", Value = 0x31, ScanCode = 0x82 };
                    break;
                case '2':
                    key = new Key() { Dscription = "2", Value = 0x32, ScanCode = 0x83 };
                    break;
                case '3':
                    key = new Key() { Dscription = "3", Value = 0x33, ScanCode = 0x84 };
                    break;
                case '4':
                    key = new Key() { Dscription = "4", Value = 0x34, ScanCode = 0x85 };
                    break;
                case '5':
                    key = new Key() { Dscription = "5", Value = 0x35, ScanCode = 0x86 };
                    break;
                case '6':
                    key = new Key() { Dscription = "6", Value = 0x36, ScanCode = 0x87 };
                    break;
                case '7':
                    key = new Key() { Dscription = "7", Value = 0x37, ScanCode = 0x88 };
                    break;
                case '8':
                    key = new Key() { Dscription = "8", Value = 0x38, ScanCode = 0x89 };
                    break;
                case '9':
                    key = new Key() { Dscription = "9", Value = 0x39, ScanCode = 0x8A };
                    break;
                case '0':
                    key = new Key() { Dscription = "0", Value = 0x30, ScanCode = 0x8B };
                    break;

                case '-':
                    key = new Key() { Dscription = "-", Value = 0xBD, ScanCode = 0x8C };
                    break;
                case '=':
                    key = new Key() { Dscription = "=", Value = 0xBB , ScanCode = 0x8D };
                    break;
                case '[':
                    key = new Key() { Dscription = "[", Value = 219 , ScanCode = 0x9A };
                    break;
                case ']':
                    key = new Key() { Dscription = "]", Value = 221, ScanCode = 0x9B };
                    break;
                case ';':
                    key = new Key() { Dscription = ";", Value = 186, ScanCode = 0xA7 };
                    break;
                case '\'':
                    key = new Key() { Dscription = "'", Value = 222, ScanCode = 0xA8 };
                    break;
                case '`':
                    key = new Key() { Dscription = "`", Value = 192, ScanCode = 0xA9 };
                    break;
                case '\\':
                    key = new Key() { Dscription = @"\", Value = 220, ScanCode = 0xAB };
                    break;
                case ',':
                    key = new Key() { Dscription = ",", Value = 188, ScanCode = 0xB3 };
                    break;
                case '.':
                    key = new Key() { Dscription = ".", Value = 190, ScanCode = 0xB4 };
                    break;
                case '/':
                    key = new Key() { Dscription = "/", Value = 191, ScanCode = 0xB5 };
                    break;
            }

            return key;
        }
    }
}
