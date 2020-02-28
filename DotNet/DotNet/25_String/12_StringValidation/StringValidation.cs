//[?] 문자열 변수에 대한 유효성 검사를 진행하는 3가지 방법 정리
class StringValidation
{
    static void Main()
    {
        //[!] 문자열 유효성 검사
        string userName = "a_b_c";

        //[1] 빈값(Empty)과 널값(null) 확인 
        userName = null;
        if (userName != "" && userName != null)
        {
            var s = userName.Split('_'); // null일 때 에러 발생
        }

        //[2] [1]번과 동일한 표현 방법
        userName = "";
        if (!string.IsNullOrEmpty(userName))
        {
            var s = userName.Split('_');
        }

        //[3] ([1][2]) + "공백"까지 처리
        userName = " ";
        if (!string.IsNullOrWhiteSpace(userName))
        {
            var s = userName.Split('_');
        }
    }
}
