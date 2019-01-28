//[!] 메인 클래스: ClassOne과 ClassTwo 클래스를 사용
class ClassDemo
{
    static void Main()
    {
        //[!] 다른 클래스의 멤버 호출
        //[a] 스태틱 멤버 호출
        ClassOne.Hi();  // "안녕하세요." 출력
        ClassTwo.Hi();  // "반갑습니다." 출력

        //[b] 인스턴스 멤버 호출: 클래스의 인스턴스 생성 => 개체(객체)
        ClassTwo ct = new ClassTwo();
        ct.Hello();     // "또 만나요." 출력
    }
}
