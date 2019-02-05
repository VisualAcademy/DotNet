namespace DotNet.Models
{
    public class OneTwo
    {
        public double One { get; set; }
        public double Two { get; set; }
    }

    public class OneTwoRepository
    {
        public OneTwo GetByMonth(int month)
        {
            var r = new OneTwo();

            switch (month)
            {
                case 1:
                    r = new OneTwo { One = 11, Two = 111 };
                    break;
                case 2:
                    r = new OneTwo { One = 22, Two = 222 };
                    break;
                case 3:
                    r = new OneTwo { One = 33, Two = 333 };
                    break;
                default:
                    break;
            }

            return r;
        }
    }
}
