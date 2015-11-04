using System.Runtime.InteropServices;

namespace System.Win32
{
    public static class XPGrid
    {
        [DllImport(XToolkit.DllName, EntryPoint = "XPGrid_Create", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Create(int x, int y, int cx, int cy, IntPtr hParent);

        [DllImport(XToolkit.DllName, EntryPoint = "XPGrid_AddItem", CallingConvention = CallingConvention.StdCall)]
        public static extern int AddItem(IntPtr hEle, [MarshalAs(UnmanagedType.LPWStr)] string pName, int type,
            int nParentID = 0); //添加项

        [DllImport(XToolkit.DllName, EntryPoint = "XPGrid_AddItemString", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern int AddItemString(IntPtr hEle, [MarshalAs(UnmanagedType.LPWStr)] string pName,
            [MarshalAs(UnmanagedType.LPWStr)] string pValue, int nParentID = 0);

        [DllImport(XToolkit.DllName, EntryPoint = "XPGrid_DeleteAll", CallingConvention = CallingConvention.StdCall)]
        public static extern void DeleteAll(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XPGrid_GetItemHELE", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetItemHELE(IntPtr hEle, int nItemID);

        [DllImport(XToolkit.DllName, EntryPoint = "XPGrid_SetWidth", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetWidth(IntPtr hEle, int nWidth);

        [DllImport(XToolkit.DllName, EntryPoint = "XPGrid_SetItemValue", CallingConvention = CallingConvention.StdCall)]
        public static extern bool SetItemValue(IntPtr hEle, int nItemID, [MarshalAs(UnmanagedType.LPWStr)] string pValue);

        [DllImport(XToolkit.DllName, EntryPoint = "XPGrid_SetItemValueInt",
            CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        public static extern bool SetItemValueInt(IntPtr hEle, int nItemID, int nValue);

        [DllImport(XToolkit.DllName, EntryPoint = "XPGrid_GetItemValue", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Unicode)]
        public static extern string GetItemValue(IntPtr hEle, int nItemID);

        [DllImport(XToolkit.DllName, EntryPoint = "XPGrid_HitTest", CallingConvention = CallingConvention.StdCall)]
        public static extern int HitTest(IntPtr hEle, [MarshalAs(UnmanagedType.LPStruct)] XPoint pPt,
            out bool pbExpandButton);

        [DllImport(XToolkit.DllName, EntryPoint = "XPGrid_HitTestOffset", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern int HitTestOffset(IntPtr hEle, [MarshalAs(UnmanagedType.LPStruct)] XPoint pPt,
            out bool pbExpandButton);

        [DllImport(XToolkit.DllName, EntryPoint = "XPGrid_ExpandItem", CallingConvention = CallingConvention.StdCall)]
        public static extern bool ExpandItem(IntPtr hEle, int nItemID, bool bExpand); //展开项
    }
}