using System.Runtime.InteropServices;

namespace System.Win32
{
    public static class XTree
    {
        [DllImport(XToolkit.DllName, EntryPoint = "XTree_Create", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Create(int x, int y, int cx, int cy, IntPtr hParent);

        [DllImport(XToolkit.DllName, EntryPoint = "XTree_SetItemTemplateXML",
            CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        public static extern bool SetItemTemplateXML(IntPtr hEle, [MarshalAs(UnmanagedType.LPWStr)] string pXmlFile);

        [DllImport(XToolkit.DllName, EntryPoint = "XTree_SetItemTemplateXMLSel",
            CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        public static extern bool SetItemTemplateXMLSel(IntPtr hEle, [MarshalAs(UnmanagedType.LPWStr)] string pXmlFile);

        [DllImport(XToolkit.DllName, EntryPoint = "XTree_SetDrawItemBkFlags",
            CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr SetDrawItemBkFlags(IntPtr hEle, int nFlags);

        [DllImport(XToolkit.DllName, EntryPoint = "XTree_SetItemData", CallingConvention = CallingConvention.StdCall)]
        public static extern bool SetItemData(IntPtr hEle, int nID, int nUserData);

        [DllImport(XToolkit.DllName, EntryPoint = "XTree_GetItemData", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetItemData(IntPtr hEle, int nID);

        [DllImport(XToolkit.DllName, EntryPoint = "XTree_SetSelectItem", CallingConvention = CallingConvention.StdCall)]
        public static extern bool SetSelectItem(IntPtr hEle, int nID);

        [DllImport(XToolkit.DllName, EntryPoint = "XTree_GetSelectItem", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetSelectItem(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XTree_IsExpand", CallingConvention = CallingConvention.StdCall)]
        public static extern bool IsExpand(IntPtr hEle, int nID);

        [DllImport(XToolkit.DllName, EntryPoint = "XTree_ExpandItem", CallingConvention = CallingConvention.StdCall)]
        public static extern bool ExpandItem(IntPtr hEle, int nID, bool bExpand);

        [DllImport(XToolkit.DllName, EntryPoint = "XTree_HitTest", CallingConvention = CallingConvention.StdCall)]
        public static extern int HitTest(IntPtr hEle, [MarshalAs(UnmanagedType.LPStruct)] XPoint pPt);

        [DllImport(XToolkit.DllName, EntryPoint = "XTree_HitTestOffet", CallingConvention = CallingConvention.StdCall)]
        public static extern int HitTestOffet(IntPtr hEle, [MarshalAs(UnmanagedType.LPStruct)] XPoint pPt);

        [DllImport(XToolkit.DllName, EntryPoint = "XTree_GetFirstChildItem",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int GetFirstChildItem(IntPtr hEle, int nID);

        [DllImport(XToolkit.DllName, EntryPoint = "XTree_GetNextSiblingItem",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int GetNextSiblingItem(IntPtr hEle, int nID);

        [DllImport(XToolkit.DllName, EntryPoint = "XTree_GetParentItem", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetParentItem(IntPtr hEle, int nID);

        [DllImport(XToolkit.DllName, EntryPoint = "XTree_SetIndentation", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern IntPtr SetIndentation(IntPtr hEle, int nWidth);

        [DllImport(XToolkit.DllName, EntryPoint = "XTree_GetIndentation", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern int GetIndentation(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XTree_SetItemHeight", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr SetItemHeight(IntPtr hEle, int nID, int nHeight, int nSelHeight);

        [DllImport(XToolkit.DllName, EntryPoint = "XTree_GetItemHeight", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetItemHeight(IntPtr hEle, int nID, out int pHeight, out int pSelHeight);

        [DllImport(XToolkit.DllName, EntryPoint = "XTree_AddItemBkBorder", CallingConvention = CallingConvention.StdCall
            )]
        public static extern IntPtr AddItemBkBorder(IntPtr hEle, XTreeItemState nState, int color, byte alpha, int width);

        [DllImport(XToolkit.DllName, EntryPoint = "XTree_AddItemBkFill", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr AddItemBkFill(IntPtr hEle, XTreeItemState nState, int color, byte alpha);

        [DllImport(XToolkit.DllName, EntryPoint = "XTree_AddItemBkImage", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern IntPtr AddItemBkImage(IntPtr hEle, XTreeItemState nState, IntPtr hImage);

        [DllImport(XToolkit.DllName, EntryPoint = "XTree_GetItemBkInfoCount",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int GetItemBkInfoCount(IntPtr hEle, XTreeItemState nState);

        [DllImport(XToolkit.DllName, EntryPoint = "XTree_ClearItemBkInfo", CallingConvention = CallingConvention.StdCall
            )]
        public static extern IntPtr ClearItemBkInfo(IntPtr hEle, XTreeItemState nState);

        [DllImport(XToolkit.DllName, EntryPoint = "XTree_GetItemBkInfoManager",
            CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetItemBkInfoManager(IntPtr hEle, XTreeItemState nState);

        [DllImport(XToolkit.DllName, EntryPoint = "XTree_SetItemHeightDefault",
            CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr SetItemHeightDefault(IntPtr hEle, int nHeight, int nSelHeight);

        [DllImport(XToolkit.DllName, EntryPoint = "XTree_GetItemHeightDefault",
            CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetItemHeightDefault(IntPtr hEle, out int pHeight, out int pSelHeight);

        [DllImport(XToolkit.DllName, EntryPoint = "XTree_GetTemplateObject",
            CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetTemplateObject(IntPtr hEle, int nID, int nTempItemID); //通过模板项ID,获取实例化模板项ID对应的对象.

        [DllImport(XToolkit.DllName, EntryPoint = "XTree_GetItemIDFromHXCGUI",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int GetItemIDFromHXCGUI(IntPtr hEle, IntPtr hXCGUI);

        [DllImport(XToolkit.DllName, EntryPoint = "XTree_BindAdapter", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr BindAdapter(IntPtr hEle, IntPtr hAdapter);

        [DllImport(XToolkit.DllName, EntryPoint = "XTree_GetAdapter", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetAdapter(IntPtr hEle);
    }
}