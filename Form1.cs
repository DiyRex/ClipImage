using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using IniParser;
using IniParser.Model;

namespace ClipImage
{
    public partial class Form1 : Form
    {

        string saveDirectory = "";
        string iniFilePath = "config.ini";
        string fileType = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                { 
                    saveDirectory = fbd.SelectedPath;
                    txtPath.Text = saveDirectory;
                    if (fileType == "PNG")
                    { 
                        updateini(iniFilePath,true,false,saveDirectory);
                    }
                    else
                    {
                        updateini(iniFilePath, false, true, saveDirectory);
                    }




                }
            }
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            if (Clipboard.ContainsImage())
            {
                Image image = Clipboard.GetImage();

                if (image != null)
                {
                    // Ensure the directory exists.
                    if (!System.IO.Directory.Exists(saveDirectory))
                    {
                        System.IO.Directory.CreateDirectory(saveDirectory);
                    }

                    // Construct the file path with a unique name (e.g., using a timestamp).
                    

                    if (rbTypePNG.Checked)
                    {
                        string fileName = $"CI-{DateTime.Now:yyyyMMddHHmmssfff}.png";
                        string filePath = System.IO.Path.Combine(saveDirectory, fileName);
                        image.Save(filePath, ImageFormat.Png);
                    }else if (rbTypeJPG.Checked)
                    {
                        string fileName = $"CI-{DateTime.Now:yyyyMMddHHmmssfff}.jpg";
                        string filePath = System.IO.Path.Combine(saveDirectory, fileName);
                        image.Save(filePath, ImageFormat.Jpeg);
                    }
                    txtStatus.Text = "Image saved";
                    txtStatus.ForeColor = Color.ForestGreen;
                }
                else
                {
                    txtStatus.Text = "Failed to Save";
                    txtStatus.ForeColor = Color.Crimson;
                }
            }
            else
            {
                txtStatus.Text = "Clipboard is Empty";
                txtStatus.ForeColor = Color.Crimson;
            }

        }

        static void updateini(string filePath, bool rb1, bool rb2, string newPath)
        {
            var parser = new FileIniDataParser();
            IniData data = new IniData();

            data.Sections.AddSection("Settings");
            data["Settings"]["Path"] = newPath;
            data["Settings"]["PNG"] = rb1.ToString();
            data["Settings"]["JPG"] = rb2.ToString();

            parser.WriteFile(filePath, data);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile("config.ini");

            saveDirectory = data["Settings"]["Path"].ToString();
            txtPath.Text = saveDirectory;
            rbTypePNG.Checked = bool.Parse(data["Settings"]["PNG"]);
            rbTypeJPG.Checked = bool.Parse(data["Settings"]["JPG"]);
            if (bool.Parse(data["Settings"]["PNG"]))
            {
                rbTypePNG.Checked = true;
                fileType = "PNG";
            }
            else
            {
                rbTypeJPG.Checked = true;
                fileType = "JPG";
            }
        }

        private void rbTypePNG_CheckedChanged(object sender, EventArgs e)
        {
            updateini(iniFilePath, rbTypePNG.Checked, rbTypeJPG.Checked, saveDirectory);
        }

        private void rbTypeJPG_CheckedChanged(object sender, EventArgs e)
        {
            updateini(iniFilePath, rbTypePNG.Checked, rbTypeJPG.Checked, saveDirectory);
        }
    }
}
