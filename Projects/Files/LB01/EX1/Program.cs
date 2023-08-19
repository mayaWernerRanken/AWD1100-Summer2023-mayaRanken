using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using SongSearchLibrary2;

namespace EX1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //List of songs and musicians
            List<Song> songs = new List<Song>
            {
                //new Song {Name = "", ArtistName = "", Genre = ""}
                new Song {Name = "Smells Like Teen Spirit", ArtistName = "Nirvana", Genre = "Rock"},
                new Song {Name = "Waterfalls", ArtistName = "TLC", Genre = "Hip-Hop"},
                new Song {Name = "I Saw The Light", ArtistName = "Hank Williams", Genre = "Country"},
                new Song {Name = "Rhythm Nation", ArtistName = "Janet Jackson", Genre = "Pop"},
                new Song {Name = "Sandstorm", ArtistName = "Darude", Genre = "Electronic"},
                new Song {Name = "Ode to Joy", ArtistName = "Beethoven", Genre = "Classical"}
            };

            SearchForSong(songs);
        }

        static void SearchForSong(List<Song> songs)
        {
            //Prompt user
            Console.Clear();
            Console.Write("Please enter song name, artist name, or genre name:\n\n");
            string input = Console.ReadLine();

            //LINQ search query
            var searchResult = songs.Where(x => x.Name.ToUpper() == input.ToUpper()
                                              || x.ArtistName.ToUpper() == input.ToUpper()
                                              || x.Genre.ToUpper() == input.ToUpper());

            //Check if user input matches song names in 'songs' List;
            foreach (Song song in searchResult)
            {
                //Found matching song
                if (searchResult != null)
                {
                    Console.Clear();
                    Console.WriteLine($"\nSong found:\n" +
                        $"\n{song.Name}\n" +
                        $"Artist: {song.ArtistName}\n" +
                        $"Genre: {song.Genre}");
                    Console.WriteLine("\nEnter another song? Y/N");
                    TryAgain(songs);
                    return;
                }
            }

            //Didn't find matching song
            Console.WriteLine($"\nERROR: '{input}' not found. Try again? Y/N");
            TryAgain(songs);
        }

        //Prompts user to restart application
        static void TryAgain(List<Song> songs)
        {
            string yesNo = Console.ReadLine();
            if (yesNo.ToUpper() == "Y")
            {
                SearchForSong(songs);
            }
            if (yesNo.ToUpper() == "N")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("ERROR: Invalid answer, try again.");
                TryAgain(songs);
            }
        }

    }
}
