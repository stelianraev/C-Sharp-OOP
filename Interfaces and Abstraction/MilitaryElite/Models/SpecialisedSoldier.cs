﻿using MilitaryElite.Contracts;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Windows.Markup;

namespace MilitaryElite.Models
{
    public class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        private string corps;
        public SpecialisedSoldier(string id, string firstName, string lastName, decimal salary, string corps) : base(id, firstName, lastName, salary)
        {
            this.Corps = corps;
        }

        public string Corps
        {
            get => this.corps;
            private set
            {
                if (value != "Airforces" && value != "Marines")
                {
                    throw new ArgumentException("Invalid Corps!");
                }
                this.corps = value;
            }           
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.Append($"Corps: {this.Corps}");

            return sb.ToString().TrimEnd();
        }
    }
}
