using System;

public class ButtonClass
{
    //[1] 이벤트 생성을 위한 대리자 하나 생성
    public delegate void EventHandler(); // 여러 개 메서드 등록 후 호출 가능

    //[2] 이벤트 선언: Click 이벤트 
    public event EventHandler Click;

    //[3] 이벤트 발생 메서드: OnClick 이벤트 처리기(핸들러) 생성
    public void OnClick()
    {
        if (Click != null) // 이벤트에 등록된 값이 있는지 확인(생략 가능)
        {
            Click(); // 대리자 형식의 이벤트 수행
        }
    }
}

class EventDemo
{
    static void Main()
    {
        //[A] Button 클래스의 인스턴스 생성
        ButtonClass btn = new ButtonClass();

        //[B] btn 개체의 Click 이벤트에 실행할 메서드들 등록
        btn.Click += Hi1; // btn.Click += new ButtonClass.EventHandler(Hi1);
        btn.Click += Hi2; // btn.Click += new ButtonClass.EventHandler(Hi2);

        //[C] 이벤트 처리기(발생 메서드)를 통한 이벤트 발생: 다중 메서드 호출
        btn.OnClick();
    }
    static void Hi1() => Console.WriteLine("C#");
    static void Hi2() => Console.WriteLine(".NET");
}
