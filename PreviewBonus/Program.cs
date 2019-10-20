using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PreviewBonus
{

    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<string> wordList = new List<string> {"שלום", "להתראות", "דינה"};
            int wordChosenIndex = rnd.Next(wordList.Count);
            string newWord = wordList[wordChosenIndex];
            Console.WriteLine(Reverse(newWord));
            int length = newWord.Length;
            Console.WriteLine(length);

            List<char> charBank = new List<char>();

            StringBuilder sb = new StringBuilder(newWord);
            for (int i=1; i<newWord.Length-1;i++){
                charBank.Add(sb[i]);
                sb[i] = '*';
            }
            string emptyWord = sb.ToString();
            Console.WriteLine(Reverse(emptyWord));

            string allLetters1Word = "קראטופשדגכעיחלזסבהנמצת";
            List<char> allLetters = new List<char>(allLetters1Word.ToCharArray());

            int howManyLeftToAdd = 20-newWord.Length;

            for (int i = 0; i<howManyLeftToAdd; i++) {
                charBank.Add(allLetters[rnd.Next(allLetters1Word.Length)]);
            }

            Console.WriteLine("Char bank:");
            List<char> shuffledCharBank = charBank.OrderBy( x => rnd.NextDouble()).ToList( );
            foreach (char c in shuffledCharBank)
            {
                Console.Write(c + ", ");
            }
        }

        public static string Reverse( string s )
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse( charArray );
            return new string( charArray );
        }
    }
}
