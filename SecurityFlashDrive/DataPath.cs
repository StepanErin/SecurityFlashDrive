using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SecurityFlashDrive
{
    public struct DataPath
    {
        /// <summary>
        /// Литера диска
        /// </summary>
        public char NameDisk { get; }
        /// <summary>
        /// Путь(nameFolderA\nameFolderB\nameFolderC)
        /// </summary>
        public string Path { get; }
        /// <summary>
        /// Имя файла
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Разширение файла(.*)
        /// </summary>
        public string Extension { get; }
        /// <summary>
        /// Полное имя(Name.Extension)
        /// </summary>
        public string FullName { get { if (string.IsNullOrEmpty(Extension)) return Name; else return $"{Name}.{Extension}"; } }
        /// <summary>
        /// Директория (NamrDisk:\nameFolderA\nameFolderB\nameFolderC)
        /// </summary>
        public string DirectoryPath { get { return $"{NameDisk}:\\{Path}"; } }
        /// <summary>
        /// Полный путь (NamrDisk:\nameFolderA\nameFolderB\nameFolderC\NameFile.Extension)
        /// </summary>
        public string FullPath { get { return $"{NameDisk}:\\{Path}\\{FullName}"; } }
        /// <summary>
        /// Создать путь
        /// </summary>
        /// <param name="nameDisk">Литера диска</param>
        /// <param name="path">Путь(nameFolderA\nameFolderB\nameFolderC)</param>
        /// <param name="name">Имя файла</param>
        /// <param name="extension">Разширение файла</param>
        public DataPath(char nameDisk, string path, string name, string extension)
        {
            NameDisk = nameDisk;
            Path = path;
            Name = name;
            Extension = extension;
        }
        static public (bool, DataPath) NewDataPath(string path)
        {
            char disk;
            string nameFile;
            string extensionFile;
            string path_ = "";
            var t = path.Split('\\');



            if (t.Length < 2) return (false, new DataPath());//наличие диска и названия

            if (t[0].Length != 2) return (false, new DataPath());//наличие диска
            disk = t[0][0];


            string fullName = t[t.Length - 1];
            if (fullName.Contains('.'))
            {
                var n = fullName.Split('.');
                if (n.Length > 2) return (false, new DataPath());//название и расширение
                nameFile = n[0];
                extensionFile = n[1];
            }
            else
            {
                nameFile = fullName;
                extensionFile = "";
            }

            if (t.Length > 2)
            {
                path_ += t[1];
                for (int i = 2; i < t.Length - 2; i++) path_ += t[i];
            }
            return (true, new DataPath(disk, path_, nameFile, extensionFile));
        }
        public override string ToString()
        {
            return FullPath;
        }
    }
}
