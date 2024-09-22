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

        private void button1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    replaysFolderPath = folderBrowserDialog.SelectedPath;
                    textBox1.Text = replaysFolderPath;
                }
                else
                {
                    return;
                }
            }

            foreach (ListViewItem item in listView1.Items)
            {
                listView1.Items.Remove(item);
            }

            FillListView(replaysFolderPath, listView1);
            replaysFolderCount = NumberOfFiles(replaysFolderPath);
            label3.Text = $"Files: {replaysFolderCount.ToString()}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    clipsFolderPath = folderBrowserDialog.SelectedPath;
                    textBox2.Text = clipsFolderPath;
                }
                else
                {
                    return;
                }
            }

            foreach (ListViewItem item in listView2.Items)
            {
                listView2.Items.Remove(item);
            }

            FillListView(clipsFolderPath, listView2);
            clipsFolderCount = NumberOfFiles(clipsFolderPath);
            label4.Text = $"Files: {clipsFolderCount.ToString()}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(replaysFolderPath) || (string.IsNullOrEmpty(clipsFolderPath)))
            {
                return;
            }

            FileInfo mostRecentFile = GetMostRecentFile(replaysFolderPath);
            string destFile = Path.Combine(clipsFolderPath, mostRecentFile.Name);
            mostRecentFile.MoveTo(destFile);

            savedFilesCount++;
            label1.Text = $"{savedFilesCount.ToString()} Files Saved";
            RefreshListView(listView1, replaysFolderPath, replaysFolderCount, label3);
            RefreshListView(listView2, clipsFolderPath, clipsFolderCount, label4);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(replaysFolderPath) || (string.IsNullOrEmpty(clipsFolderPath)))
            {
                return;
            }

            FileInfo mostRecentFile = GetMostRecentFile(replaysFolderPath);
            string deleteFilePath = Path.Combine(replaysFolderPath, mostRecentFile.Name);
            File.Delete(deleteFilePath);

            deletedFilesCount++;
            label2.Text = $"{deletedFilesCount.ToString()} Files Deleted";
            RefreshListView(listView1, replaysFolderPath, replaysFolderCount, label3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RefreshListView(listView1, replaysFolderPath, replaysFolderCount, label3);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RefreshListView(listView2, clipsFolderPath, clipsFolderCount, label4);
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
