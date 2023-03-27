using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public sealed class Singleton
    {
        private static Singleton instance = null;
        private static readonly object padlock = new object();
        private StreamWriter writer;

        Singleton()
        {
            string fileName = "rtr.txt";
            string path = @"C:\Users\олег\Desktop";
            string fullPath = Path.Combine(path, fileName);

            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                if (File.Exists(fullPath))
                {
                    File.Delete(fullPath);
                }

                using (StreamReader sr = new StreamReader(fileName))
                {

                }

                MessageBox.Show("file created");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            string filePath = @"C:\Users\олег\Desktop\rtr.txt";

            writer = new StreamWriter(filePath, true);
        }

        public static Singleton Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }
            }
        }

        public void Log(string message)
        {
            writer.WriteLine(DateTime.Now + ": " + message);
            writer.Flush();
        }
    }
}
