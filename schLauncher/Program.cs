using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xml = System.Xml.Linq;

namespace schLauncher
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Config config = new Config();
            if (args.Length == 0)
            {
                config.ShowDialog();
            }
            else
            {
                bool isEagle = false;
                try
                {
                    Xml.XDocument xDocument = Xml.XDocument.Load(args[0]);
                    Xml.XElement xEagle = xDocument.Element("eagle");
                    if(xEagle.Name == "eagle")
                    {
                        isEagle = true;
                    }
                }
                catch { }

                if (isEagle)
                {
                    //System.Windows.Forms.MessageBox.Show("Eagle" + config.EagleFilePath + "\n" + "\"" + args[0] + "\"");
                    System.Diagnostics.Process.Start(config.EagleFilePath, "\"" + args[0] + "\"");
                }
                else
                {
                    //System.Windows.Forms.MessageBox.Show("KiCad" + config.KiCadFilePath + "\n" + "\"" + args[0] + "\"");
                    System.Diagnostics.Process.Start(config.KiCadFilePath, "\"" + args[0] + "\"");
                }
            }
        }
    }
}
