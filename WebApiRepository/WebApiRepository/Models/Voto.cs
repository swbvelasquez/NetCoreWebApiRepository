﻿using System;
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

        [Required]
        [Column("WAR_IdCandidato")]
        public long IdCandidato { get; set; }

        [Required]
        [Column("WAR_IdUsuario")]
        public long IdUsuario { get; set; }

        [ForeignKey("IdUsuario")]
        public virtual Usuario Usuario { get; set; }

        [ForeignKey("IdCandidato")]
        public virtual Candidato Candidato { get; set; }
    }
}
