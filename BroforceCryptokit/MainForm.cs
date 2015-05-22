using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BroforceCryptokit
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            int decryptedDataSize = -1;
            byte[] decryptedData = null;

            string steamID = textBoxSteamID.Text;
            if(steamID.Length == 0)
            {
                steamID = "brololforce";
            }

            DialogResult openFileDialogResult = openFileDialog.ShowDialog();
            if (openFileDialogResult == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                try
                {
                    decryptedData = LoadFromFile(fileName, steamID, true);
                    decryptedDataSize = decryptedData.Length;
                }
                catch (System.NullReferenceException)
                {
                    return;
                }
            }

            if (decryptedDataSize > 0)
            {
                DialogResult saveFileDialogResult = saveFileDialog.ShowDialog();
                if (saveFileDialogResult == DialogResult.OK)
                {
                    string saveFileName = saveFileDialog.FileName;
                    try
                    {
                        SaveToFile(saveFileName, decryptedData, steamID, false);
                    }
                    catch (System.NullReferenceException)
                    {
                        return;
                    }
                }
            }
        }


        public static byte[] LoadFromFile(string path, string steamID, bool encrypted)
        {
            byte[] data = null;

            if (!File.Exists(path))
            {
                return null;
            }

            FileStream input = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(input);
            long length = new FileInfo(path).Length;

            if (encrypted)
            {
                string s = Convert.ToBase64String(reader.ReadBytes((int)length));
                byte[] blob = Convert.FromBase64String(s);
                data = Encryption.DecryptBlob(blob, steamID);
            }
            else
            {
                data = reader.ReadBytes((int)length);
            }
            reader.Close();
            input.Close();

            return data;
        }

        public void SaveToFile(string path, byte[] data, string steamID, bool encrypted)
        {
            FileStream writer = new FileStream(path, FileMode.Create, FileAccess.Write);

            if (encrypted)
            {
                byte[] encryptedData = Encryption.EncryptBlob(data, steamID);
                writer.Write(encryptedData, 0, encryptedData.Length);
            }
            else
            {
                writer.Write(data, 0, data.Length);
            }
            writer.Flush();
            writer.Close();
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            int encryptedDataSize = -1;
            byte[] encryptedData = null;

            string steamID = textBoxSteamID.Text;
            if (steamID.Length == 0)
            {
                steamID = "brololforce";
            }

            openFileDialog.Filter = "";
            DialogResult openFileDialogResult = openFileDialog.ShowDialog();
            if (openFileDialogResult == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                try
                {
                    encryptedData = LoadFromFile(fileName, steamID, false);
                    encryptedDataSize = encryptedData.Length;
                }
                catch (System.NullReferenceException)
                {
                    return;
                }
            }

            if (encryptedDataSize > 0)
            {
                DialogResult saveFileDialogResult = saveFileDialog.ShowDialog();
                if (saveFileDialogResult == DialogResult.OK)
                {
                    string saveFileName = saveFileDialog.FileName;
                    try
                    {
                        SaveToFile(saveFileName, encryptedData, steamID, true);
                    }
                    catch (System.NullReferenceException)
                    {
                        return;
                    }
                }
            }
        }

        private void pictureBoxB_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.baeckstrom.com");
        }


    }
}
