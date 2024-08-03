using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTDL_GUI
{
    internal class Downloader
    {
        private int id;

        public Downloader(int id)
        {
            this.id = id;
        }

        public int getID()
        {
            return id;
        }
    }
}
