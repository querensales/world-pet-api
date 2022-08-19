using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldPetApi.Model
{
    public class PetModel
    {
        public Guid IdEspecie { get; set; }
        public Guid IdRaca { get; set; }
        public string Nome { get; set; }
    }
}