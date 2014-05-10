// =====================================
// |        0AD Modding Toolkit        |
// =====================================
// |           Version 0.0.0.1         |
// =====================================
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ModToolsdll.Json.Civjson.bas;
using ModToolsdll.Json.Civjson.bons.civ;
using ModToolsdll.Json.Civjson.bons.team;
using ModToolsdll.Json.Civjson.forms;
using ModToolsdll.Json.Civjson.hero;
using ModToolsdll.Json.Civjson.music;
using ModToolsdll.Json.Civjson.strc;
using ModToolsdll.Json.Civjson.tech;
using ModToolsdll.logi;
namespace ModToolsdll.Json.Civjson
{
    public class civs
    {
        #region civ info
        private readonly string la = mu.Default.du;
        public civba Civ = new civba();
        public List<mus> son = new List<mus>();
        public List<techs> teca = new List<techs>();
        public List<civher> heros = new List<civher>();
        public List<civbo> bon = new List<civbo>();
        public List<civtebon> tebon = new List<civtebon>();
        public List<civforma> forma = new List<civforma>();
        public List<ciaina> names = new List<ciaina>();
        public List<civbul> bul = new List<civbul>();
        public List<ststrc> enti = new List<ststrc>();
        #endregion
        #region class
        public civs()
        {
        }
        #endregion
        #region to text info
        #region values
        public List<string> full = new List<string>();
        #endregion
        #region logic write text
        /// <summary>
        /// Returns the formated string ready to be wrote
        /// </summary>
        /// <returns>Formatted string</returns>
        public string[] Retciv()
        {
            #region 1
            this.full.Add("{");
            //TODO: add exquivalent to a tab
            this.full.Add(this.formatu(this.Civ.Co, "Code", 1));
            this.full.Add(this.formatu(this.Civ.Cu, "Culture", 1));
            this.full.Add(this.formatu(this.Civ.Na, "Name", 1));
            this.full.Add(this.formatu(this.Civ.Em, "Emblem", 1));
            this.full.Add(this.formatu(this.Civ.Hi, "History", 1));
            this.full.Add(string.Format("\t{0}Music{1}:[", this.la, this.la));
            int a = 0;
            #endregion
            #region music add
            foreach (mus x in this.son)
            {
                if (a != this.son.Count)
                {
                    this.full.Add(string.Format("{0},", this.formu(this.la, x.So, x.Ty, 3)));
                }
                else
                {
                    this.full.Add(this.formu(this.la, x.So, x.Ty, 3));
                }
                a++;
            }
            #endregion
            #region 2
            this.full.Add("\t\t],");
            this.full.Add(string.Format("\t{0}Factions{1}:", this.la, this.la));
            this.full.Add("\t[");
            this.full.Add("\t{");
            this.full.Add(this.formatu(this.Civ.Na, "Name", 3));
            this.full.Add(this.formatu(this.Civ.Di, "Discription", 3));
            this.full.Add(string.Format("\t\t\t{0}Technologies{1}:", this.la, this.la));
            this.full.Add("\t\t\t[");
            a = 0;
            #endregion
            #region techs
            foreach (techs x in this.teca)
            {
                if (a != this.teca.Count)
                {
                    this.full.Add("\t\t\t\t{");
                    this.full.Add(this.formatu(x.na, "Name", 5));
                    this.full.Add(this.formatu(x.hi, "History", 5));
                    this.full.Add(this.formatu(x.di, "Discription", 5));
                    this.full.Add("},");
                }
                else
                {
                    this.full.Add("\t\t\t\t{");
                    this.full.Add(this.formatu(x.na, "Name", 5));
                    this.full.Add(this.formatu(x.hi, "History", 5));
                    this.full.Add(this.formatu(x.di, "Discription", 5));
                    this.full.Add("\t\t\t\t}");
                }
                a++;
            }
            #endregion
            #region 3
            this.full.Add("\t\t\t],");
            this.full.Add(string.Format("\t\t\t{0}Heroes{1}:", this.la, this.la));
            this.full.Add("\t\t\t[");
            a = 0;
            #endregion
            #region heros
            foreach (civher x in this.heros)
            {
                if (a != this.heros.Count)
                {
                    this.full.Add("\t\t\t\t{");
                    this.full.Add(this.formatu(x.na, "Name", 5));
                    this.full.Add(this.formatu(x.cl, "Class", 5));
                    this.full.Add(this.formatu(x.ar, "Armament", 5));
                    this.full.Add(this.formatu(x.em, "Emblem", 5));
                    this.full.Add(this.formatu(x.hi, "History", 5));
                    this.full.Add("\t\t\t\t},");
                }
                else
                {
                    this.full.Add("\t\t\t\t{");
                    this.full.Add(this.formatu(x.na, "Name", 5));
                    this.full.Add(this.formatu(x.cl, "Class", 5));
                    this.full.Add(this.formatu(x.ar, "Armament", 5));
                    this.full.Add(this.formatu(x.em, "Emblem", 5));
                    this.full.Add(this.formatu(x.hi, "History", 5));
                    this.full.Add("\t\t\t\t}");
                }
                a++;
            }
            this.full.Add("\t\t\t]");
            this.full.Add("\t\t}");
            this.full.Add("\t],");
            #endregion
            #region civ bonuses
            this.full.Add("\"CivBonuses\":");
            this.full.Add("\t[");
            a = 0;
            foreach (civbo x in this.bon)
            {
                if (a != this.bon.Count)
                {
                    this.full.Add("\t\t{");
                    this.full.Add(this.formatu(x.na, "Name", 3));
                    this.full.Add(this.formatu(x.hi, "History", 3));
                    this.full.Add(this.formatu(x.di, "Discription", 3));
                    this.full.Add("\t\t},");
                }
                else
                {
                    this.full.Add("\t\t{");
                    this.full.Add(this.formatu(x.na, "Name", 3));
                    this.full.Add(this.formatu(x.hi, "History", 3));
                    this.full.Add(this.formatu(x.di, "Discription", 3));
                    this.full.Add("\t\t}");
                }
                a++;
            }
            this.full.Add("\t],");
            #endregion
            #region team bonus
            this.full.Add("\"TeamBonuses\":");
            this.full.Add("\t[");
            a = 0;
            foreach (civtebon x in this.tebon)
            {
                if (a != this.tebon.Count)
                {
                    this.full.Add("\t\t{");
                    this.full.Add(this.formatu(x.na, "Name", 3));
                    this.full.Add(this.formatu(x.hi, "History", 3));
                    this.full.Add(this.formatu(x.di, "Discription", 3));
                    this.full.Add("\t\t},");
                }
                else
                {
                    this.full.Add("\t\t{");
                    this.full.Add(this.formatu(x.na, "Name", 3));
                    this.full.Add(this.formatu(x.hi, "History", 3));
                    this.full.Add(this.formatu(x.di, "Discription", 3));
                    this.full.Add("\t\t}");
                }
                a++;
            }
            this.full.Add("\t],");
            #endregion
            #region Structures
            this.full.Add("\"Structures\":");
            this.full.Add("\t[");
            a = 0;
            foreach (civbul x in this.bul)
            {
                if (a != this.bul.Count)
                {
                    this.full.Add("\t\t{");
                    this.full.Add(this.formatu(x.na, "Name", 3));
                    this.full.Add(this.formatu(x.cl, "Class", 3));
                    this.full.Add(this.formatu(x.em, "Emblem", 3));
                    this.full.Add(this.formatu(x.hi, "History", 3));
                    this.full.Add(this.formatu(x.re, "Requirements", 3));
                    this.full.Add(this.formatu(x.ph, "Phase", 3));
                    this.full.Add(this.formatu(x.sp, "Special", 3));
                    this.full.Add("\t\t},");
                }
                else
                {
                    this.full.Add("\t\t{");
                    this.full.Add(this.formatu(x.na, "Name", 3));
                    this.full.Add(this.formatu(x.cl, "Class", 3));
                    this.full.Add(this.formatu(x.em, "Emblem", 3));
                    this.full.Add(this.formatu(x.hi, "History", 3));
                    this.full.Add(this.formatu(x.re, "Requirements", 3));
                    this.full.Add(this.formatu(x.ph, "Phase", 3));
                    this.full.Add(this.formatu(x.sp, "Special", 3));
                    this.full.Add("\t\t}");
                }
                a++;
            }
            this.full.Add("\t],");
            #endregion
            #region starting entities
            this.full.Add("\"StartEntities\":");
            this.full.Add("\t[");
            a = 0;
            foreach (ststrc x in this.enti)
            {
                if (a != this.enti.Count)
                {
                    if (x.cou == 1)
                    {
                        this.full.Add("\t\t{");
                        this.full.Add(this.formatu(x.tem, "Template", 3));
                        this.full.Add("\t\t},");
                    }
                    else
                    {
                        this.full.Add("\t\t{");
                        this.full.Add(this.formatu(x.tem, "Template", 3));
                        this.full.Add(string.Format("\t\t\t\"Count\": {0}", x.cou.ToString()));
                        this.full.Add("\t\t},");
                    }
                }
                else
                {
                    if (x.cou == 1)
                    {
                        this.full.Add("\t\t{");
                        this.full.Add(this.formatu(x.tem, "Template", 3));
                        this.full.Add("\t\t}");
                    }
                    else
                    {
                        this.full.Add("\t\t{");
                        this.full.Add(this.formatu(x.tem, "Template", 3));
                        this.full.Add(string.Format("\t\t\t\"Count\": {0}", x.cou.ToString()));
                        this.full.Add("\t\t}");
                    }
                }
                a++;
            }
            this.full.Add("\t],");
            #endregion
            #region formations
            this.full.Add("\"Formations\":");
            this.full.Add("\t[");
            a = 0;
            foreach (civforma x in this.forma)
            {
                this.full.Add(string.Format("\t\t\"{0}\"", x.nam));
            }
            this.full.Add("\t],");
            #endregion
            #region ai names
            this.full.Add("\"AINames\":");
            this.full.Add("\t[");
            
            foreach (ciaina x in this.names)
            {
                this.full.Add(string.Format("\t\t\"{0}\"", x.name));
            }
            this.full.Add("\t],");
            #endregion
            #region leftover
            if (this.Civ.sel)
            {
                this.full.Add(string.Format("\t\"{0}\", true", "SelectableInGameSetup"));
                this.full.Add("}");
            }
            else
            {
                this.full.Add(string.Format("\"{0}\", false", "SelectableInGameSetup"));
                this.full.Add("}");
            }
            #endregion
            return this.full.ToArray();
        }
        #region format string
        /// <summary>
        /// This formats the string so it is produced with quotes around it
        /// </summary>
        /// <param name="a">the string at the end Ie: Egypt</param>
        /// <param name="b">the string that says what it is Ie: Name</param>
        /// <returns>a formated string </returns>
        public string formatu(string a, string b, int tabcu)
        {
            string temps = "";
            for (int x = 0; x > tabcu; x++)
            {
                temps = string.Format("{0}\t", temps);
            }
            return string.Format("{3}{0}{2}{0}:{0}{1}{0},", this.la, a, b, temps);
        }
        #endregion
        #region format song
        /// <summary>
        /// This producess the formated music tring
        /// <para>IE: {"File":"Forging_a_City-State.ogg", "Type":"peace"}</para>
        /// </summary>
        /// <param name="qu">The quotes</param>
        /// <param name="song">The sing Name</param>
        /// <param name="type">The song type</param>
        /// <returns>IE: {"File":"Forging_a_City-State.ogg", "Type":"peace"}</returns>
        public string formu(string qu, string song, string type, int tabs)
        {
            string temps = "";
            for (int x = 0; x > tabs; x++)
            {
                temps = string.Format("{0}\t", temps);
            }
            return string.Format("{3}{{0}File{0}:{0}{1}{0}, {0}Type{0}:{0}{2}{0}}", qu, song, type, temps);
        }
        #endregion
        #endregion
        #endregion
        #region to .civ
        #region read
        public void reCiv(string path)
        {
            using (var rea = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                #region civinfo
                this.Civ.Na = rea.ReadString();
                this.Civ.Co = rea.ReadString();
                this.Civ.Cu = rea.ReadString();
                this.Civ.Di = rea.ReadString();
                this.Civ.Em = rea.ReadString();
                this.Civ.Hi = rea.ReadString();
                this.Civ.sel = rea.ReadBoolean();
                #endregion
                #region Songs
                int a;
                a = rea.ReadInt32();
                for (int i = 0; i > a; i++)
                {
                    mus x = new mus();
                    x.So = rea.ReadString();
                    x.Ty = rea.ReadString();
                    this.son.Add(x);
                }
                #endregion
                #region tech
                a = rea.ReadInt32();
                for (int i = 0; i > a; i++)
                {
                    techs x = new techs();
                    x.na = rea.ReadString();
                    x.di = rea.ReadString();
                    x.hi = rea.ReadString();
                    this.teca.Add(x);
                }
                #endregion
                #region heros
                a = rea.ReadInt32();
                for (int i = 0; i > a; i++)
                {
                    civher x = new civher();
                    x.na = rea.ReadString();
                    x.ar = rea.ReadString();
                    x.hi = rea.ReadString();
                    x.cl = rea.ReadString();
                    x.em = rea.ReadString();
                    this.heros.Add(x);
                }
                #endregion
                #region civbonus
                a = rea.ReadInt32();
                for (int i = 0; i > a; i++)
                {
                    civbo x = new civbo();
                    x.na = rea.ReadString();
                    x.di = rea.ReadString();
                    x.hi = rea.ReadString();
                    this.bon.Add(x);
                }
                #endregion
                #region TeamBon
                for (int i = 0; i > a; i++)
                {
                    civtebon x = new civtebon();
                    x.na = rea.ReadString();
                    x.di = rea.ReadString();
                    x.hi = rea.ReadString();
                    this.tebon.Add(x);
                }
                #endregion
                #region structures
                for (int i = 0; i > a; i++)
                {
                    civbul x = new civbul();
                    x.na = rea.ReadString();
                    x.cl = rea.ReadString();
                    x.hi = rea.ReadString();
                    x.em = rea.ReadString();
                    x.ph = rea.ReadString();
                    x.re = rea.ReadString();
                    x.sp = rea.ReadString();
                    this.bul.Add(x);
                }
                #endregion
                #region entities
                for (int i = 0; i > a; i++)
                {
                    ststrc x = new ststrc();
                    x.tem = rea.ReadString();
                    x.cou = rea.ReadInt32();
                    this.enti.Add(x);
                }
                #endregion
                #region formations
                for (int i = 0; i > a; i++)
                {
                    civforma x = new civforma();
                    x.nam = rea.ReadString();
                    this.forma.Add(x);
                }
                #endregion
                #region ainames
                for (int i = 0; i > a; i++)
                {
                    ciaina x = new ciaina();
                    x.name = rea.ReadString();
                    this.names.Add(x);
                }
                #endregion
            }
        }
        #endregion
        #region Write
        public void wrCiv(string path)
        {
            #region lock
            fiPro n = new fiPro();
            string p2 = string.Format("{0}{1}.Civ", @"\civs\", this.Civ.Co);
            if (File.Exists(string.Format("{0}{1}", path, p2)))
            {
                n.UnFi(string.Format("{0}{1}", path, p2));
            }
            #endregion
            using (var wri = new BinaryWriter(File.Open(string.Format("{0}{1}", path, p2), FileMode.Create)))
            {
                #region Civba
                wri.Write(this.Civ.Na);
                wri.Write(this.Civ.Co);
                wri.Write(this.Civ.Cu);
                wri.Write(this.Civ.Di);
                wri.Write(this.Civ.Em);
                wri.Write(this.Civ.Hi);
                wri.Write(this.Civ.sel);
                #endregion
                #region songs
                wri.Write(this.son.Count);
                foreach (mus x in this.son)
                {
                    wri.Write(x.So);
                    wri.Write(x.Ty);
                }
                #endregion
                #region techs
                wri.Write(this.teca.Count);
                foreach (techs x in this.teca)
                {
                    wri.Write(x.na);
                    wri.Write(x.di);
                    wri.Write(x.hi);
                }
                #endregion
                #region heros
                wri.Write(this.heros.Count);
                foreach (civher x in this.heros)
                {
                    wri.Write(x.na);
                    wri.Write(x.ar);
                    wri.Write(x.hi);
                    wri.Write(x.cl);
                    wri.Write(x.em);
                }
                #endregion
                #region civ bonuses
                wri.Write(this.bon.Count);
                foreach (civbo x in this.bon)
                {
                    wri.Write(x.na);
                    wri.Write(x.di);
                    wri.Write(x.hi);
                }
                #endregion
                #region team bonuses
                wri.Write(this.tebon.Count);
                foreach (civtebon x in this.tebon)
                {
                    wri.Write(x.na);
                    wri.Write(x.di);
                    wri.Write(x.hi);
                }
                #endregion
                #region structures
                wri.Write(this.bul.Count);
                foreach (civbul x in this.bul)
                {
                    wri.Write(x.na);
                    wri.Write(x.cl);
                    wri.Write(x.hi);
                    wri.Write(x.em);
                    wri.Write(x.ph);
                    wri.Write(x.re);
                    wri.Write(x.sp);
                }
                #endregion
                #region entities
                wri.Write(this.enti.Count);
                foreach (ststrc x in this.enti)
                {
                    wri.Write(x.tem);
                    wri.Write(x.cou);
                }
                #endregion
                #region formations
                wri.Write(this.forma.Count);
                foreach (civforma x in this.forma)
                {
                    wri.Write(x.nam);
                }
                #endregion
                #region ainames
                wri.Write(this.names.Count);
                foreach (ciaina x in this.names)
                {
                    wri.Write(x.name);
                }
                #endregion
            }
            #region lock file
            n.LoFi(string.Format("{0}{1}", path, p2));
            #endregion
        }
        #endregion
        #endregion
    }
}