namespace Raiding.Models
{
    public class Warrior : BaseHero
    {
        public Warrior(string name)
        {
            this.Name = name;
            this.Power = 100;
        }

        public override string CastAbility()
        {
            return $"{this.GetType().Name} - {this.Name} hit for {this.Power} damage";
        }
    }    
}
