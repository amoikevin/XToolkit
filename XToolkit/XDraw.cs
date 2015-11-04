using System.Runtime.InteropServices;

namespace System.Win32
{
    public static class XDraw
    {
        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_Create", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Create(IntPtr hdc); //创建

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_Destroy", CallingConvention = CallingConvention.StdCall)]
        public static extern void Destroy(IntPtr hDraw); //销毁

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_SetOffset", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetOffset(IntPtr hDraw, int x, int y); //设置坐标偏移量

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_GetOffset", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetOffset(IntPtr hDraw, out int pX, out int pY); //获取坐标偏移量

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_RestoreGDIOBJ", CallingConvention = CallingConvention.StdCall)]
        public static extern void RestoreGDIOBJ(IntPtr hDraw); //还原状态,释放用户绑定的GDI对象

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_GetHDC", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetHDC(IntPtr hDraw);

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_SetBrushColor", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetBrushColor(IntPtr hDraw, int color, byte alpha = 254);

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_SetTextAlign", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetTextAlign(IntPtr hDraw, int nFlag);

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_SetTextVertical", CallingConvention = CallingConvention.StdCall
            )]
        public static extern void SetTextVertical(IntPtr hDraw, bool bVertical);

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_SetFontX", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetFontX(IntPtr hDraw, IntPtr hFontx);

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_SetFont", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetFont(IntPtr hDraw, int size);

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_SetFont2", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetFont2(IntPtr hDraw, [MarshalAs(UnmanagedType.LPWStr)] string pName, int size);

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_SetFont3", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Auto)]
        public static extern void SetFont3(IntPtr hDraw, [MarshalAs(UnmanagedType.LPStruct)] XLogFont pLogFont);

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_SetBkMode", CallingConvention = CallingConvention.StdCall)]
        public static extern int SetBkMode(IntPtr hDraw, bool bTransparent);

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_CreateSolidBrush",
            CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr CreateSolidBrush(IntPtr hDraw, int crColor);

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_CreatePen", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr CreatePen(IntPtr hDraw, int fnPenStyle, int nWidth, int crColor);

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_CreateRectRgn", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr CreateRectRgn(IntPtr hDraw, int nLeftRect, int nTopRect, int nRightRect,
            int nBottomRect);

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_CreateRoundRectRgn",
            CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr CreateRoundRectRgn(IntPtr hDraw, int nLeftRect, int nTopRect, int nRightRect,
            int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_CreatePolygonRgn",
            CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr CreatePolygonRgn(IntPtr hDraw, [MarshalAs(UnmanagedType.LPStruct)] XPoint pPt,
            int cPoints, int fnPolyFillMode);

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_SelectClipRgn", CallingConvention = CallingConvention.StdCall)]
        public static extern int SelectClipRgn(IntPtr hDraw, IntPtr hRgn);

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_FillRect", CallingConvention = CallingConvention.StdCall)]
        public static extern void FillRect(IntPtr hDraw, [MarshalAs(UnmanagedType.LPStruct)] XRect pRect);

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_FillRectColor", CallingConvention = CallingConvention.StdCall)]
        public static extern void FillRectColor(IntPtr hDraw, [MarshalAs(UnmanagedType.LPStruct)] XRect pRect, int color,
            byte alpha = 255);

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_FillRgn", CallingConvention = CallingConvention.StdCall)]
        public static extern bool FillRgn(IntPtr hDraw, IntPtr hrgn, IntPtr hbr);

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_FillEllipse", CallingConvention = CallingConvention.StdCall)]
        public static extern void FillEllipse(IntPtr hDraw, [MarshalAs(UnmanagedType.LPStruct)] XRect pRect);

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_DrawEllipse", CallingConvention = CallingConvention.StdCall)]
        public static extern void DrawEllipse(IntPtr hDraw, [MarshalAs(UnmanagedType.LPStruct)] XRect pRect);

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_FillRoundRect", CallingConvention = CallingConvention.StdCall)]
        public static extern void FillRoundRect(IntPtr hDraw, [MarshalAs(UnmanagedType.LPStruct)] XRect pRect,
            int nWidth, int nHeight); //填充圆角矩形

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_DrawRoundRect", CallingConvention = CallingConvention.StdCall)]
        public static extern void DrawRoundRect(IntPtr hDraw, [MarshalAs(UnmanagedType.LPStruct)] XRect pRect,
            int nWidth, int nHeight); //绘制圆角矩形边框

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_Rectangle", CallingConvention = CallingConvention.StdCall)]
        public static extern bool XRect(IntPtr hDraw, int nLeftRect, int nTopRect, int nRightRect, int nBottomRect);

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_DrawGroupBox_Rect",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void DrawGroupBox_Rect(IntPtr hDraw, [MarshalAs(UnmanagedType.LPStruct)] XRect pRect,
            [MarshalAs(UnmanagedType.LPWStr)] string pName, int textColor, byte textAlpha,
            [MarshalAs(UnmanagedType.LPStruct)] XPoint pOffset);

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_DrawGroupBox_RoundRect",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void DrawGroupBox_RoundRect(IntPtr hDraw, [MarshalAs(UnmanagedType.LPStruct)] XRect pRect,
            [MarshalAs(UnmanagedType.LPWStr)] string pName, int textColor, byte textAlpha,
            [MarshalAs(UnmanagedType.LPStruct)] XPoint pOffset, int nWidth, int nHeight);

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_GradientFill2", CallingConvention = CallingConvention.StdCall)]
        public static extern void GradientFill2(IntPtr hDraw, int color1, byte alpha1, int color2, byte alpha2,
            [MarshalAs(UnmanagedType.LPStruct)] XRect pRect, int mode);

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_GradientFill4", CallingConvention = CallingConvention.StdCall)]
        public static extern bool GradientFill4(IntPtr hDraw, int color1, int color2, int color3, int color4,
            [MarshalAs(UnmanagedType.LPStruct)] XRect pRect, int mode);

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_FrameRgn", CallingConvention = CallingConvention.StdCall)]
        public static extern bool FrameRgn(IntPtr hDraw, IntPtr hrgn, IntPtr hbr, int nWidth, int nHeight);

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_FrameRect", CallingConvention = CallingConvention.StdCall)]
        public static extern void FrameRect(IntPtr hDraw, [MarshalAs(UnmanagedType.LPStruct)] XRect pRect);

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_FocusRect", CallingConvention = CallingConvention.StdCall)]
        public static extern void FocusRect(IntPtr hDraw, [MarshalAs(UnmanagedType.LPStruct)] XRect pRect);

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_DrawLine", CallingConvention = CallingConvention.StdCall)]
        public static extern void DrawLine(IntPtr hDraw, int x1, int y1, int x2, int y2);

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_MoveToEx", CallingConvention = CallingConvention.StdCall)]
        public static extern bool MoveToEx(IntPtr hDraw, int X, int Y,
            [MarshalAs(UnmanagedType.LPStruct)] XPoint lpPoint);

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_LineTo", CallingConvention = CallingConvention.StdCall)]
        public static extern bool LineTo(IntPtr hDraw, int nXEnd, int nYEnd);

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_Polyline", CallingConvention = CallingConvention.StdCall)]
        public static extern bool Polyline(IntPtr hDraw,
            [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] XPoint[] pArrayPt, int arrayPtSize);

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_Dottedline", CallingConvention = CallingConvention.StdCall)]
        public static extern void Dottedline(IntPtr hDraw, int x1, int y1, int x2, int y2); //绘制虚线

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_SetPixel", CallingConvention = CallingConvention.StdCall)]
        public static extern int SetPixel(IntPtr hDraw, int X, int Y, int crColor);

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_Check", CallingConvention = CallingConvention.StdCall)]
        public static extern void Check(IntPtr hDraw, int x, int y, int color, bool bCheck);

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_DrawIconEx", CallingConvention = CallingConvention.StdCall)]
        public static extern bool DrawIconEx(IntPtr hDraw, int xLeft, int yTop, IntPtr hIcon, int cxWidth, int cyWidth,
            int istepIfAniCur, IntPtr hbrFlickerFreeDraw, int diFlags);

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_BitBlt", CallingConvention = CallingConvention.StdCall)]
        public static extern bool BitBlt(IntPtr hDrawDest, int nXDest, int nYDest, int nWidth, int nHeight,
            IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_BitBlt2", CallingConvention = CallingConvention.StdCall)]
        public static extern bool BitBlt2(IntPtr hDrawDest, int nXDest, int nYDest, int nWidth, int nHeight,
            IntPtr hDrawSrc, int nXSrc, int nYSrc, int dwRop);

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_AlphaBlend", CallingConvention = CallingConvention.StdCall)]
        public static extern bool AlphaBlend(IntPtr hDraw, int nXOriginDest, int nYOriginDest, int nWidthDest,
            int nHeightDest, IntPtr hdcSrc, int nXOriginSrc, int nYOriginSrc, int nWidthSrc, int nHeightSrc, int alpha);

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_TriangularArrow", CallingConvention = CallingConvention.StdCall
            )]
        public static extern void TriangularArrow(IntPtr hDraw, int align, int x, int y, int width, int height);

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_Image", CallingConvention = CallingConvention.StdCall)]
        public static extern void Image(IntPtr hDraw, IntPtr hImage, int x, int y);

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_Image2", CallingConvention = CallingConvention.StdCall)]
        public static extern void Image2(IntPtr hDraw, IntPtr hImage, int x, int y, int width, int height);

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_ImageStretch", CallingConvention = CallingConvention.StdCall)]
        public static extern void ImageStretch(IntPtr hDraw, IntPtr hImage, int x, int y, int width, int height);

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_ImageAdaptive", CallingConvention = CallingConvention.StdCall)]
        public static extern void ImageAdaptive(IntPtr hDraw, IntPtr hImage,
            [MarshalAs(UnmanagedType.LPStruct)] XRect pRect);

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_ImageExTile", CallingConvention = CallingConvention.StdCall)]
        public static extern void ImageExTile(IntPtr hDraw, IntPtr hImage,
            [MarshalAs(UnmanagedType.LPStruct)] XRect pRect, int flag = 0);

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_ImageSuper", CallingConvention = CallingConvention.StdCall)]
        public static extern void ImageSuper(IntPtr hDraw, IntPtr hImage,
            [MarshalAs(UnmanagedType.LPStruct)] XRect pRect, bool bClip = false);

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_ImageSuper2", CallingConvention = CallingConvention.StdCall)]
        public static extern void ImageSuper2(IntPtr hDraw, IntPtr hImage,
            [MarshalAs(UnmanagedType.LPStruct)] XRect pRcDest, [MarshalAs(UnmanagedType.LPStruct)] XRect pSrcRect);

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_DrawText", CallingConvention = CallingConvention.StdCall)]
        public static extern void DrawText(IntPtr hDraw, [MarshalAs(UnmanagedType.LPWStr)] string lpString, int nCount,
            [MarshalAs(UnmanagedType.LPStruct)] XRect lpRect);

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_DrawTextUnderline",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void DrawTextUnderline(IntPtr hDraw, [MarshalAs(UnmanagedType.LPWStr)] string lpString,
            int nCount, [MarshalAs(UnmanagedType.LPStruct)] XRect lpRect, int colorLine, byte alphaLine = 254);

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_TextOut", CallingConvention = CallingConvention.StdCall)]
        public static extern void TextOut(IntPtr hDraw, int nXStart, int nYStart,
            [MarshalAs(UnmanagedType.LPWStr)] string lpString, int cbString);

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_TextOutA", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi)]
        public static extern void TextOutA(IntPtr hDraw, int nXStart, int nYStart,
            [MarshalAs(UnmanagedType.LPStr)] string lpString);

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_SetAlpha", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetAlpha(IntPtr hDraw, byte alpha); //设置透明通道度

        [DllImport(XToolkit.DllName, EntryPoint = "XDraw_SetAlphaEx", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetAlphaEx(IntPtr hdc, byte alpha); //设置透明通道度
    }
}