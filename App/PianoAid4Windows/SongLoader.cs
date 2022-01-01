using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace PianoAid4Windows
{
    public struct Song
    {
        public string PathToImage { get; set; }

        public string PathToMidiFile { get; set; }

    }
    class SongLoader
    {
        
        public Dictionary <string,Song> LoadSongs(string directoryPathOfSongs)
        {
            var songs = new Dictionary<string, Song>();

            var songDirectoryPaths = Directory.GetDirectories(directoryPathOfSongs);

            foreach (var songDirectoryPath in songDirectoryPaths)
            {
                var song = new Song();

                var songDirectoryName = Path.GetFileName(songDirectoryPath);    
                                
                var imageExtensions = new List<string> { "jpg", "gif", "png", "jfif" };
                var imagesInSongDirectory = Directory
                    .EnumerateFiles(songDirectoryPath, "*.*", SearchOption.TopDirectoryOnly)
                    .Where(f => imageExtensions.Contains(Path.GetExtension(f).TrimStart('.').ToLowerInvariant()));

                song.PathToImage = imagesInSongDirectory.FirstOrDefault();


                var midiExtensions = new List<string> { "mid", "midi"};
                var midiFilesInSongDirectory = Directory
                    .EnumerateFiles(songDirectoryPath, "*.*", SearchOption.TopDirectoryOnly)
                    .Where(f => midiExtensions.Contains(Path.GetExtension(f).TrimStart('.').ToLowerInvariant()));

                song.PathToMidiFile = midiFilesInSongDirectory.FirstOrDefault();

                songs.Add(songDirectoryName, song);
            }

            return songs;
        }
           
    }
}
