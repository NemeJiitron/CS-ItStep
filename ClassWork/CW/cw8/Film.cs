using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.CW.cw8
{
    internal class Film : IDisposable
    {
        public readonly string Title;
        public readonly string Studio;
        public readonly string Genre;
        public readonly float Duration;
        public readonly string Date;
        public Film(string title, string studio, string genre, float dur, string date)
        {
            Title = title;
            Studio = studio;
            Genre = genre;
            Duration = dur;
            Date = date;
        }
        public override string ToString()
        {
            return $"Title - {Title}\nStudio - {Studio}\nGenre - {Genre}\nDuration - {Duration}\nDate - {Date}";
        }

        public void Dispose()
        {
            Console.WriteLine("Film dispose");
        }

        public void CreateGarbage()
        {
            for (int i = 0; i < 1000; i++)
            {
                Film f = new("", "", "", 0f, "");
            }
        }

        ~Film() 
        {
            Console.WriteLine("Film dctor");
        }
    }
}
