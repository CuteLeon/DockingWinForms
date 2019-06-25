using DarkUI.Docking;

namespace DockingWinForms.ViaDarkUI.Docks
{
    public partial class DockBottom : DarkToolWindow
    {
        public DockBottom()
        {
            InitializeComponent();

            this.DockText = "记得赋值 DockText";
            DockArea = DarkDockArea.Bottom;
        }
    }
}
