// =====================================
// |        0AD Modding Toolkit        |
// =====================================
// |           Version 0.0.0.1         |
// =====================================
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace ModToolsdll.Editors.Civ
{
    public partial class CivEdi : Form
    {
        public CivEdi()
        {
            this.InitializeComponent();
        }
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
        }
        private void CivEdi_Load(object sender, EventArgs e)
        {
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region custom tabs
        private void button2_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = this.tabPage1;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = this.tabPage2;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = this.tabPage3;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = this.tabPage4;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = this.tabPage5;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = this.tabPage6;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = this.tabPage7;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = this.tabPage8;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = this.tabPage9;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = this.tabPage10;
        }
        private void button12_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = this.tabPage11;
        }
        private void button13_Click(object sender, EventArgs e)
        {
            string update;
            List<string> plans = new List<string>();
            update = "0.0.0.2";
            plans.Add("{civ}.json save fature");
            TreeNode x = new TreeNode();
            List<TreeNode> z = new List<TreeNode>();
            foreach (string tem in plans)
            {
                x.Text = tem;
                x.BackColor = Color.Lime;
                x.ForeColor = Color.Red;
                z.Add(x);
            }
            TreeNode u = new TreeNode(string.Format("update: {0}", update), z.ToArray());
            List<TreeNode> uv = new List<TreeNode>();
            uv.Add(u);
            TreeNode fi = new TreeNode("Planned Updates",uv.ToArray());
            u.BackColor = Color.Lime;
            u.ForeColor = Color.Red;
            fi.BackColor = Color.Lime;
            fi.ForeColor = Color.Red;
            this.treeView5.BackColor = Color.Lime;
            this.treeView5.ForeColor = Color.Red;
            this.treeView5.Nodes.Clear();
            this.treeView5.Nodes.Add(fi);
            this.tabControl1.SelectedTab = this.tabPage12;
        }
        #endregion
    }
}