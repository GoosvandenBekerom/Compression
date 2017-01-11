using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using Compression.Models;

namespace Compression
{
    public partial class MainForm : Form
    {
        private readonly ICompression _compression;
        private const string PROMPT_FILE_LABEL = "Select a file to compress...";
        private const string PROMPT_FILE_LABEL_DECOMPRESS = "Select a file to decompress...";
        private const string PROMPT_FOLDER_LABEL = "Choose a destination folder for the compressed file...";
        private const string PROMPT_FOLDER_LABEL_DECOMPRESS = "Choose a destination folder for the decompressed file...";
        private const string FILE_EXTENSION = ".ghcf"; // goos' huffman compressed file

        public MainForm()
        {
            InitializeComponent();
            _compression = new HuffmanCompression();
            lblFileName.Text = PROMPT_FILE_LABEL;
            lblDestFolder.Text = PROMPT_FOLDER_LABEL;
            lblCompressOutput.Text = string.Empty;
            lblDecompress.Text = string.Empty;
        }

        private void btnOpenCompress_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileToCompress.ShowDialog();
            if (result == DialogResult.OK)
            {
                lblFileName.Text = openFileToCompress.FileName;
                lblDestFolder.Text = Path.GetDirectoryName(openFileToCompress.FileName);
            }
        }

        private void btnCompress_Click(object sender, EventArgs e)
        {
            if (lblFileName.Text == PROMPT_FILE_LABEL) return;

            AddToCompressionOutput("Starting Compression");
            CompressedFile compressed = _compression.Compress(openFileToCompress.OpenFile());
            AddToCompressionOutput(compressed);

            if (lblDestFolder.Text == PROMPT_FOLDER_LABEL)
            {
                lblDestFolder.Text = Path.GetDirectoryName(openFileToCompress.FileName);
            }

            string newFileName = Path.GetFileNameWithoutExtension(openFileToCompress.FileName) + FILE_EXTENSION;
            string destinationPath = lblDestFolder.Text + "\\" + newFileName;
            SerializeCompressedToFile(compressed, destinationPath);
        }

        private void AddToCompressionOutput(object o)
        {
            lblCompressOutput.Text += $"{o}\r\n";
        }

        private void AddToDecompressionOutput(object o)
        {
            lblDecompress.Text += $"{o}\r\n";
        }

        private void SerializeCompressedToFile(CompressedFile compressed, string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Create);
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, compressed);
                AddToCompressionOutput($"Compressed file succesfully saved to {filePath}");
            }
            catch (SerializationException e)
            {
                AddToCompressionOutput($"Failed to serialize compressed file. Reason: {e.Message}");
                throw;
            }
            finally
            {
                fs.Close();
            }
        }

        private CompressedFile DeserializeCompressedFile(string filePath)
        {
            CompressedFile file;
            FileStream fs = new FileStream(filePath, FileMode.Open);
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                file = (CompressedFile) formatter.Deserialize(fs);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }

            return file;
        }

        private void btnDestFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDest.RootFolder = Environment.SpecialFolder.Desktop;
            DialogResult result = folderBrowserDest.ShowDialog();
            if (result == DialogResult.OK)
            {
                lblDestFolder.Text = folderBrowserDest.SelectedPath;
            }
        }

        private void btnFileDecompress_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileToDecompress.ShowDialog();
            if (result == DialogResult.OK)
            {
                lblFileDecompress.Text = openFileToDecompress.FileName;
                lblDecompressFolder.Text = Path.GetDirectoryName(openFileToDecompress.FileName);
            }
        }

        private void btnDestFolderDecompress_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDecompress.ShowDialog();
            if (result == DialogResult.OK)
            {
                lblDestFolder.Text = folderBrowserDecompress.SelectedPath;
            }
        }

        private void btnDecompress_Click(object sender, EventArgs e)
        {
            if (lblFileDecompress.Text == PROMPT_FILE_LABEL_DECOMPRESS) return;

            CompressedFile compressed = DeserializeCompressedFile(openFileToDecompress.FileName);
            string decompressed = _compression.Decompress(compressed);
            AddToDecompressionOutput(decompressed);
        }
    }
}
