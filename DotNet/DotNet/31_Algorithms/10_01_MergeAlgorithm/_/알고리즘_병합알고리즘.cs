using System;

class 알고리즘_병합알고리즘
{
    static void Main(string[] args)
    {
        //[1] Input
        int[] a = { 1, 3, 5 };
        int[] b = { 2, 4 };
        int[] c = { 0, 0, 0, 0, 0 };
        int i, j, k; i = j = k = 0;
        //[2] Process : MERGE
        while (i < 3 && j < 2)
        {
            if (a[i] <= b[j])
            {
                c[k++] = a[i++];
            }
            else
            {
                c[k++] = b[j++];
            }
        }
        while (i < 3)
        {
            c[k++] = a[i++];
        }
        while (j < 2)
        {
            c[k++] = b[j++];
        }
        //[3] Output
        for (int l = 0; l < 5; l++)
        {
            Console.WriteLine(c[l]);
        }
    }
}
