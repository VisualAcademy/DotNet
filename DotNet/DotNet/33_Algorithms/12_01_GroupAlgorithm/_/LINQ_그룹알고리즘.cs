using System;
using System.Collections.Generic;
using System.Linq;
namespace LINQ
{
    public class ProductInfo {
        public string Name { get; set; }
        public int Quantity { get; set; }
    }
    public class 그룹알고리즘 {
        public static void Main() {
            //[1] Input
            List<ProductInfo> lst = new List<ProductInfo>() {
                new ProductInfo{Name="RADIO", Quantity=3},
                new ProductInfo{Name="TV", Quantity=1},
                new ProductInfo{Name="RADIO", Quantity=2},
                new ProductInfo{Name="DVD", Quantity=5}
            };
            //[2] Process
            IEnumerable<IGrouping<string, ProductInfo>> q =
                from p in lst group p by p.Name; 
            //[3] Output
            foreach (IGrouping<string, ProductInfo> item in q) {
                Console.WriteLine("{0}", item.Key);
                foreach (ProductInfo pi in item) {
                    Console.WriteLine("상품:{0}, 판매량:{1}"
                        , pi.Name, pi.Quantity);
                }
            }
        }
    } 
}