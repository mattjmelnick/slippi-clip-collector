namespace slippi_clip_collector
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            replaysFolderButton = new Button();
            clipsFolderButton = new Button();
            refreshReplaysButton = new Button();
            refreshClipsButton = new Button();
            saveFileButton = new Button();
            deleteFileButton = new Button();
            replaysPathTextBox = new TextBox();
            clipsPathTextBox = new TextBox();
            replaysCountLabel = new Label();
            clipsCountLabel = new Label();
            filesMovedLabel = new Label();
            filesDeletedLabel = new Label();
            replaysListView = new ListView();
            replaysFileName = new ColumnHeader();
            replaysDateModified = new ColumnHeader();
            replaysFileSize = new ColumnHeader();
            clipsListView = new ListView();
            clipsFileName = new ColumnHeader();
            clipsDateModified = new ColumnHeader();
            clipsFileSize = new ColumnHeader();
            SuspendLayout();
            // 
            // replaysFolderButton
            // 
            replaysFolderButton.Location = new Point(48, 34);
            replaysFolderButton.Name = "replaysFolderButton";
            replaysFolderButton.Size = new Size(173, 66);
            replaysFolderButton.TabIndex = 0;
            replaysFolderButton.Text = "Select Replays Folder";
            replaysFolderButton.UseVisualStyleBackColor = true;
            replaysFolderButton.Click += ReplaysFolderButton_Click;
            // 
            // clipsFolderButton
            // 
            clipsFolderButton.Location = new Point(48, 309);
            clipsFolderButton.Name = "clipsFolderButton";
            clipsFolderButton.Size = new Size(173, 66);
            clipsFolderButton.TabIndex = 1;
            clipsFolderButton.Text = "Select Clips Folder";
            clipsFolderButton.UseVisualStyleBackColor = true;
            clipsFolderButton.Click += ClipsFolderButton_Click;
            // 
            // refreshReplaysButton
            // 
            refreshReplaysButton.Location = new Point(48, 256);
            refreshReplaysButton.Name = "refreshReplaysButton";
            refreshReplaysButton.Size = new Size(67, 29);
            refreshReplaysButton.TabIndex = 6;
            refreshReplaysButton.Text = "Refresh";
            refreshReplaysButton.UseVisualStyleBackColor = true;
            refreshReplaysButton.Click += RefreshReplaysButton_Click;
            // 
            // refreshClipsButton
            // 
            refreshClipsButton.Location = new Point(48, 531);
            refreshClipsButton.Name = "refreshClipsButton";
            refreshClipsButton.Size = new Size(67, 29);
            refreshClipsButton.TabIndex = 6;
            refreshClipsButton.Text = "Refresh";
            refreshClipsButton.UseVisualStyleBackColor = true;
            refreshClipsButton.Click += RefreshClipsButton_Click;
            // 
            // saveFileButton
            // 
            saveFileButton.Location = new Point(88, 582);
            saveFileButton.Name = "saveFileButton";
            saveFileButton.Size = new Size(137, 53);
            saveFileButton.TabIndex = 2;
            saveFileButton.Text = "Save";
            saveFileButton.UseVisualStyleBackColor = true;
            saveFileButton.Click += SaveFileButton_Click;
            // 
            // deleteFileButton
            // 
            deleteFileButton.Location = new Point(471, 582);
            deleteFileButton.Name = "deleteFileButton";
            deleteFileButton.Size = new Size(137, 53);
            deleteFileButton.TabIndex = 3;
            deleteFileButton.Text = "Delete";
            deleteFileButton.UseVisualStyleBackColor = true;
            deleteFileButton.Click += DeleteFileButton_Click;
            // 
            // replaysPathTextBox
            // 
            replaysPathTextBox.BackColor = SystemColors.ControlLightLight;
            replaysPathTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            replaysPathTextBox.Location = new Point(255, 50);
            replaysPathTextBox.Name = "replaysPathTextBox";
            replaysPathTextBox.ReadOnly = true;
            replaysPathTextBox.Size = new Size(393, 31);
            replaysPathTextBox.TabIndex = 4;
            // 
            // clipsPathTextBox
            // 
            clipsPathTextBox.BackColor = SystemColors.ControlLightLight;
            clipsPathTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clipsPathTextBox.Location = new Point(255, 325);
            clipsPathTextBox.Name = "clipsPathTextBox";
            clipsPathTextBox.ReadOnly = true;
            clipsPathTextBox.Size = new Size(393, 31);
            clipsPathTextBox.TabIndex = 4;
            // 
            // replaysCountLabel
            // 
            replaysCountLabel.AutoSize = true;
            replaysCountLabel.Location = new Point(131, 260);
            replaysCountLabel.Name = "replaysCountLabel";
            replaysCountLabel.Size = new Size(41, 20);
            replaysCountLabel.TabIndex = 9;
            replaysCountLabel.Text = "Files:";
            // 
            // clipsCountLabel
            // 
            clipsCountLabel.AutoSize = true;
            clipsCountLabel.Location = new Point(131, 535);
            clipsCountLabel.Name = "clipsCountLabel";
            clipsCountLabel.Size = new Size(41, 20);
            clipsCountLabel.TabIndex = 9;
            clipsCountLabel.Text = "Files:";
            // 
            // filesMovedLabel
            // 
            filesMovedLabel.AutoSize = true;
            filesMovedLabel.Location = new Point(105, 638);
            filesMovedLabel.Name = "filesMovedLabel";
            filesMovedLabel.Size = new Size(0, 20);
            filesMovedLabel.TabIndex = 7;
            // 
            // filesDeletedLabel
            // 
            filesDeletedLabel.AutoSize = true;
            filesDeletedLabel.Location = new Point(482, 638);
            filesDeletedLabel.Name = "filesDeletedLabel";
            filesDeletedLabel.Size = new Size(0, 20);
            filesDeletedLabel.TabIndex = 7;
            // 
            // replaysListView
            // 
            replaysListView.Columns.AddRange(new ColumnHeader[] { replaysFileName, replaysDateModified, replaysFileSize });
            replaysListView.FullRowSelect = true;
            replaysListView.GridLines = true;
            replaysListView.Location = new Point(48, 106);
            replaysListView.Name = "replaysListView";
            replaysListView.Size = new Size(600, 144);
            replaysListView.TabIndex = 8;
            replaysListView.UseCompatibleStateImageBehavior = false;
            replaysListView.View = View.Details;
            // 
            // replaysFileName
            // 
            replaysFileName.Text = "File Name";
            replaysFileName.Width = 300;
            // 
            // replaysDateModified
            // 
            replaysDateModified.Text = "Date Modified";
            replaysDateModified.Width = 200;
            // 
            // replaysFileSize
            // 
            replaysFileSize.Text = "File Size";
            replaysFileSize.Width = 96;
            // 
            // clipsListView
            // 
            clipsListView.Columns.AddRange(new ColumnHeader[] { clipsFileName, clipsDateModified, clipsFileSize });
            clipsListView.FullRowSelect = true;
            clipsListView.GridLines = true;
            clipsListView.Location = new Point(48, 381);
            clipsListView.Name = "clipsListView";
            clipsListView.Size = new Size(600, 144);
            clipsListView.TabIndex = 8;
            clipsListView.UseCompatibleStateImageBehavior = false;
            clipsListView.View = View.Details;
            // 
            // clipsFileName
            // 
            clipsFileName.Text = "File Name";
            clipsFileName.Width = 300;
            // 
            // clipsDateModified
            // 
            clipsDateModified.Text = "Date Modified";
            clipsDateModified.Width = 200;
            // 
            // clipsFileSize
            // 
            clipsFileSize.Text = "File Size";
            clipsFileSize.Width = 96;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 692);
            Controls.Add(replaysFolderButton);
            Controls.Add(clipsFolderButton);
            Controls.Add(refreshReplaysButton);
            Controls.Add(refreshClipsButton);
            Controls.Add(saveFileButton);
            Controls.Add(deleteFileButton);
            Controls.Add(replaysPathTextBox);
            Controls.Add(clipsPathTextBox);
            Controls.Add(replaysCountLabel);
            Controls.Add(clipsCountLabel);
            Controls.Add(filesMovedLabel);
            Controls.Add(filesDeletedLabel);
            Controls.Add(replaysListView);
            Controls.Add(clipsListView);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Slippi Clip Collector";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button replaysFolderButton;
        private Button clipsFolderButton;
        private Button refreshReplaysButton;
        private Button refreshClipsButton;
        private Button saveFileButton;
        private Button deleteFileButton;
        private TextBox replaysPathTextBox;
        private TextBox clipsPathTextBox;
        private Label replaysCountLabel;
        private Label clipsCountLabel;
        private Label filesMovedLabel;
        private Label filesDeletedLabel;
        private ListView replaysListView;
        private ColumnHeader replaysFileName;
        private ColumnHeader replaysDateModified;
        private ColumnHeader replaysFileSize;
        private ListView clipsListView;
        private ColumnHeader clipsFileName;
        private ColumnHeader clipsDateModified;
        private ColumnHeader clipsFileSize;
    }
}
