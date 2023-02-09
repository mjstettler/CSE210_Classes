using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureMemory
{
    class Verse
    {
        public string Text { get; set; }
        public List<string> Words { get; set; }

        public Verse(string text)
        {
            Text = text;
            Words = text.Split(' ').ToList();
        }

        public void HideWord()
        {
            Random random = new Random();
            int index = random.Next(Words.Count);
            string word = Words[index];
            Words[index] = new string('_', word.Length);
        }
    }

    class Scripture
    {
        public List<Verse> Verses { get; set; }

        public Scripture(List<Verse> verses)
        {
            Verses = verses;
        }

        public void DisplayVerse(Verse verse)
        {
            Console.WriteLine(verse.Text);
        }

        public void DisplayHiddenVerse(Verse verse)
        {
            Console.WriteLine(string.Join(" ", verse.Words));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Verse> verses = new List<Verse>
            {
                new Verse("For God so loved the world that he gave his one and only Son,"),
                new Verse("that whoever believes in him shall not perish but have eternal life."),
                new Verse("For God did not send his Son into the world to condemn the world,"),
                new Verse("but to save the world through him.")
            };
            Scripture scripture = new Scripture(verses);

            Console.WriteLine("Memorize the following scripture verses:");
            Console.WriteLine();

            foreach (Verse verse in scripture.Verses)
            {
                scripture.DisplayVerse(verse);
                Console.WriteLine();
                Console.ReadLine();
                Console.Clear();

                verse.HideWord();
                scripture.DisplayHiddenVerse(verse);
                Console.WriteLine();
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
