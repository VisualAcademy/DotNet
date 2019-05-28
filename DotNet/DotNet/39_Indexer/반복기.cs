//[?] 반복기(Iterator)
// 내가 만들어 놓은 클래스 및 개체의 멤버를 호출할 때 
// foreach문을 사용하여 반복 출력되도록 설정해 놓는 구문
using System;
using System.Collections;

public class Week
{
    private string[] m_Week;
    public Week()
    {
        m_Week = new string[7];
    }
    public string this[int index]
    {
        get { return m_Week[index]; }
        set { m_Week[index] = value; }
    }
    // 반복기 구문 : iterator
    public IEnumerator GetEnumerator()
    {
        for (int i = 0; i < m_Week.Length; i++)
        {
            yield return m_Week[i];
        }
    }
}

public class 반복기
{
    public static void Main(string[] args)
    {
        Week week = new Week();
        // 인덱서
        week[0] = "Sun";
        week[1] = "Mon";
        week[2] = "Tue";
        week[3] = "Wed";
        week[4] = "Thr";
        week[5] = "Fri";
        week[6] = "Sat";
        // 반복기
        foreach (string s in week)
        {
            Console.WriteLine(s);
        }
    }
}
