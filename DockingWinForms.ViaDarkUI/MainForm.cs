using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DarkUI.Controls;
using DarkUI.Docking;
using DarkUI.Forms;
using DockingWinForms.ViaDarkUI.Docks;

namespace DockingWinForms.ViaDarkUI
{
    public partial class MainForm : DarkForm
    {
        DockLeft dock1 = new DockLeft();
        DockLeft dock2 = new DockLeft();
        DockLeft dock3 = new DockLeft();
        DockBottom dock4 = new DockBottom();
        DockBottom dock5 = new DockBottom();
        DockRight dock6 = new DockRight();
        DockRight dock7 = new DockRight();
        DockRight dock8 = new DockRight();
        DockRight dock9 = new DockRight();
        DockDocument dock10 = new DockDocument();
        DockDocument dock11 = new DockDocument();
        DockDocument dock12 = new DockDocument();
        DockDocument dock13 = new DockDocument();

        public MainForm()
        {
            this.InitializeComponent();

            this.FormClosing += this.MainForm_FormClosing;

            // 实现停靠容器拖拽和拉伸
            Application.AddMessageFilter(this.DemoDockPanel.DockContentDragFilter);
            Application.AddMessageFilter(this.DemoDockPanel.DockResizeFilter);

            this.DemoDockPanel.AddContent(this.dock1);
            // DockPanel.AddContent(, DockGroup) 合并子容器
            this.DemoDockPanel.AddContent(this.dock2, this.dock1.DockGroup);
            this.DemoDockPanel.AddContent(this.dock3);
            this.DemoDockPanel.AddContent(this.dock4);
            this.DemoDockPanel.AddContent(this.dock5);
            this.DemoDockPanel.AddContent(this.dock6);
            this.DemoDockPanel.AddContent(this.dock7);
            this.DemoDockPanel.AddContent(this.dock8);
            this.DemoDockPanel.AddContent(this.dock9);
            this.DemoDockPanel.AddContent(this.dock10);
            this.DemoDockPanel.AddContent(this.dock11);
            this.DemoDockPanel.AddContent(this.dock12);
            this.DemoDockPanel.AddContent(this.dock13);

            DarkDocument document = new DarkDocument() { DockText = "测试" };
            DarkButton button = new DarkButton() { Dock = DockStyle.Fill, Text = "Button" };
            document.Padding = new Padding(30);
            document.Controls.Add(button);
            button.MouseClick += this.Button_MouseClick;
            this.DemoDockPanel.AddContent(document);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 序列化储存到外部，以保存布局
            // 需要给 Dock 控件设置 SerializationKey 属性
            DockPanelState state = this.DemoDockPanel.GetDockPanelState();

            // 使用字典维护 Dock 控件和序列化 Key 的关系，还原布局时，需要传入一个根据 Key， 返回对应 Dock 控件的委托；
            var dictionary = new Dictionary<string, DarkDockContent>();
            if (dictionary.Count > 0)
            {
                this.DemoDockPanel.RestoreDockPanelState(state, (key) => dictionary[key]);
            }
        }

        private void Button_MouseClick(object sender, MouseEventArgs e)
        {
            DarkMessageBox.ShowInformation(
                string.Join("、", this.DemoDockPanel.GetDocuments().Select(doc => doc.DockText)),
                "已打开文档：");
        }

        private void 退出ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void 新建文档ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }
    }
}
