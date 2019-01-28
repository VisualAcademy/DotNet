namespace ObjectInitializerNote
{
    public class Person
    {
        // propfull: 전체 속성
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        // prop: 자동으로 구현된 속성
        public int Age { get; set; }

        // 자동 속성: 속성을 자동으로 초기화(C# 6.0)
        public string Type { get; set; } = "사람";
    }
}
