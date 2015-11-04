using System.Runtime.InteropServices;

namespace System.Win32
{
    public static class XMenu
    {
        [DllImport(XToolkit.DllName, EntryPoint = "XMenu_Create", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Create();

        [DllImport(XToolkit.DllName, EntryPoint = "XMenu_AddItem", CallingConvention = CallingConvention.StdCall)]
        public static extern void AddItem(IntPtr hMenu, int nID, [MarshalAs(UnmanagedType.LPWStr)] string pText,
            int parentId = 0, int nFlags = 0); //添加菜单项

        [DllImport(XToolkit.DllName, EntryPoint = "XMenu_AddItemIcon", CallingConvention = CallingConvention.StdCall)]
        public static extern void AddItemIcon(IntPtr hMenu, int nID, [MarshalAs(UnmanagedType.LPWStr)] string pText,
            int nParentID, IntPtr hImage, int nFlags = 0);

        [DllImport(XToolkit.DllName, EntryPoint = "XMenu_InsertItem", CallingConvention = CallingConvention.StdCall)]
        public static extern void InsertItem(IntPtr hMenu, int nID, [MarshalAs(UnmanagedType.LPWStr)] string pText,
            int nFlags, int insertID);

        [DllImport(XToolkit.DllName, EntryPoint = "XMenu_InsertItemIcon", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern void InsertItemIcon(IntPtr hMenu, int nID, [MarshalAs(UnmanagedType.LPWStr)] string pText,
            IntPtr hIcon, int nFlags, int insertID);

        [DllImport(XToolkit.DllName, EntryPoint = "XMenu_SetAutoDestroy", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern void SetAutoDestroy(IntPtr hMenu, bool bAuto); //是否自动销毁对象,默认弹出菜单关闭后自动销毁

        [DllImport(XToolkit.DllName, EntryPoint = "XMenu_EnableDrawBackground",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void EnableDrawBackground(IntPtr hMenu, bool bEnable); //是否有用户绘制菜单背景

        [DllImport(XToolkit.DllName, EntryPoint = "XMenu_EnableDrawItem", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern void EnableDrawItem(IntPtr hMenu, bool bEnable);

        [DllImport(XToolkit.DllName, EntryPoint = "XMenu_Popup", CallingConvention = CallingConvention.StdCall)]
        public static extern bool Popup(IntPtr hMenu, IntPtr hParentWnd, int x, int y, IntPtr hParentEle, int uFlags);

        //弹出菜单

        [DllImport(XToolkit.DllName, EntryPoint = "XMenu_DestroyMenu", CallingConvention = CallingConvention.StdCall)]
        public static extern void DestroyMenu(IntPtr hMenu);

        [DllImport(XToolkit.DllName, EntryPoint = "XMenu_CloseMenu", CallingConvention = CallingConvention.StdCall)]
        public static extern void CloseMenu(IntPtr hMenu);

        [DllImport(XToolkit.DllName, EntryPoint = "XMenu_SetBkImage", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetBkImage(IntPtr hMenu, IntPtr hImage);

        [DllImport(XToolkit.DllName, EntryPoint = "XMenu_SetItemText", CallingConvention = CallingConvention.StdCall)]
        public static extern bool SetItemText(IntPtr hMenu, int nID, [MarshalAs(UnmanagedType.LPWStr)] string pText);

        //设置项文本

        [DllImport(XToolkit.DllName, EntryPoint = "XMenu_GetItemText", CallingConvention = CallingConvention.StdCall)]
        public static extern bool GetItemText(IntPtr hMenu, int nID, out byte[] pOut, int nOutLen);

        [DllImport(XToolkit.DllName, EntryPoint = "XMenu_GetItemTextLength",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int GetItemTextLength(IntPtr hMenu, int nID);

        [DllImport(XToolkit.DllName, EntryPoint = "XMenu_SetItemIcon", CallingConvention = CallingConvention.StdCall)]
        public static extern bool SetItemIcon(IntPtr hMenu, int nID, IntPtr hIcon);

        [DllImport(XToolkit.DllName, EntryPoint = "XMenu_SetItemFlags", CallingConvention = CallingConvention.StdCall)]
        public static extern bool SetItemFlags(IntPtr hMenu, int nID, int uFlags); //设置项属性

        [DllImport(XToolkit.DllName, EntryPoint = "XMenu_SetItemHeight", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetItemHeight(IntPtr hMenu, int height); //设置菜单项高度

        [DllImport(XToolkit.DllName, EntryPoint = "XMenu_GetItemHeight", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetItemHeight(IntPtr hMenu);

        [DllImport(XToolkit.DllName, EntryPoint = "XMenu_SetBorderColor", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern void SetBorderColor(IntPtr hMenu, int crColor, byte alpha = 255);

        [DllImport(XToolkit.DllName, EntryPoint = "XMenu_GetLeftWidth", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetLeftWidth(IntPtr hMenu); //获取左侧宽度

        [DllImport(XToolkit.DllName, EntryPoint = "XMenu_GetLeftSpaceText",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int GetLeftSpaceText(IntPtr hMenu); //获取菜单项文本左间隔

        [DllImport(XToolkit.DllName, EntryPoint = "XMenu_GetItemCount", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetItemCount(IntPtr hMenu); //获取菜单项数量,包含子菜单项

        [DllImport(XToolkit.DllName, EntryPoint = "XMenu_SetItemCheck", CallingConvention = CallingConvention.StdCall)]
        public static extern bool SetItemCheck(IntPtr hMenu, int nID, bool bCheck);

        [DllImport(XToolkit.DllName, EntryPoint = "XMenu_IsItemCheck", CallingConvention = CallingConvention.StdCall)]
        public static extern bool IsItemCheck(IntPtr hMenu, int nID);
    }
}