using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordle
{
    static class Count
    {
        public static int counter;
    }
    static class Word
    {
        public static string word = "DIRGE";

        public static string[] words = new string[] {"DIRGE","ATONE","THERE","THREE","PORTS","FUDGE", "GOALS", "PLACE", "CRANE", "PILOT"};
    }

    static class Guesses
    {
        public static Label[] guessOne;
        public static Label[] guessTwo;
        public static Label[] guessThree;
        public static Label[] guessFour;
        public static Label[] guessFive;
        public static Label[] guessSix;

    }
    static class WinStatus
    {
        public static bool won;
    }
    static class Generated
    {
        public static bool gen;
    }
}
