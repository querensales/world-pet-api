using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorldPetApi.Entities
{
    public class Raca
    {
        [Key]
        public Guid Id { get; set; }
        public string Descricao { get; set; }
    
        public Guid EspecieId { get; set; }
        public virtual Especie Especie { get; set; }

    }
}