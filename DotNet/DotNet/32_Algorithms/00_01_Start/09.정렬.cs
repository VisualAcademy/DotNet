// 정렬(SORT) : 순서대로 정렬시키는 알고리즘
// 오름차순(Ascending)정렬 : 1, 2, 3, ABC 순
// 내림차순(Descending)정렬 : 3, 2, 1, 다나가 순
// 종류 : 선택정렬, 버블정렬, 퀵정렬, 삽입, 기수, ...
using System;

public class 선택정렬 {
    public static void Main() {
        //[1] Input
        int[] data = {7, 5, 6, 1, 10 }; 
        //[2] Process : Selection Sort
        int temp = 0; // 데이터 Swap용 임시 변수
        for (int i = 0; i < data.Length - 1; i++) {
            for (int j = i + 1; j < data.Length; j++) {
                if (data[i] > data[j]) {
                    temp = data[i];
                    data[i] = data[j];
                    data[j] = temp; 
                }    
            }
            ShowArray(data); // 현재 i번째 데이터 출력
        }
        //[3] Output
        for (int i = 0; i < data.Length; i++) {
            Console.Write("{0} ", data[i]); // 5 6 7 출력되도록
        } Console.WriteLine();
    }
    private static void ShowArray(int[] data) {
        for (int i = 0; i < data.Length; i++) {
            Console.Write("{0} ", data[i]);
        } Console.WriteLine();
    }    
}