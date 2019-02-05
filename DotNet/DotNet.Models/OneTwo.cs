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
                    r = new OneTwo { One = 91.8, Two = 110.12 };
                    break;
                case 2:
                    r = new OneTwo { One = 90.3, Two = 110.56 };
                    break;
                case 3:
                    r = new OneTwo { One = 101.15, Two = 101.03 };
                    break;
                default:
                    break;
            }

            return r;
        }
    }
}
