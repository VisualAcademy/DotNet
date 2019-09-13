using System;

class CharacterArray
{
    static void Main()
    {
        char[] characters = { 'a', 'b', 'c', 'd' }; // 문자 배열

        for (int i = 0; i < characters.Length; i++) // 배열의 크기만큼 반복
        {
            Console.WriteLine(characters[i]);
        }
    }
}
