namespace System.Win32
{
    public enum XObjectType ///<炫彩对象类型
    {
        Error = -1,

        ///<错误类型
        Window = 1,

        ///<窗口
        ModalWindow,

        ///<模态窗口
        FrameWnd,

        ///<框架窗口
        FloatWnd,

        ///<浮动窗口
        ComboBoxWindow = 11, //comboBoxWindow_ 组合框弹出下拉列表窗口
        PopupMenuWindow, //popupMenuWindow_ 弹出菜单主窗口
        PopupMenuChildWindow, //popupMenuChildWindow_ 弹出菜单子窗口

        //元素
        Ele = 21,

        ///<基础元素
        Button,

        ///<按钮
        RichEdit,

        ///<富文本编辑框
        ComboBox,

        ///<下拉组合框元素
        ScrollBar,

        ///<滚动条元素
        ScrollView,

        ///<滚动视图元素
        List,

        ///<列表元素
        ListBox,

        ///<列表框元素
        ListView,

        ///<列表视图,大图标
        Tree,

        ///<树元素
        MenuBar,

        ///<菜单条
        SliderBar,

        ///<滑动条
        ProgressBar,

        ///<进度条
        ToolBar,

        ///<工具条
        MonthCal,

        ///<月历元素
        DateTime,

        ///<时间元素
        PropertyGrid,

        ///<属性网格
        RichEditColor,

        ///<颜色选择元素
        RichEditSet,
        TabBar,

        ///<tab条
        TextLink,

        ///<文本链接按钮
        Pane,

        ///<布局窗格
        PaneSplit,

        ///<布局窗格拖动分割条
        MenuBarButton,

        ///<菜单条上的按钮
        ToolBarButton,

        ///<工具条上按钮
        PropertyPageLabel,

        ///<属性页标签按钮
        Pier,

        ///<窗格停靠码头
        ButtonMenu,

        ///<弹出菜单按钮
        VirtualEle,

        ///<虚拟元素
        RichEditFile,

        ///<RichEditFile 文件选择编辑框
        RichEditFolder,

        ///<RichEditFolder 文件夹选择编辑框
        ListHeader,

        ///<列表头元素
        Shape = 61,

        ///<形状对象
        ShapeText,

        ///<形状对象-文本
        ShapePicture,

        ///<形状对象-图片
        ShapeRect,

        ///<形状对象-矩形
        ShapeEllipse,

        ///<形状对象-圆
        ShapeLine,

        ///<形状对象-直线
        ShapeGroupBox,

        ///<形状对象-组框
        ShapeGif,

        ///<形状对象-GIF

        //其他类型
        Menu = 81,

        ///<弹出菜单
        Image,

        ///<图片操作
        HDraw,

        ///<绘图操作
        Font,

        ///<炫彩字体
        Flash,

        ///<flash 
        PaneCell,
        Web,

        LayoutObject = 101,

        ///<布局对象LayoutObject
        AdapterTable,

        ///<数据适配器AdapterTable
        AdapterTree,

        ///<数据适配器AdapterTree
        AdapterListView,

        ///<数据适配器AdapterListView
        AdapterMap,

        ///<数据适配器AdapterMap

        //无实体对象,只是用来判断布局
        LayoutListView = 111,
        LayoutList,
        LayoutObjectGroup,
        LayoutObjectItem,
        LayoutPanel,

        //BUTTON_EX,
    };
}