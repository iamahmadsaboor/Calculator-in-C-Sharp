using System.IO;
using System;
using System;
using System.Text;
using System.Windows.Forms;

namespace Calc
{
    internal class FileManager
    {
        private string fileName;
        FileStream fs;

        public FileManager(string path, string name)
        {
            fileName = path + "\\" + name;
        }

        public bool CreateFile()
        {
            try
            {
                if (File.Exists(fileName))
                {
                    return false;
                }
                else
                {
                    fs = File.Create(fileName);
                    fs.Close();
                    return true;
                }
            }
            catch
            {
                throw;
            }
        }

        public bool CreateFile(bool overwrite)
        {
            try
            {
                if (File.Exists(fileName))
                {
                    if (overwrite)
                    {
                        File.Delete(fileName);
                        fs = File.Create(fileName);
                        fs.Close();
                        return true;
                    }
                    else
                        return false;
                }
                else
                {
                    fs = File.Create(fileName);
                    fs.Close();
                    return true;
                }
            }
            catch
            {
                throw;
            }
        }

        public void Write(string text)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(fileName, true))
                {
                    sw.WriteLine(text);
                }
            }
            catch
            {
                throw;
            }
        }

        public string Read()
        {
            fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);


            using (StreamReader sr = new StreamReader(fs))
            {
                string text = sr.ReadToEnd();
                fs.Close();
                return text;
            }
        }
    }
}
