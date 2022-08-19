using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldPetApi.Model
{
    public class ClienteModel
    {
        public string PrimeiroNome { get; set; }
        
        public string Email { get; set; }
        
        public string Celular { get; set; }
        
        public long Cpf { get; set; }
    }
}