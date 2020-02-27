using System;
using System.Collections.Generic;
namespace 알고리즘
{
    public class ProductInfo
    {
        public string Name { get; set; }  // 상품명
        public int Quantity { get; set; } // 판매량
        public ProductInfo()
        {
            // Empty
        }
        public ProductInfo(string name, int quantity)
        {
            this.Name = name; this.Quantity = quantity;
        }
    }
    public class 그룹
    {
        public static void Main()
        {
            //[1] Input
            List<ProductInfo> lst = new List<ProductInfo>(); // 입력데이터
            List<ProductInfo> result = new List<ProductInfo>(); // 출력데이터
            #region 콘솔로부터 데이터입력
            //ProductInfo pi; string[] temp; string btn = "n";
            //do
            //{
            //    Console.Write("데이터 입력 : ");
            //    temp = Console.ReadLine().Trim().Split(' ');
            //    pi = new ProductInfo();
            //    pi.Name = temp[0].Trim().ToUpper();
            //    pi.Quantity = Convert.ToInt32(temp[1]);
            //    lst.Add(pi); // 컬렉션에 추가
            //    Console.Write("입력(y), 종료(n) : ");
            //    btn = Console.ReadLine().ToLower(); // 소문자로 y, n
            //} while (btn == "y"); 
            #endregion
            #region 기본값으로 초기화
            lst.Add(new ProductInfo("RADIO", 3));
            lst.Add(new ProductInfo("TV", 1));
            lst.Add(new ProductInfo("RADIO", 2));
            lst.Add(new ProductInfo("DVD", 4));
            #endregion
            //[2] Process
            //[A] 원본
            for (int i = 0; i < lst.Count; i++)
            {
                Console.WriteLine("{0} {1}", lst[i].Name, lst[i].Quantity);
            }
            //[B] 정렬
            ProductInfo imsi = new ProductInfo();
            for (int i = 0; i < lst.Count - 1; i++)
            {
                for (int j = i + 1; j < lst.Count; j++)
                {
                    if (String.Compare(lst[i].Name, lst[j].Name) > 0)
                    {
                        imsi = lst[i]; lst[i] = lst[j]; lst[j] = imsi;
                    }
                }
            }
            for (int i = 0; i < lst.Count; i++)
            {
                Console.WriteLine("{0} {1}", lst[i].Name, lst[i].Quantity);
            }
            //[C] 그룹
            #region 마지막레코드를 입력 후 계산
            //int subTotal = 0; // 소계
            //ProductInfo final = new ProductInfo();
            //final.Name = ""; final.Quantity = 0; 
            //lst.Add(final); // 마지막 레코드용 빈값
            //for (int i = 0; i < lst.Count - 1; i++) // 마지막 레코드(빈) 전까지 
            //{
            //    subTotal += lst[i].Quantity;
            //    if (String.Compare(lst[i].Name, lst[i + 1].Name) != 0) // 다르다면
            //    {
            //        if (lst[i].Name.Trim() != "") // 마지막 데이터가 아닐때까지
            //        {
            //            ProductInfo rlt = new ProductInfo();
            //            rlt.Name = lst[i].Name;
            //            rlt.Quantity = subTotal; // 현재까지 소계
            //            result.Add(rlt); // 한개 그룹 저장
            //            subTotal = 0; 
            //        }
            //    }
            //} 
            #endregion
            int subTotal = 0; // 소계
            for (int i = 0; i < lst.Count; i++)
            {
                subTotal += lst[i].Quantity;
                if ((i + 1) == lst.Count || // 단락(short circuiting) 
                    String.Compare(lst[i].Name, lst[i + 1].Name) != 0)
                {
                    ProductInfo rlt = new ProductInfo();
                    rlt.Name = lst[i].Name;
                    rlt.Quantity = subTotal; // 현재까지 소계
                    result.Add(rlt); // 한개 그룹 저장
                    subTotal = 0;
                }
            }
            //[3] Output
            Console.WriteLine("그룹화된 자료 출력");
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine("{0} {1}", result[i].Name, result[i].Quantity);
            }
        }
    } 
}
// 원본 데이터가 아래와 같이 들어온다면??? 
// 이 데이터를 상품명으로 그룹화하자
// RADIO  5           DVD    5
// TV     6    -->    PHONE  5
// PHONE  3           RADIO  7
// RADIO  2           TV    16
// PHONE  2    
// TV    10       
// DVD    5
