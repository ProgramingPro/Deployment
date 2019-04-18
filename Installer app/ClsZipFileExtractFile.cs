using System;
using System.IO.Compression;
using System.Reflection;
using System.IO;

namespace AllLessstionCSharp
{
    class ClsZipFileExtractFile
    {
        private const string fileName = "readme.zip";
        private string m_sourcePath = AppDomain.CurrentDomain.BaseDirectory + "\\" + fileName;
        private string m_destPath = AppDomain.CurrentDomain.BaseDirectory;

        public object ZipFile { get; private set; }

        private void RecreateZipResource()
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            Stream streamToResource = asm.GetManifestResourceStream("Simple_Zip_Extract." + fileName);
            FileInfo outputFile = new FileInfo(fileName);
            FileStream streamToOutputFile = outputFile.OpenWrite();

            //save resource file to the disk:
            const int size = 4096;
            byte[] bytes = new byte[size];
            int numBytes;
            while ((numBytes = streamToResource.Read(bytes, 0, size)) > 0)
            {
                streamToOutputFile.Write(bytes, 0, numBytes);
            }

            streamToOutputFile.Close();
            streamToResource.Close();
        }

        public void MakeAction()
        {
            RecreateZipResource();
           // ZipFile.ExtractToDirectory(m_sourcePath, m_destPath);
        }
    }
}