// 병합(MEARGE) : 두개의 배열을 합치기(정렬하면서 합치기???)
// 오름차순으로 나열된 두 그룹의 데이터를 한 그룹의 데이터로 병합한다.
//(1) 데이터 a, b 중에 어느 한 쪽이 끝에 도달할 때까지 다음을 반복
//(2) a(i)와 b(j)를 비교해서 작은쪽을 c(k)에 복사하고 작은 쪽 번호를 +1한다.
//(3) 둘 중에 아직 끝까지 도달하지 않은 데이터를 끝까지 복사한다.
using System;

public class 병합정렬 {
    public static void Main() {
        //[1] Input : 원본 데이터가 정렬되어있다고 가정
        int[] first = {1, 3, 5 }; int[] second = { 2, 4 };
        int[] mearge = new int[first.Length + second.Length]; // MEARGE될 배열
        int i = 0; int j = 0; int k = 0;
        int M = first.Length; int N = second.Length; 
        //[2] Process
        while (i < M && j < N) {// 모두 끝에 도달할 때까지
            if (first[i] <= second[j]) {
                mearge[k++] = first[i++]; 
            }
            else {
                mearge[k++] = second[j++]; 
            }
        }
        while (i < M) {// 첫번째 배열이 끝까지 도달할 때까지
            mearge[k++] = first[i++]; 
        }
        while (j < N) {// 두번째 배열이 끝까지 도달할 때까지
            mearge[k++] = second[j++];             
        }
        //[3] Output
        for (i = 0; i < mearge.Length; i++) {
            Console.WriteLine(mearge[i]); // 1, 2, 3, 4, 5 출력되도록...
        }
    }    
}