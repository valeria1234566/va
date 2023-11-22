using System;
using System.Collections.Generic;
using System.Linq;

namespace MusicLibrary
{
    // Класс "Трек"
    public class Track
    {
        public string Title { get; set; }
        public string Album { get; set; }
        
        public Track(string title, string album)
        {
            Title = title;
            Album = album;
        }
    }

    public class TrackList : List<Track>{
        public void PrintSortedTrack(string Album){
            LINQ = from Track in this where (Track.Album==Album) OrderBy Track.Title select Track;
            Console.WriteLine($"Треки из альбома {Album}, упорядоченные по алфавиту:");
            foreach (Track track in LINQ)
            {
                Console.WriteLine($"Название: {track.Title}, Альбом: {track.Album}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создаем экземпляр коллекции треков

            var tracks = new TrackList{
                new Track("Song 1", "Album B"),
                new Track("Song 2", "Album A"),
                new Track("Song 3", "Album C"),
                new Track("Song 4", "Album B"),
                new Track("Song 5", "Album A")
            };

            tracks.PrintSortedTrack("Album A");
    }
}
```