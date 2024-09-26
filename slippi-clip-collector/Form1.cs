namespace slippi_clip_collector
{
    public partial class Form1 : Form
    {
        private string replaysFolderPath;
        private string clipsFolderPath;
        private int replaysFolderCount;
        private int clipsFolderCount;
        private int savedFilesCount;
        private int deletedFilesCount;

        public Form1()
        {
            InitializeComponent();
        }

        private void ReplaysFolderButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    replaysFolderPath = folderBrowserDialog.SelectedPath;
                    replaysPathTextBox.Text = replaysFolderPath;
                }
                else
                {
                    return;
                }
            }

            foreach (ListViewItem item in replaysListView.Items)
            {
                replaysListView.Items.Remove(item);
            }

            FillListView(replaysFolderPath, replaysListView);
            replaysFolderCount = NumberOfFiles(replaysFolderPath);
            replaysCountLabel.Text = $"Files: {replaysFolderCount.ToString()}";
        }

        private void ClipsFolderButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    clipsFolderPath = folderBrowserDialog.SelectedPath;
                    clipsPathTextBox.Text = clipsFolderPath;
                }
                else
                {
                    return;
                }
            }

            foreach (ListViewItem item in clipsListView.Items)
            {
                clipsListView.Items.Remove(item);
            }

            FillListView(clipsFolderPath, clipsListView);
            clipsFolderCount = NumberOfFiles(clipsFolderPath);
            clipsCountLabel.Text = $"Files: {clipsFolderCount.ToString()}";
        }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(replaysFolderPath) || (string.IsNullOrEmpty(clipsFolderPath)))
            {
                return;
            }

            FileInfo mostRecentFile = GetMostRecentFile(replaysFolderPath);
            string destFile = Path.Combine(clipsFolderPath, mostRecentFile.Name);
            mostRecentFile.MoveTo(destFile);

            savedFilesCount++;
            filesMovedLabel.Text = $"{savedFilesCount.ToString()} Files Saved";
            RefreshListView(replaysListView, replaysFolderPath, replaysFolderCount, replaysCountLabel);
            RefreshListView(clipsListView, clipsFolderPath, clipsFolderCount, clipsCountLabel);
        }

        private void DeleteFileButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(replaysFolderPath) || (string.IsNullOrEmpty(clipsFolderPath)))
            {
                return;
            }

            FileInfo mostRecentFile = GetMostRecentFile(replaysFolderPath);
            string deleteFilePath = Path.Combine(replaysFolderPath, mostRecentFile.Name);
            File.Delete(deleteFilePath);

            deletedFilesCount++;
            filesDeletedLabel.Text = $"{deletedFilesCount.ToString()} Files Deleted";
            RefreshListView(replaysListView, replaysFolderPath, replaysFolderCount, replaysCountLabel);
        }

        private void RefreshReplaysButton_Click(object sender, EventArgs e)
        {
            RefreshListView(replaysListView, replaysFolderPath, replaysFolderCount, replaysCountLabel);
        }

        private void RefreshClipsButton_Click(object sender, EventArgs e)
        {
            RefreshListView(clipsListView, clipsFolderPath, clipsFolderCount, clipsCountLabel);
        }

        private void FillListView(string folderPath, ListView listView)
        {
            if (!string.IsNullOrEmpty(folderPath))
            {
                var files = new DirectoryInfo(folderPath).GetFiles()
                    .OrderByDescending(f => f.LastWriteTime)
                    .ToList();

                foreach (var file in files)
                {
                    long fileSizeBytes = file.Length;
                    double fileSizeKilobytes = Math.Ceiling(fileSizeBytes / 1024.0);

                    var item = new ListViewItem(file.Name);
                    item.SubItems.Add(file.LastWriteTime.ToString());
                    item.SubItems.Add($"{fileSizeKilobytes} KB");
                    listView.Items.Add(item);
                }
            }
            else
            {
                return;
            }
        }

        private int NumberOfFiles(string folderPath)
        {
            if (!string.IsNullOrEmpty(folderPath))
            {
                int numberOfFiles = new DirectoryInfo(folderPath)
                    .GetFiles().Length;

                return numberOfFiles;
            }
            else
            {
                return 0;
            }
        }

        private FileInfo GetMostRecentFile(string folderPath)
        {
            var directory = new DirectoryInfo(folderPath);
            var mostRecentFile = directory.GetFiles()
                .OrderByDescending(f => f.LastWriteTime)
                .FirstOrDefault();

            return mostRecentFile;
        }

        private void ClearListView(ListView listView)
        {
            foreach (ListViewItem item in listView.Items)
            {
                listView.Items.Remove(item);
            }
        }

        private void RefreshListView(ListView listView, string folderPath, int count, Label label)
        {
            ClearListView(listView);
            FillListView(folderPath, listView);
            
            count = NumberOfFiles(folderPath);
            label.Text = $"Files: {count.ToString()}";
        }
    }
}
