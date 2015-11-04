using System.Runtime.InteropServices;

namespace System.Win32
{
    public static class XRichEdit
    {
        [DllImport(XToolkit.DllName, EntryPoint = "XRichEdit_Create", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Create(int x, int y, int cx, int cy, IntPtr hParent);

        [DllImport(XToolkit.DllName, EntryPoint = "XRichEdit_InsertString",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void InsertString(IntPtr hEle, [MarshalAs(UnmanagedType.LPWStr)] string pString,
            [MarshalAs(UnmanagedType.LPStruct)] XLogFontW pFont, int color = 0);

        [DllImport(XToolkit.DllName, EntryPoint = "XRichEdit_InsertImage", CallingConvention = CallingConvention.StdCall
            )]
        public static extern bool InsertImage(IntPtr hEle, IntPtr hImage,
            [MarshalAs(UnmanagedType.LPWStr)] string pImagePath);

        [DllImport(XToolkit.DllName, EntryPoint = "XRichEdit_InsertGif", CallingConvention = CallingConvention.StdCall)]
        public static extern bool InsertGif(IntPtr hEle, IntPtr hImage,
            [MarshalAs(UnmanagedType.LPWStr)] string pImagePath);

        [DllImport(XToolkit.DllName, EntryPoint = "XRichEdit_InsertStringEx",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void InsertStringEx(IntPtr hEle, int iRow, int iColumn,
            [MarshalAs(UnmanagedType.LPWStr)] string pString, [MarshalAs(UnmanagedType.LPStruct)] XLogFontW pFont,
            int color = 0);

        [DllImport(XToolkit.DllName, EntryPoint = "XRichEdit_InsertImageEx",
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool InsertImageEx(IntPtr hEle, int iRow, int iColumn, IntPtr hImage,
            [MarshalAs(UnmanagedType.LPWStr)] string pImagePath);

        [DllImport(XToolkit.DllName, EntryPoint = "XRichEdit_InsertGifEx", CallingConvention = CallingConvention.StdCall
            )]
        public static extern bool InsertGifEx(IntPtr hEle, int iRow, int iColumn, IntPtr hImage,
            [MarshalAs(UnmanagedType.LPWStr)] string pImagePath);

        [DllImport(XToolkit.DllName, EntryPoint = "XRichEdit_EnableReadOnly",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void EnableReadOnly(IntPtr hEle, bool bEnable);

        [DllImport(XToolkit.DllName, EntryPoint = "XRichEdit_EnableMultiLine",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void EnableMultiLine(IntPtr hEle, bool bEnable);

        [DllImport(XToolkit.DllName, EntryPoint = "XRichEdit_EnablePassword",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void EnablePassword(IntPtr hEle, bool bEnable);

        [DllImport(XToolkit.DllName, EntryPoint = "XRichEdit_EnableEvent_XE_RICHEDIT_CHANGE",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void EnableChangeEvent(IntPtr hEle, bool bEnable);

        [DllImport(XToolkit.DllName, EntryPoint = "XRichEdit_EnableAutoWrap",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void EnableAutoWrap(IntPtr hEle, bool bEnable);

        [DllImport(XToolkit.DllName, EntryPoint = "XRichEdit_EnableKeyTab",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void EnableKeyTab(IntPtr hEle, bool bEnable);

        [DllImport(XToolkit.DllName, EntryPoint = "XRichEdit_SetText", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetText(IntPtr hEle, [MarshalAs(UnmanagedType.LPWStr)] string pString);

        [DllImport(XToolkit.DllName, EntryPoint = "XRichEdit_SetTextInt", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern void SetTextInt(IntPtr hEle, int nVaule);

        [DllImport(XToolkit.DllName, EntryPoint = "XRichEdit_GetText", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Unicode)]
        public static extern int GetText(IntPtr hEle, out byte[] pOut, int len);

        [DllImport(XToolkit.DllName, EntryPoint = "XRichEdit_GetHTMLFormat",
            CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        public static extern void GetHTMLFormat(IntPtr hEle, out byte[] pOut, int len); //获取HTML格式内容

        [DllImport(XToolkit.DllName, EntryPoint = "XRichEdit_GetData", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetData(IntPtr hEle, out int pDataSize);

        [DllImport(XToolkit.DllName, EntryPoint = "XRichEdit_SetData", CallingConvention = CallingConvention.StdCall)]
        public static extern bool SetData(IntPtr hEle, IntPtr pData, int iRow, int iColumn);

        [DllImport(XToolkit.DllName, EntryPoint = "XRichEdit_GetTextLength",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int GetTextLength(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XRichEdit_SetRowHeight",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetRowHeight(IntPtr hEle, int nHeight); //设置默认行高

        [DllImport(XToolkit.DllName, EntryPoint = "XRichEdit_GetCurrentRow",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int GetCurrentRow(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XRichEdit_GetCurrentColumn",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int GetCurrentColumn(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XRichEdit_SetCurrentPos",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetCurrentPos(IntPtr hEle, int iRow, int iColumn);

        [DllImport(XToolkit.DllName, EntryPoint = "XRichEdit_GetRowCount", CallingConvention = CallingConvention.StdCall
            )]
        public static extern int GetRowCount(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XRichEdit_GetRowLength",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int GetRowLength(IntPtr hEle, int iRow);

        [DllImport(XToolkit.DllName, EntryPoint = "XRichEdit_GetSelectText",
            CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        public static extern int GetSelectText(IntPtr hEle, out byte[] pOut, int len);

        [DllImport(XToolkit.DllName, EntryPoint = "XRichEdit_GetSelectPosition",
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool GetSelectPosition(IntPtr hEle, out XPoint pBegin, out XPoint pEnd);

        [DllImport(XToolkit.DllName, EntryPoint = "XRichEdit_SetSelect", CallingConvention = CallingConvention.StdCall)]
        public static extern bool SetSelect(IntPtr hEle, int iStartRow, int iStartCol, int iEndRow, int iEndCol);

        [DllImport(XToolkit.DllName, EntryPoint = "XRichEdit_SetItemFontEx",
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool SetItemFontEx(IntPtr hEle, int beginRow, int beginColumn, int endRow, int endColumn,
            [MarshalAs(UnmanagedType.LPStruct)] XLogFontW pFont);

        [DllImport(XToolkit.DllName, EntryPoint = "XRichEdit_SetItemColorEx",
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool SetItemColorEx(IntPtr hEle, int beginRow, int beginColumn, int endRow, int endColumn,
            int color, byte alpha = 255);

        [DllImport(XToolkit.DllName, EntryPoint = "XRichEdit_CancelSelect",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void CancelSelect(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XRichEdit_SetSelectBkColor",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetSelectBkColor(IntPtr hEle, int color, byte alpha = 255);

        [DllImport(XToolkit.DllName, EntryPoint = "XRichEdit_IsEmpty", CallingConvention = CallingConvention.StdCall)]
        public static extern bool IsEmpty(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XRichEdit_IsKeyTab", CallingConvention = CallingConvention.StdCall)]
        public static extern bool IsKeyTab(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XRichEdit_SelectAll", CallingConvention = CallingConvention.StdCall)]
        public static extern bool SelectAll(IntPtr hEle); //选择所有内容

        [DllImport(XToolkit.DllName, EntryPoint = "XRichEdit_DeleteSelect",
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool DeleteSelect(IntPtr hEle); //删除选择内容

        [DllImport(XToolkit.DllName, EntryPoint = "XRichEdit_DeleteAll", CallingConvention = CallingConvention.StdCall)]
        public static extern void DeleteAll(IntPtr hEle); //删除所有

        [DllImport(XToolkit.DllName, EntryPoint = "XRichEdit_ClipboardCut",
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool ClipboardCut(IntPtr hEle); //剪切

        [DllImport(XToolkit.DllName, EntryPoint = "XRichEdit_ClipboardCopy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool ClipboardCopy(IntPtr hEle); //复制 选择的内容

        [DllImport(XToolkit.DllName, EntryPoint = "XRichEdit_ClipboardPaste",
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool ClipboardPaste(IntPtr hEle); //粘贴 粘贴剪贴板内容

        [DllImport(XToolkit.DllName, EntryPoint = "XRichEdit_EnableAutoCancelSel",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void EnableAutoCancelSel(IntPtr hEle, bool bEnable = true);
    }
}