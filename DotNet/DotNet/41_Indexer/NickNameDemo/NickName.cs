using System.Collections;

namespace NickNameDemo
{
    public class NickName
    {
        //[1] 필드: 해시테이블 형식의 필드 생성 
        private Hashtable _names = new Hashtable();

        //[2] 인덱서: 문자열 매개 변수를 받고 문자열 값을 반환
        public string this[string key]
        {
            get { return _names[key].ToString(); }
            set { _names[key] = value; }
        }
    }
}
