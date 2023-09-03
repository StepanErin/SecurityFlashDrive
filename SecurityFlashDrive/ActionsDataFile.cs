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
        #region Constructors
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
        #endregion Constructors


        #region Actions
        /// <summary>
        /// Сохранить файл
        /// </summary>
        /// <param name="data">Данные</param>
        /// <returns>Успешность выполнения</returns>
        public bool SaveData(FormatData data)
        {
            if (!FileExists()) Directory.CreateDirectory(Path.DirectoryPath);
            DataFormat = data;
            EncryptedFile = Crypto.ToAes256_Byte(DataBytes, PassWord);
            FileIO.OpenOrCreate(EncryptedFile, Path.FullPath);
            return true;
        }
        /// <summary>
        /// скачать данные
        /// </summary>
        /// <returns>Успешность выполнения</returns>
        public bool DownloadData()
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
            if (DownloadData()) return SaveData(DataFormat);
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
        #endregion Actions
    }
}
