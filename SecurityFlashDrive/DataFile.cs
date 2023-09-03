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
        public DataPath Path { get; }


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



        #region DataForCrypto
        public string PassWord { get; }
        public byte[] EncryptedFile { get; private protected set; } = null;
        #endregion DataForCrypto



        #region Serialization
        public FormatData DataFormat { get; private protected set; } = new FormatData();
        public byte[] DataBytes
        {
            get
            {
                return Serialization.StartSerialize<FormatData>(DataFormat).Item2;
            }
            private protected set
            {
                DataFormat = Serialization.StartDeserialize<FormatData>(value).Item2;
            }
        }
        #endregion Serialization
    }
}
