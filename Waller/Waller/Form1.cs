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
            labelInstructions.Text = "1. Copy URL of wanted image (exaple: http://www.url.com/image.jpg) \r\n2. Paste the URL into textbox below \r\n3. Click Change.";
            labelWallpaperPath.Text = "Wallpaper folder: \r\n" + WallpaperChanger.CreateFolder(); 
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            WallpaperChanger change = new WallpaperChanger(textBoxURL.Text);
        }

        private void richTextBoxInstructions_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
