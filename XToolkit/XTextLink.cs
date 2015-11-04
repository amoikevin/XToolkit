using System.Runtime.InteropServices;

namespace System.Win32
{
    public static class XTextLink
    {
        [DllImport(XToolkit.DllName, EntryPoint = "XTextLink_Create", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Unicode)]
        public static extern IntPtr Create(int x, int y, int cx, int cy, [MarshalAs(UnmanagedType.LPWStr)] string pName,
            IntPtr hParent);

        [DllImport(XToolkit.DllName, EntryPoint = "XTextLink_EnableUnderlineLeave",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void EnableUnderlineLeave(IntPtr hEle, bool bEnable);

        [DllImport(XToolkit.DllName, EntryPoint = "XTextLink_EnableUnderlineStay",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void EnableUnderlineStay(IntPtr hEle, bool bEnable);

        [DllImport(XToolkit.DllName, EntryPoint = "XTextLink_SetTextColorStay",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetTextColorStay(IntPtr hEle, int color, byte alpha);

        [DllImport(XToolkit.DllName, EntryPoint = "XTextLink_SetUnderlineColorLeave",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetUnderlineColorLeave(IntPtr hEle, int color, byte alpha);

        [DllImport(XToolkit.DllName, EntryPoint = "XTextLink_SetUnderlineColorStay",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetUnderlineColorStay(IntPtr hEle, int color, byte alpha);
    }
}