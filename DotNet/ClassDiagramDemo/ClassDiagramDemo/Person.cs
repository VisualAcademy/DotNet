namespace ClassDiagramDemo
{
    // 클래스
    public class Person
    {
        // 속성
        public string Name { get; set; }

        public int Age
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        // 메서드
        public bool Update() 
        {
            return false;
        }
    }
}
