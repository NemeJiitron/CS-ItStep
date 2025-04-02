using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2.hm.HM_12
{
    internal class Poem
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Text { get; set; }
        public string Theme { get; set; }

        public Poem(string name, string author, int year, string text, string theme)
        {
            Name = name;
            Author = author;
            Year = year;
            Text = text;
            Theme = theme;
        }
        public Poem()
        {
            Name = "name";
            Author = "author";
           Year = 2000;
            Text = "texttexttexttexttexttext";
            Theme = "theme";
        }
        public static Poem SearchBy(IEnumerable<Poem> poems, string attribute, string value)
        {
            switch (attribute)
            {
                case "name":
                    foreach (Poem poem in poems) if (poem.Name == value) return poem;
                    break;
                case "author":
                    foreach (Poem poem in poems) if (poem.Author == value) return poem;
                    break;
                case "theme":
                    foreach (Poem poem in poems) if (poem.Theme == value) return poem;
                    break;
                default:
                    break;
            }
            return null;
        }
        public static string ReportBy(IEnumerable<Poem> poems, string attribute, string value)
        {
            switch (attribute)
            {
                case "name":
                    int res = 0;
                    foreach (Poem poem in poems) if (poem.Name == value) res++;
                    return $"Poems contains {res} poems with name {value}";
                    break;
                case "author":
                    int res2 = 0;
                    foreach (Poem poem in poems) if (poem.Author == value) res2++;
                    return $"Poems contains {res2} poems with Author {value}";
                    break;
                case "theme":
                    int res3 = 0;
                    foreach (Poem poem in poems) if (poem.Author == value) res3++;
                    return $"Poems contains {res3} poems with Theme {value}";
                    break;
                case "word":
                    int res4 = 0;
                    foreach (Poem poem in poems) if (poem.Text.Contains(value)) res4++;
                    return $"Poems contains {res4} words {value}";
                    break;
                case "year":
                    int res5 = 0;
                    foreach (Poem poem in poems) if (poem.Year.ToString() == value) res5++;
                    return $"Poems contains {res5} poems wrotten in {value}";
                    break;
                default:
                    break;
            }
            return null;
        }
        public override string ToString()
        {
            return $"{Name}\n{Author}\n{Year}\n{Text}\n{Theme}\n";
        }
    }
}
