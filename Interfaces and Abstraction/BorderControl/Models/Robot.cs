using BorderControl.Contracts;

namespace BorderControl.Models
{
    public class Robot : ICitizen
    {
        private string model;        
        public Robot(string model, string id)
        {
            this.model = model;
            this.Id = id;
        }       

        public string Id { get; private set; }
    }
}
