// =====================================
// |        0AD Modding Toolkit        |
// =====================================
// |           Version 0.0.0.1         |
// =====================================
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using ModToolsdll.Editors;
using ModToolsdll.ModFiles;
using ModToolsdll.ModFiles.Base;
namespace Mod_File_List_Tool
{
    public partial class Form1 : Form
    {
        private FilesInfo x = new FilesInfo();
        public Form1()
        {
            this.InitializeComponent();
        }
        public void fi1()
        {
            List<string> o = new List<string>();
            foreach (Di_ ud in this.x.Bases.Di)
            {
                o.Add(ud.di_base);
            }
            string[] um = o.ToArray();
            foreach (string us in um)
            {
                //this.listBox1.Items.Add(us);
            }
            this.fi2();
        }
        public void fi2()
        {
            foreach (Di_ xu in this.x.Bases.Di)
            {
                foreach (Files uus in xu.Di_Files)
                {
                    //this.listBox2.Items.Add(uus.fi_na);
                }
            }
        }
        public void write()
        {
            List<string> tem = new List<string>();
            List<string> o = new List<string>();
            tem.Add(this.x.Bases.ModFile);
            tem.Add("-------------------");
            tem.Add(string.Format("Directories{0}", ""));
            tem.Add("-------------------");
            foreach (Di_ ud in this.x.Bases.Di)
            {
                o.Add(ud.di_base);
            }
            string[] um = o.ToArray();
            foreach (string us in um)
            {
                tem.Add(us);
            }
            tem.Add("-------------------");
            tem.Add(string.Format("Files{0}", ""));
            tem.Add("-------------------");
            foreach (Di_ xu in this.x.Bases.Di)
            {
                foreach (Files uus in xu.Di_Files)
                {
                    tem.Add(string.Format("-{0}", uus.fi_na));
                    //tem.Add("-!Feature Not Yet Included!");
                }
            }
            Directory.CreateDirectory(string.Format("{0}{1}{2}", Application.StartupPath, @"\", @"Mods\"));
            File.WriteAllLines(string.Format("{0}{1}{2}{3}", Application.StartupPath, @"\Mods\", this.x.Bases.ModFile, @".txt"), tem.ToArray());
        }
        public void fill2()
        {
            this.treeView1.Nodes.Clear();
            List<TreeNode> p = new List<TreeNode>();
            TreeNode m = new TreeNode(this.x.Bases.ModFile);
            p.Add(m);
            foreach (Di_ us in this.x.Bases.Di)
            {
                m = new TreeNode(us.di_base);
                p.Add(m);
            }
            List<TreeNode> r = new List<TreeNode>();
            TreeNode lp = new TreeNode("Mod File Directories",p.ToArray());
            r.Add(lp);
            this.treeView1.Nodes.Add(lp);
            this.fill3();
        }
        public void fill3()
        {
            //treeView1.Nodes.Clear();
            List<TreeNode> p = new List<TreeNode>();
            foreach (Di_ us in this.x.Bases.Di)
            {
                foreach (Files up in us.Di_Files)
                {
                    TreeNode m = new TreeNode(up.fi_na);
                    
                    p.Add(m);
                }
            }
            List<TreeNode> r = new List<TreeNode>();
            TreeNode lp = new TreeNode("Mod Files", p.ToArray());
            r.Add(lp);
            this.treeView1.Nodes.Add(lp);
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog m = this.folderBrowserDialog1;
            if (m.ShowDialog() == DialogResult.OK)
            {
                this.x = new FilesInfo(m.SelectedPath);
                Thread.Sleep(400);
                this.Text = string.Format("Mod={0}", this.x.Bases.ModFile);
                this.fill2();
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.write();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abfo Thar = new Abfo("0AD Modding Toolkit", "ReadMe Gen", "2.0", "The Readme generator allows for the generation of Readme files spesific to 0AD");
            Thar.ShowDialog();
        }
    }
}