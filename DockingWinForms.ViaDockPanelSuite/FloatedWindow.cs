using System.Drawing;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace DockingWinForms.ViaDockPanelSuite
{
    /// <summary>
    /// 默认浮动窗口为 SizableToolWindow 样式，手动实现为 Sizable
    /// </summary>
    public partial class FloatedWindow : FloatWindow
    {
        public FloatedWindow(DockPanel dockPanel, DockPane pane)
                : base(dockPanel, pane)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        public FloatedWindow(DockPanel dockPanel, DockPane pane, Rectangle bounds)
            : base(dockPanel, pane, bounds)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }
    }

    /// <summary>
    /// 通过 IFloatWindowFactory 接口实现浮动窗口工厂
    /// </summary>
    public class CustomFloatWindowFactory : DockPanelExtender.IFloatWindowFactory
    {
        public FloatWindow CreateFloatWindow(DockPanel dockPanel, DockPane pane, Rectangle bounds)
        {
            return new FloatedWindow(dockPanel, pane, bounds);
        }

        public FloatWindow CreateFloatWindow(DockPanel dockPanel, DockPane pane)
        {
            return new FloatedWindow(dockPanel, pane);
        }
    }
}
