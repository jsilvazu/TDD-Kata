// See https://aka.ms/new-console-template for more information
namespace App
{
    public class StringCalculator
    {
        public static int Add(string s)
        {
            if (s.Equals(""))
            {
                return 0;
            }
            var sts = s.Split(",");
            var ls = sts.Select(x => int.Parse(x));
            var sum = ls.DefaultIfEmpty(0).Sum();
            return sum;
        }
    }
}