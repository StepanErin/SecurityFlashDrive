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
    public struct FormatData
    {
        public FormatData() { }
        public bool OneFile { get; set; } = false;
        public string DataSTR { get; set; } = "";
        public ParametrsData Parametrs { get; set; } = new ParametrsData();
        public List<FilesData> Files { get; set; } = new List<FilesData>();
        [Serializable]
        public struct ParametrsData
        {
            public ParametrsData() { }
            public bool AutoSave { get; set; } = false;
            public bool AutoBackupSave { get; set; } = false;
            public bool FolderInStartOrEnd { get; set; } = false;
            public string NameFolder { get; set; } = "";
        }
        [Serializable]
        public struct FilesData
        {
            public FilesData(DataPath pathFromFile, DataPath pathInFile) { PathFromFile = pathFromFile; PathInFile = pathInFile; }
            public DataPath PathFromFile { get; set; } = new DataPath();
            public DataPath PathInFile { get; set; } = new DataPath();
            public override string ToString()
            {
                return $"{PathFromFile} — {PathInFile}";
            }
        }
    }
}
