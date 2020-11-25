using System;
using System.Collections.Generic;

namespace POC.Models
{
   

    public class Item
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public double Ppu { get; set; }
        public Batters Batters { get; set; }
        public List<Topping> Topping { get; set; }
    }



   
}

