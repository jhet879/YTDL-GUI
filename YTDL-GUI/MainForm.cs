using System.Diagnostics;
using System.Windows.Forms;

namespace YTDL_GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            GUIForm uc = new GUIForm();
            tabControl1.TabPages[0].Controls.Add(uc);
            Program.newDownloader();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == tabControl1.TabCount - 1)
            {
                // Create a new TabPage and GUIForm object
                TabPage tp = new TabPage($"DX{Program.getCounter()}");
                tp.BackColor = Color.FromArgb(unchecked((int)0xFFF9F9F9));
                GUIForm uc = new GUIForm();
                // Attach the controls, and add the tab
                tp.Controls.Add(uc);
                tabControl1.TabPages.Insert(tabControl1.TabCount - 1, tp);
                // Switch to the newly created tab
                tabControl1.SelectTab(tp);
                // Create a new downloader object for the newly created tab
                Program.newDownloader();
            }
            else {
                Debug.WriteLine($"Downloader ID: #{Program.getDownloader(tabControl1.SelectedIndex).getID()}");
            }
        }
    }
}
