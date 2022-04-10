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
    public partial class PlaylistItemsForm : Form
    {
        public PlaylistItemsForm()
        {
            InitializeComponent();
        }

        private void PlaylistItemsForm_Load(object sender, EventArgs e)
        {
            var items = PlaylistManager.getItems();
            listBox1.Items.Clear();

            foreach(var item in items)
            {
                listBox1.Items.Add(string.Format("{0} - {1} - {2}", item.Artist, item.Album, item.Title));
            }
        }
    }
}
