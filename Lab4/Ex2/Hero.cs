namespace Ex2
{
    internal class Hero
    {
        public string Username { get; set; }
        public int Level { get; set; }

        public Hero(string username, int level)
        {
            Username = username;
            Level = level;
        }

        public override string ToString()
        {
            return $"Type: {GetType().Name} Username: {Username} Level: {Level}";
        }
    }

    internal class Elf : Hero
    {
        public Elf(string name, int level) : base(name, level) { }
    }

    internal class MuseElf : Elf
    {
        public MuseElf(string name, int level) : base(name, level) { }
    }

    internal class Knight : Hero
    {
        public Knight(string name, int level) : base(name, level) { }
    }

    internal class DarkKnight : Knight
    {
        public DarkKnight(string name, int level) : base(name, level) { }
    }

    internal class BladeKnight : DarkKnight
    {
        public BladeKnight(string name, int level) : base(name, level) { }
    }

    internal class Wizard : Hero
    {
        public Wizard(string name, int level) : base(name, level) { }
    }

    internal class DarkWizard : Wizard
    {
        public DarkWizard(string name, int level) : base(name, level) { }
    }

    internal class SoulMaster : DarkWizard
    {
        public SoulMaster(string name, int level) : base(name, level) { }
    }
}
