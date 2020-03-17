// 구조체를 사용하여 하나의 변수로 여러 개의 변수를 묶어서 관리
using System;

class StructVariable
{
    static void Main()
    {
        // 구조체 형식 변수 선언
        Product product;
        // 구조체 변수의 각각의 멤버에 값을 할당 
        product.Id = 1;
        product.Title = "좋은 책";
        product.Price = 10000M;
        // 구조체 형식 변수 사용
        string message = 
            $"번호: {product.Id}\n상품명: {product.Title}\n가격: {product.Price}";
        Console.WriteLine(message);
    }
}

// 3개의 멤버(Member)를 가지는 Product 구조체 선언
struct Product
{
    // 구조체의 멤버가 되는 변수들은
    // public 액세스 한정자(Access Modifier)를 붙여서 외부에서 사용 가능하도록 설정
    public int Id; // 상품번호
    public string Title; // 상품명
    public decimal Price; // 가격
}
