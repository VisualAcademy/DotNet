//[?] 컬렉션 형태의 데이터를 특정 키 값으로 그룹화
using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// 그룹 알고리즘(Group Algorithm): 특정 키 값에 해당하는 그룹화된 합계 리스트 만들기
/// </summary>
class GroupAlgorithm
{
    /// <summary>
    /// 테스트용 레코드 클래스
    /// </summary>
    class Record
    {
        /// <summary>
        /// 상품명
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 수량
        /// </summary>
        public int Quantity { get; set; }
    }

    static void Main()
    {
        //[0][1] 테스트용 데이터 채우기용 로컬 함수
        List<Record> GetAll()
        {
            return new List<Record>
            {
                new Record { Name = "RADIO", Quantity = 3 },
                new Record { Name = "TV", Quantity = 1 },
                new Record { Name = "RADIO", Quantity = 2 },
                new Record { Name = "DVD", Quantity = 4 }
            };
        }

        //[0][2] 컬렉션 데이터 출력용 로컬 함수 
        void PrintData(string message, List<Record> data)
        {
            Console.WriteLine(message);
            foreach (var item in data)
            {
                Console.WriteLine($"{item.Name,5} - {item.Quantity}");
            }
        }

        //[1] Input
        List<Record> records = GetAll(); // 입력 데이터 
        List<Record> groups = new List<Record>(); // 출력 데이터
        int N = records.Count; // 의사코드

        //[2] Process: Group 알고리즘(SORT -> SUM -> GROUP)
        //[A] 그룹 정렬: SORT 
        for (int i = 0; i < N - 1; i++)
        {
            for (int j = i + 1; j < N; j++)
            {
                if (String.Compare(records[i].Name, records[j].Name) > 0)
                {
                    var t = records[i]; records[i] = records[j]; records[j] = t;
                }
            }
        }

        //[B] 그룹 소계: GROUP
        int subtotal = 0; // 소계
        for (int i = 0; i < N; i++)
        {
            subtotal += records[i].Quantity; // 같은 상품명의 수량을 누적(SUM)
            if ((i + 1) == N || // 단락(short circuiting)이면 아래 조건 무시 
                (records[i].Name != records[i + 1].Name))
            {
                //[!] 다음 레코드가 없거나, 현재 레코드와 다음 레코드가 다르면 저장
                groups.Add(new Record
                {
                    Name = records[i].Name, // 한 그룹의 키(Key) 지정
                    Quantity = subtotal // 소계
                }); // 하나의 그룹 저장

                subtotal = 0; // 하나의 그룹이 완료되면 소계 초기화
            }
        }

        //[3] Output
        PrintData("[1] 정렬된 원본 데이터: ", records);
        PrintData("[2] 이름으로 그룹화된 데이터: ", groups);
        PrintData("[3] LINQ로 그룹화된 데이터: ", records
            .GroupBy(r => r.Name).Select(g => new Record {
                Name = g.Key, Quantity = g.Sum(n => n.Quantity) }).ToList());
    }
}

// 원본 데이터를 상품명으로 그룹화: 그룹 알고리즘
// RADIO  3           DVD    4
// TV     1    -->    RADIO  5
// RADIO  2           TV     1
// DVD    4
