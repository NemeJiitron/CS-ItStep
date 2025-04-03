using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2.HM_14
{
    internal class Journal
    {
        public string Name { get; set; }
        public string PubHouse { get; set; }
        public string ReleaseDate { get; set; }
        public int Pages { get; set; }
        public Article[] Articles { get; set; }
        public Journal(string name, string pubHouse, string releaseDate, int pages, Article[] arts)
        {
            Name = name;
            PubHouse = pubHouse;
            ReleaseDate = releaseDate;
            Pages = pages;
            Articles = arts;
        }
        public Journal()
        {
            Name = "";
            PubHouse = "";
            ReleaseDate = "";
            Pages = 0;
            Articles = new Article[0];
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder($"Name: {Name}. Publishing house: {PubHouse}. Release date: {ReleaseDate}. Pages: {Pages}.");
            foreach (Article article in Articles)
            {
                sb.Append(article.ToString());
            }
            return sb.ToString();
        }
    }

    internal class Article
    {
        public string Name { get; set; }
        public int Words { get; set; }
        public string Preview { get; set; }
        public Article(string name, int words, string preview)
        {
            Name = name;
            Words = words;
            Preview = preview;
        }
        public Article()
        {
            Name = "";
            Words = 0;
            Preview = "";
        }
        public override string ToString()
        {
            return $"Article name: {Name}. Number of words: {Words}. Preview: {Preview}; ";
        }
    }
}
