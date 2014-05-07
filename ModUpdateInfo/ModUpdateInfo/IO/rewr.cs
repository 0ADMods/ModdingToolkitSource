using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ModUpdateInfo.features;
using ModUpdateInfo.features.bases;
using System.IO;
namespace ModUpdateInfo.IO
{
    public class rewr
    {
        public Dictionary<string, Upda> data = new Dictionary<string, Upda>();

        public rewr()
        {
        }
        public void wrtxt(string mn)
        {
            List<string> x = new List<string>();
            x.Add("Mod Update info");
            x.Add(mn + " Updates");
            foreach (string ups in data.Keys)
            {
                Upda umx = data[ups];
                x.Add("\t" + ups);
                x.Add("\t Added Files");
                foreach (int xs in umx.n.upda.Keys)
                {
                    x.Add(umx.n.upda[xs]);
                }
                x.Add("\t Modified Files");
                foreach (int xs in umx.p.upda.Keys)
                {
                    x.Add(umx.p.upda[xs]);
                }
                x.Add("\t Removed Files");
                foreach (int xs in umx.m.upda.Keys)
                {
                    x.Add(umx.m.upda[xs]);
                }
                x.Add("\t Balanced Files");
                foreach (int xs in umx.o.upda.Keys)
                {
                    x.Add(umx.o.upda[xs]);
                }
            }
            Directory.CreateDirectory(Environment.CurrentDirectory+@"\Files\");
            File.WriteAllLines(Environment.CurrentDirectory+@"\Files\"+mn+".txt",x.ToArray());
        }
        public void wrbi(string mn)
        {
            Directory.CreateDirectory(Environment.CurrentDirectory + @"\Files\");
            using (var bi = new BinaryWriter(File.Open(Environment.CurrentDirectory + @"\Files\" + mn + ".Upd",FileMode.Create)))
            {
                bi.Write(data.Keys.Count);
                foreach (string ups in data.Keys)
            {
                Upda umx = data[ups];
                bi.Write(umx.version);
                bi.Write(umx.n.upda.Keys.Count);
                foreach (int xs in umx.n.upda.Keys)
                {
                    bi.Write(umx.n.upda[xs]);
                }
                bi.Write(umx.p.upda.Keys.Count);
                foreach (int xs in umx.p.upda.Keys)
                {
                    bi.Write(umx.p.upda[xs]);
                }
                bi.Write(umx.m.upda.Keys.Count);
                foreach (int xs in umx.m.upda.Keys)
                {
                    bi.Write(umx.m.upda[xs]);
                }
                bi.Write(umx.o.upda.Keys.Count);
                foreach (int xs in umx.o.upda.Keys)
                {
                    bi.Write(umx.o.upda[xs]);
                }
            }
            }
        }
        public Dictionary<string, Upda> rebi(string path)
        {
            Dictionary<string, Upda> meme = new Dictionary<string, Upda>();
            using (var bi = new BinaryReader(File.Open(path, FileMode.Open)))
            {

                    int x = bi.ReadInt32();
                    for (int i = 0; i < x; i++)
                    {

                        Upda xz = new Upda();
                        xz.version = bi.ReadString();
                        x = bi.ReadInt32();
                        for (int i2= 0; i2 < x; i2++)
                        {
                            xz.n.upda.Add(i2 + 1, bi.ReadString().TrimStart("-".ToCharArray()));
                        }
                        x = bi.ReadInt32();
                        for (int i2 = 0; i2 < x; i2++)
                        {
                            xz.p.upda.Add(i2+1, bi.ReadString().TrimStart("-".ToCharArray()));
                        }
                        x = bi.ReadInt32();
                        for (int i2 = 0; i2 < x; i2++)
                        {
                            xz.m.upda.Add(i2 + 1, bi.ReadString().TrimStart("-".ToCharArray()));
                        }
                        x = bi.ReadInt32();
                        for (int i2 = 0; i2 < x; i2++)
                        {
                            xz.o.upda.Add(i2 + 1, bi.ReadString().TrimStart("-".ToCharArray()));
                        }
                        meme.Add(xz.version,xz);
                    }
                    return meme;
                
            }
        }
    }
}
