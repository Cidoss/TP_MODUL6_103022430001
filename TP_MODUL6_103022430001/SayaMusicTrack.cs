using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace TP_MODUL6_103022430001
{
    public class SayaMusicTrack
    {
        int id;
        int playCount;
        string title;

        public SayaMusicTrack(string title)
        {
            Debug.Assert(title != null, "Judul track tidak boleh null!");
            Debug.Assert(title.Length <= 100, "Judul track maksimal 100 karakter!");

            this.title = title;
            Random rdm = new Random();
            this.id = rdm.Next(10000, 100000);
            this.playCount = 0;
        }
        public void IncreasePlayCount(int count)
        {
            Debug.Assert(count <= 10000000, "Input penambahan maksimal 10.000.000!");

            try
            {
                checked
                {
                    this.playCount += count;
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"Total play count : " + count + " melebihi batas maksimal.");
                Console.WriteLine($"Detail Sistem: {ex.Message}");
                Console.WriteLine($"Play count tetap di: {this.playCount}");
            }
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
