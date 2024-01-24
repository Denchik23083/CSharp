namespace Tests
{
    public class Test
    {
        public void Print()
        {
            string hello = "Hello METANIT.COM";

            Console.WriteLine(hello);
        }

        public void Array()
        {
            var arr = new string[] { "Hello", "World" };

            var arr2 = arr.Where(_ => _.StartsWith("W"));

            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
