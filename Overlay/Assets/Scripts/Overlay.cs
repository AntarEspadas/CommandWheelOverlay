using System;
using System.Runtime.InteropServices;
using UnityEngine;
public class Overlay : MonoBehaviour
{
	[DllImport("user32.dll")]
	static extern IntPtr GetActiveWindow();

	[DllImport("Dwmapi.dll")]
	static extern uint DwmExtendFrameIntoClientArea(IntPtr hWnd, ref Margins margins);

	[StructLayout(LayoutKind.Sequential)]
	public struct Margins
	{
		public int cxLeftWidth;
		public int xcRightWidth;
		public int cyTopHeight;
		public int cyBottomHeight;
	}
	void Awake()
	{
		IntPtr hwnd = GetActiveWindow();
		Margins margins = new Margins() { cxLeftWidth = -1 };
		DwmExtendFrameIntoClientArea(hwnd, ref margins);
	}
}