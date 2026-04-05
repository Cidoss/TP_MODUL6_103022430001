using System;
using System.Collections.Generic;
using System.Text;

namespace TP_MODUL6_103022430001
{
    public class SayaMusicTrack
    {
        int id;
        int playCount;
        string title;

        public SayaMusicTrack(string title)
        {
            this.title = title;
            Random rdm = new Random();
            this.id = rdm.Next(10000, 100000);
            this.playCount = 0;
        }
        public void IncreasePlayCount(int count)
        {
            
            this.playCount += count;
        }
        public void PrintTrackDetails()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Music Track:");
            Console.WriteLine("ID : " + id);
            Console.WriteLine("Title: " + title);
            Console.WriteLine($"Play Count: " + playCount);
            Console.WriteLine("-----------------------------------");
        }

    }
}
