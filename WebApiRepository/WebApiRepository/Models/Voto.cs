using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApiRepository.Models
{
    [Table("WAR_Voto")]
    public class Voto
    {
        [Key]
        [Column("WAR_IdVoto")]
        public long IdVoto { get; set; }

        [Column("WAR_IdCandidato")]
        public long IdCandidato { get; set; }

        [Column("WAR_NroDNI")]
        public long NroDNI { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual Candidato Candidato { get; set; }
    }
}
