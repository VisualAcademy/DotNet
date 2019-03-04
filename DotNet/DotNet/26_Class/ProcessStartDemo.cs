using System.Diagnostics;

namespace DotNet
{
    class ProcessStartDemo
    {
        static void Main()
        {
            //[1] 메모장을 실행합니다. 
            Process.Start("Notepad.exe"); 
            //[2] 웹 브라우저를 열고 매개 변수로 URL을 절달합니다.
            Process.Start("Explorer.exe", "https://dotnetkorea.com"); 
        }
    }
}
