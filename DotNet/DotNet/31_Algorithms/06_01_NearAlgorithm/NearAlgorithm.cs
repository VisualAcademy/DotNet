//[?] 원본 데이터 중에서 대상 데이터와 가장 가까운 값
using System;
using System.Linq;
using static System.Console;

/// <summary>
/// 근삿값 알고리즘(Near Algorithm): 가까운 값 -> 차잇값의 절댓값의 최솟값
/// </summary>
class NearAlgorithm
{
    static void Main()
    {
        //[0] 절댓값 구하기 로컬 함수: Math.Abs() 함수와 동일한 기능을 구현해 봄
        int Abs(int number) => (number < 0) ? -number : number;

        //[1] Initialize
        int min = int.MaxValue; // 차잇값의 절댓값 중 최솟값이 담길 그릇

        //[2] Input: 2진수와 16진수로 표현({ 10, 20, 30, 27, 17 }) 
        int[] numbers = { 0b1010, 0x14, 0b11110, 0x1B, 0b10001 }; 
        int target = 25; // target과 가까운 값
        int near = default; // 가까운 값: 27

        //[3] Process: NEAR
        for (int i = 0; i < numbers.Length; i++)
        {
            int abs = Abs(numbers[i] - target); // 차잇값의 절댓값
            if (abs < min)
            {
                min = abs; // MIN: 최솟값 알고리즘
                near = numbers[i]; // NEAR: 차잇값의 절댓값 중 최솟값일 때의 값
            }
        }

        //[4] Output
        var minimum = numbers.Min(m => Math.Abs(m - target));
        var closest = numbers.First(c => Math.Abs(target - c) == minimum);
        WriteLine($"{target}와/과 가장 가까운 값(식): {closest}(차이: {minimum})");
        WriteLine($"{target}와/과 가장 가까운 값(문): {near}(차이: {min})");
    }
}

//numbers.First(c => Math.Abs(c - target) == numbers.Min(m => Math.Abs(m - target)))
//27
