using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlayList.Logic;

namespace PlayList.UI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var item = new PlaylistItem();
            item.Title = textBoxTitle.Text;
            item.Album = textBoxAlbum.Text;
            item.Artist = textBoxArtist.Text;

            PlaylistManager.AddItem(item);

            textBoxTitle.Text = "";
            textBoxArtist.Text = "";
            textBoxAlbum.Text = "";
        }

        private void playListItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var itemsForm = new PlaylistItemsForm();
            itemsForm.ShowDialog();
        }
    }
}
