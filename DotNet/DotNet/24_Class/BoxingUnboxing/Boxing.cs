﻿using System;

class Boxing
{
    static void Main()
    {
        int i = 1234;           // 값 형식(정수형) 선언
        object o = i;           // 박싱: 값 형식을 참조 형식으로 변환
        Console.WriteLine(o);   // 1234
    }
}