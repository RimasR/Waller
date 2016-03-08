using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Waller
{
    public partial class FormWaller : Form
    {
        public FormWaller()
        {
            InitializeComponent();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            WallpaperChanger change = new WallpaperChanger(textBoxURL.Text);
        }
    }
}
