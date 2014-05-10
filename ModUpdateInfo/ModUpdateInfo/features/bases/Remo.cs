// =====================================
// |        0AD Modding Toolkit        |
// =====================================
// |           Version 0.0.0.1         |
// =====================================
using System;
using System.Collections.Generic;
using System.Linq;
namespace ModUpdateInfo.features.bases
{
    public class Remo
    {
        public Dictionary<int, string> upda = new Dictionary<int, string>();
        public Remo()
        {
        }
        public List<string> ToStringx()
        {
            List<string> um = new List<string>();
            foreach (int x in upda.Keys)
            {
                string u = upda[x];
                um.Add(u);
            }
            return um;

        }
    }
}