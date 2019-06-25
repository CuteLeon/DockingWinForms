using System.Linq;
using DarkUI.Controls;
using DarkUI.Docking;

namespace DockingWinForms.ViaDarkUI.Docks
{
    public partial class Dock1 : DarkToolWindow
    {
        public Dock1()
        {
            this.InitializeComponent();

            // TODO: 必须赋值
            this.DockArea = DarkDockArea.Left;

            Enumerable.Range(1, 100).ToList().ForEach(i => this.darkListView1.Items.Add(new DarkListItem(i.ToString())));
        }
    }
}
