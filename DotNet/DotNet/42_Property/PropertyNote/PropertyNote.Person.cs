using System;

namespace PropertyNote
{
    public class Person
    {
        private int _BirthYear; // 생년월일

        public string Name { get; set; } // 이름 

        // 쓰기 전용: 계산식 사용
        public int BirthYear
        {
            set
            {
                if (value >= 1900)
                {
                    _BirthYear = value;
                }
                else
                {
                    _BirthYear = 0;
                }
            }
        }

        // 읽기 전용: 계산식 사용
        public int Age
        {
            get
            {
                return (DateTime.Now.Year - _BirthYear);
            }
        }

        public Person(string name)
        {
            Name = name; // Name 속성에 넘겨온 name 매개변수 값 저장
        }
    }
}
