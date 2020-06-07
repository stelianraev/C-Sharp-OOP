﻿namespace WildFarm.Models.Contracts
{
    public abstract class Food
    {
        public Food (int quantity)
        {
            this.Quantity = quantity;
        }
        public int Quantity { get; protected set; }
    }
}
