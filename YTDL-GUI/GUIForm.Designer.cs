namespace YTDL_GUI
{
    partial class GUIForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            URL_tb = new TextBox();
            label1 = new Label();
            label2 = new Label();
            outputName = new TextBox();
            outputFormatSelect = new ComboBox();
            downloadBtn = new Button();
            SuspendLayout();
            // 
            // URL_tb
            // 
            URL_tb.Anchor = AnchorStyles.None;
            URL_tb.Location = new Point(48, 20);
            URL_tb.Name = "URL_tb";
            URL_tb.Size = new Size(233, 23);
            URL_tb.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(11, 23);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 1;
            label1.Text = "URL:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(11, 51);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 2;
            label2.Text = "Output Name:";
            // 
            // outputName
            // 
            outputName.Anchor = AnchorStyles.None;
            outputName.Location = new Point(100, 48);
            outputName.Name = "outputName";
            outputName.Size = new Size(125, 23);
            outputName.TabIndex = 3;
            // 
            // outputFormatSelect
            // 
            outputFormatSelect.Anchor = AnchorStyles.None;
            outputFormatSelect.FormattingEnabled = true;
            outputFormatSelect.Items.AddRange(new object[] { ".mp4", ".mp3" });
            outputFormatSelect.Location = new Point(231, 48);
            outputFormatSelect.Name = "outputFormatSelect";
            outputFormatSelect.Size = new Size(50, 23);
            outputFormatSelect.TabIndex = 4;
            // 
            // downloadBtn
            // 
            downloadBtn.Anchor = AnchorStyles.None;
            downloadBtn.Location = new Point(206, 76);
            downloadBtn.Name = "downloadBtn";
            downloadBtn.Size = new Size(75, 23);
            downloadBtn.TabIndex = 5;
            downloadBtn.Text = "Download";
            downloadBtn.UseVisualStyleBackColor = true;
            downloadBtn.Click += downloadBtn_Click;
            // 
            // GUIForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(downloadBtn);
            Controls.Add(outputFormatSelect);
            Controls.Add(outputName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(URL_tb);
            MinimumSize = new Size(300, 150);
            Name = "GUIForm";
            Size = new Size(300, 150);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox URL_tb;

        public TextBox getURL()
        {
            return URL_tb;
        }

        private Label label1;
        private Label label2;
        private TextBox outputName;

        public TextBox getOutputName()
        {
            return outputName;
        }

        private ComboBox outputFormatSelect;

        public ComboBox getOutputFormatSelect()
        {
            return outputFormatSelect;
        }

        private Button downloadBtn;
    }
}
