namespace Ex3
{
    internal class Song
    {
        private string typeList;
        private string name;
        private string time;

        public string TypeList { get { return typeList; } set { typeList = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Time { get { return time; } set { time = value; } }

        public Song() { }
        public Song(string typeList, string name, string time)
        {
            TypeList = typeList;
            Name = name;
            Time = time;
        }
    }
}
