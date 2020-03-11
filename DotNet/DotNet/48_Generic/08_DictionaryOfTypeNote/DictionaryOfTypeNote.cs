using System;
using System.Collections.Generic;

namespace DotNet
{
    public class DictionaryOfTypeNote
    {
        static void Main()
        {
            //[1] 키와 값으로 이루어진 Dictionary<T> 개체 생성
            Dictionary<int, double> keyValuePairs = new Dictionary<int, double>();

            //[2] 1부터 12까지 기본값으로 초기화: 배열과 달리 1부터 12까지 지정 가능
            for (int i = 1; i <= 12; i++)
            {
                keyValuePairs.Add(i, 0.0); 
            }

            //[3] 월별 전기 요금 사용량 관리
            keyValuePairs[1] = 10.01; // 1월에 10.01 kW 사용했다고 가정
            keyValuePairs[2] = 20.02; // 2월에 20.02 kW 사용했다고 가정

            //[4] 월별 사용량 출력
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"{i}월 - {keyValuePairs[i]}kW 사용");
            }
        }
    }
}
