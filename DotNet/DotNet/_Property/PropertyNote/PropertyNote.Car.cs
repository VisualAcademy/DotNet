namespace PropertyNote
{
    public class Car
    {
        //[1] public 필드로 속성처럼 사용
        public static string Color;

        //[2] _(언더스코어) 문자로 속성에 대한 필드명 정의
        private static string _Type;

        //[3] public한 속성 정의 : 읽고 쓰기 가능한 속성
        public static string Type
        {
            get
            {
                return _Type;
            }
            set
            {
                _Type = value;
            }
        }

        //[4] 정적 개체를 생성하는 생성자
        static Car()
        {
            Color = "Red";
            _Type = "스포츠카";
        }
    }
}
