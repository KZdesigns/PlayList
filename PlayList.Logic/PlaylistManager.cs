using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayList.Data.SongDataSetTableAdapters;

namespace PlayList.Logic
{
    public class PlaylistManager
    {
        public static void AddItem(PlaylistItem item)
        {
            var adapter = new SongTableAdapter();
            adapter.Insert(item.Title, item.Artist, item.Album);
        }

        public static List<PlaylistItem> getItems()
        {
            var adapter = new SongTableAdapter();
            var results = new List<PlaylistItem>();
            var rows = adapter.GetData();

            foreach(var row in rows)
            {
                var item = new PlaylistItem();
                item.Title = row.Title;
                item.Album = row.Album;
                item.Artist = row.Artist;
                item.Id = row.Id;

                results.Add(item);
            }

            return results;
        }
    }
}
