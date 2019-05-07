using System.IO;

class 파일처리_폴더의_모든파일명_일괄변경
{
    static void Main(string[] args)
    {
        DirectoryInfo d = new DirectoryInfo(@"H:\C#_");
        FileInfo[] infos = d.GetFiles();
        foreach (FileInfo f in infos)
        {
            File.Move(f.FullName, "H:\\C#\\" + f.Name.Substring(0, 8) + ".wmv");
        }
    }
}
