using System.Runtime.InteropServices;

namespace System.Win32
{
    public static class XTextLink
    {
        [DllImport(XToolkit.DllName, EntryPoint = "XTextLink_Create", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Create(int x, int y, int cx, int cy, [MarshalAs(UnmanagedType.LPWStr)] string pName,
            IntPtr hParent);

        [DllImport(XToolkit.DllName, EntryPoint = "XTextLink_EnableUnderlineLeave",
            CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr EnableUnderlineLeave(IntPtr hEle, bool bEnable = true);

        [DllImport(XToolkit.DllName, EntryPoint = "XTextLink_EnableUnderlineStay",
            CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr EnableUnderlineStay(IntPtr hEle, bool bEnable = true);

        [DllImport(XToolkit.DllName, EntryPoint = "XTextLink_SetTextColorStay",
            CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr SetTextColorStay(IntPtr hEle, int color, byte alpha = 255);

        [DllImport(XToolkit.DllName, EntryPoint = "XTextLink_SetUnderlineColorLeave",
            CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr SetUnderlineColorLeave(IntPtr hEle, int color, byte alpha = 255);

        [DllImport(XToolkit.DllName, EntryPoint = "XTextLink_SetUnderlineColorStay",
            CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr SetUnderlineColorStay(IntPtr hEle, int color, byte alpha = 255);
    }
}