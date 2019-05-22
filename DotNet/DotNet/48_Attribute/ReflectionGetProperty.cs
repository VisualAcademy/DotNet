using System;
using System.Reflection;

namespace ReflectionGetProperty
{
    class Person
    {
        [Obsolete] public string Name { get; set; }
    }

    class ReflectionGetProperty
    {
        static void Main()
        {
            // Name 속성의 정보 얻기
            PropertyInfo pi = typeof(Person).GetProperty("Name");

            // Name 속성에 적용된 특성 읽어오기
            object[] attributes = pi.GetCustomAttributes(false);
            foreach (var attr in attributes)
            {
                // 특성의 이름들 출력
                Console.WriteLine("{0}", attr.GetType().Name);
            }
        }
    }
}
