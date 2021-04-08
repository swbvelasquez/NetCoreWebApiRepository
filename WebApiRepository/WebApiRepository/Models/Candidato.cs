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

        [Required]
        [Column("WAR_Nombre")]
        public String Nombre { get; set; }

        [Required]
        [Column("WAR_ApellidoPaterno")]
        public String ApellidoPaterno { get; set; }

        [Required]
        [Column("WAR_ApellidoMaterno")]
        public String ApellidoMaterno { get; set; }

        [Column("WAR_Edad")]
        public int Edad { get; set; }

        [ForeignKey("WAR_IdPropuesta")]
        public virtual ICollection<Propuesta> Propuestas { get; set; }

        [ForeignKey("WAR_IdVoto")]
        public virtual ICollection<Voto> Votos { get; set; }
    }
}
