class 알고리즘_천단위콤마 {
    static void Main() {
        int i = 0; // 인덱스
        int k = 0; // 한자리 읽어오기
        string[] a = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        string[] s = new string[11]; // 432,1
        int m = 1234;

        while (m > 0) {
            if ((i + 1) % 4 == 0) // 4번째 자리인지 확인(콤마 넣기 위해서)
            {
                s[i] = ",";
                i = i + 1; 
            }
            k = m % 10; // 1자리 읽어오기: 한자릿수 읽어오기
            s[i] = a[k];
            m = m / 10; // 1자리 지우기: 1234 -> 123
            i = i + 1;
        }           

        i = i - 1; 
        while (i >= 0) {
            System.Console.Write(s[i]);
            i = i - 1; 
        }
        System.Console.WriteLine();
    }
}
