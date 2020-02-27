using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int c = 0; c <= 10; c++)
            {
                Keyboard.KeyDown(Keys.D);
                Keyboard.KeyDown(Keys.U);
                Keyboard.KeyDown(Keys.P);
                Keyboard.KeyDown(Keys.A);
                Keyboard.KeyDown(Keys.Space);
            }
        }
    }
}
