using System.Linq;
using System.Windows.Forms;
using DockingWinForms.ViaDockPanelSuite.Docks;
using WeifenLuo.WinFormsUI.Docking;

namespace DockingWinForms.ViaDockPanelSuite
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            this.InitializeComponent();

            // 开启 MDI 容器
            this.IsMdiContainer = true;

            // 配置容器主题
            this.DemoDockPanel.Theme = new VS2015DarkTheme();
            // 配置停靠方式
            this.DemoDockPanel.DocumentStyle = DocumentStyle.DockingMdi;
            // 文档标签按钮位置
            this.DemoDockPanel.DocumentTabStripLocation = DocumentTabStripLocation.Top;

            // 保存和载入布局
            // this.DemoDockPanel.SaveAsXml("");
            // this.DemoDockPanel.LoadFromXml("", null);

            // 显示文档 Icon
            this.DemoDockPanel.ShowDocumentIcon = true;

            // 窗格
            // this.DemoDockPanel.Panes
            // 浮动窗口
            // this.DemoDockPanel.FloatWindows;
            // 内容
            // this.DemoDockPanel.Contents
            // 停靠窗口
            // this.DemoDockPanel.DockWindows;
            // 文档
            // this.DemoDockPanel.Documents;

            DockForm1 form1 = new DockForm1
            {
                // 配置允许的停靠模式：Float=浮动，Dock=停靠，Document=文档
                DockAreas = DockAreas.Float | DockAreas.DockLeft | DockAreas.DockRight | DockAreas.DockTop | DockAreas.DockBottom,
                // 首次显示状态：Float=浮动，Dock=停靠，Document=文档，AutoHide=自动隐藏
                ShowHint = DockState.DockLeftAutoHide,
                // 隐藏而不是关闭
                HideOnClose = true,
                // 标签页文本
                TabText = "工具",
            };

            // 获取或设置 是否浮动
            _ = form1.IsFloat;
            // 获取或设置 是否隐藏
            _ = form1.IsHidden;
            // 获取 是否受限
            _ = form1.IsRestrictedWindow;

            // 标签页菜单：TabPageContextMenuStrip 比 TabPageContextMenu 更加强大，且支持 DockPanel 主题
            form1.TabPageContextMenuStrip = new ContextMenuStrip() { Width = 100 };
            form1.TabPageContextMenuStrip.Items.Add("TabPageContextMenuStrip");

            // 内容交互菜单
            form1.ContextMenuStrip = new ContextMenuStrip();
            form1.ContextMenuStrip.Items.Add("ContextMenuStrip");

            // 显示
            form1.Show(this.DemoDockPanel);

            // DockState 可以实时切换，但必须在 Show() 之后
            form1.DockState = DockState.DockLeft;

            // 使用 Pane 以使用同一个窗格
            new DockForm1().Show(form1.Pane, null);

            // 激活
            form1.Activate();

            // 使用 同一窗格 根据比例 垂直或水平 并列显示
            new DockForm2().Show(form1.Pane, DockAlignment.Bottom, 0.4);

            // 添加多个文档
            Enumerable.Range(1, 10).ToList().ForEach(index =>
            {
                var document = new DockDocument()
                {
                    TabText = $"Document-TabText-{index}",
                    Text = $"Document-Text-{index}",
                    ToolTipText = $"Tool Tip Text - {index}",

                    DockAreas = DockAreas.Document | DockAreas.Float,
                };

                // 显示
                document.Show(this.DemoDockPanel, DockState.Document);
            });
        }
    }
}
