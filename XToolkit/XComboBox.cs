using System.Runtime.InteropServices;

namespace System.Win32
{
    public static class XComboBox
    {
        [DllImport(XToolkit.DllName, EntryPoint = "XComboBox_Create", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Create(int x, int y, int cx, int cy, IntPtr hParent);

        [DllImport(XToolkit.DllName, EntryPoint = "XComboBox_SetSelItem", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern bool SetSelItem(IntPtr hEle, int iIndex);

        [DllImport(XToolkit.DllName, EntryPoint = "XComboBox_GetButtonRect",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void GetButtonRect(IntPtr hEle, out XRect pRect);

        [DllImport(XToolkit.DllName, EntryPoint = "XComboBox_SetButtonSize",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetButtonSize(IntPtr hEle, int size);

        [DllImport(XToolkit.DllName, EntryPoint = "XComboBox_SetDropHeight",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetDropHeight(IntPtr hEle, int height); //设置下拉列表高度

        [DllImport(XToolkit.DllName, EntryPoint = "XComboBox_GetDropHeight",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int GetDropHeight(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XComboBox_BindApapter", CallingConvention = CallingConvention.StdCall
            )]
        public static extern void BindApapter(IntPtr hEle, IntPtr hAdapter);

        [DllImport(XToolkit.DllName, EntryPoint = "XComboBox_SetItemTemplateXML",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetItemTemplateXML(IntPtr hEle, [MarshalAs(UnmanagedType.LPWStr)] string pXmlFile);

        [DllImport(XToolkit.DllName, EntryPoint = "XComboBox_EnableDrawButton",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void EnableDrawButton(IntPtr hEle, bool bEnable);

        [DllImport(XToolkit.DllName, EntryPoint = "XComboBox_EnableEdit", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern void EnableEdit(IntPtr hEle, bool bEdit); //启动编辑内容

        [DllImport(XToolkit.DllName, EntryPoint = "XComboBox_SetImageStay",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetImageStay(IntPtr hEle, IntPtr hImage);

        [DllImport(XToolkit.DllName, EntryPoint = "XComboBox_SetImageDown",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetImageDown(IntPtr hEle, IntPtr hImage);

        [DllImport(XToolkit.DllName, EntryPoint = "XComboBox_GetSelectItem",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int GetSelectItem(IntPtr hEle);
    }
}