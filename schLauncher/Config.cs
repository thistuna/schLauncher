using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xml = System.Xml.Linq;

namespace schLauncher
{
    public partial class Config : Form
    {
        public string KiCadFilePath
        {
            get
            {
                return textBoxKiCad.Text;
            }
        }
        public string EagleFilePath
        {
            get
            {
                return textBoxEagle.Text;
            }
        }
        public Config()
        {
            InitializeComponent();

            try
            {
                string s = System.Reflection.Assembly.GetExecutingAssembly().Location;
                System.IO.FileInfo fileInfo = new System.IO.FileInfo(s);
                string startup_path = fileInfo.Directory.FullName;
                string settingsFile = System.IO.Path.Combine(startup_path, "settings.xml");
                Xml.XDocument xDocument = Xml.XDocument.Load(settingsFile);
                Xml.XElement setting = xDocument.Element("schLauncherSettings");
                textBoxKiCad.Text = setting.Element("KiCadPath").Value;
                textBoxEagle.Text = setting.Element("EaglePath").Value;
            }
            catch { }
        }

        private void Config_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonKiCad_Click(object sender, EventArgs e)
        {
            var openFileDialog = new System.Windows.Forms.OpenFileDialog();
            openFileDialog.Filter = "Kicad Eeschema Executable file (*.exe)|*.exe|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxKiCad.Text = openFileDialog.FileName;
            }
        }

        private void buttonEagle_Click(object sender, EventArgs e)
        {
            var openFileDialog = new System.Windows.Forms.OpenFileDialog();
            openFileDialog.Filter = "Eagle Executable file (*.exe)|*.exe|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxEagle.Text = openFileDialog.FileName;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Xml.XDocument xDocument = new Xml.XDocument(new Xml.XDeclaration("1.0", "utf-8", "Yes"));
            Xml.XElement xSettings = new Xml.XElement("schLauncherSettings");
            xSettings.Add(new Xml.XElement("KiCadPath", textBoxKiCad.Text));
            xSettings.Add(new Xml.XElement("EaglePath", textBoxEagle.Text));
            xDocument.Add(xSettings);
            xDocument.Save("settings.xml");
            this.Close();
        }
    }
}
