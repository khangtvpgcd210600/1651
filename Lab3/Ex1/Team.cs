namespace Ex1
{
    internal class Team
    {
        string name;
        List<Person> firstTeam;
        List<Person> reserveTeam;


        public string Name { get => name; private set => name = value; }
        public IReadOnlyList<Person> FirstTeam
        {
            get
            {
                return this.firstTeam.AsReadOnly();
            }
        }
        public IReadOnlyList<Person> ReserveTeam
        {
            get
            {
                return this.reserveTeam.AsReadOnly();
            }
        }

        public Team(string name)
        {
            this.name = name;
            this.firstTeam = new List<Person>();
            this.reserveTeam = new List<Person>();
        }


        public void AddPlayer(Person player)
        {
            if (player.Age < 40)
                this.firstTeam.Add(player);
            else this.reserveTeam.Add(player);
        }
    }
}
