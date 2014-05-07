// =====================================
// |        0AD Modding Toolkit        |
// =====================================
// |           Version 0.0.0.1         |
// =====================================
using System;
using System.IO;
using System.Linq;
namespace ModToolsdll.logi
{
    public class fiPro
    {
        public void LoFi(string file)
        {
            File.SetAttributes(file, FileAttributes.ReadOnly);
        }
        public void UnFi(string file)
        {
            File.SetAttributes(file, FileAttributes.Normal);
        }
    }
}