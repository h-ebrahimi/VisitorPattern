namespace VisitorPattern.App
{
    public class Odd : IComponent
    {
        public bool Can(int number)
        {
            return number % 2 != 0;
        }

        public string Do(int number)
        {
            return "number is odd";
        }
    }
}
