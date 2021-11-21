using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.IO;

namespace FirmaApp.Models
{
   public class Persona
    {
        internal Stream image;

        [PrimaryKey, AutoIncrement]
        public int Idpersona { get; set; }

        [MaxLength(10000)]
        public String imagen { get; set; }

        [MaxLength(50)]
        public String nombre { get; set; }
        [MaxLength(70)]
        public String descripcion { get; set; }

    }
}
