// https://www.youtube.com/watch?v=kvxlJrqc5wM 
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace SOLID
{
    public class Journal
    {
        private readonly List<string> entries = new List<string>();

        private static int count = 0;

        public int AddEntry(string text)
        {
            entries.Add($"{++count}: {text}");
            return count; // memento
        }

        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries); 
        }

        // 영구적으로 저장하는 로직은 따로 빼자
        //public void Save(string filename)
        //{
        //    File.WriteAllText(filename, ToString());
        //}
    }

    public class Persistence
    {
        public void SaveToFile(Journal j, string filename, bool overwrite = false)
        {
            if (overwrite || !File.Exists(filename))
            {
                File.WriteAllText(filename, j.ToString());
            }
        }
    }
    
    public class SingleResponsibilityPrinciple
    {
        static void Main(string[] args)
        {
            var j = new Journal();
            j.AddEntry("ASP.NET");
            j.AddEntry("Blazor");
            j.AddEntry("C#");
            Console.WriteLine(j);

            var p = new Persistence();
            var filename = @"C:\temp\journal.txt";
            p.SaveToFile(j, filename, true);
            Process.Start(filename); 
        }
    }
}
