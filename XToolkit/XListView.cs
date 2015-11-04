using System.Runtime.InteropServices;

namespace System.Win32
{
    public static class XListView
    {
        [DllImport(XToolkit.DllName, EntryPoint = "XListView_Create", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Create(int x, int y, int cx, int cy, IntPtr hParent);

        [DllImport(XToolkit.DllName, EntryPoint = "XListView_BindAdapter", CallingConvention = CallingConvention.StdCall
            )]
        public static extern void BindAdapter(IntPtr hEle, IntPtr hAdapter);

        [DllImport(XToolkit.DllName, EntryPoint = "XListView_GetAdapter", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern IntPtr GetAdapter(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XListView_SetItemTemplateXML",
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool SetItemTemplateXML(IntPtr hEle, [MarshalAs(UnmanagedType.LPWStr)] string pXmlFile);

        [DllImport(XToolkit.DllName, EntryPoint = "XListView_GetTemplateObject",
            CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetTemplateObject(IntPtr hEle, int iGroup, int iItem, int nTempItemID);

        [DllImport(XToolkit.DllName, EntryPoint = "XListView_GetTemplateObjectGroup",
            CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetTemplateObjectGroup(IntPtr hEle, int iGroup, int nTempItemID);

        [DllImport(XToolkit.DllName, EntryPoint = "XListView_HitTest", CallingConvention = CallingConvention.StdCall)]
        public static extern bool HitTest(IntPtr hEle, [MarshalAs(UnmanagedType.LPStruct)] XPoint pPt, out int pOutGroup,
            out int pOutItem);

        [DllImport(XToolkit.DllName, EntryPoint = "XListView_HitTestOffset",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int HitTestOffset(IntPtr hEle, [MarshalAs(UnmanagedType.LPStruct)] XPoint pPt,
            out int pOutGroup, out int pOutItem); //自动添加滚动视图偏移量

        [DllImport(XToolkit.DllName, EntryPoint = "XListView_SetSelectItem",
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool SetSelectItem(IntPtr hEle, int iGroup, int iItem);

        [DllImport(XToolkit.DllName, EntryPoint = "XListView_GetSelectItem",
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool GetSelectItem(IntPtr hEle, out int piGroup, out int piItem);

        [DllImport(XToolkit.DllName, EntryPoint = "XListView_SetColumnSpace",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetColumnSpace(IntPtr hEle, int space); //设置列间隔

        [DllImport(XToolkit.DllName, EntryPoint = "XListView_SetRowSpace", CallingConvention = CallingConvention.StdCall
            )]
        public static extern void SetRowSpace(IntPtr hEle, int space); //设置行间隔

        [DllImport(XToolkit.DllName, EntryPoint = "XListView_SetAlignSizeLeft",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetAlignSizeLeft(IntPtr hEle, int size);

        [DllImport(XToolkit.DllName, EntryPoint = "XListView_SetAlignSizeTop",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetAlignSizeTop(IntPtr hEle, int size);

        [DllImport(XToolkit.DllName, EntryPoint = "XListView_SetItemSize", CallingConvention = CallingConvention.StdCall
            )]
        public static extern void SetItemSize(IntPtr hEle, int width, int height);

        [DllImport(XToolkit.DllName, EntryPoint = "XListView_GetItemSize", CallingConvention = CallingConvention.StdCall
            )]
        public static extern void GetItemSize(IntPtr hEle, out XSize pSize);

        [DllImport(XToolkit.DllName, EntryPoint = "XListView_SetGroupHeight",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetGroupHeight(IntPtr hEle, int height);

        [DllImport(XToolkit.DllName, EntryPoint = "XListView_GetGroupHeight",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int GetGroupHeight(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XListView_SetItemColorSel",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetItemColorSel(IntPtr hEle, int color, byte alpha = 255);

        [DllImport(XToolkit.DllName, EntryPoint = "XListView_SetItemBorderColorSel",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetItemBorderColorSel(IntPtr hEle, int color, byte alpha = 255);

        [DllImport(XToolkit.DllName, EntryPoint = "XListView_SetItemColorStay",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetItemColorStay(IntPtr hEle, int color, byte alpha = 255);

        [DllImport(XToolkit.DllName, EntryPoint = "XListView_SetItemBorderColorStay",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetItemBorderColorStay(IntPtr hEle, int color, byte alpha = 255);

        [DllImport(XToolkit.DllName, EntryPoint = "XListView_SetItemColorLeave",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetItemColorLeave(IntPtr hEle, int color, byte alpha = 255);

        [DllImport(XToolkit.DllName, EntryPoint = "XListView_SetItemBorderColorLeave",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetItemBorderColorLeave(IntPtr hEle, int color, byte alpha = 255);

        [DllImport(XToolkit.DllName, EntryPoint = "XListView_ExpandGroup", CallingConvention = CallingConvention.StdCall
            )]
        public static extern bool ExpandGroup(IntPtr hEle, int iGroup, bool bExpand);

        [DllImport(XToolkit.DllName, EntryPoint = "XListView_GetItemIDFromHXCGUI", CallingConvention = CallingConvention.StdCall
            )]
        public static extern bool GetItemIDFromHXCGUI(IntPtr hEle, IntPtr hXCGUI, out int piGroup, out int piItem);
    }
}