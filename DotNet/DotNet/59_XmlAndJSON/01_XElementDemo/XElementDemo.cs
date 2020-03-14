//[?] XElement 클래스: XML 요소를 생성하거나 담을 수 있는 그릇
using System;
using System.Linq;
using System.Xml.Linq;

class XElementDemo
{
    static void Main()
    {
        //[1] XML 요소 생성
        XElement category = new XElement("Menus",
            new XElement("Menu", "책"),
            new XElement("Menu", "강의"),
            new XElement("Menu", "컴퓨터")
        );
        Console.WriteLine(category);

        //[2] XML 요소 가공
        XElement newCategory = new XElement("Menus",
            from node in category.Elements()
            where node.Value.ToString().Length >= 2
            select node
        );
        Console.WriteLine(newCategory);
    }
}
