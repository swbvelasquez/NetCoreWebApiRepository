using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApiRepository.Models
{
    [Table("WAR_Propuesta")]
    public class Propuesta
    {
        [Key]
        [Column("WAR_IdPropuesta")]
        public long IdPropuesta { get; set; }

        [Column("WAR_Descripcion")]
        public String Descripcion { get; set; }

        [Column("WAR_IdCandidato")]
        public long IdCandidato { get; set; }

        public virtual Candidato Candidato { get; set; }
    }
}
