using System;

class UserRegister {
    static void Main(string[] args) {
        Console.WriteLine(IsBelow14(2002, 2, 2)); // false
        Console.WriteLine(IsBelow14(2005, 2, 2)); // true 
    }
    //[!] 만 14세 미만 체크 by (년, 월, 일)
    public static bool IsBelow14(int year, int month, int day)
    {
        // 현재 년월일과 생년월일의 차이 구하기
        var yearDiff = DateTime.Now.Year - year;
        var monthDiff = DateTime.Now.Month - month;
        var dayDiff = DateTime.Now.Day - day;

        // 년도 차이가 14이면 월과 일 차이도 체크
        if (yearDiff == 14) {
            // 월 차이가 마이너스면 아직 생일이 지나지 않은 상태
            if (monthDiff < 0) {
                return true; // 만 14세 미만
            }
            else if (monthDiff == 0) {
                if (dayDiff < 0) {
                    return true; // 만 14세 미만
                }
                else {
                    return false; // 만 14세 이상 
                }
            }
            else {
                return false; 
            }
        }
        else if (yearDiff < 14) {            
            return true; // 아직 14세 미만
        }
        else {
            return false; // 14세 이상
        }
    } // </만 14세 미만 체크> 
}
