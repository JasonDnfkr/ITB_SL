using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ITB_SL {
    class Controller {
        private const string folderName = "ITB_Helper";

        private string gameLocation;
        private string folderLocation;
        private string saveDataLocation;
        private string undoSaveLocation;

        private DirectoryInfo saveDataDir;
        private DirectoryInfo undoSaveDir;

        private List<string> saveDataList;
        private List<string> undoSaveList;

        private FileInfo[] saveDataFile;
        private FileInfo[] undoSaveFile;

        public const int SAVEDATA = 0;
        public const int UNDOSAVE = 1;

        public Controller() {
            gameLocation = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            gameLocation += "\\My games\\Into the Breach\\profile_Alpha\\";
            Console.WriteLine(gameLocation);

            folderLocation = gameLocation + folderName + "\\";

            Directory.CreateDirectory(folderLocation);
            Console.WriteLine(folderLocation);

            saveDataLocation = folderLocation + "saveData\\";
            undoSaveLocation = folderLocation + "undoSave\\";
            Directory.CreateDirectory(saveDataLocation);
            Directory.CreateDirectory(undoSaveLocation);

            saveDataDir = new DirectoryInfo(saveDataLocation);
            undoSaveDir = new DirectoryInfo(undoSaveLocation);

            saveDataList = new List<string>();
            undoSaveList = new List<string>();

            ListData(saveDataDir, saveDataList);
            ListData(undoSaveDir, undoSaveList);

            Init();
        }

        public void ListData(DirectoryInfo directoryInfo, List<string> l) {
            FileInfo[] fileInfos = directoryInfo.GetFiles();
            l.Clear();
            foreach (FileInfo fileInfo in fileInfos) {
                string fileName = fileInfo.Name;
                l.Add(fileName);
                Console.WriteLine(fileName);
            }
        }

        public void saveData() {
            FileInfo file = new FileInfo(gameLocation + "saveData.lua");
            Console.WriteLine(file.Name);
            file.CopyTo(saveDataDir + "saveData_" + System.DateTime.Now.ToString("yyyy-MM-dd-HHmmss"), true);
        }

        public void undoSave() {
            FileInfo file = new FileInfo(gameLocation + "undoSave.lua");
            Console.WriteLine(file.Name);
            file.CopyTo(undoSaveDir + "undoSave_" + System.DateTime.Now.ToString("yyyy-MM-dd-HHmmss"), true);
        }

        public void deleteFile(string fileName, int flag) {
            FileInfo file;
            if (flag == SAVEDATA) {
                file = new FileInfo(saveDataDir + fileName);
                file.Delete();
            }
            else if (flag == UNDOSAVE) {
                file = new FileInfo(undoSaveDir + fileName);
                file.Delete();
            }
        }

        public void regret() {
            FileInfo file = new FileInfo(gameLocation + "undoSave.lua");
            if (file.Exists) {
                file.CopyTo(gameLocation + "saveData.lua", true);
            }
        }

        public void restoreFile(string fileName, int flag) {
            FileInfo file;
            if (flag == SAVEDATA) {
                file = new FileInfo(saveDataDir + fileName);
                file.CopyTo(gameLocation + "saveData.lua", true);
            }
            else if (flag == UNDOSAVE) {
                file = new FileInfo(undoSaveDir + fileName);
                file.CopyTo(gameLocation + "saveData.lua", true);
            }
        }

        private void Init() {

        }

        public string GameLocation {
            get { return gameLocation; }
            set { gameLocation = value + "\\"; }
        }

        public DirectoryInfo SaveDataDir {
            get { return saveDataDir; }
        }

        public DirectoryInfo UndoSaveDir {
            get { return undoSaveDir; }
        }
    }
}
