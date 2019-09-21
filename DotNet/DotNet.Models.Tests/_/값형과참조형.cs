using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace 값형과참조형
{
    // 참조형 타입인 클래스 생성
    public class Person
    {
        public int ID { get; set; }          // 일련번호
        public string Name { get; set; }     // 이름
        public decimal Height { get; set; }  // 키
    }

    [TestClass]
    public class 값형과참조형
    {
        //[1] 시작
        [TestMethod]
        public void TestMethodTest()
        {
            Assert.IsTrue(true == true); // 참
        }

        //[2] Reference Type : 참조(주소) 복사 : 같은 곳을 바라본다.
        [TestMethod]
        public void ReferenceTest()
        {
            Person p1 = new Person();
            p1.ID = 1;
            p1.Name = "홍길동";
            p1.Height = 180.5M;

            Person p2 = new Person();
            p2.ID = 2;
            p2.Name = "백두산";
            p2.Height = 170.5M;

            Assert.IsFalse(object.ReferenceEquals(p1, p2)); // 같지 않다... 통과
            Assert.IsTrue(p2.Name == "백두산"); // 통과
            Assert.IsTrue(p2.ID == 2); // 통과

            // R타입에 R타입 대입
            p2 = p1;
            // 같은 곳을 바라본다. 같은 인스턴스다.
            Assert.IsTrue(object.ReferenceEquals(p1, p2)); 

            p2.ID = 10;
            Assert.IsTrue(p1.ID == 10); // 통과
        }

        //[3] Value Type : 값이 복사
        [TestMethod]
        public void ValueTest()
        {
            int x = 5;
            int y = x; // 참조 전달이 아닌 값만 전달

            y = 10;

            Assert.IsTrue(x == 5); //
            Assert.IsTrue(y == 10); // 
        }

        //[4] 메서드 매개변수 전달 방식 : Pass by Value, Pass by Reference
        [TestMethod]
        public void PassByXxx()
        {
            // 데이터 생성
            Person p = new Person();
            p.ID = 1;
            int i = 1;
            // 매개변수 전달
            DoWork(p, ref i); // 첫번째 매개변수는 값전달, 두번째 : 참조전달
            // 테스트 
            Assert.IsFalse(p.ID == 5);
            Assert.IsTrue(i == 5);
        }
        private void DoWork(Person p, ref int i)
        {
            p = new Person();
            p.ID = 5;
            i = 5; // 호출한 쪽의 데이터가 변경
        }

        //[5] 문자열 비교 : string 변수는 참조형이지만, 값형처럼 사용
        [TestMethod]
        public void StringTest()
        {
            string name = " RedPlus ";

            name = name.Trim();

            Assert.IsTrue(name.Equals("redplus",
                StringComparison.CurrentCultureIgnoreCase)); // 대소문자구분X
        }

        //[6] 배열 비교 : 참조형
        [TestMethod]
        public void ArrayTest()
        {
            string[] names = 
                { "RedPlus", "RedZero", "WhitePlus", "WhiteZero" };
            int index = Array.IndexOf(names, "BlackPlus");
            Assert.IsTrue(index == -1);

            ChangeName(names);

            Assert.IsTrue(names[0] == "RedMinus");
        }
        // string[] names
        private static void ChangeName(System.Collections.IList names) 
        {
            names[0] = "RedMinus";
        }
    }
}
