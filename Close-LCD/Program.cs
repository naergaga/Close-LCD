using System;
using System.Runtime.InteropServices;

namespace Close_LCD{
	class Program{
		[DllImport("user32.dll")]
		private static extern int SendMessage(int hWnd, int hMsg, int wParam, int lParam);

		[DllImport("user32.dll")]
		private static extern int PostMessage(int hWnd, int hMsg, int wParam, int lParam);
		
		const int HWND_BROADCAST = 0xFFFF;
		const int WM_SYSCOMMAND = 0x0112;
		const int SC_MONITORPOWER = 0xF170;

		enum MonitorPowerCmd{
			MonitroPowerOn = -1,
			MonitorGoLowPower = 1,
			MonitorPowerOff = 2,
		};

		public static void Main(string[]args) {
			//SendMessage(HWND_BROADCAST, WM_SYSCOMMAND, SC_MONITORPOWER, (int)MonitorPowerCmd.MonitorPowerOff);
			
			PostMessage(HWND_BROADCAST, WM_SYSCOMMAND, SC_MONITORPOWER, (int)MonitorPowerCmd.MonitorPowerOff);
		}
	}
}
