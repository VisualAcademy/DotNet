using System.Collections;
using System.Collections.Generic;

namespace 제네릭_장점
{
    class 제네릭_장점
    {
        static void Main(string[] args)
        {
            //[1] 제네릭 사용 전
            Stack s1 = new Stack();
            s1.Push(1234);
            int i1 = (int)s1.Pop(); // cast 필요

            //[2] 제네릭 사용 후
            Stack<int> s2 = new Stack<int>();
            s2.Push(2345);
            int i2 = s2.Pop(); // cast 불필요

            //[3] 장점 1: 타입 안정성
            Stack o = new Stack();
            o.Push(1234);
            o.Push("Hello");
            object oo = o.Pop(); // 가능

            Stack<int> i = new Stack<int>();
            i.Push(1234);
            //i.Push("Bye"); // 컴파일 타임 에러

            //[4] 장점 2: 성능 향상
            Stack stack = new Stack();
            stack.Push(1234); // 1234(값형) to object(참조형) : 박싱(Boxing) : 포장
            int iStack = (int)stack.Pop(); // 참조형 to 값형 : 언박싱(UnBoxing)
        }
    }
}
