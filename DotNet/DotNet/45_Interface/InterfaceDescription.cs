using static System.Console;

namespace InterfaceDescription
{
    public interface ICarStandard
    {
        void Left();
    }
    public abstract class KS
    {
        public abstract void Back();
        public void Fly() => WriteLine("날다");
    }
    public partial class MyCar : KS
    {
        public override void Back() => WriteLine("후진");
    }
    public partial class MyCar : KS
    {
        public void Right() => WriteLine("우회전");
    }
    public sealed class Car : MyCar, ICarStandard
    {
        public void Left() => WriteLine("좌회전");
        public void Run() => WriteLine("직진");
    }
    //class SpyCar : Car { }
    public class InterfaceDescription
    {
        public static void Main()
        {
            Car car = new Car();
            car.Run(); car.Right(); car.Back(); car.Left(); car.Fly();
            //SpyCar spy = new SpyCar(); spy.Run();
        }
    }
}
