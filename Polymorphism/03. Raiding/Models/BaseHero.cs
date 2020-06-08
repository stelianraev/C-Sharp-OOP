namespace Raiding.Models
{
   public abstract class BaseHero
    {
        public string Name { get; protected set; }
        public int Power { get; protected set; }
        public virtual string CastAbility()
        {
            return $"{this.GetType().Name} - {this.Name} healed for {this.Power}";
        }
    }
}
