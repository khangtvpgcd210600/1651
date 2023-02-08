namespace Ex1
{
    internal class RandomList : List<string>
    {
        public string RandomString()
        {
            Random i = new Random();
            int number = i.Next(0, Count - 1);
            string result = this[number];
            Remove(this[number]);
            return result;
        }
    }
}
