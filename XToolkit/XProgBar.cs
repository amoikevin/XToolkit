using System.Runtime.InteropServices;

namespace System.Win32
{
    public static class XProgBar
    {
        [DllImport(XToolkit.DllName, EntryPoint = "XProgBar_Create", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Create(int x, int y, int cx, int cy, IntPtr hParent);

        [DllImport(XToolkit.DllName, EntryPoint = "XProgBar_SetRange", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetRange(IntPtr hEle, int range);

        [DllImport(XToolkit.DllName, EntryPoint = "XProgBar_GetRange", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetRange(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XProgBar_SetSpaceTwo", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern void SetSpaceTwo(IntPtr hEle, int leftSize, int rightSize);

        [DllImport(XToolkit.DllName, EntryPoint = "XProgBar_SetPos", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetPos(IntPtr hEle, int pos);

        [DllImport(XToolkit.DllName, EntryPoint = "XProgBar_GetPos", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetPos(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XProgBar_SetHorizon", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetHorizon(IntPtr hEle, bool bHorizon);

        [DllImport(XToolkit.DllName, EntryPoint = "XProgBar_SetImageLoad", CallingConvention = CallingConvention.StdCall
            )]
        public static extern void SetImageLoad(IntPtr hEle, IntPtr hImage);
    }
}