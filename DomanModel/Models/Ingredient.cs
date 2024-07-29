using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomanModel.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Weight { get; set; }
        public decimal KcalPer100g { get; set; }
        public decimal PricePer100g { get; set; }
        public Ingredient(string name, string type, decimal kcalPer100g, decimal pricePer100g, decimal weight, int? id = null)
        {

            Name = name;
            Type = type;
            KcalPer100g = kcalPer100g;
            PricePer100g = pricePer100g;
            Weight = weight;
            if(id != null)
                Id = (int)id;
        }
        public Ingredient() { }
    }
}
