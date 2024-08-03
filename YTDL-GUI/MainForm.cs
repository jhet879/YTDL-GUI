using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace YTDL_GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            createTab();
            OutputPathLabel.Text = $"Output Path: {Program.getOutputPath()}";
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == tabControl1.TabCount - 1)
            {
                createTab();
                GUIForm gf = (GUIForm)tabControl1.SelectedTab.Controls[0];
            }
            else
            {
                Debug.WriteLine("################################");
                Debug.WriteLine($"Downloader ID: #{Program.getDownloader(tabControl1.SelectedIndex).getID()}");
                Debug.WriteLine($"Output Path: {Program.getOutputPath()}");
                GUIForm gf = (GUIForm) tabControl1.SelectedTab.Controls[0];
                Debug.WriteLine($"URL: {gf.getURL().Text}");
                Debug.WriteLine($"Output File: {gf.getOutputName().Text} Output Format: {gf.getOutputFormatSelect().Text}");
                Debug.WriteLine($"");
                Debug.WriteLine("");
            }
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            // Create a CommonOpenFileDialog (from WindowsAPICodePack NuGet package)
            // in a folder picker mode. Update the 
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = Program.getOutputPath();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                Program.setOutputPath(dialog.FileName);
                OutputPathLabel.Text = $"Output Path: {dialog.FileName}";
            }
        }

        private void createTab()
        {
            // Create a new TabPage and GUIForm object
            TabPage tp = new TabPage($"DX{Program.getCounter()}");
            tp.BackColor = Color.FromArgb(unchecked((int)0xFFF9F9F9));
            GUIForm gf = new GUIForm();
            //gf.Anchor = AnchorStyles.Left;
            gf.Dock = DockStyle.Fill;
            gf.AutoScaleMode = AutoScaleMode.None;
            gf.getOutputFormatSelect().SelectedIndex = 0;
            // Attach the controls, and add the tab
            tp.Controls.Add(gf);
            tabControl1.TabPages.Insert(tabControl1.TabCount - 1, tp);
            // Switch to the newly created tab
            tabControl1.SelectTab(tp);
            // Create a new downloader object for the newly created tab
            Program.newDownloader();
        }
    }
}
