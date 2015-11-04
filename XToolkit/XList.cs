using System.Runtime.InteropServices;

namespace System.Win32
{
    public static class XList
    {
        [DllImport(XToolkit.DllName, EntryPoint = "XList_Create", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Create(int x, int y, int cx, int cy, IntPtr hParent);

        [DllImport(XToolkit.DllName, EntryPoint = "XList_AddColumn", CallingConvention = CallingConvention.StdCall)]
        public static extern int AddColumn(IntPtr hEle, int width); //增加列

        [DllImport(XToolkit.DllName, EntryPoint = "XList_InsertColumn", CallingConvention = CallingConvention.StdCall)]
        public static extern int InsertColumn(IntPtr hEle, int width, int iItem);

        [DllImport(XToolkit.DllName, EntryPoint = "XList_EnableMultiSel", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern void EnableMultiSel(IntPtr hEle, bool bEnable);

        [DllImport(XToolkit.DllName, EntryPoint = "XList_SetStyle", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetStyle(IntPtr hEle, int style);

        [DllImport(XToolkit.DllName, EntryPoint = "XList_SetColumnWidth", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern void SetColumnWidth(IntPtr hEle, int iItem, int width);

        [DllImport(XToolkit.DllName, EntryPoint = "XList_SetColumnMinWidth",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetColumnMinWidth(IntPtr hEle, int iItem, int width);

        [DllImport(XToolkit.DllName, EntryPoint = "XList_DeleteColumn", CallingConvention = CallingConvention.StdCall)]
        public static extern bool DeleteColumn(IntPtr hEle, int iItem);

        [DllImport(XToolkit.DllName, EntryPoint = "XList_DeleteColumnAll", CallingConvention = CallingConvention.StdCall
            )]
        public static extern void DeleteColumnAll(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XList_SetItemData", CallingConvention = CallingConvention.StdCall)]
        public static extern bool SetItemData(IntPtr hEle, int iItem, int iSubItem, int data);

        [DllImport(XToolkit.DllName, EntryPoint = "XList_GetItemData", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetItemData(IntPtr hEle, int iItem, int iSubItem);

        [DllImport(XToolkit.DllName, EntryPoint = "XList_SetSelectItem", CallingConvention = CallingConvention.StdCall)]
        public static extern bool SetSelectItem(IntPtr hEle, int iItem, bool bSelect);

        [DllImport(XToolkit.DllName, EntryPoint = "XList_GetSelectItem", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetSelectItem(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XList_SelectAll", CallingConvention = CallingConvention.StdCall)]
        public static extern void SelectAll(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XList_GetSelectAll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetSelectAll(IntPtr hEle,
            [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] out int[] pArray, int nArraySize);

        [DllImport(XToolkit.DllName, EntryPoint = "XList_GetHeaderHELE", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetHeaderHELE(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XList_BindAdapter", CallingConvention = CallingConvention.StdCall)]
        public static extern void BindAdapter(IntPtr hEle, IntPtr hAdapter);

        [DllImport(XToolkit.DllName, EntryPoint = "XList_BindAdapterHeader",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void BindAdapterHeader(IntPtr hEle, IntPtr hAdapter);

        [DllImport(XToolkit.DllName, EntryPoint = "XList_GetAdapter", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetAdapter(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XList_SetItemTemplateXML",
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool SetItemTemplateXML(IntPtr hEle, [MarshalAs(UnmanagedType.LPWStr)] string pXmlFile);

        [DllImport(XToolkit.DllName, EntryPoint = "XList_GetTemplateObject",
            CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetTemplateObject(IntPtr hEle, int iItem, int nTempItemID);

        //通过模板项ID,获取实例化模板项ID对应的对象.

        [DllImport(XToolkit.DllName, EntryPoint = "XList_SetHeaderHeight", CallingConvention = CallingConvention.StdCall
            )]
        public static extern void SetHeaderHeight(IntPtr hEle, int height);

        [DllImport(XToolkit.DllName, EntryPoint = "XList_GetHeaderHeight", CallingConvention = CallingConvention.StdCall
            )]
        public static extern int GetHeaderHeight(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XList_SetItemColor", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetItemColor(IntPtr hEle, int color, byte alpha = 255);

        [DllImport(XToolkit.DllName, EntryPoint = "XList_SetItemColorSel", CallingConvention = CallingConvention.StdCall
            )]
        public static extern void SetItemColorSel(IntPtr hEle, int color, byte alpha = 255);

        [DllImport(XToolkit.DllName, EntryPoint = "XList_SetItemColorStay",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetItemColorStay(IntPtr hEle, int color, byte alpha = 255);

        [DllImport(XToolkit.DllName, EntryPoint = "XList_GetItemColor", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetItemColor(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XList_GetItemColorSel", CallingConvention = CallingConvention.StdCall
            )]
        public static extern int GetItemColorSel(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XList_GetItemColorStay",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int GetItemColorStay(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XList_SetItemHeightDefault",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetItemHeightDefault(IntPtr hEle, int nHeight, int nSelHeight);

        [DllImport(XToolkit.DllName, EntryPoint = "XList_GetItemHeightDefault",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void GetItemHeightDefault(IntPtr hEle, out int pHeight, out int pSelHeight);

        [DllImport(XToolkit.DllName, EntryPoint = "XList_HitTest", CallingConvention = CallingConvention.StdCall)]
        public static extern bool HitTest(IntPtr hEle, [MarshalAs(UnmanagedType.LPStruct)] XPoint pPt, out int piItem,
            out int piSubItem);

        [DllImport(XToolkit.DllName, EntryPoint = "XList_HitTestOffset", CallingConvention = CallingConvention.StdCall)]
        public static extern bool HitTestOffset(IntPtr hEle, [MarshalAs(UnmanagedType.LPStruct)] XPoint pPt,
            out int piItem, out int piSubItem);

        [DllImport(XToolkit.DllName, EntryPoint = "XList_RefreshData", CallingConvention = CallingConvention.StdCall)]
        public static extern void RefreshData(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XList_GetItemIndexFromHXCGUI",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int GetItemIndexFromHXCGUI(IntPtr hEle, IntPtr hXCGUI);
    }
}