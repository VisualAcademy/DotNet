using System;

class ForIfContinuePicture
{
    static void Main()
    {

        for (int i = 1; i <= 5; i++)
        {
            if (i % 2 == 0)
            {
                continue;
            }

            #region Code...
            Console.WriteLine(i); // 1, 3, 5 
            #endregion
        }



    }
}
