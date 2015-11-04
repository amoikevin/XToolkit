using System.Runtime.InteropServices;

namespace System.Win32
{
    public static class XRichEditColor
    {
        [DllImport(XToolkit.DllName, EntryPoint = "XRichEditColor_Create", CallingConvention = CallingConvention.StdCall
            )]
        public static extern IntPtr Create(int x, int y, int cx, int cy, IntPtr hParent);

        [DllImport(XToolkit.DllName, EntryPoint = "XRichEditColor_SetColor",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetColor(IntPtr hEle, int color); //设置颜色

        [DllImport(XToolkit.DllName, EntryPoint = "XRichEditColor_GetColor",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int GetColor(IntPtr hEle); //获取颜色RGB值
    }
}