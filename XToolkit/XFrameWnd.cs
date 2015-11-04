using System.Runtime.InteropServices;

namespace System.Win32
{
    public static class XFrameWnd
    {
        [DllImport(XToolkit.DllName, EntryPoint = "XFrameWnd_Create", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Create(int x, int y, int cx, int cy, [MarshalAs(UnmanagedType.LPWStr)] string pTitle,
            IntPtr hWndParent, int XCStyle); //创建窗口

        [DllImport(XToolkit.DllName, EntryPoint = "XFrameWnd_CreateEx", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr CreateEx(int dwExStyle, [MarshalAs(UnmanagedType.LPWStr)] string lpClassName,
            [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName, int dwStyle, int x, int y, int cx, int cy,
            IntPtr hWndParent, int XCStyle); //创建窗口

        [DllImport(XToolkit.DllName, EntryPoint = "XFrameWnd_GetLayoutAreaRect",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void GetLayoutAreaRect(IntPtr hWindow, out XRect pRect); //获取客户区布局区域坐标

        [DllImport(XToolkit.DllName, EntryPoint = "XFrameWnd_SetView", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetView(IntPtr hWindow, IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XFrameWnd_AddPane", CallingConvention = CallingConvention.StdCall)]
        public static extern bool AddPane(IntPtr hWindow, IntPtr hPaneDest, IntPtr hPaneNew, XAlignType align);

        [DllImport(XToolkit.DllName, EntryPoint = "XFrameWnd_MergePane", CallingConvention = CallingConvention.StdCall)]
        public static extern bool MergePane(IntPtr hWindow, IntPtr hPaneDest, IntPtr hPaneNew);
    }
}