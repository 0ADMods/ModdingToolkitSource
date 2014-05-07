// =====================================
// |        0AD Modding Toolkit        |
// =====================================
// |           Version 0.0.0.1         |
// =====================================
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ModToolsdll.ModFiles.Base
{
    public class modbase
    {
        public List<Di_> Di = new List<Di_>();
        public string ModFile;
        public modbase()
        {
        }
        public void Fi_files(string dire)
        {
            Di_ p = new Di_();
            string[] tem = Directory.GetDirectories(dire, "*", SearchOption.AllDirectories);
            foreach (string s in tem)
            {
                string[] te2 = Directory.GetFiles(s);
                Files x = new Files();
                string z = Path.GetFileNameWithoutExtension(s);
                p.di_base = z;
                p.dis = Path.GetFileNameWithoutExtension(Path.GetDirectoryName(s));
                
                foreach (string ss in te2)
                {
                    x.fi_na = Path.GetFileName(ss);
                    x.disc = "";
                    p.Di_Files.Add(x);
                    x = new Files();
                }
                this.Di.Add(p);
                p = new Di_();
            }
        }
    }
}