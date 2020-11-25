using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personal_manage.UI
{
    public partial class TabFormTest : Form
    {
        public TabFormTest()
        {
            InitializeComponent();
        }

        private void TabFormTest_Load(object sender, EventArgs e)
        {
            tabControl1_SelectedIndexChanged(null, null);//触发切换选项卡事件，显示需要设置的UI
        }



        private void tabPage1_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// 切换选项卡时设置UI样式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region UI设置
            foreach (TabPage tab in this.tabControl1.TabPages)
            {
                var t = tab as TabPage;
                t.Font = new Font("微软雅黑", 14F, GraphicsUnit.Pixel);
            }

            var item = this.tabControl1.SelectedTab;
            item.Font = new Font("微软雅黑", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            #endregion
        }

        private void kenComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kenGroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void kenPage1_Load(object sender, EventArgs e)
        {

        }

        private void kryptonDropButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
