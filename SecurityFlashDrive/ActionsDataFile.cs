using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityFlashDrive
{
    /// <summary>
    /// Действия с файлом
    /// </summary>
    public class ActionsDataFile : DataFile
    {
        /// <summary>
        /// Реализация класса ActionsDataFile
        /// </summary>
        /// <param name="dataFile">Данные файла</param>
        public ActionsDataFile(DataFile dataFile)
        : base(dataFile.Path, dataFile.PassWord) { }
        /// <summary>
        /// Реализация класса ActionsDataFile
        /// </summary>
        /// <param name="nameDisk">Литера диска</param>
        /// <param name="path">Путь(nameFolderA\nameFolderB\nameFolderC)</param>
        /// <param name="name">Имя файла</param>
        /// <param name="extension">Разширение файла</param>
        /// <param name="passWord">Пароль</param>
        public ActionsDataFile(char nameDisk, string path, string name, string extension, string passWord)
        : base(new DataPath(nameDisk, path, name, extension), passWord) { }
        /// <summary>
        /// Реализация класса ActionsDataFile
        /// </summary>
        /// <param name="dataPath">Путь</param>
        /// <param name="passWord">Пароль</param>
        public ActionsDataFile(DataPath dataPath, string passWord)
        : base(dataPath, passWord) { }
        /*
        /// <summary>
        /// Сохранить файл
        /// </summary>
        /// <param name="data">Данные</param>
        /// <returns>Успешность выполнения</returns>
        public bool SaveData(string data)
        {
            if (!FileExists()) Directory.CreateDirectory(Path.DirectoryPath);
            Data = data;
            EncryptedFile = Crypto.ToAes256(Data, PassWord);
            FileIO.OpenOrCreate(EncryptedFile, Path.FullPath);
            return true;
        }*/
        /// <summary>
        /// Сохранить файл
        /// </summary>
        /// <param name="data">Данные</param>
        /// <returns>Успешность выполнения</returns>
        public bool SaveData(FileFormat data)
        {
            if (!FileExists()) Directory.CreateDirectory(Path.DirectoryPath);
            DataFormat = data;
            EncryptedFile = Crypto.ToAes256_Byte(DataBytes, PassWord);
            FileIO.OpenOrCreate(EncryptedFile, Path.FullPath);
            return true;
        }
        /*
        /// <summary>
        /// скачать данные
        /// </summary>
        /// <returns>Успешность выполнения</returns>
        public bool DownloadData()
        {
            if (!File.Exists(Path.FullPath)) return false;
            EncryptedFile = FileIO.Read(Path.FullPath).Item3;
            Data = Crypto.FromAes256(EncryptedFile, PassWord);
            return true;
        }*/
        /// <summary>
        /// скачать данные
        /// </summary>
        /// <returns>Успешность выполнения</returns>
        public bool DownloadDataBBB()
        {
            if (!File.Exists(Path.FullPath)) return false;
            EncryptedFile = FileIO.Read(Path.FullPath).Item3;
            DataBytes = Crypto.FromAes256_Byte(EncryptedFile, PassWord);
            return true;
        }
        /// <summary>
        /// Обновить шифровку
        /// </summary>
        /// <returns>Успешность выполнения</returns>
        public bool UpdateCipher()
        {
            if (DownloadDataBBB()) return SaveData(DataFormat);
            return false;
        }
        /// <summary>
        /// Проверить наличие файла
        /// </summary>
        /// <returns>Результат: файл в наличии — true, иначе — false</returns>
        public bool FileExists()
        {
            return File.Exists(Path.FullPath);
        }
    }
    /// <summary>
    /// Данные файла
    /// </summary>
    public class ActionsDataFile2
    {
        public DataPath Path { get; }
        #region Path
        //public char NameDisk { get; }
        //public string Path { get; }
        //public string Name { get; }
        //public string DirectoryPath { get { return $"{NameDisk}:\\{Path}"; } }
        //public string FullPath { get { return $"{NameDisk}:\\{Path}\\{Name}"; } }
        #endregion Path

        #region DataForCrypto
        public string PassWord { get; }
        //public string DataString { get { return ; } }
        public string Data { get; private set; } = null;
        public byte[] EncryptedFile { get; private set; } = null;
        #endregion DataForCrypto

        /// <summary>
        /// Создать данные файла
        /// </summary>
        /// <param name="nameDisk">литера диска</param>
        /// <param name="path">путь до файла</param>
        /// <param name="name">имя файла</param>
        /// <param name="passWord">пароль</param>
        public ActionsDataFile2(char nameDisk, string path, string name, string extension, string passWord)
        {
            Path = new DataPath(nameDisk, path, name, extension);
            //NameDisk = nameDisk;
            //Path = path;
            //Name = name;
            PassWord = passWord;
        }
        public bool SaveData(string data)
        {
            if (!FileExists()) Directory.CreateDirectory(Path.DirectoryPath);
            Data = data;
            EncryptedFile = Crypto.ToAes256(Data, PassWord);
            FileIO.OpenOrCreate(EncryptedFile, Path.FullPath);
            return true;
        }
        public bool DownloadData()
        {
            if (!File.Exists(Path.FullPath)) return false;
            EncryptedFile = FileIO.Read(Path.FullPath).Item3;
            Data = Crypto.FromAes256(EncryptedFile, PassWord);
            return true;
        }
        public bool UpdateCipher()
        {
            if (DownloadData()) return SaveData(Data);
            return false;
        }
        public bool FileExists()
        {
            return File.Exists(Path.FullPath);
        }
        /*
        public void TEST()
        {
            ActionsDataFile_ fff = new ActionsDataFile_(new DataPath(), "0");
            DataFile_ ddd = fff;
            ActionsDataFile_ sss = new ActionsDataFile_(ddd);
        }*/
    }
}
