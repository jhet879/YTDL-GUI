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
            SuspendLayout();
            // 
            // URL_tb
            // 
            URL_tb.Anchor = AnchorStyles.None;
            URL_tb.Location = new Point(48, 13);
            URL_tb.Name = "URL_tb";
            URL_tb.Size = new Size(233, 23);
            URL_tb.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(11, 16);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 1;
            label1.Text = "URL:";
            // 
            // GUIForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
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
    }
}
