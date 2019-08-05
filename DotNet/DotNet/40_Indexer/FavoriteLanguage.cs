//[?] 이터레이터(반복기; Iterator): 개체의 값들을 foreach문으로 반복해서 사용 
using System;
using System.Collections;

namespace FavoriteLanguage
{
    public class Language
    {
        //[1] 필드
        private string[] languages;
        //[2] 생성자
        public Language(int length)
        {
            languages = new string[length];
        }
        //[3] 인덱서
        public string this[int index]
        {
            get { return languages[index]; }
            set { languages[index] = value; }
        }
        //[4] 반복기(이터레이터)
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < languages.Length; i++)
            {
                yield return languages[i]; 
            }
        }
    }

    class FavoriteLanguage
    {
        static void Main()
        {
            //[A] 클래스의 인스턴스 생성 
            var language = new Language(2);

            //[B] 정수 형식의 인덱서로 문자열 값 저장
            language[0] = "C#";
            language[1] = "TypeScript";

            //[C] foreach 문을 사용하여 배열의 값을 출력 
            foreach (var lang in language)
            {
                Console.WriteLine(lang); 
            }
        }
    }
}
