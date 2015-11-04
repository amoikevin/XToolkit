using System.Runtime.InteropServices;

namespace System.Win32
{
    public static class XAdapterMap
    {
        [DllImport(XToolkit.DllName, EntryPoint = "XAdapterMap_Create", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Create();

        [DllImport(XToolkit.DllName, EntryPoint = "XAdapterMap_AddItemText",
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool AddItemText(IntPtr hAdapter, [MarshalAs(UnmanagedType.LPWStr)] string pName,
            [MarshalAs(UnmanagedType.LPWStr)] string pValue);

        [DllImport(XToolkit.DllName, EntryPoint = "XAdapterMap_AddItemImage",
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool AddItemImage(IntPtr hAdapter, [MarshalAs(UnmanagedType.LPWStr)] string pName,
            IntPtr hImage);

        [DllImport(XToolkit.DllName, EntryPoint = "XAdapterMap_DeleteItem",
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool DeleteItem(IntPtr hAdapter, [MarshalAs(UnmanagedType.LPWStr)] string pName);

        [DllImport(XToolkit.DllName, EntryPoint = "XAdapterMap_GetCount", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern int GetCount(IntPtr hAdapter);

        [DllImport(XToolkit.DllName, EntryPoint = "XAdapterMap_GetItemText",
            CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        public static extern bool GetItemText(IntPtr hAdapter, [MarshalAs(UnmanagedType.LPWStr)] string pName,
            out byte[] pOut, int nOutLen);

        [DllImport(XToolkit.DllName, EntryPoint = "XAdapterMap_GetItemImage",
            CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetItemImage(IntPtr hAdapter, [MarshalAs(UnmanagedType.LPWStr)] string pName);
    }
}