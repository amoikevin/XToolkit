using System.Runtime.InteropServices;

namespace System.Win32
{
    public static class XSBar
    {
        [DllImport(XToolkit.DllName, EntryPoint = "XSBar_Create", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Create(int x, int y, int cx, int cy, IntPtr hParent);

        [DllImport(XToolkit.DllName, EntryPoint = "XSBar_SetRange", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetRange(IntPtr hEle, int range);

        [DllImport(XToolkit.DllName, EntryPoint = "XSBar_GetRange", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetRange(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XSBar_ShowButton", CallingConvention = CallingConvention.StdCall)]
        public static extern void ShowButton(IntPtr hEle, bool bShow);

        [DllImport(XToolkit.DllName, EntryPoint = "XSBar_SetSliderLength", CallingConvention = CallingConvention.StdCall
            )]
        public static extern void SetSliderLength(IntPtr hEle, int length); //设置滑块长度

        [DllImport(XToolkit.DllName, EntryPoint = "XSBar_SetSliderMinLength",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetSliderMinLength(IntPtr hEle, int minLength); //设置滑块最小长度

        [DllImport(XToolkit.DllName, EntryPoint = "XSBar_SetHorizon", CallingConvention = CallingConvention.StdCall)]
        public static extern bool SetHorizon(IntPtr hEle, bool bHorizon); //水平显示或垂直

        [DllImport(XToolkit.DllName, EntryPoint = "XSBar_GetSliderMaxLength",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int GetSliderMaxLength(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XSBar_ScrollUp", CallingConvention = CallingConvention.StdCall)]
        public static extern bool ScrollUp(IntPtr hEle); //向左滚动

        [DllImport(XToolkit.DllName, EntryPoint = "XSBar_ScrollDown", CallingConvention = CallingConvention.StdCall)]
        public static extern bool ScrollDown(IntPtr hEle); //向右滚动

        [DllImport(XToolkit.DllName, EntryPoint = "XSBar_ScrollTop", CallingConvention = CallingConvention.StdCall)]
        public static extern bool ScrollTop(IntPtr hEle); //滚动到顶部

        [DllImport(XToolkit.DllName, EntryPoint = "XSBar_ScrollBottom", CallingConvention = CallingConvention.StdCall)]
        public static extern bool ScrollBottom(IntPtr hEle); //滚动到底部

        [DllImport(XToolkit.DllName, EntryPoint = "XSBar_ScrollPos", CallingConvention = CallingConvention.StdCall)]
        public static extern bool ScrollPos(IntPtr hEle, int pos); //滚动到指定点

        [DllImport(XToolkit.DllName, EntryPoint = "XSBar_GetButtonUp", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetButtonUp(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XSBar_GetButtonDown", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetButtonDown(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XSBar_GetButtonSlider", CallingConvention = CallingConvention.StdCall
            )]
        public static extern IntPtr GetButtonSlider(IntPtr hEle);
    }
}