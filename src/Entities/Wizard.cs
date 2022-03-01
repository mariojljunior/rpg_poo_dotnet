namespace RPG.src.Entities
{
    public class Wizard : Character
    {
        public Wizard(
          string Name,
          int Level,
          string HeroType,
          int HP_MAX,
          int HP_Current,
          int MP_MAX,
          int MP_Current,
          int ST_MAX,
          int ST_Current) : base(
            Name,
            Level,
            HeroType,
            HP_MAX,
            HP_Current,
            MP_MAX,
            MP_Current,
            ST_MAX,
            ST_Current)
        {}

        public override string Attack()
        {
            return base.Name + " Usou magia de ataque!";
        }

        public string Attack(int Bonus)
        {
            if(Bonus > 6){
                return base.Name + " lançou magia de Alto Grau com dano de " + Bonus;
            }else{
                return base.Name + " lançou magia com dano de " + Bonus;
            }
        }

        public override string Defend()
        {
            return this.Name + " Usou magia de defesa!";
        }
    }
}