using System;

class ValueReferenceDemo
{
    static void Main()
    {
        int originalValue = 10;

        // Pass by Value
        Console.WriteLine("PassByValue 실행 전: " + originalValue);
        PassByValue(originalValue);
        Console.WriteLine("PassByValue 실행 후: " + originalValue);

        // Pass by Reference
        Console.WriteLine("\nPassByReference 실행 전: " + originalValue);
        PassByReference(ref originalValue);
        Console.WriteLine("PassByReference 실행 후: " + originalValue);
    }

    // Pass by Value: 전달된 값의 복사본을 수정
    static void PassByValue(int value)
    {
        value += 10;
        Console.WriteLine("PassByValue 내부에서 수정된 값: " + value);
    }

    // Pass by Reference: 원본 값을 직접 수정
    static void PassByReference(ref int value)
    {
        value += 10;
        Console.WriteLine("PassByReference 내부에서 수정된 값: " + value);
    }
}
