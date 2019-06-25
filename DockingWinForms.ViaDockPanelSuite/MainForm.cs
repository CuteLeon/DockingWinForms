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
                ShowHint = DockState.DockLeft,
                // 隐藏而不是关闭
                HideOnClose = true,
                // 标签页文本
                TabText = "工具",
            };

            // 是否浮动
            _ = form1.IsFloat;
            // 是否隐藏
            _ = form1.IsHidden;
            // 是否受限
            _ = form1.IsRestrictedWindow;

            // 配置菜单
            form1.TabPageContextMenu = new ContextMenu();
            form1.TabPageContextMenu.MenuItems.Add("TabPageContextMenu");

            // 显示
            form1.Show(this.DemoDockPanel);

            // 切换停靠状态
            form1.DockState = DockState.DockLeftAutoHide;

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
