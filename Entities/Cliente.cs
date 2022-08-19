using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldPetApi.Entities
{
    public class Cliente
    {
        public Guid Id { get; set; }

        public string PrimeiroNome { get; set; }
        
        public string Email { get; set; }
        
        public string Celular { get; set; }
        
        public long Cpf { get; set; }
        
        public ICollection<Pet> Pets { get; set; }
        
                
        
    }
}