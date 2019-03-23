using System;

namespace ConstructorForwarding
{
    class Money
    {
        public Money() : this(1000) { }
        public Money(int money) => Console.WriteLine("월급: {0}", money);
    }

    class ConstructorForwarding
    {
        static void Main()
        {
            var basic = new Money();        // 1000
            var bonus = new Money(2000);    // 2000
        }
    }
}
