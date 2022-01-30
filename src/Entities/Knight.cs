namespace ProjetoDIOJogoRPG.src.Entities
{
    public class Knight : Hero
    {
        public Knight()
        {

        }
        public Knight(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            return this.Name + " Atacou com sua espada";
        }

        public string Attack(int Bonus)
        {
            if(Bonus > 6)
            {
                return this.Name + " Atacou com sua super espada com bonus de " + Bonus;
            }
            else
            {
                return this.Name + " Atacou com sua espada com força franca com bonus de " + Bonus;
            }
            
        }
    }
}