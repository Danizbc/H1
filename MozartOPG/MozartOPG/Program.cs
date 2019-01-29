using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Threading;

namespace MozartOPG
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating an random.
            Random ran = new Random();
            //by using system.media i can get access to sound player.
            SoundPlayer MusicPlayer = new SoundPlayer();
            //Making 2 list of strings
            List<string> MusicString = new List<string>();
            List<string> TrieonString = new List<string>();

            //Adding all Music files
            for (int i = 1; i < 177; i++)
            {
                MusicString.Add("M" + i);
            }
            for (int i = 1; i < 97; i++)
            {
                TrieonString.Add("T" + i);
            }
            //playing music for ever, you cant escape Mozart. u could close the Console but that's cheating.
            while (true)
            {
                MusicPlayer.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + $"\\{MusicString[ran.Next(0, MusicString.Count)]}.wav";
                MusicPlayer.PlaySync();
                MusicPlayer.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + $"\\{TrieonString[ran.Next(0, TrieonString.Count)]}.wav";
                MusicPlayer.PlaySync();
            }
        }
    }
}
