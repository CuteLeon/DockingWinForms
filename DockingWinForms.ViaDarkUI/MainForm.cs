using System.Windows.Forms;
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

        public MainForm()
        {
            this.InitializeComponent();

            // 实现停靠容器拖拽和拉伸
            Application.AddMessageFilter(this.DemoDockPanel.DockContentDragFilter);
            Application.AddMessageFilter(this.DemoDockPanel.DockResizeFilter);

            this.DemoDockPanel.AddContent(this.dock1);
            this.DemoDockPanel.AddContent(this.dock2);
            this.DemoDockPanel.AddContent(this.dock3);
            this.DemoDockPanel.AddContent(this.dock4);
            this.DemoDockPanel.AddContent(this.dock5);
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
