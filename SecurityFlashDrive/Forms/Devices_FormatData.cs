using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityFlashDrive
{
    /// <summary>
    /// File for serialization
    /// </summary>
    [Serializable]
    public struct Devices_FormatData
    {
        public Devices_FormatData() { }
        #region Data
        public string DataSTR { get; set; } = "";
        public ParametrsData Parametrs { get; set; } = new ParametrsData();
        public List<UserFile> Files { get; set; } = new List<UserFile>();
        #endregion Data

        public override string ToString()
        {
            string sf = "";
            foreach (var item in Files) sf += $"{item}\n";
            return "\tДанные:\n" +
                $"{DataSTR}\n" +
                "\tПараметры:\n" +
                $"{Parametrs}\n" +
                $"\tФайлы\n{sf}";
        }


        #region DataClasses
        [Serializable]
        public struct ParametrsData
        {
            public override string ToString()
            {
                return $"Cпрашивать о сохранении - {BoolInStr(AskAboutSaving)}";
                string BoolInStr(bool inp)
                {
                    if (inp) return "YES";
                    return "NO";
                }
            }
            public ParametrsData() { }
            public bool AskAboutSaving { get; set; } = false;
        }
        [Serializable]
        public struct UserFile
        {
            public UserFile(DataPath pathFile, DataPath pathDirectory)
            {
                PathFile = pathFile;
                PathDirectory = pathDirectory;
                this.pwd = (false, new byte[0]);
            }
            public UserFile(DataPath pathFile, DataPath pathDirectory, string pwd)
            {
                PathFile = pathFile;
                PathDirectory = pathDirectory;
                this.pwd = (true, Crypto.ComputeSHA256(pwd));
            }
            public DataPath PathFile { get; set; } = new DataPath();
            public DataPath PathDirectory { get; set; } = new DataPath();
            public (bool, byte[]) pwd { get; set; } = (false, new byte[0]);

            /*
            public UserFile(DataPath pathFromFile, DataPath pathInFile) { PathFromFile = pathFromFile; PathInFile = pathInFile; }
            public DataPath PathFromFile { get; set; } = new DataPath();
            public DataPath PathInFile { get; set; } = new DataPath();
            */
            public override string ToString()
            {
                return PathFile.ToString();
            }
        }
        #endregion DataClasses
    }
}
