using System.IO;

namespace 파일처리_파일리스트_특정폴더
{
    class 파일처리_파일리스트_특정폴더
    {
        static void Main(string[] args)
        {
            //string[] fileLists = Directory.GetFiles(@"F:\동영상\");
            string[] fileLists = Directory.GetFiles(@"F:\동영상\", "*.wmv");
            for (int i = 0; i < fileLists.Length; i++)
            {
                //File.Move(fileLists[i], @"F:\파일명축소\" + 
                //    Path.GetFileNameWithoutExtension(fileLists[i]).Substring(0, 5) + ".wmv");
            }
        }
    }
}
