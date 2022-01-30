namespace ProjetoDIOJogoRPG.src.Entities
{
    public class BWizard : Hero
    {
        public BWizard()
        {

        }
        public BWizard(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            return this.Name + " Lançou Magia Black";
        }

        public string Attack(int Bonus)
        {
            if(Bonus > 6)
            {
                return this.Name + " Lançou Magia Black super efetiva com bonus de " + Bonus;
            }
            else
            {
                return this.Name + " Lançou Magia Black com força franca com bonus de " + Bonus;
            }
            
        }
    }
}