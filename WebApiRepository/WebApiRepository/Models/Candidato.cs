using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApiRepository.Models
{
    [Table("WAR_Candidato")]
    public class Candidato
    {
        [Key]
        [Column("WAR_IdCandidato")]
        public long IdCandidato { get; set; }

        [Column("WAR_Nombre")]
        public String Nombre { get; set; }

        [Column("WAR_ApellidoPaterno")]
        public String ApellidoPaterno { get; set; }

        [Column("WAR_ApellidoMaterno")]
        public String ApellidoMaterno { get; set; }

        [Column("WAR_Edad")]
        public int Edad { get; set; }

        public virtual IEnumerable<Propuesta> Propuestas { get; set; }

        public virtual IEnumerable<Voto> Votos { get; set; }
    }
}
