public class 데이터형과변수
{
	public static void Main()
	{
		//변수(Variable) : 메모리 상의 임시 데이터 저장 공간

		//[1] 변수 선언
		int 정수;
		//[2] 변수 초기화(할당)
		정수 = 1234;
		//[3] 변수 참조(사용)
		System.Console.WriteLine("{0}",정수);
		//[4] 변수의 데이터 타입을 반환 : GetType()
		System.Console.WriteLine("{0}",정수.GetType());
	}
}