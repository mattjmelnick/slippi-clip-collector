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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            button5 = new Button();
            button6 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(44, 33);
            button1.Name = "button1";
            button1.Size = new Size(173, 66);
            button1.TabIndex = 0;
            button1.Text = "Select Replays Folder";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(44, 308);
            button2.Name = "button2";
            button2.Size = new Size(173, 66);
            button2.TabIndex = 1;
            button2.Text = "Select Clips Folder";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(84, 581);
            button3.Name = "button3";
            button3.Size = new Size(137, 53);
            button3.TabIndex = 2;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(467, 581);
            button4.Name = "button4";
            button4.Size = new Size(137, 53);
            button4.TabIndex = 3;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlLightLight;
            textBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(251, 49);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(393, 31);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ControlLightLight;
            textBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(251, 324);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(393, 31);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(44, 105);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(600, 144);
            listBox1.TabIndex = 5;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(44, 380);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(600, 144);
            listBox2.TabIndex = 5;
            // 
            // button5
            // 
            button5.Location = new Point(44, 255);
            button5.Name = "button5";
            button5.Size = new Size(67, 29);
            button5.TabIndex = 6;
            button5.Text = "Refresh";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(44, 530);
            button6.Name = "button6";
            button6.Size = new Size(67, 29);
            button6.TabIndex = 6;
            button6.Text = "Refresh";
            button6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 637);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 7;
            label1.Text = "10 Files Saved";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(478, 637);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 7;
            label2.Text = "10 Files Deleted";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 692);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Slippi Clip Collector";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private TextBox textBox2;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button button5;
        private Button button6;
        private Label label1;
        private Label label2;
    }
}
