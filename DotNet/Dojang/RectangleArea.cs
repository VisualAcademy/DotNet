using System;

class RectangleArea
{
    // 직사각형의 넓이를 계산하는 함수
    static int CalcRectangleArea(int width, int height)
    {
        return width * height; // 가로 * 세로
    }

    static void Main()
    {
        int width, height;

        // 사용자로부터 직사각형의 가로와 세로 길이를 입력받음
        Console.Write("직사각형의 가로와 세로 길이를 입력하세요:\n");
        width = Convert.ToInt32(Console.ReadLine());
        height = Convert.ToInt32(Console.ReadLine());

        // 계산된 넓이를 출력
        Console.WriteLine("직사각형의 넓이: {0}", CalcRectangleArea(width, height));
    }
}
