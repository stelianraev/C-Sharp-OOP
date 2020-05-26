using System;
using System.Runtime.InteropServices;

namespace PizzaCalories
{
   public class Dough
    {
        private const string FLOUR_BAKING_VALIDATION_EXCEPTION = "Invalid type of dough";
        private const string DOUGH_WEIGHT_VALIDATION_EXCEPTION = "Dough weight should be in the range [1..200].";

        private string fourType;
        private string bakingTechnique;
        private int weight;

        public Dough(string fourType, string bakingTechnique, int weight)
        {
            this.FourType = fourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        public string FourType
        {
            get
            {
                return this.fourType;
            }
            private set
            {
                if(value != "White" && value != "Wholegrain")
                {
                    throw new ArgumentException(FLOUR_BAKING_VALIDATION_EXCEPTION);
                }

                this.fourType = value;
            }
        }

        public string BakingTechnique
        {
            get
            {
                return this.bakingTechnique;
            }
            private set
            {
                if (value != "Crispy" && value != "Chewy" && value != "Homemade")
                {
                    throw new ArgumentException(FLOUR_BAKING_VALIDATION_EXCEPTION);
                }

                this.bakingTechnique = value;
            }
        }

        public int Weight
        {
            get
            {
                return this.weight;
            }
            private set
            {
                if (value < 1 && value > 200)
                {
                    throw new ArgumentException(DOUGH_WEIGHT_VALIDATION_EXCEPTION);
                }

                this.weight = value;
            }
        }

        public double DoughCaloriesCalculation()
        {
            double multiplierDough = 0;
            double multiplierBakingTechnique = 0;

            if(this.FourType == "White")
            {
                multiplierDough = 1.5;
            }
            else if (this.FourType == "Wholegrain")
            {
                multiplierDough = 1.0;
            }
            if (this.BakingTechnique == "Crispy")
            {
                multiplierBakingTechnique = 0.9;
            }
            else if (this.BakingTechnique == "Chewy")
            {
                multiplierBakingTechnique = 1.1;
            }
            else if (this.BakingTechnique == "Homemade")
            {
                multiplierBakingTechnique = 1.0;
            }

            return (2 * (double)this.weight) * multiplierDough * multiplierBakingTechnique;
        }
    }
}
