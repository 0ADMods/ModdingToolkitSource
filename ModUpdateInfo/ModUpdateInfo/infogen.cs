// =====================================
// |        0AD Modding Toolkit        |
// =====================================
// |           Version 0.0.0.1         |
// =====================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ModUpdateInfo.features;
using ModUpdateInfo.features.bases;
using ModUpdateInfo.IO;
using System.Drawing;
namespace ModUpdateInfo
{
    public partial class infogen : Form
    {
        #region info
        private Dictionary<string, Upda> updae = new Dictionary<string, Upda>();
        private rewr rex=new rewr();
        #endregion
        #region commands 1
        public infogen()
        {
            this.InitializeComponent();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.comboBox1.Items.Clear();
            Upda a = new Upda();
            a.version = this.textBox1.Text;
            this.updae.Add(a.version, a);
            this.totre();
        }
        private void totre()
        {
            List<string> bales = new List<string>();
            List<string> modis = new List<string>();
            List<string> remos = new List<string>();
            List<string> updats = new List<string>();
            List<TreeNode> nodes = new List<TreeNode>();
            List<TreeNode> nodes2 = new List<TreeNode>();
            foreach (string vr in this.updae.Keys)
            {
                #region dic to list
                this.tco(vr);
                Upda updas = this.updae[vr];
                bala bals = updas.o;
                foreach (int tem in bals.upda.Keys)
                {
                    string x = bals.upda[tem];
                    bales.Add(x);
                }
                Remo resu = updas.m;
                foreach (int tem in resu.upda.Keys)
                {
                    string x = resu.upda[tem];
                    remos.Add(x);
                }
                modi modiu = updas.p;
                foreach (int tem in modiu.upda.Keys)
                {
                    string x = modiu.upda[tem];
                    modis.Add(x);
                }
                updated upsu = updas.n;
                foreach (int tem in upsu.upda.Keys)
                {
                    string x = upsu.upda[tem];
                    updats.Add(x);
                }
                #endregion
                #region create nodes
                nodes.Add(this.balx(bales));
                nodes.Add(this.rexx(modis));
                nodes.Add(this.upx(remos));
                nodes.Add(this.mox(updats));
                #endregion
                TreeNode uxp = new TreeNode(vr, nodes.ToArray());
                nodes2.Add(uxp);
                bales = new List<string>();
                modis = new List<string>();
                remos = new List<string>();
                updats = new List<string>();
                nodes = new List<TreeNode>();
            }
            TreeNode u = new TreeNode("Updates", nodes2.ToArray());
            this.xxx(u);
            nodes2 = new List<TreeNode>();
        }
        #endregion
        #region to trees
        private TreeNode balx(List<string> bals)
        {
            List<TreeNode> umi = new List<TreeNode>();
            
            foreach (string use in bals)
            {
                TreeNode x = new TreeNode(use);
                umi.Add(x);
            }
            TreeNode unix = new TreeNode("Balenced Features",umi.ToArray());
            return unix;
        }
        private TreeNode rexx(List<string> bals)
        {
            List<TreeNode> umi = new List<TreeNode>();
            foreach (string use in bals)
            {
                TreeNode x = new TreeNode(use);
                umi.Add(x);
            }
            TreeNode unix = new TreeNode("Removed Features", umi.ToArray());
            return unix;
        }
        private TreeNode upx(List<string> bals)
        {
            List<TreeNode> umi = new List<TreeNode>();
            foreach (string use in bals)
            {
                TreeNode x = new TreeNode(use);
                umi.Add(x);
            }
            TreeNode unix = new TreeNode("Updated Features", umi.ToArray());
            return unix;
        }
        private TreeNode mox(List<string> bals)
        {
            List<TreeNode> umi = new List<TreeNode>();
            foreach (string use in bals)
            {
                TreeNode x = new TreeNode(use);
                umi.Add(x);
            }
            TreeNode unix = new TreeNode("Modified Features", umi.ToArray());
            return unix;
        }
        #endregion
        #region to list
        private void xxx(TreeNode ums)
        {
            this.treeView1.Nodes.Clear();
            this.treeView1.Nodes.Add(ums);
        }
        #endregion
        #region tocombo
        private void tco(string x)
        {
            this.comboBox1.Items.Add(x);
            this.comboBox1.SelectedIndex = 0;
        }
        #endregion
        #region tabSwitches
        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage5;
        }
        #endregion
        #region commands2
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<string> ums = new List<string>();
            ums = richTextBox4.Lines.ToList<string>();
            anf(ums);
        }
        #endregion
        #region add new features
        private void anf(List<string> x)
        {
            Upda ux = updae[this.comboBox1.SelectedItem.ToString()];
            updae.Remove(ux.version);
            foreach (string x2 in x)
            {
                ux.n.upda.Add(ux.n.upda.Count + 1,("- "+ x2));
            }
            updae.Add(ux.version, ux);
            totre();
        }
        private void anr(List<string> x)
        {
            Upda ux = updae[this.comboBox1.SelectedItem.ToString()];
            updae.Remove(ux.version);
            foreach (string x2 in x)
            {
                ux.m.upda.Add(ux.m.upda.Count + 1, "- " + x2);
            }
            updae.Add(ux.version, ux);
            totre();
        }
        private void anb(List<string> x)
        {
            Upda ux = updae[this.comboBox1.SelectedItem.ToString()];
            updae.Remove(ux.version);
            foreach (string x2 in x)
            {
                ux.o.upda.Add(ux.o.upda.Count + 1, "- " + x2);
            }
            updae.Add(ux.version, ux);
            totre();
        }
        private void anm(List<string> x)
        {
            Upda ux = updae[this.comboBox1.SelectedItem.ToString()];
            updae.Remove(ux.version);
            foreach (string x2 in x)
            {
                ux.p.upda.Add(ux.p.upda.Count + 1, "- " + x2);
            }
            updae.Add(ux.version, ux);
            totre();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            List<string> ums = new List<string>();
            ums = richTextBox1.Lines.ToList<string>();
            anr(ums);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            List<string> ums = new List<string>();
            ums = richTextBox2.Lines.ToList<string>();
            anb(ums);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            List<string> ums = new List<string>();
            ums = richTextBox3.Lines.ToList<string>();
            anm(ums);
        }
        #endregion

        private void binaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rex.data = this.updae;
            rex.wrbi(this.textBox2.Text);
        }

        private void toTextFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rex.data = this.updae;
            rex.wrtxt(this.textBox2.Text);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ops = new OpenFileDialog();
            ops.InitialDirectory = Environment.CurrentDirectory;
            if (ops.ShowDialog() == DialogResult.OK)
            {
                this.updae = rex.rebi(ops.FileName);
            }
            totre();
        }
        private void cols()
        {
            Color u = this.menuStrip1.BackColor;
            Color z = this.label2.ForeColor;
            foreach (Control x in this.Controls)
            {
                x.BackColor = u;
                x.ForeColor = z;
                foreach (Control x2 in x.Controls)
                {
                    x2.BackColor = u;
                    x2.ForeColor = z;
                    foreach (Control x3 in x2.Controls)
                    {
                        x3.BackColor = u;
                        x3.ForeColor = z;
                        foreach (Control x4 in x3.Controls)
                        {
                            x4.BackColor = u;
                            x4.ForeColor = z;

                        }
                    }
                }
            }
            foreach (ToolStripMenuItem x in this.menuStrip1.Items)
            {
                x.BackColor = u;
                x.ForeColor = z;
                foreach (ToolStripMenuItem x2 in x.DropDownItems)
                {
                    x2.BackColor = u;
                    x2.ForeColor = z;
                    foreach (ToolStripMenuItem x3 in x2.DropDownItems)
                    {
                        x3.BackColor = u;
                        x3.ForeColor = z;
                    }
                }
            }
            this.BackColor = u;
            this.ForeColor = z;
        }

        private void infogen_Load(object sender, EventArgs e)
        {
            cols();
        }
        
    }
}
