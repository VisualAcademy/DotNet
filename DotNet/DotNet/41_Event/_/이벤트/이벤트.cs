using System;

namespace 이벤트
{
    public class Button
    {
        //[1] 이벤트 생성을 위한 대리자 하나 생성
        public delegate void EventHandler(); // 여러개 메서드 등록 후 호출

        //[2] 이벤트 선언 : Click 이벤트 
        public event EventHandler Click;

        //[3] 이벤트 발생 메서드 : OnClick 이벤트 처리기(핸들러) 생성
        public void OnClick()
        {
            if (Click != null) // 이벤트에 등록된 값이 있다면 실행
            {
                Click(); // 대리자 형식의 이벤트 수행
            }
        }
    }

    public class 이벤트
    {
        public static void Main(string[] args)
        {
            //[1] Button 클래스의 인스턴스 생성
            Button btn = new Button();

            //[2] btn 개체의 Click 이벤트에 실행할 메서드들 등록
            btn.Click += Hi1; // btn.Click += new Button.EventHandler(Hi1);
            btn.Click += Hi2; // btn.Click += new Button.EventHandler(Hi2);

            //[3] 이벤트 처리기(발생 메서드)를 통한 이벤트 발생 : 다중 메서드 호출
            btn.OnClick();
        }
        public static void Hi1() { Console.WriteLine("안녕하세요."); }
        public static void Hi2() { Console.WriteLine("반갑습니다."); }
    }
}
