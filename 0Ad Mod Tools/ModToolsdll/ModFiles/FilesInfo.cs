// =====================================
// |        0AD Modding Toolkit        |
// =====================================
// |           Version 0.0.0.1         |
// =====================================
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ModToolsdll.ModFiles.Base;
namespace ModToolsdll.ModFiles
{
    public class FilesInfo
    {
        #region infos
        public modbase Bases = new modbase();
        public List<Files> fi = new List<Files>();
        public List<Di_> Di = new List<Di_>();
        #endregion
        public FilesInfo()
        {
        }
        public FilesInfo(string filedir)
        {
            string[] temp = Directory.GetDirectories(filedir);
            this.Bases.ModFile = Path.GetFileNameWithoutExtension(filedir);
            this.Bases.Fi_files(filedir);
        }
    }
}