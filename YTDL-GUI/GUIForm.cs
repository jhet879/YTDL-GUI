using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.WindowsAPICodePack.Shell.PropertySystem.SystemProperties.System;

namespace YTDL_GUI
{
    public partial class GUIForm : UserControl
    {
        public GUIForm()
        {
            InitializeComponent();
        }

        public event EventHandler<DownloadEventArgs> ActionTaskClicked;

        private void downloadBtn_Click(object sender, EventArgs e)
        {
            var args = new DownloadEventArgs(getURL().Text, getOutputName().Text, getOutputFormatSelect().Text);
            ActionTaskClicked?.Invoke(this, args);
        }
    }

    public class DownloadEventArgs : EventArgs
    {
        public DownloadEventArgs(string url, string outputName, string outputFormat)
        {
            URL = url;
            OutputName = outputName;
            OutputFormat = outputFormat;
        }
        public string URL { get; }
        public string OutputName { get; }
        public string OutputFormat { get; }
    }
}
