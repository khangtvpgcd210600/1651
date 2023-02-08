namespace Ex1
{
    internal class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()
        {
            if (Count == 0) return true; return false;
        }

        public Stack<string> AddRange(int range)
        {
            for (int i = 0; i < range; i++)
            {
                Push("i");
            }
            return this;
        }
    }
}
