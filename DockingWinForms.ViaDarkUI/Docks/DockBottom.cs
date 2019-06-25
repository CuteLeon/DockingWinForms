using DarkUI.Docking;

namespace DockingWinForms.ViaDarkUI.Docks
{
    public partial class DockBottom : DarkToolWindow
    {
        public DockBottom()
        {
            this.InitializeComponent();

            this.DockText = "记得赋值 DockText";
            this.DockArea = DarkDockArea.Bottom;
        }
    }
}
