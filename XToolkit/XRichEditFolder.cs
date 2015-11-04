using System.Runtime.InteropServices;

namespace System.Win32
{
    public static class XRichEditFolder
    {
        [DllImport(XToolkit.DllName, EntryPoint = "XRichEditFolder_Create",
            CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Create(int x, int y, int cx, int cy, IntPtr hParent);

        [DllImport(XToolkit.DllName, EntryPoint = "XRichEditFolder_SetDefaultDir",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetDefaultDir(IntPtr hEle, [MarshalAs(UnmanagedType.LPWStr)] string pDir); //ÉèÖÃÄ¬ÈÏÄ¿Â¼
    }
}