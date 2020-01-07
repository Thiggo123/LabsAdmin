using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Labs.Models
{
    public class Computers
    {
        public int ID { get; set; }

        
        public string Marca { get; set; }

        public string Modelo { get; set; }

        public string PlacaMae { get; set; }

        public string Memoria { get; set; }

        public string  HD { get; set; }

        public string MarcaHD { get; set; }

        public string VelocidadeCPU { get; set; }




    }
}
