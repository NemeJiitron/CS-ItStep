using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClassWork.CW.cw8
{
    internal class Play : IDisposable
    {
        public readonly string Title;
        public readonly string Theatre;
        public readonly string Genre;
        public readonly float Duration;
        public readonly string[] Actors;
        public Play(string title, string theatre, string genre, float dur, params string[] actors)
        {
            this.Title = title;
            this.Theatre = theatre;
            this.Genre = genre;
            this.Duration = dur;
            this.Actors = actors;
        }
        public void CreateGarbage()
        {
            for (int i = 0; i < 1000; i++)
            {
                Play p = new("", "", "", 0f, "");
            }
        }

        public void Dispose()
        {
            Console.WriteLine("Play dispose");
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder($"Title - {Title}\nTheatre - {Theatre}\nGenre - {Genre}\nDuration - {Duration}\nActors - ");
            foreach (var actor in this.Actors)
            {
                sb.Append(actor.ToString() + " ");
            }
            return sb.ToString();
        }
        ~Play() 
        {
            Console.WriteLine("Play dctor");
        }
    }
}
