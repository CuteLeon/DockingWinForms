using WeifenLuo.WinFormsUI.Docking;

namespace DockingWinForms.ViaDockPanelSuite.Docks
{
    public partial class DockForm1 : DockContent
    {
        public DockForm1()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// 返回在布局转储XML中被作为唯一标记的字符串，base 方法近包含类型名称，通过复写追加针对此类每个对象的特征数据，以便于恢复布局
        /// </summary>
        /// <returns></returns>
        protected override string GetPersistString()
        {
            // 假设此类有多个窗口实例，但每个实例标题不同，可以追加标题作为唯一特征
            return $"{base.GetPersistString()}@{this.TabText}";
        }
    }
}
