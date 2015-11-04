using System.Runtime.InteropServices;

namespace System.Win32
{
    public static class XModalWnd
    {
        [DllImport(XToolkit.DllName, EntryPoint = "XModalWnd_Create", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Unicode)]
        public static extern IntPtr Create(int nWidth, int nHeight, [MarshalAs(UnmanagedType.LPWStr)] string pTitle,
            IntPtr hWndParent, int XCStyle = XWindowStyle.ModalWindow);

        [DllImport(XToolkit.DllName, EntryPoint = "XModalWnd_CreateEx", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Unicode)]
        public static extern IntPtr CreateEx(int dwExStyle, [MarshalAs(UnmanagedType.LPWStr)] string lpClassName,
            [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName, int dwStyle, int x, int y, int cx, int cy,
            IntPtr hWndParent, int XCStyle = XWindowStyle.ModalWindow); //创建窗口

        [DllImport(XToolkit.DllName, EntryPoint = "XModalWnd_EnableAutoClose",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void EnableAutoClose(IntPtr hWindow, bool bEnable);

        [DllImport(XToolkit.DllName, EntryPoint = "XModalWnd_DoModal", CallingConvention = CallingConvention.StdCall)]
        public static extern int DoModal(IntPtr hWindow); //启动模态窗口

        [DllImport(XToolkit.DllName, EntryPoint = "XModalWnd_EndModal", CallingConvention = CallingConvention.StdCall)]
        public static extern void EndModal(IntPtr hWindow, int nResult); //终止
    }
}