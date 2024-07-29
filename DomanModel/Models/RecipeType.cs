using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomanModel.Models
{
    public class RecipeType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public RecipeType() { }
        public RecipeType(string name, int id)
        {
            Name = name;
            Id = id;
        }
        public RecipeType(string name)
        {
            Name = name;
        }
    }
}
