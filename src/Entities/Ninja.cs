namespace ProjetoDIOJogoRPG.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja()
        {
            
        }
        public Ninja(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            return this.Name + " Lançou Shuriken";
        }

        public string Attack(int Bonus)
        {
            if(Bonus > 6)
            {
                return this.Name + " Lançou Shuriken super efetiva com bonus de " + Bonus;
            }
            else
            {
                return this.Name + " Lançou Shuriken com força franca com bonus de " + Bonus;
            }
            
        }
    }
}