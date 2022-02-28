namespace RPG.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
            base.Name = Name;
            base.Level = Level;
            base.HeroType = HeroType;
        }

        public override string Attack()
        {
            return base.Name + " Atacou com sua magia";
        }

        public string Attack(int Bonus)
        {
            return base.Name + " Atacou com sua magia com Bonus de ataque de " + Bonus;
        }
    }
}