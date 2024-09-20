namespace slippi_clip_collector
{
    public partial class Form1 : Form
    {
        private string replaysFolderPath;
        private string clipsFolderPath;

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
            }

            FillListView(replaysFolderPath, listView1);
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
            }

            FillListView(clipsFolderPath, listView2);
        }

        private void FillListView(string folderPath, ListView listView)
        {
            var files = new DirectoryInfo(folderPath).GetFiles()
                .OrderByDescending(f => f.LastWriteTime)
                .ToList();

            foreach (var file in files)
            {
                var item = new ListViewItem(file.Name);
                item.SubItems.Add(file.LastWriteTime.ToString());
                listView.Items.Add(item); 
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
