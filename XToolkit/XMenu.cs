using System.Runtime.InteropServices;

namespace System.Win32
{
    public static class XMenu
    {
        [DllImport(XToolkit.DllName, EntryPoint = "XMenu_Create", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Create();

        [DllImport(XToolkit.DllName, EntryPoint = "XMenu_AddItem", CallingConvention = CallingConvention.StdCall)]
        public static extern void AddItem(IntPtr hMenu, int nID, [MarshalAs(UnmanagedType.LPWStr)] string pText,
            int parentId = 0, int nFlags = 0); //��Ӳ˵���

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
        public static extern void SetAutoDestroy(IntPtr hMenu, bool bAuto); //�Ƿ��Զ����ٶ���,Ĭ�ϵ����˵��رպ��Զ�����

        [DllImport(XToolkit.DllName, EntryPoint = "XMenu_EnableDrawBackground",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void EnableDrawBackground(IntPtr hMenu, bool bEnable); //�Ƿ����û����Ʋ˵�����

        [DllImport(XToolkit.DllName, EntryPoint = "XMenu_EnableDrawItem", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern void EnableDrawItem(IntPtr hMenu, bool bEnable);

        [DllImport(XToolkit.DllName, EntryPoint = "XMenu_Popup", CallingConvention = CallingConvention.StdCall)]
        public static extern bool Popup(IntPtr hMenu, IntPtr hParentWnd, int x, int y, IntPtr hParentEle, int uFlags);

        //�����˵�

        [DllImport(XToolkit.DllName, EntryPoint = "XMenu_DestroyMenu", CallingConvention = CallingConvention.StdCall)]
        public static extern void DestroyMenu(IntPtr hMenu);

        [DllImport(XToolkit.DllName, EntryPoint = "XMenu_CloseMenu", CallingConvention = CallingConvention.StdCall)]
        public static extern void CloseMenu(IntPtr hMenu);

        [DllImport(XToolkit.DllName, EntryPoint = "XMenu_SetBkImage", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetBkImage(IntPtr hMenu, IntPtr hImage);

        [DllImport(XToolkit.DllName, EntryPoint = "XMenu_SetItemText", CallingConvention = CallingConvention.StdCall)]
        public static extern bool SetItemText(IntPtr hMenu, int nID, [MarshalAs(UnmanagedType.LPWStr)] string pText);

        //�������ı�

        [DllImport(XToolkit.DllName, EntryPoint = "XMenu_GetItemText", CallingConvention = CallingConvention.StdCall)]
        public static extern bool GetItemText(IntPtr hMenu, int nID, out byte[] pOut, int nOutLen);

        [DllImport(XToolkit.DllName, EntryPoint = "XMenu_GetItemTextLength",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int GetItemTextLength(IntPtr hMenu, int nID);

        [DllImport(XToolkit.DllName, EntryPoint = "XMenu_SetItemIcon", CallingConvention = CallingConvention.StdCall)]
        public static extern bool SetItemIcon(IntPtr hMenu, int nID, IntPtr hIcon);

        [DllImport(XToolkit.DllName, EntryPoint = "XMenu_SetItemFlags", CallingConvention = CallingConvention.StdCall)]
        public static extern bool SetItemFlags(IntPtr hMenu, int nID, int uFlags); //����������

        [DllImport(XToolkit.DllName, EntryPoint = "XMenu_SetItemHeight", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetItemHeight(IntPtr hMenu, int height); //���ò˵���߶�

        [DllImport(XToolkit.DllName, EntryPoint = "XMenu_GetItemHeight", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetItemHeight(IntPtr hMenu);

        [DllImport(XToolkit.DllName, EntryPoint = "XMenu_SetBorderColor", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern void SetBorderColor(IntPtr hMenu, int crColor, byte alpha = 255);

        [DllImport(XToolkit.DllName, EntryPoint = "XMenu_GetLeftWidth", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetLeftWidth(IntPtr hMenu); //��ȡ�����

        [DllImport(XToolkit.DllName, EntryPoint = "XMenu_GetLeftSpaceText",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int GetLeftSpaceText(IntPtr hMenu); //��ȡ�˵����ı�����

        [DllImport(XToolkit.DllName, EntryPoint = "XMenu_GetItemCount", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetItemCount(IntPtr hMenu); //��ȡ�˵�������,�����Ӳ˵���

        [DllImport(XToolkit.DllName, EntryPoint = "XMenu_SetItemCheck", CallingConvention = CallingConvention.StdCall)]
        public static extern bool SetItemCheck(IntPtr hMenu, int nID, bool bCheck);

        [DllImport(XToolkit.DllName, EntryPoint = "XMenu_IsItemCheck", CallingConvention = CallingConvention.StdCall)]
        public static extern bool IsItemCheck(IntPtr hMenu, int nID);
    }
}