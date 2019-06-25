using System.Windows.Forms;
using DarkUI.Forms;

namespace DockingWinForms.ViaDarkUI
{
    public partial class MainForm : DarkForm
    {
        public MainForm()
        {
            this.InitializeComponent();
        }

        private void 退出ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}
