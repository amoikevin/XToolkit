using System.Runtime.InteropServices;

namespace System.Win32
{
    public static class XListBox
    {
        [DllImport(XToolkit.DllName, EntryPoint = "XListBox_Create", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Create(int x, int y, int cx, int cy, IntPtr hParent);

        [DllImport(XToolkit.DllName, EntryPoint = "XListBox_SetStyle", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetStyle(IntPtr hEle, int style);

        [DllImport(XToolkit.DllName, EntryPoint = "XListBox_SetItemData", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern bool SetItemData(IntPtr hEle, int iItem, int nUserData);

        [DllImport(XToolkit.DllName, EntryPoint = "XListBox_GetItemData", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern int GetItemData(IntPtr hEle, int iItem);

        [DllImport(XToolkit.DllName, EntryPoint = "XListBox_SetItemInfo", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern bool SetItemInfo(IntPtr hEle, int iItem,
            [MarshalAs(UnmanagedType.LPStruct)] ListBoxItemInfoI pItem);

        [DllImport(XToolkit.DllName, EntryPoint = "XListBox_GetItemInfo", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern bool GetItemInfo(IntPtr hEle, int iItem, out ListBoxItemInfoI pItem);

        [DllImport(XToolkit.DllName, EntryPoint = "XListBox_SetItemColor", CallingConvention = CallingConvention.StdCall
            )]
        public static extern void SetItemColor(IntPtr hEle, int color, byte alpha = 255);

        [DllImport(XToolkit.DllName, EntryPoint = "XListBox_GetItemColor", CallingConvention = CallingConvention.StdCall
            )]
        public static extern int GetItemColor(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XListBox_SetItemColorSel",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetItemColorSel(IntPtr hEle, int color, byte alpha = 255);

        [DllImport(XToolkit.DllName, EntryPoint = "XListBox_GetItemColorSel",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int GetItemColorSel(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XListBox_SetItemColorStay",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetItemColorStay(IntPtr hEle, int color, byte alpha = 255);

        [DllImport(XToolkit.DllName, EntryPoint = "XListBox_GetItemColorStay",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int GetItemColorStay(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XListBox_SetSelectItem",
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool SetSelectItem(IntPtr hEle, int iItem);

        [DllImport(XToolkit.DllName, EntryPoint = "XListBox_GetSelectItem",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int GetSelectItem(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XListBox_CancelSelectItem",
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool CancelSelectItem(IntPtr hEle, int iItem);

        [DllImport(XToolkit.DllName, EntryPoint = "XListBox_CancelSelectAll",
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool CancelSelectAll(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XListBox_GetSelectAll", CallingConvention = CallingConvention.StdCall
            )]
        public static extern int GetSelectAll(IntPtr hEle,
            [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] out int[] pArray, int nArraySize);

        [DllImport(XToolkit.DllName, EntryPoint = "XListBox_GetSelectCount",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int GetSelectCount(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XListBox_GetItemMouseStay",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int GetItemMouseStay(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XListBox_SelectAll", CallingConvention = CallingConvention.StdCall)]
        public static extern bool SelectAll(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XListBox_SetItemHeightDefault",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetItemHeightDefault(IntPtr hEle, int nHeight, int nSelHeight);

        [DllImport(XToolkit.DllName, EntryPoint = "XListBox_GetItemHeightDefault",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void GetItemHeightDefault(IntPtr hEle, out int pHeight, out int pSelHeight);

        [DllImport(XToolkit.DllName, EntryPoint = "XListBox_HitTest", CallingConvention = CallingConvention.StdCall)]
        public static extern int HitTest(IntPtr hEle, [MarshalAs(UnmanagedType.LPStruct)] XPoint pPt);

        [DllImport(XToolkit.DllName, EntryPoint = "XListBox_HitTestOffset",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int HitTestOffset(IntPtr hEle, [MarshalAs(UnmanagedType.LPStruct)] XPoint pPt);

        //自动添加滚动视图偏移量

        [DllImport(XToolkit.DllName, EntryPoint = "XListBox_SetItemTemplateXML",
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool SetItemTemplateXML(IntPtr hEle, [MarshalAs(UnmanagedType.LPWStr)] string pXmlFile);

        [DllImport(XToolkit.DllName, EntryPoint = "XListBox_GetTemplateObject",
            CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetTemplateObject(IntPtr hEle, int iItem, int nTempItemID);

        [DllImport(XToolkit.DllName, EntryPoint = "XListBox_EnableMultiSel",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void EnableMultiSel(IntPtr hEle, bool bEnable);

        [DllImport(XToolkit.DllName, EntryPoint = "XListBox_BindAdapter", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern void BindAdapter(IntPtr hEle, IntPtr hAdapter);

        [DllImport(XToolkit.DllName, EntryPoint = "XListBox_GetAdapter", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetAdapter(IntPtr hEle);
        [DllImport(XToolkit.DllName, EntryPoint = "XListBox_GetItemIndexFromHXCGUI", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetItemIndexFromHXCGUI(IntPtr hEle, IntPtr hXCGUI);
    }
}