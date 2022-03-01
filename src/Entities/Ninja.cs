namespace RPG.src.Entities
{
    public class Ninja : Character
    {
        public Ninja(
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
            return base.Name + " Atacou com sua kunai!";
        }

        public string Attack(int Bonus)
        {
            if(Bonus < 10){
                return base.Name + " fez um ataque fraco +" + Bonus + " de dano";
            }else if(Bonus >= 10 || Bonus < 50){
                return base.Name + " fez um ataque forte +" + Bonus + " de dano";
            }else if(Bonus >= 50){
                return base.Name + " fez um ataque sem defesa +" + Bonus + " de dano";
            }
            return null;
        }

        public override string Defend()
        {
            return this.Name + " Defendeu com sua kunai!";
        }

    }
}