using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldPetApi.Entities
{
    public class Pet
    {
        public Guid Id { get; set; }
        
        public string Nome { get; set; }
        
        public Especie Especie { get; set; }
        
        
    }
}