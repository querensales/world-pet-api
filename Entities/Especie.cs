using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldPetApi.Entities
{
    public class Especie
    {
        public Guid Id { get; set; }
        
        public string Descricao { get; set; }

        public virtual ICollection<Raca> Raca { get; set; }
    }
}