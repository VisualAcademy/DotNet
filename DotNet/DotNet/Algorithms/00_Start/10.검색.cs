using System;

public class 이진검색 {
    public static void Main() {
        //[1] Input
        int[] data = {1, 3, 5, 7, 9 }; //[!] 오름차순 정렬되었다고 가정...
        Console.WriteLine("찾을 데이터 : ");
        int search = Convert.ToInt32(Console.ReadLine());
        bool flag = false; // 찾았으면 true 그렇지않으면 false 
        int index = -1; // 찾은 위치
        int low = 0; int mid = 0; int high = 0; // 이분탐색 관련 변수
        low = 0; high = data.Length - 1; 
        //[2] Process
        #region 순차검색
        //for (int i = 0; i < data.Length; i++)
        //{
        //    if (data[i] == search)
        //    {
        //        flag = true;
        //        index = i;
        //    }
        //} 
        #endregion
        while (low <= high) {
            mid = (low + high) / 2; // 중간값(검색할 데이터) 
            if (data[mid] == search) {
                flag = true; index = mid; break; 
            }
            if (data[mid] < search) {
                low = mid + 1;    
            }
            else {
                high = mid - 1; 
            }
        }
        //[3] Output    
        if (flag) {
            Console.WriteLine("{0}를 {1}위치에서 찾았습니다.", search, index);
        }
        else {
            Console.WriteLine("찾지 못했습니다.");
        }
    }    
}