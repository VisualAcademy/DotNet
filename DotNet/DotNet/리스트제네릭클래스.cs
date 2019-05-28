using System;
using System.Collections.Generic;

public class ProductInfo
{
    // 상품명
    public string MedelName { get; set; }
    // 판매량
    public int Quantity { get; set; }

    // 생성자
    public ProductInfo()
    {
        // Empty
    }
    public ProductInfo(string modelName, int quantity)
    {
        this.MedelName = modelName;
        this.Quantity = quantity;
    }
}

class 리스트제네릭클래스
{
    static void Main(string[] args)
    {
        // 정수형
        List<int> su = new List<int>();
        su.Add(10); su.Add(20); su.Add(30);
        for (int i = 0; i < su.Count; i++)
        {
            Console.WriteLine("{0}", su[i]);
        }
        // 문자열
        List<string> str = new List<string>();
        str.Add("안녕"); str.Add("반가워"); str.Add("또봐");
        for (int i = 0; i < str.Count; i++)
        {
            Console.WriteLine("{0}", str[i]);
        }
        // 개체형(테이블형태) : 문자열, 정수
        List<ProductInfo> lstProduct = new List<ProductInfo>();

        ProductInfo pi1 = new ProductInfo(); //[1] 속성 사용
        pi1.MedelName = "TV"; pi1.Quantity = 10;
        lstProduct.Add(pi1);

        lstProduct.Add(new ProductInfo("RADIO", 5)); //[2] 생성자

        //[3] 컬렉션/개체 초기화자
        lstProduct.Add(new ProductInfo() { MedelName = "DVD", Quantity = 3 });

        // 출력 : 윈폼/웹폼에서는 DataSouce 개념 적용
        for (int i = 0; i < lstProduct.Count; i++)
        {
            Console.WriteLine("{0}, {1}"
                , lstProduct[i].MedelName, lstProduct[i].Quantity);
        }
    }
}
