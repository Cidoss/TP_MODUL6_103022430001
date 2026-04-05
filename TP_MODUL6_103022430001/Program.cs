// See https://aka.ms/new-console-template for more information
using System;
namespace TP_MODUL6_103022430001
{
    class Program
    {
        static void Main(string[] args)
        {
            SayaMusicTrack track1 = new SayaMusicTrack("Pirates of the Carabian");

            track1.IncreasePlayCount(100);
            track1.IncreasePlayCount(2500);

            track1.PrintTrackDetails();

            Console.ReadLine();
        }
    }
}