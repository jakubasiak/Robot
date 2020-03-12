using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot.WindowInspektor
{
    public class WindowInspektor
    {
        public void GetWindowHandler(int x, int y)
        {
            IntPtr hWnd = WinApi.WindowFromPoint(new WinApi.POINT(x, x)); ;
            if (hWnd != null)
            {
                //WinApi.SetActiveWindow(hWnd);
                //WinApi.SetForegroundWindow(hWnd);
                WinApi.SetWindowText(hWnd, hWnd.ToInt32().ToString());
                WinApi.WINDOWINFO info = new WinApi.WINDOWINFO();
                WinApi.GetWindowInfo(hWnd, ref info);
                Console.WriteLine(hWnd.ToInt32().ToString());
            }
        }

    }
}
