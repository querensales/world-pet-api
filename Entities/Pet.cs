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

        public Guid EspecieId { get; set; }        
        public virtual Especie Especie { get; set; }
        
        public Guid RacaId { get; set; }    
        public virtual Raca Raca { get; set; }

        public Guid ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}