namespace ddd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = "KsjDsSsadsaFs";
            string ss = "";
            foreach (var item in s)
            {
                if (char.IsUpper(item))
                {
                    ss += item;
                }

            }
            Console.WriteLine(ss);
        }
    }
}
