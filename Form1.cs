namespace ITB_SL {
    public partial class Form1 : Form {
        private Controller controller;
        public Form1() {
            InitializeComponent();

            controller = new Controller();

            locLabel.Text = controller.GameLocation;

            ShowList(saveDataListView, controller.SaveDataDir);
            ShowList(undoSaveListView, controller.UndoSaveDir);
        }

        private void ShowList(ListView listView, DirectoryInfo di) {
            listView.BeginUpdate();
            listView.Items.Clear();

            FileInfo[] fileInfos = di.GetFiles(@"*.*").OrderByDescending(x => x.CreationTime).ToArray();
            //DateTime[] creationTimes = new DateTime[fileInfos.Length];
            //for (int i = 0; i < fileInfos.Length; i++) {
            //    creationTimes[i] = fileInfos[i].CreationTime;
            //    //Console.WriteLine(creationTimes[i]);
            //}

            //Array.Sort(creationTimes, fileInfos);

            foreach (FileInfo fileInfo in fileInfos) {
                Console.WriteLine(fileInfo.CreationTime);
            }

            //Console.WriteLine("\n");

            //Array.Sort(fileInfos, (x, y) => Comparer<DateTime>.Default.Compare(x.CreationTime, y.CreationTime));
            foreach (FileInfo fi in fileInfos) {
                string[] col = new string[2];
                col[0] = fi.Name;
                col[1] = fi.CreationTime.ToString();
                //Console.WriteLine(col[0] + " " + col[1]);
                ListViewItem itm = new ListViewItem(col);
                listView.Items.Add(itm);
            }
            listView.EndUpdate();
        }

        private void saveDataBtn_Click(object sender, EventArgs e) {
            controller.saveData();
            ShowList(saveDataListView, controller.SaveDataDir);
        }

        private void undoSaveBtn_Click(object sender, EventArgs e) {
            controller.undoSave();
            ShowList(undoSaveListView, controller.UndoSaveDir);
        }

        private void deleteProgress() {
            string fileName;
            if (saveDataListView.SelectedItems.Count > 0) {
                fileName = saveDataListView.SelectedItems[0].SubItems[0].Text;
                Console.WriteLine(fileName);
                controller.deleteFile(fileName, Controller.SAVEDATA);
                ShowList(saveDataListView, controller.SaveDataDir);
            } else if (undoSaveListView.SelectedItems.Count > 0) {
                fileName = undoSaveListView.SelectedItems[0].SubItems[0].Text;
                Console.WriteLine(fileName);
                controller.deleteFile(fileName, Controller.UNDOSAVE);
                ShowList(undoSaveListView, controller.UndoSaveDir);
            }
        }

        private void delBtn_Click(object sender, EventArgs e) {
            deleteProgress();
        }

        private void saveDataListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e) {
            if (undoSaveListView.SelectedItems.Count > 0) {
                //undoSaveListView.SelectedItems[0].Selected = false;
            }
        }

        private void undoSaveListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e) {
            if (saveDataListView.SelectedItems.Count > 0) {
                //saveDataListView.SelectedItems[0].Selected = false;
            }
        }

        private void restoreProgress() {
            string fileName;
            if (saveDataListView.SelectedItems.Count > 0) {
                fileName = saveDataListView.SelectedItems[0].SubItems[0].Text;
                controller.restoreFile(fileName, Controller.SAVEDATA);
            } else if (undoSaveListView.SelectedItems.Count > 0) {
                fileName = undoSaveListView.SelectedItems[0].SubItems[0].Text;
                controller.restoreFile(fileName, Controller.UNDOSAVE);
            }
        }

        private void restoreBtn_Click(object sender, EventArgs e) {
            restoreProgress();
        }

        private void regretBtn_Click(object sender, EventArgs e) {
            controller.regret();
        }

        private void restoreAndDelBtn_Click(object sender, EventArgs e) {
            restoreProgress();
            deleteProgress();
        }

        private void undoSaveListView_MouseClick(object sender, MouseEventArgs e) {
            if (saveDataListView.SelectedItems.Count > 0) {
                saveDataListView.SelectedItems[0].Selected = false;
            }
        }

        private void saveDataListView_MouseDown(object sender, MouseEventArgs e) {
            if (undoSaveListView.SelectedItems.Count > 0) {
                undoSaveListView.SelectedItems[0].Selected = false;
            }
        }

        private void locBtn_Click(object sender, EventArgs e) {
            FolderBrowserDialog f = new FolderBrowserDialog();
            if (f.ShowDialog() == DialogResult.OK) {
                string gameLoc = f.SelectedPath;
                controller.GameLocation = gameLoc;
                locLabel.Text = gameLoc;
            }
        }
    }
}