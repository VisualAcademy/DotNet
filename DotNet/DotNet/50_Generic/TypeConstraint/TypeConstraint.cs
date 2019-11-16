public interface IKs { }
public class GoodCar { }
public class BadCar { public BadCar(string message) { } }
public class OfficeCamper : GoodCar, IKs { }
public class CarValue<T> where T : struct { } // 값 형식만
public class CarReference<T> where T : class { } // 참조 형식만
public class CarNew<T> where T : new() { } // Default 생성자
public class CarClass<T> where T : GoodCar { } // GoodCar에서 파생
public class CarInterface<T> where T : IKs { } // IKs인터페이스

public class TypeConstraint
{
    public static void Main()
    {
        CarValue<int> c = new CarValue<int>(); // struct 성공
        CarReference<string> cs = new CarReference<string>(); // class 성공   
        CarNew<GoodCar> cn = new CarNew<GoodCar>(); // new() 성공
        CarClass<OfficeCamper> cc = new CarClass<OfficeCamper>(); // 사용자 정의 타입
        CarInterface<IKs> h = new CarInterface<IKs>(); // 인터페이스 지정
    }
}
