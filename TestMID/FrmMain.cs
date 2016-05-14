using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestMID
{
    public partial class FrmMain : Form
    {
        Sunisoft.IrisSkin.SkinEngine se = null;
        #region 构造方法
        public FrmMain()
        {
            InitializeComponent();
            se = new Sunisoft.IrisSkin.SkinEngine();
            se.SkinFile = "皮肤/SteelBlack.ssk";   // 选择皮肤
            se.SkinAllForm = true;
        } 
        #endregion

        #region 菜单事件
        private void frm1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMid frm1 = new FrmMid();
            frm1.MdiParent = this;
            frm1.WindowState = FormWindowState.Maximized;
            frm1.Show();
            AddTabPage(frm1);
        }
        #endregion

        #region FrmMain_Load
        private void FrmMain_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages.Clear();
            tabControl1.Visible = false;
            label1.Visible = false;
        }

        #endregion

        #region TabControl
        /// <summary>
        /// 添加TabPage
        /// </summary>
        /// <param name="frm"></param>
        private void AddTabPage(Form frm)
        {
            TabPage tp = new TabPage();
            tp.Tag = frm;
            tabControl1.TabPages.Add(tp);
            tabControl1.SelectedIndex = tabControl1.TabCount - 1;//选中最后一个新建的tab
            if (tabControl1.Visible == false) tabControl1.Visible = true;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex > -1)
                (tabControl1.TabPages[tabControl1.SelectedIndex].Tag as Form).Focus();
        } 

        /// <summary>
        /// 隐藏MID窗体菜单、按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuStrip1_ItemAdded(object sender, ToolStripItemEventArgs e)
        {
            if (e.Item.Text.Length == 0 || e.Item.Text == "最小化(&N)" || e.Item.Text == "还原(&R)" || e.Item.Text == "关闭(&C)")
            {
                e.Item.Visible = false;
            }
        }
        #endregion

        #region 鼠标坐标
        /// <summary>
        /// 从菜单弹出位置得到当前所在的标签索引
        /// </summary>
        /// <returns></returns>
        private int GetPageIndexWidthPoint(int pointX)
        {
            int x = 0;
            for (int i = 0; i < tabControl1.TabPages.Count; ++i)
            {
                if (pointX >= x && pointX <= x + tabControl1.ItemSize.Width)
                    return i;
                x += tabControl1.ItemSize.Width;
            }
            return tabControl1.TabPages.Count - 1;
        }

        /// <summary>
        /// 计算从第一个可见项到当前项的宽度
        /// </summary>
        /// <param name="nowItemIndex"></param>
        /// <returns></returns>
        private int GetItemWidth(int nowItemIndex)
        {
            int w = 0;
            for (int i = 0; i <= nowItemIndex; i++)
            {
                w += tabControl1.ItemSize.Width;
            }
            return w;
        } 
        #endregion

        #region 鼠标事件
        private void tabControl1_MouseMove(object sender, MouseEventArgs e)
        {
            int i = GetPageIndexWidthPoint(e.X); // 获取当前鼠标所在标签位置
            if (i > -1)
            {
                int posX = GetItemWidth(i) - label1.Width - 4;    // 计算label1的x坐标
                                                                  //定位label1位置
                label1.Left = posX;
                label1.Top = tabControl1.Top + 6;
                label1.Visible = true;
            }
            else
            {
                label1.Visible = false;
            }
            label1.Tag = i;
        }

        private void tabControl1_MouseLeave(object sender, EventArgs e)
        {
            label1.Visible = false;
        }
        #endregion

        #region 关闭事件
        /// <summary>
        /// 关闭lab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            if (label1.Tag != null && (int)label1.Tag > -1)
            {
                CloseTabPage((int)label1.Tag);
                label1.Visible = false;  // 关闭后将自己隐藏  
            }
        }
        /// <summary>
        /// 右键菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = GetPageIndexWidthPoint(contextMenuStrip1.Left - this.Left);  // 这里也需要通过弹出菜单的位置来得到当前是哪个项弹出的，注意菜单位置是针对屏幕左边的距离  
            CloseTabPage(index);
        }
        /// <summary>
        /// 点击鼠标中键关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                CloseTabPage(tabControl1.SelectedIndex);
            }
        }
        /// <summary>
        /// 关闭标签页
        /// </summary>
        /// <param name="index"></param>
        private void CloseTabPage(int index)
        {
            (tabControl1.TabPages[index].Tag as Form).Close();
            tabControl1.TabPages.RemoveAt(index);
            if (tabControl1.TabCount == 0)
            {
                tabControl1.Visible = false;
            }
        }
        /// <summary>
        /// 双击关闭标签
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                CloseTabPage(tabControl1.SelectedIndex);
            }
        }
        #endregion

        private void 换肤ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            se.SkinFile = "皮肤/SteelBlack.ssk";   // 选择皮肤
        }
    }
}
