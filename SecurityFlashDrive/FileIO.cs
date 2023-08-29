using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityFlashDrive
{
    internal static class FileIO
    {
        public static void DirectoryCreate(string path)
        {
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);
        }
        public static (bool, string) OpenOrCreate(string data, string path)
        {
            // преобразуем строку в байты
            return OpenOrCreate(Encoding.Default.GetBytes(data), path);
        }
        public static (bool, string) OpenOrCreate(byte[] data, string path)
        {
            string error = null;
            FileStream fstream = null;
            try
            {
                fstream = new FileStream(path, FileMode.OpenOrCreate);
                // запись массива байтов в файл
                fstream.Write(data, 0, data.Length);
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            finally
            {
                fstream?.Close();
            }
            return (error != null, error);
        }//fstream.Seek(0, SeekOrigin.Begin);
        public static (bool, string, string) ReadTXT(string path)
        {
            var t = Read(path);
            return (t.Item1, t.Item2, Encoding.Default.GetString(t.Item3));
        }
        public static (bool, string, byte[]) Read(string path)
        {
            string error = null;
            FileStream fstream = null;
            byte[] data = null;
            try
            {
                fstream = new FileStream(path, FileMode.Open);
                // выделяем массив для считывания данных из файла
                byte[] buffer = new byte[fstream.Length];
                // считываем данные
                fstream.Read(buffer, 0, buffer.Length);
                data = buffer;
            }
            catch (Exception ex) { error = ex.Message; }
            finally
            {
                fstream?.Close();
            }
            return (error == null, error, data);
        }//fstream.Seek(0, SeekOrigin.Begin);



        static public class VisualHiding
        {
            private static bool FileExists(string fullPath)
            {
                return File.Exists(fullPath);
            }

            public static bool PrivatizeFile(DataPath path)
            {
                try
                {
                    if (FileExists(path.FullPath))
                        File.SetAttributes(path.FullPath, FileAttributes.Hidden);
                }
                catch
                {
                    return false;
                }
                return true;
            }
            public static bool DeprivatizeFile(DataPath path)
            {
                try
                {
                    if (FileExists(path.FullPath))
                        File.SetAttributes(path.FullPath, FileAttributes.Normal);
                }
                catch
                {
                    return false;
                }
                return true;
            }
            public static bool PrivatizeFileDirectory(DataPath path)
            {
                try
                {
                    string str = path.DirectoryPath;
                    int count = 0;
                    foreach (var item in str) if (item == '\\') count++;

                    for (int i = count; i != 0; i--)
                    {
                        new DirectoryInfo(str).Attributes = FileAttributes.Hidden;
                        str = str.Remove(str.LastIndexOf('\\'));
                    }
                }
                catch
                {
                    return false;
                }
                return true;
            }
            public static bool DeprivatizeDirectory(DataPath path)
            {
                try
                {
                    string str = path.DirectoryPath;
                    int count = 0;
                    foreach (var item in str) if (item == '\\') count++;

                    for (int i = count; i != 0; i--)
                    {
                        new DirectoryInfo(str).Attributes = FileAttributes.Normal;
                        str = str.Remove(str.LastIndexOf('\\'));
                    }
                }
                catch
                {
                    return false;
                }
                return true;
            }
        }
    }
}
