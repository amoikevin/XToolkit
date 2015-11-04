namespace System.Win32
{
    public static class XWindowStyle
    {
        public const int Caption = 0x00000001;

        ///<top布局,如果指定该属性,默认为绑定标题栏元素
        public const int Border = 0x00000002;

        ///<边框,指定默认上下左右布局大小,如果没有指定,那么边框布局大小为0
        public const int Center = 0x00000004;

        ///<窗口居中
        public const int DragBorder = 0x00000008;

        ///<拖动窗口边框
        public const int DragWindow = 0x00000010;

        ///<拖动窗口
        ///窗口默认样式
        public const int Default = (Caption | Border | Center | DragBorder);

        ///模态窗口
        public const int ModalWindow = (Caption | Center | Border);
    }
}