using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string FullName { get { return $"{Name}.{Extension}"; } }
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
    }
}
