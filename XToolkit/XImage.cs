using System.Runtime.InteropServices;

namespace System.Win32
{
    public static class XImage
    {
        [DllImport(XToolkit.DllName, EntryPoint = "XImage_LoadFile", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr LoadFile([MarshalAs(UnmanagedType.LPWStr)] string pImageName, bool bStretch = false); //从文件中加载图片

        [DllImport(XToolkit.DllName, EntryPoint = "XImage_LoadFileAdaptive",
            CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr LoadFileAdaptive([MarshalAs(UnmanagedType.LPWStr)] string pImageName, int leftSize,
            int topSize, int rightSize, int bottomSize); //从文件中加载图片

        [DllImport(XToolkit.DllName, EntryPoint = "XImage_LoadFileRect", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr LoadFileRect([MarshalAs(UnmanagedType.LPWStr)] string pImageName, int x, int y,
            int cx, int cy); //加载图片,指定区域

        [DllImport(XToolkit.DllName, EntryPoint = "XImage_LoadResAdaptive",
            CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr LoadResAdaptive(int id, [MarshalAs(UnmanagedType.LPWStr)] string pType, int leftSize,
            int topSize, int rightSize, int bottomSize); //从资源中加载图片

        [DllImport(XToolkit.DllName, EntryPoint = "XImage_LoadRes", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr LoadRes(int id, [MarshalAs(UnmanagedType.LPWStr)] string pType,
            bool bStretch = false); //从资源中加载图片

        [DllImport(XToolkit.DllName, EntryPoint = "XImage_LoadZip", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr LoadZip([MarshalAs(UnmanagedType.LPWStr)] string pZipFileName,
            [MarshalAs(UnmanagedType.LPWStr)] string pImageName,
            [MarshalAs(UnmanagedType.LPWStr)] string pPassword = null, bool bStretch = false); //从ZIP中加载图片

        [DllImport(XToolkit.DllName, EntryPoint = "XImage_LoadZipAdaptive",
            CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr LoadZipAdaptive([MarshalAs(UnmanagedType.LPWStr)] string pZipFileName,
            [MarshalAs(UnmanagedType.LPWStr)] string pImageName, [MarshalAs(UnmanagedType.LPWStr)] string pPassword,
            int x1, int x2, int y1, int y2); //从ZIP中加载图片

        [DllImport(XToolkit.DllName, EntryPoint = "XImage_LoadZipRect", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr LoadZipRect([MarshalAs(UnmanagedType.LPWStr)] string pZipFileName,
            [MarshalAs(UnmanagedType.LPWStr)] string pImageName, [MarshalAs(UnmanagedType.LPWStr)] string pPassword,
            int x, int y, int cx, int cy);

        [DllImport(XToolkit.DllName, EntryPoint = "XImage_LoadMemory", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr LoadMemory(IntPtr pBuffer, int nSize, bool bStretch);

        [DllImport(XToolkit.DllName, EntryPoint = "XImage_LoadMemoryRect", CallingConvention = CallingConvention.StdCall
            )]
        public static extern IntPtr LoadMemoryRect(IntPtr pBuffer, int nSize, int x, int y, int cx, int cy,
            bool bStretch);

        [DllImport(XToolkit.DllName, EntryPoint = "XImage_LoadMemoryAdaptive",
            CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr LoadMemoryAdaptive(IntPtr pBuffer, int nSize, int leftSize, int topSize,
            int rightSize, int bottomSize);

        [DllImport(XToolkit.DllName, EntryPoint = "XImage_LoadFromImage", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern IntPtr LoadFromImage(IntPtr pImage);

        [DllImport(XToolkit.DllName, EntryPoint = "XImage_LoadFileFromExtractIcon",
            CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr LoadFileFromExtractIcon([MarshalAs(UnmanagedType.LPWStr)] string pImageName);

        [DllImport(XToolkit.DllName, EntryPoint = "XImage_LoadFileFromHICON",
            CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr LoadFileFromHICON(IntPtr hIcon);

        [DllImport(XToolkit.DllName, EntryPoint = "XImage_LoadFileFromHBITMAP",
            CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr LoadFileFromHBITMAP(IntPtr hBitmap);

        [DllImport(XToolkit.DllName, EntryPoint = "XImage_IsStretch", CallingConvention = CallingConvention.StdCall)]
        public static extern bool IsStretch(IntPtr hImage); //是否拉伸图片

        [DllImport(XToolkit.DllName, EntryPoint = "XImage_IsAdaptive", CallingConvention = CallingConvention.StdCall)]
        public static extern bool IsAdaptive(IntPtr hImage); //是否为自适应图片

        [DllImport(XToolkit.DllName, EntryPoint = "XImage_IsTile", CallingConvention = CallingConvention.StdCall)]
        public static extern bool IsTile(IntPtr hImage); //是否为平铺图片

        [DllImport(XToolkit.DllName, EntryPoint = "XImage_SetDrawType", CallingConvention = CallingConvention.StdCall)]
        public static extern bool SetDrawType(IntPtr hImage, int type); //设置图片绘制类型

        [DllImport(XToolkit.DllName, EntryPoint = "XImage_SetDrawTypeAdaptive",
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool SetDrawTypeAdaptive(IntPtr hImage, int leftSize, int topSize, int rightSize,
            int bottomSize); //设置图片自适应

        [DllImport(XToolkit.DllName, EntryPoint = "XImage_SetTranColor", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetTranColor(IntPtr hImage, int color); //设置透明色

        [DllImport(XToolkit.DllName, EntryPoint = "XImage_SetTranColorEx", CallingConvention = CallingConvention.StdCall
            )]
        public static extern void SetTranColorEx(IntPtr hImage, int color, byte tranColor); //设置透明色

        [DllImport(XToolkit.DllName, EntryPoint = "XImage_EnableTranColor",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void EnableTranColor(IntPtr hImage, bool bEnable); //启用透明色

        [DllImport(XToolkit.DllName, EntryPoint = "XImage_EnableAutoDestroy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void EnableAutoDestroy(IntPtr hImage, bool bEnable); //启用或关闭自动销毁,当与UI元素关联时有效

        [DllImport(XToolkit.DllName, EntryPoint = "XImage_EnableCenter", CallingConvention = CallingConvention.StdCall)]
        public static extern void EnableCenter(IntPtr hImage, bool bCenter); //bCenter

        [DllImport(XToolkit.DllName, EntryPoint = "XImage_IsCenter", CallingConvention = CallingConvention.StdCall)]
        public static extern bool IsCenter(IntPtr hImage);

        [DllImport(XToolkit.DllName, EntryPoint = "XImage_GetDrawType", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetDrawType(IntPtr hImage); //获取图片绘制类型

        [DllImport(XToolkit.DllName, EntryPoint = "XImage_GetWidth", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetWidth(IntPtr hImage);

        [DllImport(XToolkit.DllName, EntryPoint = "XImage_GetHeight", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetHeight(IntPtr hImage);

        [DllImport(XToolkit.DllName, EntryPoint = "XImage_Release", CallingConvention = CallingConvention.StdCall)]
        public static extern void Release(IntPtr hImage);

        [DllImport(XToolkit.DllName, EntryPoint = "XImage_Destroy", CallingConvention = CallingConvention.StdCall)]
        public static extern void Destroy(IntPtr hImage);
    }
}