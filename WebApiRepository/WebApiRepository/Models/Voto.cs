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

        [ForeignKey("WAR_Candidato")]
        [Column("WAR_IdCandidato")]
        public long IdCandidato { get; set; }

        [[ForeignKey("WAR_Usuario")]
        [Column("WAR_IdUsuario")]
        public long IdUsuario { get; set; }

    }
}
