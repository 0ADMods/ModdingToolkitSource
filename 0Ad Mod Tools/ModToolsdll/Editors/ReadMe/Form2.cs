// =====================================
// |        0AD Modding Toolkit        |
// =====================================
// |           Version 0.0.0.1         |
// =====================================
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
namespace _0ad_Mod_ReadMe
{
    public partial class Form2 : Form
    {
        public string[] readme;
        public Form2()
        {
            this.InitializeComponent();
        }
        public void sere()
        {
            List<string> temp = new List<string>();
            string m = "===============================================================";
            temp.Add("Mod Name: ");
            temp.Add(this.toolStripTextBox1.Text);
            temp.Add(m);
            temp.Add("Mod Version: ");
            temp.Add(this.toolStripTextBox2.Text);
            temp.Add(m);
            temp.Add("0Ad Build Required:");
            temp.Add(this.toolStripTextBox3.Text);
            temp.Add(m);
            temp.Add("Update Date: ");
            temp.Add(this.toolStripTextBox4.Text);
            temp.Add(m);
            temp.Add("Mod Team Name: ");
            temp.Add(this.toolStripTextBox5.Text);
            temp.Add(m);
            temp.Add("Mod Leader: ");
            temp.Add(this.toolStripTextBox6.Text);
            temp.Add(m);
            temp.Add("Status: ");
            temp.Add(this.toolStripTextBox7.Text);
            temp.Add(m);
            temp.Add("Mod Infomation And Background: ");
            temp.Add(this.richTextBox1.Text);
            temp.Add(m);
            temp.Add("Required Mods: ");
            temp.Add(this.richTextBox2.Text);
            temp.Add(m);
            temp.Add("Messanger/Forum Contact Info: ");
            temp.Add(this.richTextBox3.Text);
            temp.Add(m);
            temp.Add("Email Contact Info: ");
            temp.Add(this.richTextBox4.Text);
            temp.Add(m);
            temp.Add("Change Log: ");
            temp.Add(this.richTextBox5.Text);
            temp.Add(m);
            temp.Add("Mod Team Info: ");
            temp.Add(this.richTextBox6.Text);
            temp.Add(m);
            temp.Add("Mod Insperation: ");
            temp.Add(this.richTextBox7.Text);
            temp.Add(m);
            temp.Add("Side Notes And Recruitment: ");
            temp.Add(this.richTextBox8.Text);
            temp.Add(m);
            temp.Add("Credits: ");
            temp.Add("Mod Team Members: ");
            temp.Add(this.richTextBox9.Text);
            temp.Add(m);
            temp.Add("Individual Modders: ");
            temp.Add(this.richTextBox10.Text);
            temp.Add(m);
            temp.Add("Additional Info: ");
            temp.Add(this.richTextBox11.Text);
            temp.Add(m);
            temp.Add("Next Update will Feature: ");
            temp.Add(this.richTextBox12.Text);
            temp.Add(m);
            temp.Add("Install Instructions: ");
            temp.Add(this.richTextBox13.Text);
            temp.Add(m);
            temp.Add("How to Uninstall: ");
            temp.Add(this.richTextBox14.Text);
            temp.Add(m);
            this.readme = temp.ToArray();
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.sere();
            Directory.CreateDirectory(string.Format("{0}{1}{2}{3}", Application.StartupPath, @"\", this.toolStripTextBox1.Text, @"\"));
            File.WriteAllLines(string.Format("{0}{1}{2}{3}{4}.txt", Application.StartupPath, @"\", this.toolStripTextBox1.Text, @"\", this.toolStripTextBox1.Text), this.readme);
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string up = string.Format("{0}{1}", DateTime.Today.Month.ToString(), @"-");
            up = string.Format("{0}{1}{2}{3}", up, DateTime.Today.Day.ToString(), @"-", DateTime.Today.Year.ToString());
            this.toolStripTextBox4.Text = up;
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }
    }
}