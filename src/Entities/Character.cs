namespace RPG.src.Entities
{
    public abstract class Character
    {
        public Character(
          string Name,
          int Level,
          string HeroType,
          int HP_MAX,
          int HP_Current,
          int MP_MAX,
          int MP_Current,
          int ST_MAX,
          int ST_Current)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP_MAX = HP_MAX;
            this.HP_Current = HP_Current;
            this.MP_MAX = MP_MAX;
            this.MP_Current = MP_Current;
            this.ST_MAX = ST_MAX;
            this.ST_Current = ST_Current;
        }

        public string Name;
        public int Level;
        public string HeroType;
        public int HP_MAX;
        public int HP_Current;
        public int MP_MAX;
        public int MP_Current;
        public int ST_MAX;
        public int ST_Current;

        public override string ToString()
        {
            return this.Name 
                    + "\n Lv. " + this.Level + " " + this.HeroType
                    + "\n" + " HP " + HP_Current + " / " + HP_MAX
                    + "\n" + " MP " + MP_Current + " / " + MP_MAX
                    + "\n" + " ST " + ST_Current + " / " + ST_MAX;
        }

        public virtual string Attack()
        {
            return this.Name + " Atacou!";
        }

        public virtual string Defend()
        {
            return this.Name + " Defendeu!";
        }
    }
}