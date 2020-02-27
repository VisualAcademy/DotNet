namespace 확장메서드 // 기존의 형식이나 구축된 형식을 추가 메서드로 확장
{
    static class E
    {
        public static void EF(this object obj, int i) { } // 정수
        public static void EF(this object obj, string i) { } // 문자열
    }
    class A { }
    class B
    {
        public void EF(int i) { } // 일반 메서드
    }
    class C
    {
        public void EF(object obj) { } // 일반 메서드
    }
    class 확장메서드
    {
        static void Main(string[] args)
        {
            A a = new A(); a.EF(10); a.EF("안녕"); // 둘 다 확장 메서드
            B b = new B(); b.EF(100); b.EF("안녕"); // 일반, 확장 메서드
            C c = new C(); c.EF(1000); c.EF("안녕"); // 둘 다 일반 메서드
        }
    }
}
