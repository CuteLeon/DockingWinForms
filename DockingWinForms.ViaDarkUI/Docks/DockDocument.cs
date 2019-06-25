using System.Windows.Forms;
using DarkUI.Docking;
using DarkUI.Forms;

namespace DockingWinForms.ViaDarkUI.Docks
{
    public partial class DockDocument : DarkDocument
    {
        public DockDocument()
        {
            this.InitializeComponent();
        }

        public override void Close()
        {
            var result = DarkMessageBox.ShowWarning(@"You will lose any unsaved changes. Continue?", @"Close document", DarkDialogButton.YesNo);
            if (result == DialogResult.No)
                return;

            base.Close();
        }
    }
}
