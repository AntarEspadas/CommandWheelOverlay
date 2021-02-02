using System;
using System.Runtime.InteropServices;
using UnityEngine;
public class Overlay : MonoBehaviour
{

	private long lastWindowLeft = 0;
	private long lastWindowTop = 0;
	private IntPtr hwnd;

[DllImport("user32.dll")]
	static extern IntPtr GetActiveWindow();

	[DllImport("Dwmapi.dll")]
	static extern uint DwmExtendFrameIntoClientArea(IntPtr hWnd, ref Margins margins);
	[DllImport("user32.dll")]
	private static extern int SetWindowLong(IntPtr hWnd, int nIndex, uint dwNewLong);
	[DllImport("user32.dll", SetLastError = true)]
	static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
	[DllImport("user32.dll", SetLastError = true)]
	static extern bool GetWindowRect(IntPtr hWnd, ref Rect lpRect);

	const int GWL_EXSTYLE = -20;

	const uint NO_ACTIVATE = 0x08000000;
	const uint WS_EX_APPWINDOW = 0x00040000;

	static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);

	[StructLayout(LayoutKind.Sequential)]
	public struct Margins
	{
		public int cxLeftWidth;
		public int xcRightWidth;
		public int cyTopHeight;
		public int cyBottomHeight;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct Rect
	{
		public long left;
		public long top;
		public long right;
		public long bottom;
	}
	void Awake()
	{   
		hwnd = GetActiveWindow();
		Margins margins = new Margins() { cxLeftWidth = -1 };
		DwmExtendFrameIntoClientArea(hwnd, ref margins);
		SetWindowPos(hwnd, HWND_TOPMOST, 0, 0, 0, 0, 0);
		SetWindowLong(hwnd, GWL_EXSTYLE, NO_ACTIVATE | WS_EX_APPWINDOW);
	}
    private void Update()
    {
		Rect rect = new Rect();
		GetWindowRect(hwnd, ref rect);

        if (lastWindowLeft != rect.left | lastWindowTop != rect.top)
		{
			SetWindowPos(hwnd, HWND_TOPMOST, (int)rect.left, (int)rect.right, 0, 0, 0);
		}
		lastWindowLeft = rect.left;
		lastWindowTop = rect.top;

    }
}