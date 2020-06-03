using BorderControl.Contracts;

namespace BorderControl.Models
{
    public class Pet : IBirthday
    {
        private string name;
        public Pet(string name, string birthdate)
        {
            this.name = name;
            this.BirthDate = birthdate;
        }
        public string BirthDate { get; }        
    }
}
