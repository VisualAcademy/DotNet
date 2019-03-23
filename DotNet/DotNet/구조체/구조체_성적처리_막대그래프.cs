// StructExam.cs와 동일 
using System;

namespace 구조체_성적처리_막대그래프
{
    struct Score
    {
        public string Name;
        public int Kor;
        public int Eng;
        public int Tot;
        public int Avg;
        public int Graph;
    }

    class 구조체_성적처리_막대그래프
    {
        static void Main()
        {
            Score[] scores = new Score[3];
            scores[0].Name = "홍길동"; scores[0].Kor = 100; scores[0].Eng = 90;
            scores[1].Name = "백두산"; scores[1].Kor = 90; scores[1].Eng = 80;
            scores[2].Name = "임꺽정"; scores[2].Kor = 90; scores[2].Eng = 70;

            for (int i = 0; i < 3; i++)
            {
                scores[i].Tot = scores[i].Kor + scores[i].Eng;
                scores[i].Avg = scores[i].Tot / 2;
                scores[i].Graph = scores[i].Avg / 5;
            }

            Console.WriteLine("이름\t 총점\t 평균\t 막대 그래프");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(
                    $"{scores[i].Name}\t {scores[i].Tot}\t {scores[i].Avg}\t");
                for (int j = 0; j < scores[i].Graph; j++)
                {
                    Console.Write("★");
                }
                Console.WriteLine();
            }
        }
    }
}
