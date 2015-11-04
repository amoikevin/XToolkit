using System.Runtime.InteropServices;

namespace System.Win32
{
    public static class XAdapterTree
    {
        [DllImport(XToolkit.DllName, EntryPoint = "XAdapterTree_Create", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Create();

        [DllImport(XToolkit.DllName, EntryPoint = "XAdapterTree_AddColumn",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int AddColumn(IntPtr hAdapter, [MarshalAs(UnmanagedType.LPWStr)] string pName);

        [DllImport(XToolkit.DllName, EntryPoint = "XAdapterTree_InsertItemText",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int InsertItemText(IntPtr hAdapter, [MarshalAs(UnmanagedType.LPWStr)] string pValue,
            int nParentID = 0, int insertID = -3);

        [DllImport(XToolkit.DllName, EntryPoint = "XAdapterTree_InsertItemTextEx",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int InsertItemTextEx(IntPtr hAdapter, [MarshalAs(UnmanagedType.LPWStr)] string pName,
            [MarshalAs(UnmanagedType.LPWStr)] string pValue, int nParentID = 0, int insertID = -3);

        [DllImport(XToolkit.DllName, EntryPoint = "XAdapterTree_InsertItemImage",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int InsertItemImage(IntPtr hAdapter, IntPtr hImage, int nParentID = 0, int insertID = -3);

        [DllImport(XToolkit.DllName, EntryPoint = "XAdapterTree_InsertItemImageEx",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int InsertItemImageEx(IntPtr hAdapter, [MarshalAs(UnmanagedType.LPWStr)] string pName,
            IntPtr hImage, int nParentID = 0, int insertID = -3);

        [DllImport(XToolkit.DllName, EntryPoint = "XAdapterTree_GetCount", CallingConvention = CallingConvention.StdCall
            )]
        public static extern int GetCount(IntPtr hAdapter);

        [DllImport(XToolkit.DllName, EntryPoint = "XAdapterTree_GetCountColumn",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int GetCountColumn(IntPtr hAdapter);

        [DllImport(XToolkit.DllName, EntryPoint = "XAdapterTree_SetItemText",
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool SetItemText(IntPtr hAdapter, int nID, int iColumn,
            [MarshalAs(UnmanagedType.LPWStr)] string pValue);

        [DllImport(XToolkit.DllName, EntryPoint = "XAdapterTree_SetItemTextEx",
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool SetItemTextEx(IntPtr hAdapter, int nID, [MarshalAs(UnmanagedType.LPWStr)] string pName,
            [MarshalAs(UnmanagedType.LPWStr)] string pValue);

        [DllImport(XToolkit.DllName, EntryPoint = "XAdapterTree_SetItemImage",
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool SetItemImage(IntPtr hAdapter, int nID, int iColumn, IntPtr hImage);

        [DllImport(XToolkit.DllName, EntryPoint = "XAdapterTree_SetItemImageEx",
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool SetItemImageEx(IntPtr hAdapter, int nID,
            [MarshalAs(UnmanagedType.LPWStr)] string pName, IntPtr hImage);

        [DllImport(XToolkit.DllName, EntryPoint = "XAdapterTree_GetItemTextEx",
            CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        public static extern bool GetItemTextEx(IntPtr hAdapter, int nID, [MarshalAs(UnmanagedType.LPWStr)] string pName,
            out byte[] pOut, int nOutLen);

        [DllImport(XToolkit.DllName, EntryPoint = "XAdapterTree_GetItemImageEx",
            CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetItemImageEx(IntPtr hAdapter, int nID,
            [MarshalAs(UnmanagedType.LPWStr)] string pName);

        [DllImport(XToolkit.DllName, EntryPoint = "XAdapterTree_DeleteItem",
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool DeleteItem(IntPtr hAdapter, int nID);

        [DllImport(XToolkit.DllName, EntryPoint = "XAdapterTree_DeleteItemAll",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void DeleteItemAll(IntPtr hAdapter);
    }
}