using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityFlashDrive
{
    public class Backup
    {
        public void RunFile(ActionsDataFile file)
        {
            file.DownloadData();
            var data = file.DataFormat;
            var instructionsFiles = data.Files;
            foreach (var instructionsFile in instructionsFiles)
            {
                var t = FileIO.Read(instructionsFile.PathFromFile.FullPath);
                if (t.Item1)
                {
                    var res = FileIO.OpenOrCreate(t.Item3, instructionsFile.PathInFile.FullPath);
                    if (res.Item1)
                        MessageBox.Show("Файл сохранён");
                };
            }
            MessageBox.Show(data.DataSTR);
        }
    }
}
