using System;

[AttributeUsage(
    AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = true)]
public class NickNameAttribute : Attribute
{
    public string name;
    public NickNameAttribute(string name) { this.name = name; }
}
[NickName("RedPlus")]
class 특성_사용자정의특성
{
    static void Main(string[] args)
    {
        ShowMetaData();
    }
    // 특성정보 읽어오기
    private static void ShowMetaData()
    {
        Attribute[] attrs =
            Attribute.GetCustomAttributes(typeof(특성_사용자정의특성));
        foreach (var attr in attrs)
        {
            // is 연산자 사용
            if (attr is NickNameAttribute)
            {
                NickNameAttribute ais = (NickNameAttribute)attr;
                Console.WriteLine("{0}", ais.name);
            }
            // as 연산자 사용
            NickNameAttribute aas = attr as NickNameAttribute;
            if (aas != null)
            {
                Console.WriteLine("{0}", aas.name);
            }
        }
    }
}
