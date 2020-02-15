// 중첩 구조체를 사용하여 성적 리스트 출력
using System;

namespace StructPractice
{
    struct Score
    {
        public int Kor;
        public int Eng;
    }

    struct Student
    {
        public int Num;
        public string Name;
        public Score Scores; // 중첩 구조체 
    }

    class StructPractice
    {
        static void Main()
        {
            Student[] s = new Student[3];
            s[0].Num = 1; s[0].Name = "홍길동";
            s[0].Scores.Kor = 100; s[0].Scores.Eng = 90;
            s[1].Num = 2; s[1].Name = "백두산";
            s[1].Scores.Kor = 90; s[1].Scores.Eng = 80;
            s[2].Num = 3; s[2].Name = "임꺽정";
            s[2].Scores.Kor = 80; s[2].Scores.Eng = 70;

            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(
                    $"{s[i].Num} - {s[i].Name} : {s[i].Scores.Kor}, {s[i].Scores.Eng}");
            }
        }
    }
}
