using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldPetApi.Entities
{
    public class Usuario
    {
        public Guid Id { get; set; }

        public string Login { get; set; }
    }
}