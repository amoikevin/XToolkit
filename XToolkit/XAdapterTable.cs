using System.Runtime.InteropServices;

namespace System.Win32
{
    public static class XAdapterTable
    {
        [DllImport(XToolkit.DllName, EntryPoint = "XAdapterTable_Create", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern IntPtr Create();

        [DllImport(XToolkit.DllName, EntryPoint = "XAdapterTable_AddColumn",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int AddColumn(IntPtr hAdapter, [MarshalAs(UnmanagedType.LPWStr)] string pName);

        [DllImport(XToolkit.DllName, EntryPoint = "XAdapterTable_AddItemText",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int AddItemText(IntPtr hAdapter, [MarshalAs(UnmanagedType.LPWStr)] string pValue);

        [DllImport(XToolkit.DllName, EntryPoint = "XAdapterTable_AddItemTextEx",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int AddItemTextEx(IntPtr hAdapter, [MarshalAs(UnmanagedType.LPWStr)] string pName,
            [MarshalAs(UnmanagedType.LPWStr)] string pValue);

        [DllImport(XToolkit.DllName, EntryPoint = "XAdapterTable_AddItemImage",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int AddItemImage(IntPtr hAdapter, IntPtr hImage);

        [DllImport(XToolkit.DllName, EntryPoint = "XAdapterTable_AddItemImageEx",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int AddItemImageEx(IntPtr hAdapter, [MarshalAs(UnmanagedType.LPWStr)] string pName,
            IntPtr hImage);

        [DllImport(XToolkit.DllName, EntryPoint = "XAdapterTable_InsertItemText",
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool InsertItemText(IntPtr hAdapter, int iItem,
            [MarshalAs(UnmanagedType.LPWStr)] string pValue);

        [DllImport(XToolkit.DllName, EntryPoint = "XAdapterTable_InsertItemTextEx",
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool InsertItemTextEx(IntPtr hAdapter, int iItem,
            [MarshalAs(UnmanagedType.LPWStr)] string pName, [MarshalAs(UnmanagedType.LPWStr)] string pValue);

        [DllImport(XToolkit.DllName, EntryPoint = "XAdapterTable_InsertItemImage",
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool InsertItemImage(IntPtr hAdapter, int iItem, IntPtr hImage);

        [DllImport(XToolkit.DllName, EntryPoint = "XAdapterTable_InsertItemImageEx",
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool InsertItemImageEx(IntPtr hAdapter, int iItem,
            [MarshalAs(UnmanagedType.LPWStr)] string pName, IntPtr hImage);

        [DllImport(XToolkit.DllName, EntryPoint = "XAdapterTable_SetItemText",
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool SetItemText(IntPtr hAdapter, int iItem, int iColumn,
            [MarshalAs(UnmanagedType.LPWStr)] string pValue);

        [DllImport(XToolkit.DllName, EntryPoint = "XAdapterTable_SetItemTextEx",
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool SetItemTextEx(IntPtr hAdapter, int iItem,
            [MarshalAs(UnmanagedType.LPWStr)] string pName, [MarshalAs(UnmanagedType.LPWStr)] string pValue);

        [DllImport(XToolkit.DllName, EntryPoint = "XAdapterTable_SetItemImage",
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool SetItemImage(IntPtr hAdapter, int iItem, int iColumn, IntPtr hImage);

        [DllImport(XToolkit.DllName, EntryPoint = "XAdapterTable_SetItemImageEx",
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool SetItemImageEx(IntPtr hAdapter, int iItem,
            [MarshalAs(UnmanagedType.LPWStr)] string pName, IntPtr hImage);

        [DllImport(XToolkit.DllName, EntryPoint = "XAdapterTable_DeleteItem",
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool DeleteItem(IntPtr hAdapter, int iItem);

        [DllImport(XToolkit.DllName, EntryPoint = "XAdapterTable_DeleteItemEx",
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool DeleteItemEx(IntPtr hAdapter, int iItem, int nCount);

        [DllImport(XToolkit.DllName, EntryPoint = "XAdapterTable_GetCount",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int GetCount(IntPtr hAdapter);

        [DllImport(XToolkit.DllName, EntryPoint = "XAdapterTable_GetCountColumn",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int GetCountColumn(IntPtr hAdapter);

        [DllImport(XToolkit.DllName, EntryPoint = "XAdapterTable_GetItemText",
            CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        public static extern bool GetItemText(IntPtr hAdapter, int iItem, int iColumn, out byte[] pOut, int nOutLen);

        [DllImport(XToolkit.DllName, EntryPoint = "XAdapterTable_GetItemImage",
            CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetItemImage(IntPtr hAdapter, int iItem, int iColumn);

        [DllImport(XToolkit.DllName, EntryPoint = "XAdapterTable_GetItemTextEx",
            CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        public static extern bool GetItemTextEx(IntPtr hAdapter, int iItem,
            [MarshalAs(UnmanagedType.LPWStr)] string pName, out byte[] pOut, int nOutLen);

        [DllImport(XToolkit.DllName, EntryPoint = "XAdapterTable_GetItemImageEx",
            CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetItemImageEx(IntPtr hAdapter, int iItem,
            [MarshalAs(UnmanagedType.LPWStr)] string pName);
    }
}