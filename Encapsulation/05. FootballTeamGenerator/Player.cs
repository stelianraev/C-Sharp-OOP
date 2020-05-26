using System;

namespace FootballTeamGenerator
{
    public class Player
    {
        private string name;
        private int stats;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }

                this.name = value;
            }
        }

        public int Stats
        {
            get
            {
                return (int)Math.Round((this.Endurance + this.Sprint + this.Dribble + this.Passing + this.Shooting) / (double)5);
            }            
        }

        private int Endurance
        {
            get { return this.endurance; }
            set
            {
                ValidateStats(value, "Endurance");               

                this.endurance = value;
            }
        }
        private int Sprint
        {
            get { return this.sprint; }
            set
            {
                ValidateStats(value, "Sprint");
                this.sprint = value;
            }
        }
        private int Dribble
        {
            get { return this.dribble; }
            set
            {
                ValidateStats(value, "Dribble");
                this.dribble = value;
            }
        }
        private int Passing
        {
            get { return this.passing; }
            set
            {
                ValidateStats(value, "Passing");
                this.passing = value;
            }
        }
        private int Shooting
        {
            get { return this.shooting; }
            set
            {
                ValidateStats(value, "Shooting");
                this.shooting = value;
            }
        }
        private void ValidateStats(int stat, string name)
        {
            if(stat < 0 || stat > 100)
            {
                throw new ArgumentException(String.Format("{0} should be between 0 and 100.", name));
            }            
        }      
    }
}