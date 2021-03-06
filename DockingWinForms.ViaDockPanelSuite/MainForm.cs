﻿using System.Linq;
using System.Windows.Forms;
using DockingWinForms.ViaDockPanelSuite.Docks;
using WeifenLuo.WinFormsUI.Docking;

namespace DockingWinForms.ViaDockPanelSuite
{
    /// <summary>
    /// 主窗口
    /// </summary>
    /// <see cref="http://docs.dockpanelsuite.com/getting-started/index.html#"/>
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

                    TabPageContextMenuStrip = form1.TabPageContextMenuStrip,
                };

                // 显示
                document.Show(this.DemoDockPanel, DockState.Document);
            });

            // 激活被隐藏的 AutoHide 窗口
            form1.DockState = DockState.DockLeftAutoHide;
            this.DemoDockPanel.ActiveAutoHideContent = form1;
            // 隐藏被激活的 AutoHide 窗口 (双击被激活的 AutoHide 窗口即可)
            this.DemoDockPanel.ActiveAutoHideContent = null;

            // 移除停靠内容
            form1.DockHandler.DockPanel = null;

            // 使用自定义浮动窗口工厂
            this.DemoDockPanel.Theme.Extender.FloatWindowFactory = new CustomFloatWindowFactory();

            /* 将主题应用到 菜单栏、工具栏、状态栏
            this.DemoDockPanel.Theme.ApplyTo(this.MainTopMenuStrip);
            this.DemoDockPanel.Theme.ApplyTo(this.MainToolStrip);
            this.DemoDockPanel.Theme.ApplyTo(this.MainStatusStrip);
             */
        }

        private void ExportImport()
        {
            // 保存布局（使用 IDockContent.GetPersistString() 生成窗口对象的唯一标记）
            this.DemoDockPanel.SaveAsXml("layout.xml");

            // 加载布局（使用 DeserializeDockContent 委托解析 persist 寻找对应的窗口对象）
            DeserializeDockContent deserialize = (persist) => new DockForm1();
            this.DemoDockPanel.LoadFromXml("layout.xml", deserialize);
        }
    }
}
