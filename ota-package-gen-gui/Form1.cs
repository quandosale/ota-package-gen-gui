using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace ota_package_gen_gui
{
    public partial class Form1 : Form
    {
        String filepath = "dist\\__main__.exe";
        String param_keyfile = "keys generate temp.pem";
        String firmware_filename = "";
        String param_package = "pkg generate --hw-version 52 --sd-req 0x98,0xCAFE --application-version 1 ";

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_keyfile_Click(object sender, EventArgs e)
        {
        }

        private void btn_package_Click(object sender, EventArgs e)
        {
            String firmware = firmware_url.Text;

            if(firmware == "")
            {
                MessageBox.Show("Please specify firmware", "Package Generation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            String zipfile = "temp.zip";
            String param = param_package + "--application \"" + firmware + "\" --key-file dist\\temp.pem " + zipfile;

            Process P = Process.Start(filepath, param);
            P.WaitForExit();
            int result = P.ExitCode;
            if(result == 0)
            {
                String dest = "dist\\temp.zip";

                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.Filter = "zip files (*.zip)|*.zip|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.RestoreDirectory = true;
                saveFileDialog1.FileName = firmware_filename.Substring(0, firmware_filename.Length - 4);

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    dest = saveFileDialog1.FileName;
                    if (File.Exists(dest))
                    {
                        File.Delete(dest);
                    }
                    File.Move("temp.zip", dest);
                    MessageBox.Show("DFU package has been generated successfully", "Package Generation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } else
            {
                MessageBox.Show("Error occured while generating DFU package. Please make sure firmware is correct.", "Package Generation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_keyfile_browse_Click(object sender, EventArgs e)
        {

        }

        private void btn_firmware_browse_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "firmware files (*.hex)|*.hex|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                firmware_url.Text = openFileDialog1.FileName;
                firmware_filename = openFileDialog1.SafeFileName;
            }
        }
    }
}
