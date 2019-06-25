using WeifenLuo.WinFormsUI.Docking;

namespace DockingWinForms.ViaDockPanelSuite.Docks
{
    public partial class DockForm2 : DockContent
    {
        public DockForm2()
        {
            this.InitializeComponent();

            // 禁用关闭按钮
            this.CloseButton = false;
            // 隐藏关闭按钮
            this.CloseButtonVisible = false;
        }
    }
}
