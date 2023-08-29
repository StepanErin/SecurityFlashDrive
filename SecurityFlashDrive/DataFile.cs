using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SecurityFlashDrive
{
    /// <summary>
    /// Данные файла
    /// </summary>
    public class DataFile
    {
        /// <summary>
        /// File for serialization
        /// </summary>
        [Serializable]
        public struct FileFormat
        {
            public FileFormat(string dataSTR)
            {
                DataSTR = dataSTR;
            }
            public string DataSTR { get; set; }
        }
        public FileFormat DataFormat { get; private protected set; }
        public byte[] DataBytes
        {
            get
            {
                return Serialization.StartSerialize<FileFormat>(DataFormat).Item2;
            }
            private protected set
            {
                DataFormat = Serialization.StartDeserialize<FileFormat>(value).Item2;
            }
        }


        public DataPath Path { get; }

        #region DataForCrypto
        public string PassWord { get; }
        public byte[] EncryptedFile { get; private protected set; } = null;
        #endregion DataForCrypto

        /// <summary>
        /// Создать данные файла
        /// </summary>
        /// <param name="nameDisk">литера диска</param>
        /// <param name="path">путь до файла</param>
        /// <param name="name">имя файла</param>
        /// <param name="passWord">пароль</param>
        public DataFile(DataPath dataPath, string passWord)
        {
            Path = dataPath;
            PassWord = passWord;
        }
    }
}
