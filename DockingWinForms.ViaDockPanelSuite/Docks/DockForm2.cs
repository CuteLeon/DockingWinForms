using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace DockingWinForms.ViaDockPanelSuite.Docks
{
    public partial class DockForm2 : DockContent
    {
        public DockForm2()
        {
            this.InitializeComponent();

            this.DockHandler.AllowEndUserDocking = false;

            // 禁用关闭按钮
            this.CloseButton = false;
            // 隐藏关闭按钮
            this.CloseButtonVisible = false;
        }

        /// <summary>
        /// 窗口关闭
        /// </summary>
        /// <param name="e"></param>
        /// <remarks>坑：this.Hide() 将引用到 DockContent().Hide()，请使用：((Form)this).Hide() 或 this.Visible = false</remarks>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // 如果启用“隐藏窗口而非关闭”且用户主动请求关闭时
            if (this.HideOnClose &&
                e.CloseReason == CloseReason.UserClosing)
            {
                // 取消窗口关闭并手动隐藏窗口
                e.Cancel = true;
                this.Visible = false;
            }

            base.OnFormClosing(e);
        }
    }
}
