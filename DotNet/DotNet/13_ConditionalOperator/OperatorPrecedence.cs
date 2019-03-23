// C#의 연산자 우선 순위: 괄호(그룹) > 곱셈/나눗셈 > 덧셈/뺄셈 > 왼쪽에서 오른쪽
using static System.Console;

class OperatorPrecedence
{
    static void Main()
    {
        WriteLine(3 + 4 * 2); // 곱하기가 우선: 3 * 8 => 11
        WriteLine((3 + 4) * 2); // 괄호가 우선: 7 * 2 => 14
        WriteLine(10 / 5 * 2 + 1); // 왼쪽에서 오른쪽으로: 2 * 2 + 1 => 5
        WriteLine(15 / (5 * (2 + 1))); // 안쪽 괄호가 우선: 15 / (5 * 3) => 1
    }
}
