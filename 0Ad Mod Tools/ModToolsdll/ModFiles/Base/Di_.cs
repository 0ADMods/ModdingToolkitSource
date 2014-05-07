// =====================================
// |        0AD Modding Toolkit        |
// =====================================
// |           Version 0.0.0.1         |
// =====================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace ModToolsdll.ModFiles.Base
{
    public class Di_
    {
        public string dis;
        public string di_base;
        public List<Files> Di_Files = new List<Files>();
        public Di_()
        {
        }
        public List<TreeNode> gen1()
        {
            TreeNode u;
            List<TreeNode> m = new List<TreeNode>();
            foreach (Files x in this.Di_Files)
            {
                u = new TreeNode(x.fi_na);
                m.Add(u);
            }
            //u = new TreeNode(di_base, m.ToArray());
            //u.Name = dis;
            return m;
        }
    }
}