using System.Runtime.InteropServices;

namespace System.Win32
{
    public static class XSliderBar
    {
        [DllImport(XToolkit.DllName, EntryPoint = "XSliderBar_Create", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Create(int x, int y, int cx, int cy, IntPtr hParent);

        [DllImport(XToolkit.DllName, EntryPoint = "XSliderBar_SetRange", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetRange(IntPtr hEle, int range);

        [DllImport(XToolkit.DllName, EntryPoint = "XSliderBar_GetRange", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetRange(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XSliderBar_SetButtonWidth",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetButtonWidth(IntPtr hEle, int width);

        [DllImport(XToolkit.DllName, EntryPoint = "XSliderBar_SetButtonHeight",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetButtonHeight(IntPtr hEle, int height);

        [DllImport(XToolkit.DllName, EntryPoint = "XSliderBar_SetSpaceTwo",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetSpaceTwo(IntPtr hEle, int leftSize, int rightSize);

        [DllImport(XToolkit.DllName, EntryPoint = "XSliderBar_SetPos", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetPos(IntPtr hEle, int pos);

        [DllImport(XToolkit.DllName, EntryPoint = "XSliderBar_GetPos", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetPos(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XSliderBar_GetButton", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern IntPtr GetButton(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XSliderBar_SetHorizon", CallingConvention = CallingConvention.StdCall
            )]
        public static extern void SetHorizon(IntPtr hEle, bool bHorizon);

        [DllImport(XToolkit.DllName, EntryPoint = "XSliderBar_SetImageLoad",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetImageLoad(IntPtr hEle, IntPtr hImage);
    }
}