// Int32(int) 구조체를 모방한 Number 클래스 설계 연습
using System;

namespace 클래스설계연습
{
    //[1] 클래스
    public class Number
    {
        //[2] MaxValue 상수 선언
        public const int MaxValue = int.MaxValue;
        //[3] MinValue 읽기전용 필드 선언
        public static readonly int MinValue = int.MinValue;
        //[4] 생성자
        public Number() { }
        public Number(int i) { this.m_value = i; }
        //[5] 필드 선언
        private int m_value;
        //[6] 속성 선언
        public int Value
        {
            get { return m_value; }
            set { this.m_value = value; }
        }
        //[7] 변환연산자 선언 : new Number(); 생략
        public static implicit operator Number(int i)
        {
            return new Number(i);
        }
        //[8] 단항연산자 오버로드
        public static Number operator ++(Number i)
        {
            return ++i.m_value;
        }
        //[9] 이항연산자 오버로드
        public static Number operator +(Number a, Number b)
        {
            return a.m_value + b.m_value;
        }
        //[10] ToString 메서드 오버라이드
        public override string ToString()
        {
            return m_value.ToString();
        }
    }

    class 클래스설계연습
    {
        static void Main(string[] args)
        {
            Number j = new Number(10);
            Number i = 10;//[1] 변환연산자 구현

            j.Value = ++j.Value;
            ++i; // Number.operator++(i); //[2] 단항 연산자 오버로드

            j.Value = j.Value + 10;
            i = i + 10; //[3] 이항 연산자 오버로드

            Console.WriteLine(j.Value);
            Console.WriteLine(i);//21 //[4] ToString() 메서드 오버라이드
        }
    }
}
