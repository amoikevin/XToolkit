namespace System.Win32
{
    public enum XButtonStyle
    {
        Default = 0, ///<默认风格
        Check, ///<复选按钮
        Radio, ///<单选按钮
        ScrollBarUp, ///<水平滚动条,上按钮
        ScrollBarDown, ///<水平滚动条,下按钮
        ScrollBarLeft, ///<水平滚动条,左按钮
        ScrollBarRight, ///<水平滚动条,右按钮
        ScrollBarSlider, ///<滚动条,滑块
        TabBarButton, ///<TabBar上的按钮
        ToolBarLeft, ///<ToolBar左滚动按钮
        ToolBarRight, ///<ToolBar右滚动按钮

        PaneClose, ///<窗格关闭按钮
        PaneLock, ///<窗格锁定按钮
        PaneMenu, ///<窗格下拉菜单按钮
        PaneDockH, ///<框架窗口左边或右边码头上按钮
        PaneDockV, ///<框架窗口上边或下边码头上按钮
    };
}