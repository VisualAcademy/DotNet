public class CarValue<T> where T : struct { } // 값타입
public class CarReference<T> where T : class { } // 참조타입
public class CarNew<T> where T : new() { } // Default 생성자
public class CarClass<T> where T : Hyundai { } // Hyundai에서 파생
public class CarInterface<T> where T : IKs { } // IKs인터페이스

public interface IKs { }
public class Hyundai { }
public class Sonata : Hyundai, IKs { }

public class 형식매개변수에대한제약조건
{
    public static void Main()
    {
        CarValue<int> c = new CarValue<int>(); // struct 성공
        CarReference<string> cs = new CarReference<string>(); // class 성공   
        CarNew<Hyundai> cn = new CarNew<Hyundai>(); // new() 성공
        CarClass<Sonata> cc = new CarClass<Sonata>(); // 사용자 정의 타입
        CarInterface<IKs> h = new CarInterface<IKs>(); // 인터페이스
    }
}
