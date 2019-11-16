using static System.Console;

class TupleLiteral
{
    static void Main()
    {
        var fhd = (1920, 1080); //[1] 기본: Item1, Item2 형태 
        WriteLine($"Full HD: {fhd.Item1} * {fhd.Item2}");

        var uhd = (Width: 3840, Height: 2160); //[2] 이름 지정
        WriteLine($"4K UHD: {uhd.Width} * {uhd.Height}");

        (ushort Width, ushort Height) hd = (1366, 768); //[3] 이름과 형식 지정
        Write($"HD: {hd.Width} * {hd.Height}");
        WriteLine($"Type({hd.Width.GetType()}, {hd.Height.GetType()})");
    }
}
