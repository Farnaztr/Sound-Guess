using System;
using System.Collections.Generic;
using System.Threading;

namespace toolid
{
    class Program
    {
        static void TypeMessage(string messages, int delay = 60)
        {
            foreach (char mes in messages)
            {

                Console.Write(mes);
                Thread.Sleep(delay);
            }
        }

        static string GetValidInput(string prompt, string[] validOptions, ConsoleColor color)
        {


            while (true)
            {
                TypeMessage(prompt);
                string input = Console.ReadLine().Trim().ToLower();

                if (Array.Exists(validOptions, option => option.ToLower() == input))
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("\nInvalid input! Please choose from the given options.\n");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }
        }

        static void Main(string[] args)
        {
            string color, instrument, job;

            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(53, 6);
            TypeMessage("Welcome!!");
            Thread.Sleep(1000);
            Console.Clear();
            Console.SetCursorPosition(30, 6);
            TypeMessage("In this game, I'll tell you which song can be your favorite.", 50);
            Thread.Sleep(1000);
            TypeMessage("Ready?");
            Thread.Sleep(2000);
            Console.Clear();
            Console.SetCursorPosition(53, 6);
            TypeMessage("Let's go!!");
            Thread.Sleep(1000);
            Console.Clear();

            color = GetValidInput("\n\n Enter your favorite color between\n\n (Red, Blue, Black, Pink)\n\n Write here: ",
                                  new string[] { "red", "blue", "black", "pink" },
                                  ConsoleColor.Cyan);
            Console.Clear();
            instrument = GetValidInput("\n\n Enter your favorite instrument now\n\n (Guitar, Piano, Violin)\n\n Write here: ",
                                       new string[] { "guitar", "piano", "violin" },
                                       ConsoleColor.Green);
            Console.Clear();
            job = GetValidInput("\n\n Enter your favorite job\n\n (Engineering, Doctor, Attorney, Astronaut)\n\n Write here: ",
                                new string[] { "engineering", "doctor", "attorney", "astronaut" },
                                ConsoleColor.Yellow);

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            TypeMessage("\n  So now...\n");
            TypeMessage($"\n   Your favorite color is: {color}\n   Your favorite instrument is: {instrument}\n   Your favorite job is: {job}");
            Thread.Sleep(2000);

            Console.SetCursorPosition(30, 13);
            Console.ForegroundColor = ConsoleColor.Magenta;
            TypeMessage("Your favorite song (might) be: ");




            string song = GetSongRecommendation(color, instrument, job);

            Console.ForegroundColor = ConsoleColor.Magenta;
            TypeMessage(song);

            Console.ReadKey();
        }

            static string GetSongRecommendation(string color, string instrument, string job)
            {
                Dictionary<string, string> songRecommendations = new Dictionary<string, string>
            {
                { "red-guitar-engineering", "Hotel California - Eagles" },
                { "red-guitar-doctor", "Sweet Child O' Mine - Guns N' Roses" },
                { "red-guitar-attorney", "Stairway to Heaven - Led Zeppelin" },
                { "red-guitar-astronaut", "Space Oddity - David Bowie" },

                { "red-piano-engineering", "Clocks - Coldplay" },
                { "red-piano-doctor", "Someone Like You - Adele" },
                { "red-piano-attorney", "Bohemian Rhapsody - Queen" },
                { "red-piano-astronaut", "Fly Me to the Moon - Frank Sinatra" },

                { "red-violin-engineering", "Canon in D - Pachelbel" },
                { "red-violin-doctor", "The Four Seasons - Vivaldi" },
                { "red-violin-attorney", "Hungarian Dance - Brahms" },
                { "red-violin-astronaut", "Moonlight Sonata - Beethoven" },

                { "blue-guitar-engineering", "Wonderwall - Oasis" },
                { "blue-guitar-doctor", "Let It Be - The Beatles" },
                { "blue-guitar-attorney", "Yesterday - The Beatles" },
                { "blue-guitar-astronaut", "Rocket Man - Elton John" },

                { "blue-piano-engineering", "Comptine d'un autre été - Yann Tiersen" },
                { "blue-piano-doctor", "River Flows In You - Yiruma" },
                { "blue-piano-attorney", "Imagine - John Lennon" },
                { "blue-piano-astronaut", "Across the Stars - John Williams" },

                { "blue-violin-engineering", "Meditation - Massenet" },
                { "blue-violin-doctor", "Adagio for Strings - Barber" },
                { "blue-violin-attorney", "Swan Lake - Tchaikovsky" },
                { "blue-violin-astronaut", "Serenade - Schubert" },

                { "black-guitar-engineering", "Paranoid - Black Sabbath" },
                { "black-guitar-doctor", "Smoke on the Water - Deep Purple" },
                { "black-guitar-attorney", "Back in Black - AC/DC" },
                { "black-guitar-astronaut", "Space Truckin' - Deep Purple" },

                { "black-piano-engineering", "Nocturne - Chopin" },
                { "black-piano-doctor", "Moonlight Sonata - Beethoven" },
                { "black-piano-attorney", "Clair de Lune - Debussy" },
                { "black-piano-astronaut", "Lux Aeterna - Clint Mansell" },

                { "pink-guitar-engineering", "Like a Virgin - Madonna" },
                { "pink-guitar-doctor", "Material Girl - Madonna" },
                { "pink-guitar-attorney", "Girls Just Want to Have Fun - Cyndi Lauper" },
                { "pink-guitar-astronaut", "Starships - Nicki Minaj" },

                { "pink-piano-engineering", "Barbie Girl - Aqua" },
                { "pink-piano-doctor", "Perfect - Ed Sheeran" },
                { "pink-piano-attorney", "Love Story - Taylor Swift" },
                { "pink-piano-astronaut", "Halo - Beyoncé" }
            };

                string key = $"{color}-{instrument}-{job}";
                return songRecommendations[key];
            }
        }
    }
