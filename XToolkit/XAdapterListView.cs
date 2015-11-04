using System.Runtime.InteropServices;

namespace System.Win32
{
    public static class XAdapterListView
    {
        public static class Item
        {
            [DllImport(XToolkit.DllName, EntryPoint = "XAdapterListView_Item_AddColumn",
                CallingConvention = CallingConvention.StdCall)]
            public static extern int AddColumn(IntPtr hAdapter, [MarshalAs(UnmanagedType.LPWStr)] string pName); //增加列

            [DllImport(XToolkit.DllName, EntryPoint = "XAdapterListView_Item_AddItemText",
                CallingConvention = CallingConvention.StdCall)]
            public static extern int AddItemText(IntPtr hAdapter, int iGroup,
                [MarshalAs(UnmanagedType.LPWStr)] string pValue);

            [DllImport(XToolkit.DllName, EntryPoint = "XAdapterListView_Item_AddItemTextEx",
                CallingConvention = CallingConvention.StdCall)]
            public static extern int AddItemTextEx(IntPtr hAdapter, int iGroup,
                [MarshalAs(UnmanagedType.LPWStr)] string pName, [MarshalAs(UnmanagedType.LPWStr)] string pValue);

            [DllImport(XToolkit.DllName, EntryPoint = "XAdapterListView_Item_AddItemImage",
                CallingConvention = CallingConvention.StdCall)]
            public static extern int AddItemImage(IntPtr hAdapter, int iGroup, IntPtr hImage);

            [DllImport(XToolkit.DllName, EntryPoint = "XAdapterListView_Item_AddItemImageEx",
                CallingConvention = CallingConvention.StdCall)]
            public static extern int AddItemImageEx(IntPtr hAdapter, int iGroup,
                [MarshalAs(UnmanagedType.LPWStr)] string pName, IntPtr hImage);

            [DllImport(XToolkit.DllName, EntryPoint = "XAdapterListView_Item_SetText",
                CallingConvention = CallingConvention.StdCall)]
            public static extern bool SetText(IntPtr hAdapter, int iGroup, int iItem, int iColumn,
                [MarshalAs(UnmanagedType.LPWStr)] string pValue);

            [DllImport(XToolkit.DllName, EntryPoint = "XAdapterListView_Item_SetTextEx",
                CallingConvention = CallingConvention.StdCall)]
            public static extern bool SetTextEx(IntPtr hAdapter, int iGroup, int iItem,
                [MarshalAs(UnmanagedType.LPWStr)] string pName, [MarshalAs(UnmanagedType.LPWStr)] string pValue);

            [DllImport(XToolkit.DllName, EntryPoint = "XAdapterListView_Item_SetImage",
                CallingConvention = CallingConvention.StdCall)]
            public static extern bool SetImage(IntPtr hAdapter, int iGroup, int iItem, int iColumn, IntPtr hImage);

            [DllImport(XToolkit.DllName, EntryPoint = "XAdapterListView_Item_SetImageEx",
                CallingConvention = CallingConvention.StdCall)]
            public static extern bool SetImageEx(IntPtr hAdapter, int iGroup, int iItem,
                [MarshalAs(UnmanagedType.LPWStr)] string pName, IntPtr hImage);

            [DllImport(XToolkit.DllName, EntryPoint = "XAdapterListView_Item_DeleteItem",
                CallingConvention = CallingConvention.StdCall)]
            public static extern bool DeleteItem(IntPtr hAdapter, int iGroup, int iItem); //删除项

            [DllImport(XToolkit.DllName, EntryPoint = "XAdapterListView_Item_GetTextEx",
                CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
            public static extern bool GetTextEx(IntPtr hAdapter, int iGroup, int iItem,
                [MarshalAs(UnmanagedType.LPWStr)] string pName, out byte[] pOut, int nOutLen);

            [DllImport(XToolkit.DllName, EntryPoint = "XAdapterListView_Item_GetImageEx",
                CallingConvention = CallingConvention.StdCall)]
            public static extern IntPtr GetImageEx(IntPtr hAdapter, int iGroup, int iItem,
                [MarshalAs(UnmanagedType.LPWStr)] string pName);
        }

        public static class Group
        {
            [DllImport(XToolkit.DllName, EntryPoint = "XAdapterListView_Group_AddColumn",
                CallingConvention = CallingConvention.StdCall)]
            public static extern int AddColumn(IntPtr hAdapter, [MarshalAs(UnmanagedType.LPWStr)] string pName);

            [DllImport(XToolkit.DllName, EntryPoint = "XAdapterListView_Group_AddItemText",
                CallingConvention = CallingConvention.StdCall)]
            public static extern int AddItemText(IntPtr hAdapter, [MarshalAs(UnmanagedType.LPWStr)] string pValue);

            [DllImport(XToolkit.DllName, EntryPoint = "XAdapterListView_Group_AddItemTextEx",
                CallingConvention = CallingConvention.StdCall)]
            public static extern int AddItemTextEx(IntPtr hAdapter, [MarshalAs(UnmanagedType.LPWStr)] string pName,
                [MarshalAs(UnmanagedType.LPWStr)] string pValue);

            [DllImport(XToolkit.DllName, EntryPoint = "XAdapterListView_Group_AddItemImage",
                CallingConvention = CallingConvention.StdCall)]
            public static extern int AddItemImage(IntPtr hAdapter, IntPtr hImage);

            [DllImport(XToolkit.DllName, EntryPoint = "XAdapterListView_Group_AddItemImageEx",
                CallingConvention = CallingConvention.StdCall)]
            public static extern int AddItemImageEx(IntPtr hAdapter, [MarshalAs(UnmanagedType.LPWStr)] string pName,
                IntPtr hImage);

            [DllImport(XToolkit.DllName, EntryPoint = "XAdapterListView_Group_SetText",
                CallingConvention = CallingConvention.StdCall)]
            public static extern bool SetText(IntPtr hAdapter, int iGroup, int iColumn,
                [MarshalAs(UnmanagedType.LPWStr)] string pValue);

            [DllImport(XToolkit.DllName, EntryPoint = "XAdapterListView_Group_SetTextEx",
                CallingConvention = CallingConvention.StdCall)]
            public static extern bool SetTextEx(IntPtr hAdapter, int iGroup,
                [MarshalAs(UnmanagedType.LPWStr)] string pName, [MarshalAs(UnmanagedType.LPWStr)] string pValue);

            [DllImport(XToolkit.DllName, EntryPoint = "XAdapterListView_Group_SetImage",
                CallingConvention = CallingConvention.StdCall)]
            public static extern bool SetImage(IntPtr hAdapter, int iGroup, int iColumn, IntPtr hImage);

            [DllImport(XToolkit.DllName, EntryPoint = "XAdapterListView_Group_SetImageEx",
                CallingConvention = CallingConvention.StdCall)]
            public static extern bool SetImageEx(IntPtr hAdapter, int iGroup,
                [MarshalAs(UnmanagedType.LPWStr)] string pName, IntPtr hImage);

            [DllImport(XToolkit.DllName, EntryPoint = "XAdapterListView_Group_DeleteItem",
                CallingConvention = CallingConvention.StdCall)]
            public static extern bool DeleteItem(IntPtr hAdapter, int iGroup); //删除组
        }

        [DllImport(XToolkit.DllName, EntryPoint = "XAdapterListView_Create",
            CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Create();

        [DllImport(XToolkit.DllName, EntryPoint = "XAdapterListView_DeleteAll",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void DeleteAll(IntPtr hAdapter);
    }
}