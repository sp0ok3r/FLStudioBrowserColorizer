using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace FLStudioBrowserColorizer
{


    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        OpenFileDialog folderBrowser = new OpenFileDialog();

        public Form1()
        {
            InitializeComponent();
            components.SetStyle(this);
        }
        private static String HexConverterFL(Color c)
        {
            return c.B.ToString("X2") + c.G.ToString("X2") + c.R.ToString("X2");
        }

        private void NFOCreator(string path, string color)
        {
            if (File.Exists(path + ".nfo"))
            {
                File.SetAttributes(path + ".nfo", FileAttributes.Normal);
            }
            File.WriteAllText(path + ".nfo", "Color=$" + color);
            File.SetAttributes(path + ".nfo", FileAttributes.Hidden);
        }

        private void btn_OneFolder_Click(object sender, EventArgs e)
        {
            FolderColor(false);
        }
        private void btn_allfolders_Click(object sender, EventArgs e)
        {
            FolderColor(true);
        }

        private void FolderColor(bool x)
        {
            //folderBrowser.InitialDirectory = "c:\\";
            folderBrowser.ValidateNames = false;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;
            folderBrowser.FileName = "Folder Selection.";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                string path = Path.GetDirectoryName(folderBrowser.FileName);
                string[] subdirs = Directory.GetDirectories(path);


                ColorDialog clrDialog = new ColorDialog();
                clrDialog.FullOpen = true;
                string FinalColor = "";
                Color a = Color.White;
                if (txtbox_hexcode.Text.Length > 0)
                {
                    FinalColor = txtbox_hexcode.Text;
                }
                else
                {
                    if (clrDialog.ShowDialog() == DialogResult.OK)
                    {
                        a = clrDialog.Color;
                    }
                }


                string ColorHex = HexConverterFL(a);

                if (chc_firstfoldercolor.Checked)
                {
                    string pathlast = Path.GetFileName(Path.GetDirectoryName(path));
                    using (TextWriter tw = new StreamWriter(pathlast + ".nfo"))
                    {
                        NFOCreator(path, ColorHex);
                    }
                }

                if (x == true)
                {
                    foreach (string subf in subdirs)
                    {
                        NFOCreator(subf, ColorHex);
                    }
                }
                else
                {

                    Console.WriteLine(path);
                    NFOCreator(path, ColorHex);

                }


                Console.WriteLine("okok");
            }
            lbl_setcolormanual.Focus();
        }



        private void btn_randomColorsfolders_Click(object sender, EventArgs e)
        {
            folderBrowser.ValidateNames = false;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;
            folderBrowser.FileName = "Folder Selection.";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                string path = Path.GetDirectoryName(folderBrowser.FileName);
                string[] subdirs = Directory.GetDirectories(path);


                Random r = new Random();

                Color[] NiceColors = new Color[] { Color.Red, Color.Yellow, Color.Purple, Color.Green, Color.Brown, Color.Pink, Color.Orange, Color.Cyan, Color.Magenta, Color.Lime, Color.White };

                foreach (string d in subdirs)
                {
                    string ch = HexConverterFL(NiceColors[r.Next(11)]);
                    NFOCreator(d, ch);
                }
            }
            Console.WriteLine("okRandomColorsFolders");
            lbl_setcolormanual.Focus();
        }

        private void link_spk_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/sp0ok3r");
            Process.Start("https://linktr.ee/sp0ok3r");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}