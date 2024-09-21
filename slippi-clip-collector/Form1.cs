namespace slippi_clip_collector
{
    public partial class Form1 : Form
    {
        private string replaysFolderPath;
        private string clipsFolderPath;
        private int replaysFolderCount = 0;
        private int clipsFolderCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

            FillListView(clipsFolderPath, listView2);
            clipsFolderCount = NumberOfFiles(clipsFolderPath);
            label4.Text = $"Files: {clipsFolderCount.ToString()}";
        }

        private void FillListView(string folderPath, ListView listView)
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

        private int NumberOfFiles(string folderPath)
        {
            int numberOfFiles = new DirectoryInfo(folderPath)
                .GetFiles().Length;

            return numberOfFiles;
        }
    }
}
