using System.Windows.Forms;
using DarkUI.Docking;
using DarkUI.Forms;
using DockingWinForms.ViaDarkUI.Docks;

namespace DockingWinForms.ViaDarkUI
{
    public partial class MainForm : DarkForm
    {
        Dock1 dock1 = new Dock1();
        Dock1 dock2 = new Dock1();
        Dock1 dock3 = new Dock1();

        public MainForm()
        {
            this.InitializeComponent();

            // 实现停靠容器拖拽和拉伸
            Application.AddMessageFilter(this.DemoDockPanel.DockContentDragFilter);
            Application.AddMessageFilter(this.DemoDockPanel.DockResizeFilter);

            this.DemoDockPanel.AddContent(this.dock1);
            this.DemoDockPanel.AddContent(this.dock2);
            this.DemoDockPanel.AddContent(this.dock3);
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
